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
using System.Collections.Generic;
using System.Net;

using Amazon.SsmSap.Model;
using Amazon.SsmSap.Model.Internal.MarshallTransformations;
using Amazon.SsmSap.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

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

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSsmSapConfig()) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSsmSapConfig{RegionEndpoint = region}) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSsmSapEndpointResolver());
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

        /// <summary>
        /// Removes permissions associated with the target database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePermission service method.</param>
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
        public virtual DeleteResourcePermissionResponse DeleteResourcePermission(DeleteResourcePermissionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteResourcePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePermissionResponseUnmarshaller.Instance;

            return Invoke<DeleteResourcePermissionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteResourcePermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePermission operation on AmazonSsmSapClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteResourcePermission
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/DeleteResourcePermission">REST API Reference for DeleteResourcePermission Operation</seealso>
        public virtual IAsyncResult BeginDeleteResourcePermission(DeleteResourcePermissionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteResourcePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePermissionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteResourcePermission operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteResourcePermission.</param>
        /// 
        /// <returns>Returns a  DeleteResourcePermissionResult from SsmSap.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/DeleteResourcePermission">REST API Reference for DeleteResourcePermission Operation</seealso>
        public virtual DeleteResourcePermissionResponse EndDeleteResourcePermission(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteResourcePermissionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeregisterApplication

        /// <summary>
        /// Deregister an SAP application with AWS Systems Manager for SAP. This action does not
        /// aﬀect the existing setup of your SAP workloads on Amazon EC2.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterApplication service method.</param>
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
        public virtual DeregisterApplicationResponse DeregisterApplication(DeregisterApplicationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeregisterApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterApplicationResponseUnmarshaller.Instance;

            return Invoke<DeregisterApplicationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterApplication operation on AmazonSsmSapClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/DeregisterApplication">REST API Reference for DeregisterApplication Operation</seealso>
        public virtual IAsyncResult BeginDeregisterApplication(DeregisterApplicationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeregisterApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterApplicationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterApplication.</param>
        /// 
        /// <returns>Returns a  DeregisterApplicationResult from SsmSap.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/DeregisterApplication">REST API Reference for DeregisterApplication Operation</seealso>
        public virtual DeregisterApplicationResponse EndDeregisterApplication(IAsyncResult asyncResult)
        {
            return EndInvoke<DeregisterApplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetApplication

        /// <summary>
        /// Gets an application registered with AWS Systems Manager for SAP. It also returns the
        /// components of the application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplication service method.</param>
        /// 
        /// <returns>The response from the GetApplication service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/GetApplication">REST API Reference for GetApplication Operation</seealso>
        public virtual GetApplicationResponse GetApplication(GetApplicationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApplicationResponseUnmarshaller.Instance;

            return Invoke<GetApplicationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApplication operation on AmazonSsmSapClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/GetApplication">REST API Reference for GetApplication Operation</seealso>
        public virtual IAsyncResult BeginGetApplication(GetApplicationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApplicationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApplication.</param>
        /// 
        /// <returns>Returns a  GetApplicationResult from SsmSap.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/GetApplication">REST API Reference for GetApplication Operation</seealso>
        public virtual GetApplicationResponse EndGetApplication(IAsyncResult asyncResult)
        {
            return EndInvoke<GetApplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetComponent

        /// <summary>
        /// Gets the component of an application registered with AWS Systems Manager for SAP.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetComponent service method.</param>
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
        public virtual GetComponentResponse GetComponent(GetComponentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetComponentResponseUnmarshaller.Instance;

            return Invoke<GetComponentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetComponent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetComponent operation on AmazonSsmSapClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetComponent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/GetComponent">REST API Reference for GetComponent Operation</seealso>
        public virtual IAsyncResult BeginGetComponent(GetComponentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetComponentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetComponent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetComponent.</param>
        /// 
        /// <returns>Returns a  GetComponentResult from SsmSap.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/GetComponent">REST API Reference for GetComponent Operation</seealso>
        public virtual GetComponentResponse EndGetComponent(IAsyncResult asyncResult)
        {
            return EndInvoke<GetComponentResponse>(asyncResult);
        }

        #endregion
        
        #region  GetConfigurationCheckOperation

        /// <summary>
        /// Gets the details of a configuration check operation by specifying the operation ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfigurationCheckOperation service method.</param>
        /// 
        /// <returns>The response from the GetConfigurationCheckOperation service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/GetConfigurationCheckOperation">REST API Reference for GetConfigurationCheckOperation Operation</seealso>
        public virtual GetConfigurationCheckOperationResponse GetConfigurationCheckOperation(GetConfigurationCheckOperationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConfigurationCheckOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfigurationCheckOperationResponseUnmarshaller.Instance;

            return Invoke<GetConfigurationCheckOperationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetConfigurationCheckOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConfigurationCheckOperation operation on AmazonSsmSapClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConfigurationCheckOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/GetConfigurationCheckOperation">REST API Reference for GetConfigurationCheckOperation Operation</seealso>
        public virtual IAsyncResult BeginGetConfigurationCheckOperation(GetConfigurationCheckOperationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConfigurationCheckOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfigurationCheckOperationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetConfigurationCheckOperation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConfigurationCheckOperation.</param>
        /// 
        /// <returns>Returns a  GetConfigurationCheckOperationResult from SsmSap.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/GetConfigurationCheckOperation">REST API Reference for GetConfigurationCheckOperation Operation</seealso>
        public virtual GetConfigurationCheckOperationResponse EndGetConfigurationCheckOperation(IAsyncResult asyncResult)
        {
            return EndInvoke<GetConfigurationCheckOperationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDatabase

        /// <summary>
        /// Gets the SAP HANA database of an application registered with AWS Systems Manager for
        /// SAP.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDatabase service method.</param>
        /// 
        /// <returns>The response from the GetDatabase service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/GetDatabase">REST API Reference for GetDatabase Operation</seealso>
        public virtual GetDatabaseResponse GetDatabase(GetDatabaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDatabaseResponseUnmarshaller.Instance;

            return Invoke<GetDatabaseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDatabase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDatabase operation on AmazonSsmSapClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDatabase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/GetDatabase">REST API Reference for GetDatabase Operation</seealso>
        public virtual IAsyncResult BeginGetDatabase(GetDatabaseRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDatabaseResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDatabase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDatabase.</param>
        /// 
        /// <returns>Returns a  GetDatabaseResult from SsmSap.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/GetDatabase">REST API Reference for GetDatabase Operation</seealso>
        public virtual GetDatabaseResponse EndGetDatabase(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDatabaseResponse>(asyncResult);
        }

        #endregion
        
        #region  GetOperation

        /// <summary>
        /// Gets the details of an operation by specifying the operation ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOperation service method.</param>
        /// 
        /// <returns>The response from the GetOperation service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/GetOperation">REST API Reference for GetOperation Operation</seealso>
        public virtual GetOperationResponse GetOperation(GetOperationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOperationResponseUnmarshaller.Instance;

            return Invoke<GetOperationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOperation operation on AmazonSsmSapClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/GetOperation">REST API Reference for GetOperation Operation</seealso>
        public virtual IAsyncResult BeginGetOperation(GetOperationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOperationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetOperation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOperation.</param>
        /// 
        /// <returns>Returns a  GetOperationResult from SsmSap.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/GetOperation">REST API Reference for GetOperation Operation</seealso>
        public virtual GetOperationResponse EndGetOperation(IAsyncResult asyncResult)
        {
            return EndInvoke<GetOperationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetResourcePermission

        /// <summary>
        /// Gets permissions associated with the target database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePermission service method.</param>
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
        public virtual GetResourcePermissionResponse GetResourcePermission(GetResourcePermissionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourcePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePermissionResponseUnmarshaller.Instance;

            return Invoke<GetResourcePermissionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetResourcePermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePermission operation on AmazonSsmSapClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResourcePermission
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/GetResourcePermission">REST API Reference for GetResourcePermission Operation</seealso>
        public virtual IAsyncResult BeginGetResourcePermission(GetResourcePermissionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourcePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePermissionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetResourcePermission operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResourcePermission.</param>
        /// 
        /// <returns>Returns a  GetResourcePermissionResult from SsmSap.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/GetResourcePermission">REST API Reference for GetResourcePermission Operation</seealso>
        public virtual GetResourcePermissionResponse EndGetResourcePermission(IAsyncResult asyncResult)
        {
            return EndInvoke<GetResourcePermissionResponse>(asyncResult);
        }

        #endregion
        
        #region  ListApplications

        /// <summary>
        /// Lists all the applications registered with AWS Systems Manager for SAP.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplications service method.</param>
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
        public virtual ListApplicationsResponse ListApplications(ListApplicationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationsResponseUnmarshaller.Instance;

            return Invoke<ListApplicationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListApplications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApplications operation on AmazonSsmSapClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListApplications
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/ListApplications">REST API Reference for ListApplications Operation</seealso>
        public virtual IAsyncResult BeginListApplications(ListApplicationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListApplications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListApplications.</param>
        /// 
        /// <returns>Returns a  ListApplicationsResult from SsmSap.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/ListApplications">REST API Reference for ListApplications Operation</seealso>
        public virtual ListApplicationsResponse EndListApplications(IAsyncResult asyncResult)
        {
            return EndInvoke<ListApplicationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListComponents

        /// <summary>
        /// Lists all the components registered with AWS Systems Manager for SAP.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListComponents service method.</param>
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
        public virtual ListComponentsResponse ListComponents(ListComponentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListComponentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComponentsResponseUnmarshaller.Instance;

            return Invoke<ListComponentsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListComponents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListComponents operation on AmazonSsmSapClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListComponents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/ListComponents">REST API Reference for ListComponents Operation</seealso>
        public virtual IAsyncResult BeginListComponents(ListComponentsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListComponentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComponentsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListComponents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListComponents.</param>
        /// 
        /// <returns>Returns a  ListComponentsResult from SsmSap.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/ListComponents">REST API Reference for ListComponents Operation</seealso>
        public virtual ListComponentsResponse EndListComponents(IAsyncResult asyncResult)
        {
            return EndInvoke<ListComponentsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListConfigurationCheckDefinitions

        /// <summary>
        /// Lists all configuration check types supported by AWS Systems Manager for SAP.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurationCheckDefinitions service method.</param>
        /// 
        /// <returns>The response from the ListConfigurationCheckDefinitions service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/ListConfigurationCheckDefinitions">REST API Reference for ListConfigurationCheckDefinitions Operation</seealso>
        public virtual ListConfigurationCheckDefinitionsResponse ListConfigurationCheckDefinitions(ListConfigurationCheckDefinitionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConfigurationCheckDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfigurationCheckDefinitionsResponseUnmarshaller.Instance;

            return Invoke<ListConfigurationCheckDefinitionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListConfigurationCheckDefinitions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurationCheckDefinitions operation on AmazonSsmSapClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListConfigurationCheckDefinitions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/ListConfigurationCheckDefinitions">REST API Reference for ListConfigurationCheckDefinitions Operation</seealso>
        public virtual IAsyncResult BeginListConfigurationCheckDefinitions(ListConfigurationCheckDefinitionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConfigurationCheckDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfigurationCheckDefinitionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListConfigurationCheckDefinitions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListConfigurationCheckDefinitions.</param>
        /// 
        /// <returns>Returns a  ListConfigurationCheckDefinitionsResult from SsmSap.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/ListConfigurationCheckDefinitions">REST API Reference for ListConfigurationCheckDefinitions Operation</seealso>
        public virtual ListConfigurationCheckDefinitionsResponse EndListConfigurationCheckDefinitions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListConfigurationCheckDefinitionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListConfigurationCheckOperations

        /// <summary>
        /// Lists the configuration check operations performed by AWS Systems Manager for SAP.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurationCheckOperations service method.</param>
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
        public virtual ListConfigurationCheckOperationsResponse ListConfigurationCheckOperations(ListConfigurationCheckOperationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConfigurationCheckOperationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfigurationCheckOperationsResponseUnmarshaller.Instance;

            return Invoke<ListConfigurationCheckOperationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListConfigurationCheckOperations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurationCheckOperations operation on AmazonSsmSapClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListConfigurationCheckOperations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/ListConfigurationCheckOperations">REST API Reference for ListConfigurationCheckOperations Operation</seealso>
        public virtual IAsyncResult BeginListConfigurationCheckOperations(ListConfigurationCheckOperationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConfigurationCheckOperationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfigurationCheckOperationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListConfigurationCheckOperations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListConfigurationCheckOperations.</param>
        /// 
        /// <returns>Returns a  ListConfigurationCheckOperationsResult from SsmSap.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/ListConfigurationCheckOperations">REST API Reference for ListConfigurationCheckOperations Operation</seealso>
        public virtual ListConfigurationCheckOperationsResponse EndListConfigurationCheckOperations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListConfigurationCheckOperationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDatabases

        /// <summary>
        /// Lists the SAP HANA databases of an application registered with AWS Systems Manager
        /// for SAP.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatabases service method.</param>
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
        public virtual ListDatabasesResponse ListDatabases(ListDatabasesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDatabasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatabasesResponseUnmarshaller.Instance;

            return Invoke<ListDatabasesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDatabases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDatabases operation on AmazonSsmSapClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDatabases
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/ListDatabases">REST API Reference for ListDatabases Operation</seealso>
        public virtual IAsyncResult BeginListDatabases(ListDatabasesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDatabasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatabasesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDatabases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDatabases.</param>
        /// 
        /// <returns>Returns a  ListDatabasesResult from SsmSap.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/ListDatabases">REST API Reference for ListDatabases Operation</seealso>
        public virtual ListDatabasesResponse EndListDatabases(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDatabasesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListOperationEvents

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
        /// 
        /// <returns>The response from the ListOperationEvents service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/ListOperationEvents">REST API Reference for ListOperationEvents Operation</seealso>
        public virtual ListOperationEventsResponse ListOperationEvents(ListOperationEventsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOperationEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOperationEventsResponseUnmarshaller.Instance;

            return Invoke<ListOperationEventsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListOperationEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOperationEvents operation on AmazonSsmSapClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOperationEvents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/ListOperationEvents">REST API Reference for ListOperationEvents Operation</seealso>
        public virtual IAsyncResult BeginListOperationEvents(ListOperationEventsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOperationEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOperationEventsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListOperationEvents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOperationEvents.</param>
        /// 
        /// <returns>Returns a  ListOperationEventsResult from SsmSap.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/ListOperationEvents">REST API Reference for ListOperationEvents Operation</seealso>
        public virtual ListOperationEventsResponse EndListOperationEvents(IAsyncResult asyncResult)
        {
            return EndInvoke<ListOperationEventsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListOperations

        /// <summary>
        /// Lists the operations performed by AWS Systems Manager for SAP.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOperations service method.</param>
        /// 
        /// <returns>The response from the ListOperations service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/ListOperations">REST API Reference for ListOperations Operation</seealso>
        public virtual ListOperationsResponse ListOperations(ListOperationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOperationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOperationsResponseUnmarshaller.Instance;

            return Invoke<ListOperationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListOperations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOperations operation on AmazonSsmSapClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOperations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/ListOperations">REST API Reference for ListOperations Operation</seealso>
        public virtual IAsyncResult BeginListOperations(ListOperationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOperationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOperationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListOperations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOperations.</param>
        /// 
        /// <returns>Returns a  ListOperationsResult from SsmSap.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/ListOperations">REST API Reference for ListOperations Operation</seealso>
        public virtual ListOperationsResponse EndListOperations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListOperationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSubCheckResults

        /// <summary>
        /// Lists the sub-check results of a specified configuration check operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubCheckResults service method.</param>
        /// 
        /// <returns>The response from the ListSubCheckResults service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/ListSubCheckResults">REST API Reference for ListSubCheckResults Operation</seealso>
        public virtual ListSubCheckResultsResponse ListSubCheckResults(ListSubCheckResultsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSubCheckResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSubCheckResultsResponseUnmarshaller.Instance;

            return Invoke<ListSubCheckResultsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSubCheckResults operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSubCheckResults operation on AmazonSsmSapClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSubCheckResults
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/ListSubCheckResults">REST API Reference for ListSubCheckResults Operation</seealso>
        public virtual IAsyncResult BeginListSubCheckResults(ListSubCheckResultsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSubCheckResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSubCheckResultsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSubCheckResults operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSubCheckResults.</param>
        /// 
        /// <returns>Returns a  ListSubCheckResultsResult from SsmSap.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/ListSubCheckResults">REST API Reference for ListSubCheckResults Operation</seealso>
        public virtual ListSubCheckResultsResponse EndListSubCheckResults(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSubCheckResultsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSubCheckRuleResults

        /// <summary>
        /// Lists the rules of a specified sub-check belonging to a configuration check operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubCheckRuleResults service method.</param>
        /// 
        /// <returns>The response from the ListSubCheckRuleResults service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/ListSubCheckRuleResults">REST API Reference for ListSubCheckRuleResults Operation</seealso>
        public virtual ListSubCheckRuleResultsResponse ListSubCheckRuleResults(ListSubCheckRuleResultsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSubCheckRuleResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSubCheckRuleResultsResponseUnmarshaller.Instance;

            return Invoke<ListSubCheckRuleResultsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSubCheckRuleResults operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSubCheckRuleResults operation on AmazonSsmSapClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSubCheckRuleResults
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/ListSubCheckRuleResults">REST API Reference for ListSubCheckRuleResults Operation</seealso>
        public virtual IAsyncResult BeginListSubCheckRuleResults(ListSubCheckRuleResultsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSubCheckRuleResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSubCheckRuleResultsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSubCheckRuleResults operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSubCheckRuleResults.</param>
        /// 
        /// <returns>Returns a  ListSubCheckRuleResultsResult from SsmSap.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/ListSubCheckRuleResults">REST API Reference for ListSubCheckRuleResults Operation</seealso>
        public virtual ListSubCheckRuleResultsResponse EndListSubCheckRuleResults(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSubCheckRuleResultsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists all tags on an SAP HANA application and/or database registered with AWS Systems
        /// Manager for SAP.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonSsmSapClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from SsmSap.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  PutResourcePermission

        /// <summary>
        /// Adds permissions to the target database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePermission service method.</param>
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
        public virtual PutResourcePermissionResponse PutResourcePermission(PutResourcePermissionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutResourcePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePermissionResponseUnmarshaller.Instance;

            return Invoke<PutResourcePermissionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutResourcePermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePermission operation on AmazonSsmSapClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutResourcePermission
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/PutResourcePermission">REST API Reference for PutResourcePermission Operation</seealso>
        public virtual IAsyncResult BeginPutResourcePermission(PutResourcePermissionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutResourcePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePermissionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutResourcePermission operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutResourcePermission.</param>
        /// 
        /// <returns>Returns a  PutResourcePermissionResult from SsmSap.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/PutResourcePermission">REST API Reference for PutResourcePermission Operation</seealso>
        public virtual PutResourcePermissionResponse EndPutResourcePermission(IAsyncResult asyncResult)
        {
            return EndInvoke<PutResourcePermissionResponse>(asyncResult);
        }

        #endregion
        
        #region  RegisterApplication

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
        public virtual RegisterApplicationResponse RegisterApplication(RegisterApplicationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterApplicationResponseUnmarshaller.Instance;

            return Invoke<RegisterApplicationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterApplication operation on AmazonSsmSapClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/RegisterApplication">REST API Reference for RegisterApplication Operation</seealso>
        public virtual IAsyncResult BeginRegisterApplication(RegisterApplicationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterApplicationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterApplication.</param>
        /// 
        /// <returns>Returns a  RegisterApplicationResult from SsmSap.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/RegisterApplication">REST API Reference for RegisterApplication Operation</seealso>
        public virtual RegisterApplicationResponse EndRegisterApplication(IAsyncResult asyncResult)
        {
            return EndInvoke<RegisterApplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  StartApplication

        /// <summary>
        /// Request is an operation which starts an application.
        /// 
        ///  
        /// <para>
        /// Parameter <c>ApplicationId</c> is required.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartApplication service method.</param>
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
        public virtual StartApplicationResponse StartApplication(StartApplicationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartApplicationResponseUnmarshaller.Instance;

            return Invoke<StartApplicationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartApplication operation on AmazonSsmSapClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/StartApplication">REST API Reference for StartApplication Operation</seealso>
        public virtual IAsyncResult BeginStartApplication(StartApplicationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartApplicationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartApplication.</param>
        /// 
        /// <returns>Returns a  StartApplicationResult from SsmSap.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/StartApplication">REST API Reference for StartApplication Operation</seealso>
        public virtual StartApplicationResponse EndStartApplication(IAsyncResult asyncResult)
        {
            return EndInvoke<StartApplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  StartApplicationRefresh

        /// <summary>
        /// Refreshes a registered application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartApplicationRefresh service method.</param>
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
        public virtual StartApplicationRefreshResponse StartApplicationRefresh(StartApplicationRefreshRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartApplicationRefreshRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartApplicationRefreshResponseUnmarshaller.Instance;

            return Invoke<StartApplicationRefreshResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartApplicationRefresh operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartApplicationRefresh operation on AmazonSsmSapClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartApplicationRefresh
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/StartApplicationRefresh">REST API Reference for StartApplicationRefresh Operation</seealso>
        public virtual IAsyncResult BeginStartApplicationRefresh(StartApplicationRefreshRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartApplicationRefreshRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartApplicationRefreshResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartApplicationRefresh operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartApplicationRefresh.</param>
        /// 
        /// <returns>Returns a  StartApplicationRefreshResult from SsmSap.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/StartApplicationRefresh">REST API Reference for StartApplicationRefresh Operation</seealso>
        public virtual StartApplicationRefreshResponse EndStartApplicationRefresh(IAsyncResult asyncResult)
        {
            return EndInvoke<StartApplicationRefreshResponse>(asyncResult);
        }

        #endregion
        
        #region  StartConfigurationChecks

        /// <summary>
        /// Initiates configuration check operations against a specified application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartConfigurationChecks service method.</param>
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
        public virtual StartConfigurationChecksResponse StartConfigurationChecks(StartConfigurationChecksRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartConfigurationChecksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartConfigurationChecksResponseUnmarshaller.Instance;

            return Invoke<StartConfigurationChecksResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartConfigurationChecks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartConfigurationChecks operation on AmazonSsmSapClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartConfigurationChecks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/StartConfigurationChecks">REST API Reference for StartConfigurationChecks Operation</seealso>
        public virtual IAsyncResult BeginStartConfigurationChecks(StartConfigurationChecksRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartConfigurationChecksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartConfigurationChecksResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartConfigurationChecks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartConfigurationChecks.</param>
        /// 
        /// <returns>Returns a  StartConfigurationChecksResult from SsmSap.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/StartConfigurationChecks">REST API Reference for StartConfigurationChecks Operation</seealso>
        public virtual StartConfigurationChecksResponse EndStartConfigurationChecks(IAsyncResult asyncResult)
        {
            return EndInvoke<StartConfigurationChecksResponse>(asyncResult);
        }

        #endregion
        
        #region  StopApplication

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
        public virtual StopApplicationResponse StopApplication(StopApplicationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopApplicationResponseUnmarshaller.Instance;

            return Invoke<StopApplicationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopApplication operation on AmazonSsmSapClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/StopApplication">REST API Reference for StopApplication Operation</seealso>
        public virtual IAsyncResult BeginStopApplication(StopApplicationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopApplicationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopApplication.</param>
        /// 
        /// <returns>Returns a  StopApplicationResult from SsmSap.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/StopApplication">REST API Reference for StopApplication Operation</seealso>
        public virtual StopApplicationResponse EndStopApplication(IAsyncResult asyncResult)
        {
            return EndInvoke<StopApplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Creates tag for a resource by specifying the ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonSsmSapClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from SsmSap.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Delete the tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonSsmSapClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from SsmSap.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateApplicationSettings

        /// <summary>
        /// Updates the settings of an application registered with AWS Systems Manager for SAP.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplicationSettings service method.</param>
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
        public virtual UpdateApplicationSettingsResponse UpdateApplicationSettings(UpdateApplicationSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApplicationSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdateApplicationSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApplicationSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplicationSettings operation on AmazonSsmSapClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApplicationSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/UpdateApplicationSettings">REST API Reference for UpdateApplicationSettings Operation</seealso>
        public virtual IAsyncResult BeginUpdateApplicationSettings(UpdateApplicationSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApplicationSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApplicationSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApplicationSettings.</param>
        /// 
        /// <returns>Returns a  UpdateApplicationSettingsResult from SsmSap.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/UpdateApplicationSettings">REST API Reference for UpdateApplicationSettings Operation</seealso>
        public virtual UpdateApplicationSettingsResponse EndUpdateApplicationSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateApplicationSettingsResponse>(asyncResult);
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
            var resolver = new AmazonSsmSapEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}