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
 * Do not modify this file. This file is generated from the timestream-influxdb-2023-01-27.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.TimestreamInfluxDB.Model;
using Amazon.TimestreamInfluxDB.Model.Internal.MarshallTransformations;
using Amazon.TimestreamInfluxDB.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.TimestreamInfluxDB
{
    /// <summary>
    /// <para>Implementation for accessing TimestreamInfluxDB</para>
    ///
    /// Amazon Timestream for InfluxDB is a managed time-series database engine that makes
    /// it easy for application developers and DevOps teams to run InfluxDB databases on Amazon
    /// Web Services for near real-time time-series applications using open-source APIs. With
    /// Amazon Timestream for InfluxDB, it is easy to set up, operate, and scale time-series
    /// workloads that can answer queries with single-digit millisecond query response time.
    /// </summary>
    public partial class AmazonTimestreamInfluxDBClient : AmazonServiceClient, IAmazonTimestreamInfluxDB
    {
        private static IServiceMetadata serviceMetadata = new AmazonTimestreamInfluxDBMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private ITimestreamInfluxDBPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ITimestreamInfluxDBPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new TimestreamInfluxDBPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonTimestreamInfluxDBClient with the credentials loaded from the application's
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
        public AmazonTimestreamInfluxDBClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonTimestreamInfluxDBConfig()) { }

        /// <summary>
        /// Constructs AmazonTimestreamInfluxDBClient with the credentials loaded from the application's
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
        public AmazonTimestreamInfluxDBClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonTimestreamInfluxDBConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonTimestreamInfluxDBClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonTimestreamInfluxDBClient Configuration Object</param>
        public AmazonTimestreamInfluxDBClient(AmazonTimestreamInfluxDBConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonTimestreamInfluxDBClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonTimestreamInfluxDBClient(AWSCredentials credentials)
            : this(credentials, new AmazonTimestreamInfluxDBConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonTimestreamInfluxDBClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonTimestreamInfluxDBClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonTimestreamInfluxDBConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonTimestreamInfluxDBClient with AWS Credentials and an
        /// AmazonTimestreamInfluxDBClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonTimestreamInfluxDBClient Configuration Object</param>
        public AmazonTimestreamInfluxDBClient(AWSCredentials credentials, AmazonTimestreamInfluxDBConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonTimestreamInfluxDBClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonTimestreamInfluxDBClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonTimestreamInfluxDBConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonTimestreamInfluxDBClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonTimestreamInfluxDBClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonTimestreamInfluxDBConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonTimestreamInfluxDBClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonTimestreamInfluxDBClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonTimestreamInfluxDBClient Configuration Object</param>
        public AmazonTimestreamInfluxDBClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonTimestreamInfluxDBConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonTimestreamInfluxDBClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonTimestreamInfluxDBClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonTimestreamInfluxDBConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonTimestreamInfluxDBClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonTimestreamInfluxDBClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonTimestreamInfluxDBConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonTimestreamInfluxDBClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonTimestreamInfluxDBClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonTimestreamInfluxDBClient Configuration Object</param>
        public AmazonTimestreamInfluxDBClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonTimestreamInfluxDBConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonTimestreamInfluxDBEndpointResolver());
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


        #region  CreateDbInstance

        /// <summary>
        /// Creates a new Timestream for InfluxDB DB instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDbInstance service method.</param>
        /// 
        /// <returns>The response from the CreateDbInstance service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ConflictException">
        /// The request conflicts with an existing resource in Timestream for InfluxDB.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ServiceQuotaExceededException">
        /// The request exceeds the service quota.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Timestream for InfluxDB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/CreateDbInstance">REST API Reference for CreateDbInstance Operation</seealso>
        public virtual CreateDbInstanceResponse CreateDbInstance(CreateDbInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDbInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDbInstanceResponseUnmarshaller.Instance;

            return Invoke<CreateDbInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDbInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDbInstance operation on AmazonTimestreamInfluxDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDbInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/CreateDbInstance">REST API Reference for CreateDbInstance Operation</seealso>
        public virtual IAsyncResult BeginCreateDbInstance(CreateDbInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDbInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDbInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDbInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDbInstance.</param>
        /// 
        /// <returns>Returns a  CreateDbInstanceResult from TimestreamInfluxDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/CreateDbInstance">REST API Reference for CreateDbInstance Operation</seealso>
        public virtual CreateDbInstanceResponse EndCreateDbInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDbInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDbParameterGroup

        /// <summary>
        /// Creates a new Timestream for InfluxDB DB parameter group to associate with DB instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDbParameterGroup service method.</param>
        /// 
        /// <returns>The response from the CreateDbParameterGroup service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ConflictException">
        /// The request conflicts with an existing resource in Timestream for InfluxDB.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ServiceQuotaExceededException">
        /// The request exceeds the service quota.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Timestream for InfluxDB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/CreateDbParameterGroup">REST API Reference for CreateDbParameterGroup Operation</seealso>
        public virtual CreateDbParameterGroupResponse CreateDbParameterGroup(CreateDbParameterGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDbParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDbParameterGroupResponseUnmarshaller.Instance;

            return Invoke<CreateDbParameterGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDbParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDbParameterGroup operation on AmazonTimestreamInfluxDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDbParameterGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/CreateDbParameterGroup">REST API Reference for CreateDbParameterGroup Operation</seealso>
        public virtual IAsyncResult BeginCreateDbParameterGroup(CreateDbParameterGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDbParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDbParameterGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDbParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDbParameterGroup.</param>
        /// 
        /// <returns>Returns a  CreateDbParameterGroupResult from TimestreamInfluxDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/CreateDbParameterGroup">REST API Reference for CreateDbParameterGroup Operation</seealso>
        public virtual CreateDbParameterGroupResponse EndCreateDbParameterGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDbParameterGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDbInstance

        /// <summary>
        /// Deletes a Timestream for InfluxDB DB instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDbInstance service method.</param>
        /// 
        /// <returns>The response from the DeleteDbInstance service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ConflictException">
        /// The request conflicts with an existing resource in Timestream for InfluxDB.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Timestream for InfluxDB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/DeleteDbInstance">REST API Reference for DeleteDbInstance Operation</seealso>
        public virtual DeleteDbInstanceResponse DeleteDbInstance(DeleteDbInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDbInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDbInstanceResponseUnmarshaller.Instance;

            return Invoke<DeleteDbInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDbInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDbInstance operation on AmazonTimestreamInfluxDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDbInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/DeleteDbInstance">REST API Reference for DeleteDbInstance Operation</seealso>
        public virtual IAsyncResult BeginDeleteDbInstance(DeleteDbInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDbInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDbInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDbInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDbInstance.</param>
        /// 
        /// <returns>Returns a  DeleteDbInstanceResult from TimestreamInfluxDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/DeleteDbInstance">REST API Reference for DeleteDbInstance Operation</seealso>
        public virtual DeleteDbInstanceResponse EndDeleteDbInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDbInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDbInstance

        /// <summary>
        /// Returns a Timestream for InfluxDB DB instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDbInstance service method.</param>
        /// 
        /// <returns>The response from the GetDbInstance service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Timestream for InfluxDB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/GetDbInstance">REST API Reference for GetDbInstance Operation</seealso>
        public virtual GetDbInstanceResponse GetDbInstance(GetDbInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDbInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDbInstanceResponseUnmarshaller.Instance;

            return Invoke<GetDbInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDbInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDbInstance operation on AmazonTimestreamInfluxDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDbInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/GetDbInstance">REST API Reference for GetDbInstance Operation</seealso>
        public virtual IAsyncResult BeginGetDbInstance(GetDbInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDbInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDbInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDbInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDbInstance.</param>
        /// 
        /// <returns>Returns a  GetDbInstanceResult from TimestreamInfluxDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/GetDbInstance">REST API Reference for GetDbInstance Operation</seealso>
        public virtual GetDbInstanceResponse EndGetDbInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDbInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDbParameterGroup

        /// <summary>
        /// Returns a Timestream for InfluxDB DB parameter group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDbParameterGroup service method.</param>
        /// 
        /// <returns>The response from the GetDbParameterGroup service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Timestream for InfluxDB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/GetDbParameterGroup">REST API Reference for GetDbParameterGroup Operation</seealso>
        public virtual GetDbParameterGroupResponse GetDbParameterGroup(GetDbParameterGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDbParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDbParameterGroupResponseUnmarshaller.Instance;

            return Invoke<GetDbParameterGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDbParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDbParameterGroup operation on AmazonTimestreamInfluxDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDbParameterGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/GetDbParameterGroup">REST API Reference for GetDbParameterGroup Operation</seealso>
        public virtual IAsyncResult BeginGetDbParameterGroup(GetDbParameterGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDbParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDbParameterGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDbParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDbParameterGroup.</param>
        /// 
        /// <returns>Returns a  GetDbParameterGroupResult from TimestreamInfluxDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/GetDbParameterGroup">REST API Reference for GetDbParameterGroup Operation</seealso>
        public virtual GetDbParameterGroupResponse EndGetDbParameterGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDbParameterGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDbInstances

        /// <summary>
        /// Returns a list of Timestream for InfluxDB DB instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDbInstances service method.</param>
        /// 
        /// <returns>The response from the ListDbInstances service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Timestream for InfluxDB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/ListDbInstances">REST API Reference for ListDbInstances Operation</seealso>
        public virtual ListDbInstancesResponse ListDbInstances(ListDbInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDbInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDbInstancesResponseUnmarshaller.Instance;

            return Invoke<ListDbInstancesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDbInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDbInstances operation on AmazonTimestreamInfluxDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDbInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/ListDbInstances">REST API Reference for ListDbInstances Operation</seealso>
        public virtual IAsyncResult BeginListDbInstances(ListDbInstancesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDbInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDbInstancesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDbInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDbInstances.</param>
        /// 
        /// <returns>Returns a  ListDbInstancesResult from TimestreamInfluxDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/ListDbInstances">REST API Reference for ListDbInstances Operation</seealso>
        public virtual ListDbInstancesResponse EndListDbInstances(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDbInstancesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDbParameterGroups

        /// <summary>
        /// Returns a list of Timestream for InfluxDB DB parameter groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDbParameterGroups service method.</param>
        /// 
        /// <returns>The response from the ListDbParameterGroups service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Timestream for InfluxDB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/ListDbParameterGroups">REST API Reference for ListDbParameterGroups Operation</seealso>
        public virtual ListDbParameterGroupsResponse ListDbParameterGroups(ListDbParameterGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDbParameterGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDbParameterGroupsResponseUnmarshaller.Instance;

            return Invoke<ListDbParameterGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDbParameterGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDbParameterGroups operation on AmazonTimestreamInfluxDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDbParameterGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/ListDbParameterGroups">REST API Reference for ListDbParameterGroups Operation</seealso>
        public virtual IAsyncResult BeginListDbParameterGroups(ListDbParameterGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDbParameterGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDbParameterGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDbParameterGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDbParameterGroups.</param>
        /// 
        /// <returns>Returns a  ListDbParameterGroupsResult from TimestreamInfluxDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/ListDbParameterGroups">REST API Reference for ListDbParameterGroups Operation</seealso>
        public virtual ListDbParameterGroupsResponse EndListDbParameterGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDbParameterGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// A list of tags applied to the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonTimestreamInfluxDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  ListTagsForResourceResult from TimestreamInfluxDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Tags are composed of a Key/Value pairs. You can use tags to categorize and track your
        /// Timestream for InfluxDB resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ServiceQuotaExceededException">
        /// The request exceeds the service quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonTimestreamInfluxDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  TagResourceResult from TimestreamInfluxDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes the tag from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonTimestreamInfluxDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  UntagResourceResult from TimestreamInfluxDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDbInstance

        /// <summary>
        /// Updates a Timestream for InfluxDB DB instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDbInstance service method.</param>
        /// 
        /// <returns>The response from the UpdateDbInstance service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ConflictException">
        /// The request conflicts with an existing resource in Timestream for InfluxDB.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Timestream for InfluxDB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/UpdateDbInstance">REST API Reference for UpdateDbInstance Operation</seealso>
        public virtual UpdateDbInstanceResponse UpdateDbInstance(UpdateDbInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDbInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDbInstanceResponseUnmarshaller.Instance;

            return Invoke<UpdateDbInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDbInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDbInstance operation on AmazonTimestreamInfluxDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDbInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/UpdateDbInstance">REST API Reference for UpdateDbInstance Operation</seealso>
        public virtual IAsyncResult BeginUpdateDbInstance(UpdateDbInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDbInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDbInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDbInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDbInstance.</param>
        /// 
        /// <returns>Returns a  UpdateDbInstanceResult from TimestreamInfluxDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/UpdateDbInstance">REST API Reference for UpdateDbInstance Operation</seealso>
        public virtual UpdateDbInstanceResponse EndUpdateDbInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDbInstanceResponse>(asyncResult);
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
            var resolver = new AmazonTimestreamInfluxDBEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}