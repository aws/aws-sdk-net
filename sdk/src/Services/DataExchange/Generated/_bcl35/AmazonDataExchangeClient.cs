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
 * Do not modify this file. This file is generated from the dataexchange-2017-07-25.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.DataExchange.Model;
using Amazon.DataExchange.Model.Internal.MarshallTransformations;
using Amazon.DataExchange.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.DataExchange
{
    /// <summary>
    /// <para>Implementation for accessing DataExchange</para>
    ///
    /// AWS Data Exchange is a service that makes it easy for AWS customers to exchange data
    /// in the cloud. You can use the AWS Data Exchange APIs to create, update, manage, and
    /// access file-based data set in the AWS Cloud.
    /// 
    ///  
    /// <para>
    /// As a subscriber, you can view and access the data sets that you have an entitlement
    /// to through a subscription. You can use the APIs to download or copy your entitled
    /// data sets to Amazon Simple Storage Service (Amazon S3) for use across a variety of
    /// AWS analytics and machine learning services.
    /// </para>
    ///  
    /// <para>
    /// As a provider, you can create and manage your data sets that you would like to publish
    /// to a product. Being able to package and provide your data sets into products requires
    /// a few steps to determine eligibility. For more information, visit the <i>AWS Data
    /// Exchange User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// A data set is a collection of data that can be changed or updated over time. Data
    /// sets can be updated using revisions, which represent a new version or incremental
    /// change to a data set. A revision contains one or more assets. An asset in AWS Data
    /// Exchange is a piece of data that can be stored as an Amazon S3 object, Redshift datashare,
    /// API Gateway API, AWS Lake Formation data permission, or Amazon S3 data access. The
    /// asset can be a structured data file, an image file, or some other data file. Jobs
    /// are asynchronous import or export operations used to create or copy assets.
    /// </para>
    /// </summary>
    public partial class AmazonDataExchangeClient : AmazonServiceClient, IAmazonDataExchange
    {
        private static IServiceMetadata serviceMetadata = new AmazonDataExchangeMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IDataExchangePaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IDataExchangePaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new DataExchangePaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonDataExchangeClient with the credentials loaded from the application's
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
        public AmazonDataExchangeClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDataExchangeConfig()) { }

        /// <summary>
        /// Constructs AmazonDataExchangeClient with the credentials loaded from the application's
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
        public AmazonDataExchangeClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDataExchangeConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonDataExchangeClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonDataExchangeClient Configuration Object</param>
        public AmazonDataExchangeClient(AmazonDataExchangeConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonDataExchangeClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonDataExchangeClient(AWSCredentials credentials)
            : this(credentials, new AmazonDataExchangeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDataExchangeClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDataExchangeClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonDataExchangeConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDataExchangeClient with AWS Credentials and an
        /// AmazonDataExchangeClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonDataExchangeClient Configuration Object</param>
        public AmazonDataExchangeClient(AWSCredentials credentials, AmazonDataExchangeConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDataExchangeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonDataExchangeClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDataExchangeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDataExchangeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDataExchangeClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDataExchangeConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonDataExchangeClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDataExchangeClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonDataExchangeClient Configuration Object</param>
        public AmazonDataExchangeClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonDataExchangeConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDataExchangeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonDataExchangeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDataExchangeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDataExchangeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDataExchangeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDataExchangeConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDataExchangeClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDataExchangeClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonDataExchangeClient Configuration Object</param>
        public AmazonDataExchangeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonDataExchangeConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonDataExchangeEndpointResolver());
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


        #region  AcceptDataGrant

        /// <summary>
        /// This operation accepts a data grant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptDataGrant service method.</param>
        /// 
        /// <returns>The response from the AcceptDataGrant service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/AcceptDataGrant">REST API Reference for AcceptDataGrant Operation</seealso>
        public virtual AcceptDataGrantResponse AcceptDataGrant(AcceptDataGrantRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptDataGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptDataGrantResponseUnmarshaller.Instance;

            return Invoke<AcceptDataGrantResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AcceptDataGrant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptDataGrant operation on AmazonDataExchangeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAcceptDataGrant
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/AcceptDataGrant">REST API Reference for AcceptDataGrant Operation</seealso>
        public virtual IAsyncResult BeginAcceptDataGrant(AcceptDataGrantRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptDataGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptDataGrantResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AcceptDataGrant operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAcceptDataGrant.</param>
        /// 
        /// <returns>Returns a  AcceptDataGrantResult from DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/AcceptDataGrant">REST API Reference for AcceptDataGrant Operation</seealso>
        public virtual AcceptDataGrantResponse EndAcceptDataGrant(IAsyncResult asyncResult)
        {
            return EndInvoke<AcceptDataGrantResponse>(asyncResult);
        }

        #endregion
        
        #region  CancelJob

        /// <summary>
        /// This operation cancels a job. Jobs can be cancelled only when they are in the WAITING
        /// state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelJob service method.</param>
        /// 
        /// <returns>The response from the CancelJob service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/CancelJob">REST API Reference for CancelJob Operation</seealso>
        public virtual CancelJobResponse CancelJob(CancelJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelJobResponseUnmarshaller.Instance;

            return Invoke<CancelJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelJob operation on AmazonDataExchangeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/CancelJob">REST API Reference for CancelJob Operation</seealso>
        public virtual IAsyncResult BeginCancelJob(CancelJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelJob.</param>
        /// 
        /// <returns>Returns a  CancelJobResult from DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/CancelJob">REST API Reference for CancelJob Operation</seealso>
        public virtual CancelJobResponse EndCancelJob(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelJobResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDataGrant

        /// <summary>
        /// This operation creates a data grant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataGrant service method.</param>
        /// 
        /// <returns>The response from the CreateDataGrant service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ServiceLimitExceededException">
        /// The request has exceeded the quotas imposed by the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/CreateDataGrant">REST API Reference for CreateDataGrant Operation</seealso>
        public virtual CreateDataGrantResponse CreateDataGrant(CreateDataGrantRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataGrantResponseUnmarshaller.Instance;

            return Invoke<CreateDataGrantResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataGrant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataGrant operation on AmazonDataExchangeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDataGrant
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/CreateDataGrant">REST API Reference for CreateDataGrant Operation</seealso>
        public virtual IAsyncResult BeginCreateDataGrant(CreateDataGrantRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataGrantResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataGrant operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataGrant.</param>
        /// 
        /// <returns>Returns a  CreateDataGrantResult from DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/CreateDataGrant">REST API Reference for CreateDataGrant Operation</seealso>
        public virtual CreateDataGrantResponse EndCreateDataGrant(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDataGrantResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDataSet

        /// <summary>
        /// This operation creates a data set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSet service method.</param>
        /// 
        /// <returns>The response from the CreateDataSet service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ServiceLimitExceededException">
        /// The request has exceeded the quotas imposed by the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/CreateDataSet">REST API Reference for CreateDataSet Operation</seealso>
        public virtual CreateDataSetResponse CreateDataSet(CreateDataSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataSetResponseUnmarshaller.Instance;

            return Invoke<CreateDataSetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSet operation on AmazonDataExchangeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDataSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/CreateDataSet">REST API Reference for CreateDataSet Operation</seealso>
        public virtual IAsyncResult BeginCreateDataSet(CreateDataSetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataSetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataSet.</param>
        /// 
        /// <returns>Returns a  CreateDataSetResult from DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/CreateDataSet">REST API Reference for CreateDataSet Operation</seealso>
        public virtual CreateDataSetResponse EndCreateDataSet(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDataSetResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateEventAction

        /// <summary>
        /// This operation creates an event action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEventAction service method.</param>
        /// 
        /// <returns>The response from the CreateEventAction service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ServiceLimitExceededException">
        /// The request has exceeded the quotas imposed by the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/CreateEventAction">REST API Reference for CreateEventAction Operation</seealso>
        public virtual CreateEventActionResponse CreateEventAction(CreateEventActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEventActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEventActionResponseUnmarshaller.Instance;

            return Invoke<CreateEventActionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEventAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEventAction operation on AmazonDataExchangeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEventAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/CreateEventAction">REST API Reference for CreateEventAction Operation</seealso>
        public virtual IAsyncResult BeginCreateEventAction(CreateEventActionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEventActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEventActionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEventAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEventAction.</param>
        /// 
        /// <returns>Returns a  CreateEventActionResult from DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/CreateEventAction">REST API Reference for CreateEventAction Operation</seealso>
        public virtual CreateEventActionResponse EndCreateEventAction(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateEventActionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateJob

        /// <summary>
        /// This operation creates a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateJob service method.</param>
        /// 
        /// <returns>The response from the CreateJob service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/CreateJob">REST API Reference for CreateJob Operation</seealso>
        public virtual CreateJobResponse CreateJob(CreateJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateJobResponseUnmarshaller.Instance;

            return Invoke<CreateJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateJob operation on AmazonDataExchangeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/CreateJob">REST API Reference for CreateJob Operation</seealso>
        public virtual IAsyncResult BeginCreateJob(CreateJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateJob.</param>
        /// 
        /// <returns>Returns a  CreateJobResult from DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/CreateJob">REST API Reference for CreateJob Operation</seealso>
        public virtual CreateJobResponse EndCreateJob(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateJobResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateRevision

        /// <summary>
        /// This operation creates a revision for a data set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRevision service method.</param>
        /// 
        /// <returns>The response from the CreateRevision service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/CreateRevision">REST API Reference for CreateRevision Operation</seealso>
        public virtual CreateRevisionResponse CreateRevision(CreateRevisionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRevisionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRevisionResponseUnmarshaller.Instance;

            return Invoke<CreateRevisionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRevision operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRevision operation on AmazonDataExchangeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRevision
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/CreateRevision">REST API Reference for CreateRevision Operation</seealso>
        public virtual IAsyncResult BeginCreateRevision(CreateRevisionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRevisionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRevisionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRevision operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRevision.</param>
        /// 
        /// <returns>Returns a  CreateRevisionResult from DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/CreateRevision">REST API Reference for CreateRevision Operation</seealso>
        public virtual CreateRevisionResponse EndCreateRevision(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateRevisionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAsset

        /// <summary>
        /// This operation deletes an asset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAsset service method.</param>
        /// 
        /// <returns>The response from the DeleteAsset service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/DeleteAsset">REST API Reference for DeleteAsset Operation</seealso>
        public virtual DeleteAssetResponse DeleteAsset(DeleteAssetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssetResponseUnmarshaller.Instance;

            return Invoke<DeleteAssetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAsset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAsset operation on AmazonDataExchangeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAsset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/DeleteAsset">REST API Reference for DeleteAsset Operation</seealso>
        public virtual IAsyncResult BeginDeleteAsset(DeleteAssetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAsset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAsset.</param>
        /// 
        /// <returns>Returns a  DeleteAssetResult from DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/DeleteAsset">REST API Reference for DeleteAsset Operation</seealso>
        public virtual DeleteAssetResponse EndDeleteAsset(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAssetResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDataGrant

        /// <summary>
        /// This operation deletes a data grant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataGrant service method.</param>
        /// 
        /// <returns>The response from the DeleteDataGrant service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/DeleteDataGrant">REST API Reference for DeleteDataGrant Operation</seealso>
        public virtual DeleteDataGrantResponse DeleteDataGrant(DeleteDataGrantRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDataGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataGrantResponseUnmarshaller.Instance;

            return Invoke<DeleteDataGrantResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDataGrant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataGrant operation on AmazonDataExchangeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDataGrant
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/DeleteDataGrant">REST API Reference for DeleteDataGrant Operation</seealso>
        public virtual IAsyncResult BeginDeleteDataGrant(DeleteDataGrantRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDataGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataGrantResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDataGrant operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDataGrant.</param>
        /// 
        /// <returns>Returns a  DeleteDataGrantResult from DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/DeleteDataGrant">REST API Reference for DeleteDataGrant Operation</seealso>
        public virtual DeleteDataGrantResponse EndDeleteDataGrant(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDataGrantResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDataSet

        /// <summary>
        /// This operation deletes a data set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataSet service method.</param>
        /// 
        /// <returns>The response from the DeleteDataSet service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/DeleteDataSet">REST API Reference for DeleteDataSet Operation</seealso>
        public virtual DeleteDataSetResponse DeleteDataSet(DeleteDataSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDataSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataSetResponseUnmarshaller.Instance;

            return Invoke<DeleteDataSetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDataSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataSet operation on AmazonDataExchangeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDataSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/DeleteDataSet">REST API Reference for DeleteDataSet Operation</seealso>
        public virtual IAsyncResult BeginDeleteDataSet(DeleteDataSetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDataSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataSetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDataSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDataSet.</param>
        /// 
        /// <returns>Returns a  DeleteDataSetResult from DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/DeleteDataSet">REST API Reference for DeleteDataSet Operation</seealso>
        public virtual DeleteDataSetResponse EndDeleteDataSet(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDataSetResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteEventAction

        /// <summary>
        /// This operation deletes the event action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventAction service method.</param>
        /// 
        /// <returns>The response from the DeleteEventAction service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/DeleteEventAction">REST API Reference for DeleteEventAction Operation</seealso>
        public virtual DeleteEventActionResponse DeleteEventAction(DeleteEventActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEventActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventActionResponseUnmarshaller.Instance;

            return Invoke<DeleteEventActionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEventAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventAction operation on AmazonDataExchangeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEventAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/DeleteEventAction">REST API Reference for DeleteEventAction Operation</seealso>
        public virtual IAsyncResult BeginDeleteEventAction(DeleteEventActionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEventActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventActionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEventAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEventAction.</param>
        /// 
        /// <returns>Returns a  DeleteEventActionResult from DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/DeleteEventAction">REST API Reference for DeleteEventAction Operation</seealso>
        public virtual DeleteEventActionResponse EndDeleteEventAction(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteEventActionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteRevision

        /// <summary>
        /// This operation deletes a revision.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRevision service method.</param>
        /// 
        /// <returns>The response from the DeleteRevision service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/DeleteRevision">REST API Reference for DeleteRevision Operation</seealso>
        public virtual DeleteRevisionResponse DeleteRevision(DeleteRevisionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRevisionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRevisionResponseUnmarshaller.Instance;

            return Invoke<DeleteRevisionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRevision operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRevision operation on AmazonDataExchangeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRevision
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/DeleteRevision">REST API Reference for DeleteRevision Operation</seealso>
        public virtual IAsyncResult BeginDeleteRevision(DeleteRevisionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRevisionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRevisionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRevision operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRevision.</param>
        /// 
        /// <returns>Returns a  DeleteRevisionResult from DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/DeleteRevision">REST API Reference for DeleteRevision Operation</seealso>
        public virtual DeleteRevisionResponse EndDeleteRevision(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRevisionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAsset

        /// <summary>
        /// This operation returns information about an asset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAsset service method.</param>
        /// 
        /// <returns>The response from the GetAsset service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/GetAsset">REST API Reference for GetAsset Operation</seealso>
        public virtual GetAssetResponse GetAsset(GetAssetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssetResponseUnmarshaller.Instance;

            return Invoke<GetAssetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAsset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAsset operation on AmazonDataExchangeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAsset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/GetAsset">REST API Reference for GetAsset Operation</seealso>
        public virtual IAsyncResult BeginGetAsset(GetAssetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAsset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAsset.</param>
        /// 
        /// <returns>Returns a  GetAssetResult from DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/GetAsset">REST API Reference for GetAsset Operation</seealso>
        public virtual GetAssetResponse EndGetAsset(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAssetResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDataGrant

        /// <summary>
        /// This operation returns information about a data grant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataGrant service method.</param>
        /// 
        /// <returns>The response from the GetDataGrant service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/GetDataGrant">REST API Reference for GetDataGrant Operation</seealso>
        public virtual GetDataGrantResponse GetDataGrant(GetDataGrantRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataGrantResponseUnmarshaller.Instance;

            return Invoke<GetDataGrantResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDataGrant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataGrant operation on AmazonDataExchangeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDataGrant
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/GetDataGrant">REST API Reference for GetDataGrant Operation</seealso>
        public virtual IAsyncResult BeginGetDataGrant(GetDataGrantRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataGrantResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDataGrant operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDataGrant.</param>
        /// 
        /// <returns>Returns a  GetDataGrantResult from DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/GetDataGrant">REST API Reference for GetDataGrant Operation</seealso>
        public virtual GetDataGrantResponse EndGetDataGrant(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDataGrantResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDataSet

        /// <summary>
        /// This operation returns information about a data set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataSet service method.</param>
        /// 
        /// <returns>The response from the GetDataSet service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/GetDataSet">REST API Reference for GetDataSet Operation</seealso>
        public virtual GetDataSetResponse GetDataSet(GetDataSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataSetResponseUnmarshaller.Instance;

            return Invoke<GetDataSetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDataSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataSet operation on AmazonDataExchangeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDataSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/GetDataSet">REST API Reference for GetDataSet Operation</seealso>
        public virtual IAsyncResult BeginGetDataSet(GetDataSetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataSetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDataSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDataSet.</param>
        /// 
        /// <returns>Returns a  GetDataSetResult from DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/GetDataSet">REST API Reference for GetDataSet Operation</seealso>
        public virtual GetDataSetResponse EndGetDataSet(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDataSetResponse>(asyncResult);
        }

        #endregion
        
        #region  GetEventAction

        /// <summary>
        /// This operation retrieves information about an event action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEventAction service method.</param>
        /// 
        /// <returns>The response from the GetEventAction service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/GetEventAction">REST API Reference for GetEventAction Operation</seealso>
        public virtual GetEventActionResponse GetEventAction(GetEventActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEventActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEventActionResponseUnmarshaller.Instance;

            return Invoke<GetEventActionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetEventAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEventAction operation on AmazonDataExchangeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEventAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/GetEventAction">REST API Reference for GetEventAction Operation</seealso>
        public virtual IAsyncResult BeginGetEventAction(GetEventActionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEventActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEventActionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetEventAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEventAction.</param>
        /// 
        /// <returns>Returns a  GetEventActionResult from DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/GetEventAction">REST API Reference for GetEventAction Operation</seealso>
        public virtual GetEventActionResponse EndGetEventAction(IAsyncResult asyncResult)
        {
            return EndInvoke<GetEventActionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetJob

        /// <summary>
        /// This operation returns information about a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJob service method.</param>
        /// 
        /// <returns>The response from the GetJob service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/GetJob">REST API Reference for GetJob Operation</seealso>
        public virtual GetJobResponse GetJob(GetJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobResponseUnmarshaller.Instance;

            return Invoke<GetJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetJob operation on AmazonDataExchangeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/GetJob">REST API Reference for GetJob Operation</seealso>
        public virtual IAsyncResult BeginGetJob(GetJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetJob.</param>
        /// 
        /// <returns>Returns a  GetJobResult from DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/GetJob">REST API Reference for GetJob Operation</seealso>
        public virtual GetJobResponse EndGetJob(IAsyncResult asyncResult)
        {
            return EndInvoke<GetJobResponse>(asyncResult);
        }

        #endregion
        
        #region  GetReceivedDataGrant

        /// <summary>
        /// This operation returns information about a received data grant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReceivedDataGrant service method.</param>
        /// 
        /// <returns>The response from the GetReceivedDataGrant service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/GetReceivedDataGrant">REST API Reference for GetReceivedDataGrant Operation</seealso>
        public virtual GetReceivedDataGrantResponse GetReceivedDataGrant(GetReceivedDataGrantRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetReceivedDataGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReceivedDataGrantResponseUnmarshaller.Instance;

            return Invoke<GetReceivedDataGrantResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetReceivedDataGrant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetReceivedDataGrant operation on AmazonDataExchangeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetReceivedDataGrant
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/GetReceivedDataGrant">REST API Reference for GetReceivedDataGrant Operation</seealso>
        public virtual IAsyncResult BeginGetReceivedDataGrant(GetReceivedDataGrantRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetReceivedDataGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReceivedDataGrantResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetReceivedDataGrant operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetReceivedDataGrant.</param>
        /// 
        /// <returns>Returns a  GetReceivedDataGrantResult from DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/GetReceivedDataGrant">REST API Reference for GetReceivedDataGrant Operation</seealso>
        public virtual GetReceivedDataGrantResponse EndGetReceivedDataGrant(IAsyncResult asyncResult)
        {
            return EndInvoke<GetReceivedDataGrantResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRevision

        /// <summary>
        /// This operation returns information about a revision.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRevision service method.</param>
        /// 
        /// <returns>The response from the GetRevision service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/GetRevision">REST API Reference for GetRevision Operation</seealso>
        public virtual GetRevisionResponse GetRevision(GetRevisionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRevisionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRevisionResponseUnmarshaller.Instance;

            return Invoke<GetRevisionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRevision operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRevision operation on AmazonDataExchangeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRevision
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/GetRevision">REST API Reference for GetRevision Operation</seealso>
        public virtual IAsyncResult BeginGetRevision(GetRevisionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRevisionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRevisionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRevision operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRevision.</param>
        /// 
        /// <returns>Returns a  GetRevisionResult from DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/GetRevision">REST API Reference for GetRevision Operation</seealso>
        public virtual GetRevisionResponse EndGetRevision(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRevisionResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDataGrants

        /// <summary>
        /// This operation returns information about all data grants.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataGrants service method.</param>
        /// 
        /// <returns>The response from the ListDataGrants service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/ListDataGrants">REST API Reference for ListDataGrants Operation</seealso>
        public virtual ListDataGrantsResponse ListDataGrants(ListDataGrantsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataGrantsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataGrantsResponseUnmarshaller.Instance;

            return Invoke<ListDataGrantsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDataGrants operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDataGrants operation on AmazonDataExchangeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDataGrants
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/ListDataGrants">REST API Reference for ListDataGrants Operation</seealso>
        public virtual IAsyncResult BeginListDataGrants(ListDataGrantsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataGrantsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataGrantsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDataGrants operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDataGrants.</param>
        /// 
        /// <returns>Returns a  ListDataGrantsResult from DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/ListDataGrants">REST API Reference for ListDataGrants Operation</seealso>
        public virtual ListDataGrantsResponse EndListDataGrants(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDataGrantsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDataSetRevisions

        /// <summary>
        /// This operation lists a data set's revisions sorted by CreatedAt in descending order.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataSetRevisions service method.</param>
        /// 
        /// <returns>The response from the ListDataSetRevisions service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/ListDataSetRevisions">REST API Reference for ListDataSetRevisions Operation</seealso>
        public virtual ListDataSetRevisionsResponse ListDataSetRevisions(ListDataSetRevisionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataSetRevisionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataSetRevisionsResponseUnmarshaller.Instance;

            return Invoke<ListDataSetRevisionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDataSetRevisions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDataSetRevisions operation on AmazonDataExchangeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDataSetRevisions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/ListDataSetRevisions">REST API Reference for ListDataSetRevisions Operation</seealso>
        public virtual IAsyncResult BeginListDataSetRevisions(ListDataSetRevisionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataSetRevisionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataSetRevisionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDataSetRevisions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDataSetRevisions.</param>
        /// 
        /// <returns>Returns a  ListDataSetRevisionsResult from DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/ListDataSetRevisions">REST API Reference for ListDataSetRevisions Operation</seealso>
        public virtual ListDataSetRevisionsResponse EndListDataSetRevisions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDataSetRevisionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDataSets

        /// <summary>
        /// This operation lists your data sets. When listing by origin OWNED, results are sorted
        /// by CreatedAt in descending order. When listing by origin ENTITLED, there is no order.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataSets service method.</param>
        /// 
        /// <returns>The response from the ListDataSets service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/ListDataSets">REST API Reference for ListDataSets Operation</seealso>
        public virtual ListDataSetsResponse ListDataSets(ListDataSetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataSetsResponseUnmarshaller.Instance;

            return Invoke<ListDataSetsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDataSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDataSets operation on AmazonDataExchangeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDataSets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/ListDataSets">REST API Reference for ListDataSets Operation</seealso>
        public virtual IAsyncResult BeginListDataSets(ListDataSetsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataSetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDataSets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDataSets.</param>
        /// 
        /// <returns>Returns a  ListDataSetsResult from DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/ListDataSets">REST API Reference for ListDataSets Operation</seealso>
        public virtual ListDataSetsResponse EndListDataSets(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDataSetsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListEventActions

        /// <summary>
        /// This operation lists your event actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventActions service method.</param>
        /// 
        /// <returns>The response from the ListEventActions service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/ListEventActions">REST API Reference for ListEventActions Operation</seealso>
        public virtual ListEventActionsResponse ListEventActions(ListEventActionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEventActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventActionsResponseUnmarshaller.Instance;

            return Invoke<ListEventActionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListEventActions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEventActions operation on AmazonDataExchangeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEventActions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/ListEventActions">REST API Reference for ListEventActions Operation</seealso>
        public virtual IAsyncResult BeginListEventActions(ListEventActionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEventActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventActionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListEventActions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEventActions.</param>
        /// 
        /// <returns>Returns a  ListEventActionsResult from DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/ListEventActions">REST API Reference for ListEventActions Operation</seealso>
        public virtual ListEventActionsResponse EndListEventActions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListEventActionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListJobs

        /// <summary>
        /// This operation lists your jobs sorted by CreatedAt in descending order.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobs service method.</param>
        /// 
        /// <returns>The response from the ListJobs service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/ListJobs">REST API Reference for ListJobs Operation</seealso>
        public virtual ListJobsResponse ListJobs(ListJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobsResponseUnmarshaller.Instance;

            return Invoke<ListJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListJobs operation on AmazonDataExchangeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/ListJobs">REST API Reference for ListJobs Operation</seealso>
        public virtual IAsyncResult BeginListJobs(ListJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListJobs.</param>
        /// 
        /// <returns>Returns a  ListJobsResult from DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/ListJobs">REST API Reference for ListJobs Operation</seealso>
        public virtual ListJobsResponse EndListJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListReceivedDataGrants

        /// <summary>
        /// This operation returns information about all received data grants.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReceivedDataGrants service method.</param>
        /// 
        /// <returns>The response from the ListReceivedDataGrants service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/ListReceivedDataGrants">REST API Reference for ListReceivedDataGrants Operation</seealso>
        public virtual ListReceivedDataGrantsResponse ListReceivedDataGrants(ListReceivedDataGrantsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListReceivedDataGrantsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReceivedDataGrantsResponseUnmarshaller.Instance;

            return Invoke<ListReceivedDataGrantsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListReceivedDataGrants operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListReceivedDataGrants operation on AmazonDataExchangeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListReceivedDataGrants
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/ListReceivedDataGrants">REST API Reference for ListReceivedDataGrants Operation</seealso>
        public virtual IAsyncResult BeginListReceivedDataGrants(ListReceivedDataGrantsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListReceivedDataGrantsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReceivedDataGrantsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListReceivedDataGrants operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListReceivedDataGrants.</param>
        /// 
        /// <returns>Returns a  ListReceivedDataGrantsResult from DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/ListReceivedDataGrants">REST API Reference for ListReceivedDataGrants Operation</seealso>
        public virtual ListReceivedDataGrantsResponse EndListReceivedDataGrants(IAsyncResult asyncResult)
        {
            return EndInvoke<ListReceivedDataGrantsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRevisionAssets

        /// <summary>
        /// This operation lists a revision's assets sorted alphabetically in descending order.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRevisionAssets service method.</param>
        /// 
        /// <returns>The response from the ListRevisionAssets service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/ListRevisionAssets">REST API Reference for ListRevisionAssets Operation</seealso>
        public virtual ListRevisionAssetsResponse ListRevisionAssets(ListRevisionAssetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRevisionAssetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRevisionAssetsResponseUnmarshaller.Instance;

            return Invoke<ListRevisionAssetsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRevisionAssets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRevisionAssets operation on AmazonDataExchangeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRevisionAssets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/ListRevisionAssets">REST API Reference for ListRevisionAssets Operation</seealso>
        public virtual IAsyncResult BeginListRevisionAssets(ListRevisionAssetsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRevisionAssetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRevisionAssetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRevisionAssets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRevisionAssets.</param>
        /// 
        /// <returns>Returns a  ListRevisionAssetsResult from DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/ListRevisionAssets">REST API Reference for ListRevisionAssets Operation</seealso>
        public virtual ListRevisionAssetsResponse EndListRevisionAssets(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRevisionAssetsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// This operation lists the tags on the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonDataExchangeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  RevokeRevision

        /// <summary>
        /// This operation revokes subscribers' access to a revision.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeRevision service method.</param>
        /// 
        /// <returns>The response from the RevokeRevision service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/RevokeRevision">REST API Reference for RevokeRevision Operation</seealso>
        public virtual RevokeRevisionResponse RevokeRevision(RevokeRevisionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RevokeRevisionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeRevisionResponseUnmarshaller.Instance;

            return Invoke<RevokeRevisionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RevokeRevision operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeRevision operation on AmazonDataExchangeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRevokeRevision
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/RevokeRevision">REST API Reference for RevokeRevision Operation</seealso>
        public virtual IAsyncResult BeginRevokeRevision(RevokeRevisionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RevokeRevisionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeRevisionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RevokeRevision operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRevokeRevision.</param>
        /// 
        /// <returns>Returns a  RevokeRevisionResult from DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/RevokeRevision">REST API Reference for RevokeRevision Operation</seealso>
        public virtual RevokeRevisionResponse EndRevokeRevision(IAsyncResult asyncResult)
        {
            return EndInvoke<RevokeRevisionResponse>(asyncResult);
        }

        #endregion
        
        #region  SendApiAsset

        /// <summary>
        /// This operation invokes an API Gateway API asset. The request is proxied to the provider’s
        /// API Gateway API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendApiAsset service method.</param>
        /// 
        /// <returns>The response from the SendApiAsset service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/SendApiAsset">REST API Reference for SendApiAsset Operation</seealso>
        public virtual SendApiAssetResponse SendApiAsset(SendApiAssetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendApiAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendApiAssetResponseUnmarshaller.Instance;

            return Invoke<SendApiAssetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SendApiAsset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendApiAsset operation on AmazonDataExchangeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendApiAsset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/SendApiAsset">REST API Reference for SendApiAsset Operation</seealso>
        public virtual IAsyncResult BeginSendApiAsset(SendApiAssetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendApiAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendApiAssetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SendApiAsset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendApiAsset.</param>
        /// 
        /// <returns>Returns a  SendApiAssetResult from DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/SendApiAsset">REST API Reference for SendApiAsset Operation</seealso>
        public virtual SendApiAssetResponse EndSendApiAsset(IAsyncResult asyncResult)
        {
            return EndInvoke<SendApiAssetResponse>(asyncResult);
        }

        #endregion
        
        #region  SendDataSetNotification

        /// <summary>
        /// The type of event associated with the data set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendDataSetNotification service method.</param>
        /// 
        /// <returns>The response from the SendDataSetNotification service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/SendDataSetNotification">REST API Reference for SendDataSetNotification Operation</seealso>
        public virtual SendDataSetNotificationResponse SendDataSetNotification(SendDataSetNotificationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendDataSetNotificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendDataSetNotificationResponseUnmarshaller.Instance;

            return Invoke<SendDataSetNotificationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SendDataSetNotification operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendDataSetNotification operation on AmazonDataExchangeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendDataSetNotification
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/SendDataSetNotification">REST API Reference for SendDataSetNotification Operation</seealso>
        public virtual IAsyncResult BeginSendDataSetNotification(SendDataSetNotificationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendDataSetNotificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendDataSetNotificationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SendDataSetNotification operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendDataSetNotification.</param>
        /// 
        /// <returns>Returns a  SendDataSetNotificationResult from DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/SendDataSetNotification">REST API Reference for SendDataSetNotification Operation</seealso>
        public virtual SendDataSetNotificationResponse EndSendDataSetNotification(IAsyncResult asyncResult)
        {
            return EndInvoke<SendDataSetNotificationResponse>(asyncResult);
        }

        #endregion
        
        #region  StartJob

        /// <summary>
        /// This operation starts a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartJob service method.</param>
        /// 
        /// <returns>The response from the StartJob service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/StartJob">REST API Reference for StartJob Operation</seealso>
        public virtual StartJobResponse StartJob(StartJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartJobResponseUnmarshaller.Instance;

            return Invoke<StartJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartJob operation on AmazonDataExchangeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/StartJob">REST API Reference for StartJob Operation</seealso>
        public virtual IAsyncResult BeginStartJob(StartJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartJob.</param>
        /// 
        /// <returns>Returns a  StartJobResult from DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/StartJob">REST API Reference for StartJob Operation</seealso>
        public virtual StartJobResponse EndStartJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StartJobResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// This operation tags a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonDataExchangeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// This operation removes one or more tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonDataExchangeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAsset

        /// <summary>
        /// This operation updates an asset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAsset service method.</param>
        /// 
        /// <returns>The response from the UpdateAsset service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/UpdateAsset">REST API Reference for UpdateAsset Operation</seealso>
        public virtual UpdateAssetResponse UpdateAsset(UpdateAssetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssetResponseUnmarshaller.Instance;

            return Invoke<UpdateAssetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAsset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAsset operation on AmazonDataExchangeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAsset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/UpdateAsset">REST API Reference for UpdateAsset Operation</seealso>
        public virtual IAsyncResult BeginUpdateAsset(UpdateAssetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAsset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAsset.</param>
        /// 
        /// <returns>Returns a  UpdateAssetResult from DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/UpdateAsset">REST API Reference for UpdateAsset Operation</seealso>
        public virtual UpdateAssetResponse EndUpdateAsset(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAssetResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDataSet

        /// <summary>
        /// This operation updates a data set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSet service method.</param>
        /// 
        /// <returns>The response from the UpdateDataSet service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/UpdateDataSet">REST API Reference for UpdateDataSet Operation</seealso>
        public virtual UpdateDataSetResponse UpdateDataSet(UpdateDataSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDataSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataSetResponseUnmarshaller.Instance;

            return Invoke<UpdateDataSetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDataSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSet operation on AmazonDataExchangeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDataSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/UpdateDataSet">REST API Reference for UpdateDataSet Operation</seealso>
        public virtual IAsyncResult BeginUpdateDataSet(UpdateDataSetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDataSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataSetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDataSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDataSet.</param>
        /// 
        /// <returns>Returns a  UpdateDataSetResult from DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/UpdateDataSet">REST API Reference for UpdateDataSet Operation</seealso>
        public virtual UpdateDataSetResponse EndUpdateDataSet(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDataSetResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateEventAction

        /// <summary>
        /// This operation updates the event action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventAction service method.</param>
        /// 
        /// <returns>The response from the UpdateEventAction service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/UpdateEventAction">REST API Reference for UpdateEventAction Operation</seealso>
        public virtual UpdateEventActionResponse UpdateEventAction(UpdateEventActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEventActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEventActionResponseUnmarshaller.Instance;

            return Invoke<UpdateEventActionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEventAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventAction operation on AmazonDataExchangeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEventAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/UpdateEventAction">REST API Reference for UpdateEventAction Operation</seealso>
        public virtual IAsyncResult BeginUpdateEventAction(UpdateEventActionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEventActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEventActionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEventAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEventAction.</param>
        /// 
        /// <returns>Returns a  UpdateEventActionResult from DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/UpdateEventAction">REST API Reference for UpdateEventAction Operation</seealso>
        public virtual UpdateEventActionResponse EndUpdateEventAction(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateEventActionResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateRevision

        /// <summary>
        /// This operation updates a revision.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRevision service method.</param>
        /// 
        /// <returns>The response from the UpdateRevision service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/UpdateRevision">REST API Reference for UpdateRevision Operation</seealso>
        public virtual UpdateRevisionResponse UpdateRevision(UpdateRevisionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRevisionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRevisionResponseUnmarshaller.Instance;

            return Invoke<UpdateRevisionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRevision operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRevision operation on AmazonDataExchangeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRevision
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/UpdateRevision">REST API Reference for UpdateRevision Operation</seealso>
        public virtual IAsyncResult BeginUpdateRevision(UpdateRevisionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRevisionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRevisionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRevision operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRevision.</param>
        /// 
        /// <returns>Returns a  UpdateRevisionResult from DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/UpdateRevision">REST API Reference for UpdateRevision Operation</seealso>
        public virtual UpdateRevisionResponse EndUpdateRevision(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateRevisionResponse>(asyncResult);
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
            var resolver = new AmazonDataExchangeEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}