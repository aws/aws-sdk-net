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
 * Do not modify this file. This file is generated from the iotdeviceadvisor-2020-09-18.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.IoTDeviceAdvisor.Model;
using Amazon.IoTDeviceAdvisor.Model.Internal.MarshallTransformations;
using Amazon.IoTDeviceAdvisor.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.IoTDeviceAdvisor
{
    /// <summary>
    /// <para>Implementation for accessing IoTDeviceAdvisor</para>
    ///
    /// Amazon Web Services IoT Core Device Advisor is a cloud-based, fully managed test capability
    /// for validating IoT devices during device software development. Device Advisor provides
    /// pre-built tests that you can use to validate IoT devices for reliable and secure connectivity
    /// with Amazon Web Services IoT Core before deploying devices to production. By using
    /// Device Advisor, you can confirm that your devices can connect to Amazon Web Services
    /// IoT Core, follow security best practices and, if applicable, receive software updates
    /// from IoT Device Management. You can also download signed qualification reports to
    /// submit to the Amazon Web Services Partner Network to get your device qualified for
    /// the Amazon Web Services Partner Device Catalog without the need to send your device
    /// in and wait for it to be tested.
    /// </summary>
    public partial class AmazonIoTDeviceAdvisorClient : AmazonServiceClient, IAmazonIoTDeviceAdvisor
    {
        private static IServiceMetadata serviceMetadata = new AmazonIoTDeviceAdvisorMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IIoTDeviceAdvisorPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IIoTDeviceAdvisorPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new IoTDeviceAdvisorPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonIoTDeviceAdvisorClient with the credentials loaded from the application's
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
        public AmazonIoTDeviceAdvisorClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonIoTDeviceAdvisorConfig()) { }

        /// <summary>
        /// Constructs AmazonIoTDeviceAdvisorClient with the credentials loaded from the application's
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
        public AmazonIoTDeviceAdvisorClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonIoTDeviceAdvisorConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonIoTDeviceAdvisorClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonIoTDeviceAdvisorClient Configuration Object</param>
        public AmazonIoTDeviceAdvisorClient(AmazonIoTDeviceAdvisorConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonIoTDeviceAdvisorClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonIoTDeviceAdvisorClient(AWSCredentials credentials)
            : this(credentials, new AmazonIoTDeviceAdvisorConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIoTDeviceAdvisorClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIoTDeviceAdvisorClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonIoTDeviceAdvisorConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonIoTDeviceAdvisorClient with AWS Credentials and an
        /// AmazonIoTDeviceAdvisorClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonIoTDeviceAdvisorClient Configuration Object</param>
        public AmazonIoTDeviceAdvisorClient(AWSCredentials credentials, AmazonIoTDeviceAdvisorConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonIoTDeviceAdvisorClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonIoTDeviceAdvisorClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIoTDeviceAdvisorConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIoTDeviceAdvisorClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIoTDeviceAdvisorClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIoTDeviceAdvisorConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonIoTDeviceAdvisorClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonIoTDeviceAdvisorClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonIoTDeviceAdvisorClient Configuration Object</param>
        public AmazonIoTDeviceAdvisorClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonIoTDeviceAdvisorConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonIoTDeviceAdvisorClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonIoTDeviceAdvisorClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonIoTDeviceAdvisorConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIoTDeviceAdvisorClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIoTDeviceAdvisorClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonIoTDeviceAdvisorConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonIoTDeviceAdvisorClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonIoTDeviceAdvisorClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonIoTDeviceAdvisorClient Configuration Object</param>
        public AmazonIoTDeviceAdvisorClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonIoTDeviceAdvisorConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonIoTDeviceAdvisorEndpointResolver());
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


        #region  CreateSuiteDefinition

        /// <summary>
        /// Creates a Device Advisor test suite.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CreateSuiteDefinition</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSuiteDefinition service method.</param>
        /// 
        /// <returns>The response from the CreateSuiteDefinition service method, as returned by IoTDeviceAdvisor.</returns>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.InternalServerException">
        /// Sends an Internal Failure exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ValidationException">
        /// Sends a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/CreateSuiteDefinition">REST API Reference for CreateSuiteDefinition Operation</seealso>
        public virtual CreateSuiteDefinitionResponse CreateSuiteDefinition(CreateSuiteDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSuiteDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSuiteDefinitionResponseUnmarshaller.Instance;

            return Invoke<CreateSuiteDefinitionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSuiteDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSuiteDefinition operation on AmazonIoTDeviceAdvisorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSuiteDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/CreateSuiteDefinition">REST API Reference for CreateSuiteDefinition Operation</seealso>
        public virtual IAsyncResult BeginCreateSuiteDefinition(CreateSuiteDefinitionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSuiteDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSuiteDefinitionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSuiteDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSuiteDefinition.</param>
        /// 
        /// <returns>Returns a  CreateSuiteDefinitionResult from IoTDeviceAdvisor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/CreateSuiteDefinition">REST API Reference for CreateSuiteDefinition Operation</seealso>
        public virtual CreateSuiteDefinitionResponse EndCreateSuiteDefinition(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSuiteDefinitionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteSuiteDefinition

        /// <summary>
        /// Deletes a Device Advisor test suite.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DeleteSuiteDefinition</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSuiteDefinition service method.</param>
        /// 
        /// <returns>The response from the DeleteSuiteDefinition service method, as returned by IoTDeviceAdvisor.</returns>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.InternalServerException">
        /// Sends an Internal Failure exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ValidationException">
        /// Sends a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/DeleteSuiteDefinition">REST API Reference for DeleteSuiteDefinition Operation</seealso>
        public virtual DeleteSuiteDefinitionResponse DeleteSuiteDefinition(DeleteSuiteDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSuiteDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSuiteDefinitionResponseUnmarshaller.Instance;

            return Invoke<DeleteSuiteDefinitionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSuiteDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSuiteDefinition operation on AmazonIoTDeviceAdvisorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSuiteDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/DeleteSuiteDefinition">REST API Reference for DeleteSuiteDefinition Operation</seealso>
        public virtual IAsyncResult BeginDeleteSuiteDefinition(DeleteSuiteDefinitionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSuiteDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSuiteDefinitionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSuiteDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSuiteDefinition.</param>
        /// 
        /// <returns>Returns a  DeleteSuiteDefinitionResult from IoTDeviceAdvisor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/DeleteSuiteDefinition">REST API Reference for DeleteSuiteDefinition Operation</seealso>
        public virtual DeleteSuiteDefinitionResponse EndDeleteSuiteDefinition(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSuiteDefinitionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetEndpoint

        /// <summary>
        /// Gets information about an Device Advisor endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEndpoint service method.</param>
        /// 
        /// <returns>The response from the GetEndpoint service method, as returned by IoTDeviceAdvisor.</returns>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.InternalServerException">
        /// Sends an Internal Failure exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ResourceNotFoundException">
        /// Sends a Resource Not Found exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ValidationException">
        /// Sends a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/GetEndpoint">REST API Reference for GetEndpoint Operation</seealso>
        public virtual GetEndpointResponse GetEndpoint(GetEndpointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEndpointResponseUnmarshaller.Instance;

            return Invoke<GetEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEndpoint operation on AmazonIoTDeviceAdvisorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/GetEndpoint">REST API Reference for GetEndpoint Operation</seealso>
        public virtual IAsyncResult BeginGetEndpoint(GetEndpointRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEndpointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEndpoint.</param>
        /// 
        /// <returns>Returns a  GetEndpointResult from IoTDeviceAdvisor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/GetEndpoint">REST API Reference for GetEndpoint Operation</seealso>
        public virtual GetEndpointResponse EndGetEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<GetEndpointResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSuiteDefinition

        /// <summary>
        /// Gets information about a Device Advisor test suite.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">GetSuiteDefinition</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSuiteDefinition service method.</param>
        /// 
        /// <returns>The response from the GetSuiteDefinition service method, as returned by IoTDeviceAdvisor.</returns>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.InternalServerException">
        /// Sends an Internal Failure exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ResourceNotFoundException">
        /// Sends a Resource Not Found exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ValidationException">
        /// Sends a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/GetSuiteDefinition">REST API Reference for GetSuiteDefinition Operation</seealso>
        public virtual GetSuiteDefinitionResponse GetSuiteDefinition(GetSuiteDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSuiteDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSuiteDefinitionResponseUnmarshaller.Instance;

            return Invoke<GetSuiteDefinitionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSuiteDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSuiteDefinition operation on AmazonIoTDeviceAdvisorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSuiteDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/GetSuiteDefinition">REST API Reference for GetSuiteDefinition Operation</seealso>
        public virtual IAsyncResult BeginGetSuiteDefinition(GetSuiteDefinitionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSuiteDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSuiteDefinitionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSuiteDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSuiteDefinition.</param>
        /// 
        /// <returns>Returns a  GetSuiteDefinitionResult from IoTDeviceAdvisor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/GetSuiteDefinition">REST API Reference for GetSuiteDefinition Operation</seealso>
        public virtual GetSuiteDefinitionResponse EndGetSuiteDefinition(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSuiteDefinitionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSuiteRun

        /// <summary>
        /// Gets information about a Device Advisor test suite run.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">GetSuiteRun</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSuiteRun service method.</param>
        /// 
        /// <returns>The response from the GetSuiteRun service method, as returned by IoTDeviceAdvisor.</returns>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.InternalServerException">
        /// Sends an Internal Failure exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ResourceNotFoundException">
        /// Sends a Resource Not Found exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ValidationException">
        /// Sends a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/GetSuiteRun">REST API Reference for GetSuiteRun Operation</seealso>
        public virtual GetSuiteRunResponse GetSuiteRun(GetSuiteRunRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSuiteRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSuiteRunResponseUnmarshaller.Instance;

            return Invoke<GetSuiteRunResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSuiteRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSuiteRun operation on AmazonIoTDeviceAdvisorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSuiteRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/GetSuiteRun">REST API Reference for GetSuiteRun Operation</seealso>
        public virtual IAsyncResult BeginGetSuiteRun(GetSuiteRunRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSuiteRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSuiteRunResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSuiteRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSuiteRun.</param>
        /// 
        /// <returns>Returns a  GetSuiteRunResult from IoTDeviceAdvisor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/GetSuiteRun">REST API Reference for GetSuiteRun Operation</seealso>
        public virtual GetSuiteRunResponse EndGetSuiteRun(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSuiteRunResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSuiteRunReport

        /// <summary>
        /// Gets a report download link for a successful Device Advisor qualifying test suite
        /// run.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">GetSuiteRunReport</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSuiteRunReport service method.</param>
        /// 
        /// <returns>The response from the GetSuiteRunReport service method, as returned by IoTDeviceAdvisor.</returns>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.InternalServerException">
        /// Sends an Internal Failure exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ResourceNotFoundException">
        /// Sends a Resource Not Found exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ValidationException">
        /// Sends a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/GetSuiteRunReport">REST API Reference for GetSuiteRunReport Operation</seealso>
        public virtual GetSuiteRunReportResponse GetSuiteRunReport(GetSuiteRunReportRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSuiteRunReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSuiteRunReportResponseUnmarshaller.Instance;

            return Invoke<GetSuiteRunReportResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSuiteRunReport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSuiteRunReport operation on AmazonIoTDeviceAdvisorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSuiteRunReport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/GetSuiteRunReport">REST API Reference for GetSuiteRunReport Operation</seealso>
        public virtual IAsyncResult BeginGetSuiteRunReport(GetSuiteRunReportRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSuiteRunReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSuiteRunReportResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSuiteRunReport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSuiteRunReport.</param>
        /// 
        /// <returns>Returns a  GetSuiteRunReportResult from IoTDeviceAdvisor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/GetSuiteRunReport">REST API Reference for GetSuiteRunReport Operation</seealso>
        public virtual GetSuiteRunReportResponse EndGetSuiteRunReport(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSuiteRunReportResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSuiteDefinitions

        /// <summary>
        /// Lists the Device Advisor test suites you have created.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListSuiteDefinitions</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSuiteDefinitions service method.</param>
        /// 
        /// <returns>The response from the ListSuiteDefinitions service method, as returned by IoTDeviceAdvisor.</returns>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.InternalServerException">
        /// Sends an Internal Failure exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ValidationException">
        /// Sends a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/ListSuiteDefinitions">REST API Reference for ListSuiteDefinitions Operation</seealso>
        public virtual ListSuiteDefinitionsResponse ListSuiteDefinitions(ListSuiteDefinitionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSuiteDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSuiteDefinitionsResponseUnmarshaller.Instance;

            return Invoke<ListSuiteDefinitionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSuiteDefinitions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSuiteDefinitions operation on AmazonIoTDeviceAdvisorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSuiteDefinitions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/ListSuiteDefinitions">REST API Reference for ListSuiteDefinitions Operation</seealso>
        public virtual IAsyncResult BeginListSuiteDefinitions(ListSuiteDefinitionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSuiteDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSuiteDefinitionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSuiteDefinitions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSuiteDefinitions.</param>
        /// 
        /// <returns>Returns a  ListSuiteDefinitionsResult from IoTDeviceAdvisor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/ListSuiteDefinitions">REST API Reference for ListSuiteDefinitions Operation</seealso>
        public virtual ListSuiteDefinitionsResponse EndListSuiteDefinitions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSuiteDefinitionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSuiteRuns

        /// <summary>
        /// Lists runs of the specified Device Advisor test suite. You can list all runs of the
        /// test suite, or the runs of a specific version of the test suite.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListSuiteRuns</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSuiteRuns service method.</param>
        /// 
        /// <returns>The response from the ListSuiteRuns service method, as returned by IoTDeviceAdvisor.</returns>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.InternalServerException">
        /// Sends an Internal Failure exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ValidationException">
        /// Sends a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/ListSuiteRuns">REST API Reference for ListSuiteRuns Operation</seealso>
        public virtual ListSuiteRunsResponse ListSuiteRuns(ListSuiteRunsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSuiteRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSuiteRunsResponseUnmarshaller.Instance;

            return Invoke<ListSuiteRunsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSuiteRuns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSuiteRuns operation on AmazonIoTDeviceAdvisorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSuiteRuns
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/ListSuiteRuns">REST API Reference for ListSuiteRuns Operation</seealso>
        public virtual IAsyncResult BeginListSuiteRuns(ListSuiteRunsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSuiteRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSuiteRunsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSuiteRuns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSuiteRuns.</param>
        /// 
        /// <returns>Returns a  ListSuiteRunsResult from IoTDeviceAdvisor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/ListSuiteRuns">REST API Reference for ListSuiteRuns Operation</seealso>
        public virtual ListSuiteRunsResponse EndListSuiteRuns(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSuiteRunsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists the tags attached to an IoT Device Advisor resource.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListTagsForResource</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by IoTDeviceAdvisor.</returns>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.InternalServerException">
        /// Sends an Internal Failure exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ResourceNotFoundException">
        /// Sends a Resource Not Found exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ValidationException">
        /// Sends a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonIoTDeviceAdvisorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from IoTDeviceAdvisor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  StartSuiteRun

        /// <summary>
        /// Starts a Device Advisor test suite run.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">StartSuiteRun</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSuiteRun service method.</param>
        /// 
        /// <returns>The response from the StartSuiteRun service method, as returned by IoTDeviceAdvisor.</returns>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ConflictException">
        /// Sends a Conflict Exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.InternalServerException">
        /// Sends an Internal Failure exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ValidationException">
        /// Sends a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/StartSuiteRun">REST API Reference for StartSuiteRun Operation</seealso>
        public virtual StartSuiteRunResponse StartSuiteRun(StartSuiteRunRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartSuiteRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSuiteRunResponseUnmarshaller.Instance;

            return Invoke<StartSuiteRunResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartSuiteRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartSuiteRun operation on AmazonIoTDeviceAdvisorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartSuiteRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/StartSuiteRun">REST API Reference for StartSuiteRun Operation</seealso>
        public virtual IAsyncResult BeginStartSuiteRun(StartSuiteRunRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartSuiteRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSuiteRunResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartSuiteRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartSuiteRun.</param>
        /// 
        /// <returns>Returns a  StartSuiteRunResult from IoTDeviceAdvisor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/StartSuiteRun">REST API Reference for StartSuiteRun Operation</seealso>
        public virtual StartSuiteRunResponse EndStartSuiteRun(IAsyncResult asyncResult)
        {
            return EndInvoke<StartSuiteRunResponse>(asyncResult);
        }

        #endregion
        
        #region  StopSuiteRun

        /// <summary>
        /// Stops a Device Advisor test suite run that is currently running.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">StopSuiteRun</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopSuiteRun service method.</param>
        /// 
        /// <returns>The response from the StopSuiteRun service method, as returned by IoTDeviceAdvisor.</returns>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.InternalServerException">
        /// Sends an Internal Failure exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ResourceNotFoundException">
        /// Sends a Resource Not Found exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ValidationException">
        /// Sends a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/StopSuiteRun">REST API Reference for StopSuiteRun Operation</seealso>
        public virtual StopSuiteRunResponse StopSuiteRun(StopSuiteRunRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopSuiteRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopSuiteRunResponseUnmarshaller.Instance;

            return Invoke<StopSuiteRunResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopSuiteRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopSuiteRun operation on AmazonIoTDeviceAdvisorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopSuiteRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/StopSuiteRun">REST API Reference for StopSuiteRun Operation</seealso>
        public virtual IAsyncResult BeginStopSuiteRun(StopSuiteRunRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopSuiteRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopSuiteRunResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopSuiteRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopSuiteRun.</param>
        /// 
        /// <returns>Returns a  StopSuiteRunResult from IoTDeviceAdvisor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/StopSuiteRun">REST API Reference for StopSuiteRun Operation</seealso>
        public virtual StopSuiteRunResponse EndStopSuiteRun(IAsyncResult asyncResult)
        {
            return EndInvoke<StopSuiteRunResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds to and modifies existing tags of an IoT Device Advisor resource.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">TagResource</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by IoTDeviceAdvisor.</returns>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.InternalServerException">
        /// Sends an Internal Failure exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ResourceNotFoundException">
        /// Sends a Resource Not Found exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ValidationException">
        /// Sends a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonIoTDeviceAdvisorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from IoTDeviceAdvisor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes tags from an IoT Device Advisor resource.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">UntagResource</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by IoTDeviceAdvisor.</returns>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.InternalServerException">
        /// Sends an Internal Failure exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ResourceNotFoundException">
        /// Sends a Resource Not Found exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ValidationException">
        /// Sends a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonIoTDeviceAdvisorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from IoTDeviceAdvisor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateSuiteDefinition

        /// <summary>
        /// Updates a Device Advisor test suite.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">UpdateSuiteDefinition</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSuiteDefinition service method.</param>
        /// 
        /// <returns>The response from the UpdateSuiteDefinition service method, as returned by IoTDeviceAdvisor.</returns>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.InternalServerException">
        /// Sends an Internal Failure exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ValidationException">
        /// Sends a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/UpdateSuiteDefinition">REST API Reference for UpdateSuiteDefinition Operation</seealso>
        public virtual UpdateSuiteDefinitionResponse UpdateSuiteDefinition(UpdateSuiteDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSuiteDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSuiteDefinitionResponseUnmarshaller.Instance;

            return Invoke<UpdateSuiteDefinitionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSuiteDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSuiteDefinition operation on AmazonIoTDeviceAdvisorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSuiteDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/UpdateSuiteDefinition">REST API Reference for UpdateSuiteDefinition Operation</seealso>
        public virtual IAsyncResult BeginUpdateSuiteDefinition(UpdateSuiteDefinitionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSuiteDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSuiteDefinitionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSuiteDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSuiteDefinition.</param>
        /// 
        /// <returns>Returns a  UpdateSuiteDefinitionResult from IoTDeviceAdvisor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/UpdateSuiteDefinition">REST API Reference for UpdateSuiteDefinition Operation</seealso>
        public virtual UpdateSuiteDefinitionResponse EndUpdateSuiteDefinition(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSuiteDefinitionResponse>(asyncResult);
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
            var resolver = new AmazonIoTDeviceAdvisorEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}