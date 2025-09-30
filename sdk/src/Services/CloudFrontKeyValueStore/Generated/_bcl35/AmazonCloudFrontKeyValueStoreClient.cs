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
 * Do not modify this file. This file is generated from the cloudfront-keyvaluestore-2022-07-26.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.CloudFrontKeyValueStore.Model;
using Amazon.CloudFrontKeyValueStore.Model.Internal.MarshallTransformations;
using Amazon.CloudFrontKeyValueStore.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.CloudFrontKeyValueStore
{
    /// <summary>
    /// <para>Implementation for accessing CloudFrontKeyValueStore</para>
    ///
    /// Amazon CloudFront KeyValueStore Service to View and Update Data in a KVS Resource
    /// </summary>
    public partial class AmazonCloudFrontKeyValueStoreClient : AmazonServiceClient, IAmazonCloudFrontKeyValueStore
    {
        private static IServiceMetadata serviceMetadata = new AmazonCloudFrontKeyValueStoreMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private ICloudFrontKeyValueStorePaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ICloudFrontKeyValueStorePaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new CloudFrontKeyValueStorePaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonCloudFrontKeyValueStoreClient with the credentials loaded from the application's
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
        public AmazonCloudFrontKeyValueStoreClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudFrontKeyValueStoreConfig()) { }

        /// <summary>
        /// Constructs AmazonCloudFrontKeyValueStoreClient with the credentials loaded from the application's
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
        public AmazonCloudFrontKeyValueStoreClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudFrontKeyValueStoreConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonCloudFrontKeyValueStoreClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonCloudFrontKeyValueStoreClient Configuration Object</param>
        public AmazonCloudFrontKeyValueStoreClient(AmazonCloudFrontKeyValueStoreConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonCloudFrontKeyValueStoreClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCloudFrontKeyValueStoreClient(AWSCredentials credentials)
            : this(credentials, new AmazonCloudFrontKeyValueStoreConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFrontKeyValueStoreClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudFrontKeyValueStoreClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCloudFrontKeyValueStoreConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFrontKeyValueStoreClient with AWS Credentials and an
        /// AmazonCloudFrontKeyValueStoreClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCloudFrontKeyValueStoreClient Configuration Object</param>
        public AmazonCloudFrontKeyValueStoreClient(AWSCredentials credentials, AmazonCloudFrontKeyValueStoreConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFrontKeyValueStoreClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCloudFrontKeyValueStoreClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloudFrontKeyValueStoreConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFrontKeyValueStoreClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudFrontKeyValueStoreClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloudFrontKeyValueStoreConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFrontKeyValueStoreClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudFrontKeyValueStoreClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCloudFrontKeyValueStoreClient Configuration Object</param>
        public AmazonCloudFrontKeyValueStoreClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCloudFrontKeyValueStoreConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFrontKeyValueStoreClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCloudFrontKeyValueStoreClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudFrontKeyValueStoreConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFrontKeyValueStoreClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudFrontKeyValueStoreClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudFrontKeyValueStoreConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFrontKeyValueStoreClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudFrontKeyValueStoreClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCloudFrontKeyValueStoreClient Configuration Object</param>
        public AmazonCloudFrontKeyValueStoreClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCloudFrontKeyValueStoreConfig clientConfig)
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
            return new AWS4aSignerCRTWrapper();
        }

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonCloudFrontKeyValueStoreEndpointResolver());
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


        #region  DeleteKey

        /// <summary>
        /// Deletes the key value pair specified by the key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteKey service method.</param>
        /// 
        /// <returns>The response from the DeleteKey service method, as returned by CloudFrontKeyValueStore.</returns>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.ConflictException">
        /// Resource is not in expected state.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.InternalServerException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.ServiceQuotaExceededException">
        /// Limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.ValidationException">
        /// Validation failed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-keyvaluestore-2022-07-26/DeleteKey">REST API Reference for DeleteKey Operation</seealso>
        public virtual DeleteKeyResponse DeleteKey(DeleteKeyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKeyResponseUnmarshaller.Instance;

            return Invoke<DeleteKeyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteKey operation on AmazonCloudFrontKeyValueStoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-keyvaluestore-2022-07-26/DeleteKey">REST API Reference for DeleteKey Operation</seealso>
        public virtual IAsyncResult BeginDeleteKey(DeleteKeyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKeyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteKey.</param>
        /// 
        /// <returns>Returns a  DeleteKeyResult from CloudFrontKeyValueStore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-keyvaluestore-2022-07-26/DeleteKey">REST API Reference for DeleteKey Operation</seealso>
        public virtual DeleteKeyResponse EndDeleteKey(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteKeyResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeKeyValueStore

        /// <summary>
        /// Returns metadata information about Key Value Store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeKeyValueStore service method.</param>
        /// 
        /// <returns>The response from the DescribeKeyValueStore service method, as returned by CloudFrontKeyValueStore.</returns>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.ConflictException">
        /// Resource is not in expected state.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.InternalServerException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-keyvaluestore-2022-07-26/DescribeKeyValueStore">REST API Reference for DescribeKeyValueStore Operation</seealso>
        public virtual DescribeKeyValueStoreResponse DescribeKeyValueStore(DescribeKeyValueStoreRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeKeyValueStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeKeyValueStoreResponseUnmarshaller.Instance;

            return Invoke<DescribeKeyValueStoreResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeKeyValueStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeKeyValueStore operation on AmazonCloudFrontKeyValueStoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeKeyValueStore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-keyvaluestore-2022-07-26/DescribeKeyValueStore">REST API Reference for DescribeKeyValueStore Operation</seealso>
        public virtual IAsyncResult BeginDescribeKeyValueStore(DescribeKeyValueStoreRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeKeyValueStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeKeyValueStoreResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeKeyValueStore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeKeyValueStore.</param>
        /// 
        /// <returns>Returns a  DescribeKeyValueStoreResult from CloudFrontKeyValueStore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-keyvaluestore-2022-07-26/DescribeKeyValueStore">REST API Reference for DescribeKeyValueStore Operation</seealso>
        public virtual DescribeKeyValueStoreResponse EndDescribeKeyValueStore(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeKeyValueStoreResponse>(asyncResult);
        }

        #endregion
        
        #region  GetKey

        /// <summary>
        /// Returns a key value pair.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKey service method.</param>
        /// 
        /// <returns>The response from the GetKey service method, as returned by CloudFrontKeyValueStore.</returns>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.ConflictException">
        /// Resource is not in expected state.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.InternalServerException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-keyvaluestore-2022-07-26/GetKey">REST API Reference for GetKey Operation</seealso>
        public virtual GetKeyResponse GetKey(GetKeyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKeyResponseUnmarshaller.Instance;

            return Invoke<GetKeyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetKey operation on AmazonCloudFrontKeyValueStoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-keyvaluestore-2022-07-26/GetKey">REST API Reference for GetKey Operation</seealso>
        public virtual IAsyncResult BeginGetKey(GetKeyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKeyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetKey.</param>
        /// 
        /// <returns>Returns a  GetKeyResult from CloudFrontKeyValueStore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-keyvaluestore-2022-07-26/GetKey">REST API Reference for GetKey Operation</seealso>
        public virtual GetKeyResponse EndGetKey(IAsyncResult asyncResult)
        {
            return EndInvoke<GetKeyResponse>(asyncResult);
        }

        #endregion
        
        #region  ListKeys

        /// <summary>
        /// Returns a list of key value pairs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKeys service method.</param>
        /// 
        /// <returns>The response from the ListKeys service method, as returned by CloudFrontKeyValueStore.</returns>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.ConflictException">
        /// Resource is not in expected state.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.InternalServerException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.ValidationException">
        /// Validation failed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-keyvaluestore-2022-07-26/ListKeys">REST API Reference for ListKeys Operation</seealso>
        public virtual ListKeysResponse ListKeys(ListKeysRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKeysResponseUnmarshaller.Instance;

            return Invoke<ListKeysResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListKeys operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListKeys operation on AmazonCloudFrontKeyValueStoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListKeys
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-keyvaluestore-2022-07-26/ListKeys">REST API Reference for ListKeys Operation</seealso>
        public virtual IAsyncResult BeginListKeys(ListKeysRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKeysResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListKeys operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListKeys.</param>
        /// 
        /// <returns>Returns a  ListKeysResult from CloudFrontKeyValueStore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-keyvaluestore-2022-07-26/ListKeys">REST API Reference for ListKeys Operation</seealso>
        public virtual ListKeysResponse EndListKeys(IAsyncResult asyncResult)
        {
            return EndInvoke<ListKeysResponse>(asyncResult);
        }

        #endregion
        
        #region  PutKey

        /// <summary>
        /// Creates a new key value pair or replaces the value of an existing key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutKey service method.</param>
        /// 
        /// <returns>The response from the PutKey service method, as returned by CloudFrontKeyValueStore.</returns>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.ConflictException">
        /// Resource is not in expected state.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.InternalServerException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.ServiceQuotaExceededException">
        /// Limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.ValidationException">
        /// Validation failed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-keyvaluestore-2022-07-26/PutKey">REST API Reference for PutKey Operation</seealso>
        public virtual PutKeyResponse PutKey(PutKeyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutKeyResponseUnmarshaller.Instance;

            return Invoke<PutKeyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutKey operation on AmazonCloudFrontKeyValueStoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-keyvaluestore-2022-07-26/PutKey">REST API Reference for PutKey Operation</seealso>
        public virtual IAsyncResult BeginPutKey(PutKeyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutKeyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutKey.</param>
        /// 
        /// <returns>Returns a  PutKeyResult from CloudFrontKeyValueStore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-keyvaluestore-2022-07-26/PutKey">REST API Reference for PutKey Operation</seealso>
        public virtual PutKeyResponse EndPutKey(IAsyncResult asyncResult)
        {
            return EndInvoke<PutKeyResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateKeys

        /// <summary>
        /// Puts or Deletes multiple key value pairs in a single, all-or-nothing operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateKeys service method.</param>
        /// 
        /// <returns>The response from the UpdateKeys service method, as returned by CloudFrontKeyValueStore.</returns>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.ConflictException">
        /// Resource is not in expected state.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.InternalServerException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.ServiceQuotaExceededException">
        /// Limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.ValidationException">
        /// Validation failed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-keyvaluestore-2022-07-26/UpdateKeys">REST API Reference for UpdateKeys Operation</seealso>
        public virtual UpdateKeysResponse UpdateKeys(UpdateKeysRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateKeysResponseUnmarshaller.Instance;

            return Invoke<UpdateKeysResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateKeys operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateKeys operation on AmazonCloudFrontKeyValueStoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateKeys
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-keyvaluestore-2022-07-26/UpdateKeys">REST API Reference for UpdateKeys Operation</seealso>
        public virtual IAsyncResult BeginUpdateKeys(UpdateKeysRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateKeysResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateKeys operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateKeys.</param>
        /// 
        /// <returns>Returns a  UpdateKeysResult from CloudFrontKeyValueStore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-keyvaluestore-2022-07-26/UpdateKeys">REST API Reference for UpdateKeys Operation</seealso>
        public virtual UpdateKeysResponse EndUpdateKeys(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateKeysResponse>(asyncResult);
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
            var resolver = new AmazonCloudFrontKeyValueStoreEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}