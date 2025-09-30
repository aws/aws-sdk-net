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
 * Do not modify this file. This file is generated from the medical-imaging-2023-07-19.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.MedicalImaging.Model;
using Amazon.MedicalImaging.Model.Internal.MarshallTransformations;
using Amazon.MedicalImaging.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.MedicalImaging
{
    /// <summary>
    /// <para>Implementation for accessing MedicalImaging</para>
    ///
    /// This is the <i>AWS HealthImaging API Reference</i>. For an introduction to the service,
    /// see <a href="https://docs.aws.amazon.com/healthimaging/latest/devguide/what-is.html">What
    /// is AWS HealthImaging?</a> in the <i>AWS HealthImaging Developer Guide</i>.
    /// </summary>
    public partial class AmazonMedicalImagingClient : AmazonServiceClient, IAmazonMedicalImaging
    {
        private static IServiceMetadata serviceMetadata = new AmazonMedicalImagingMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IMedicalImagingPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IMedicalImagingPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new MedicalImagingPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonMedicalImagingClient with the credentials loaded from the application's
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
        public AmazonMedicalImagingClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMedicalImagingConfig()) { }

        /// <summary>
        /// Constructs AmazonMedicalImagingClient with the credentials loaded from the application's
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
        public AmazonMedicalImagingClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMedicalImagingConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonMedicalImagingClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonMedicalImagingClient Configuration Object</param>
        public AmazonMedicalImagingClient(AmazonMedicalImagingConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonMedicalImagingClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonMedicalImagingClient(AWSCredentials credentials)
            : this(credentials, new AmazonMedicalImagingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMedicalImagingClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMedicalImagingClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonMedicalImagingConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMedicalImagingClient with AWS Credentials and an
        /// AmazonMedicalImagingClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonMedicalImagingClient Configuration Object</param>
        public AmazonMedicalImagingClient(AWSCredentials credentials, AmazonMedicalImagingConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMedicalImagingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonMedicalImagingClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMedicalImagingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMedicalImagingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMedicalImagingClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMedicalImagingConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonMedicalImagingClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMedicalImagingClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonMedicalImagingClient Configuration Object</param>
        public AmazonMedicalImagingClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonMedicalImagingConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMedicalImagingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonMedicalImagingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMedicalImagingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMedicalImagingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMedicalImagingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMedicalImagingConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMedicalImagingClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMedicalImagingClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonMedicalImagingClient Configuration Object</param>
        public AmazonMedicalImagingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonMedicalImagingConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonMedicalImagingEndpointResolver());
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


        #region  CopyImageSet

        /// <summary>
        /// Copy an image set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyImageSet service method.</param>
        /// 
        /// <returns>The response from the CopyImageSet service method, as returned by MedicalImaging.</returns>
        /// <exception cref="Amazon.MedicalImaging.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.InternalServerException">
        /// An unexpected error occurred during processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ServiceQuotaExceededException">
        /// The request caused a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ThrottlingException">
        /// The request was denied due to throttling.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/CopyImageSet">REST API Reference for CopyImageSet Operation</seealso>
        public virtual CopyImageSetResponse CopyImageSet(CopyImageSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CopyImageSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyImageSetResponseUnmarshaller.Instance;

            return Invoke<CopyImageSetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CopyImageSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyImageSet operation on AmazonMedicalImagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCopyImageSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/CopyImageSet">REST API Reference for CopyImageSet Operation</seealso>
        public virtual IAsyncResult BeginCopyImageSet(CopyImageSetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CopyImageSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyImageSetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CopyImageSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCopyImageSet.</param>
        /// 
        /// <returns>Returns a  CopyImageSetResult from MedicalImaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/CopyImageSet">REST API Reference for CopyImageSet Operation</seealso>
        public virtual CopyImageSetResponse EndCopyImageSet(IAsyncResult asyncResult)
        {
            return EndInvoke<CopyImageSetResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDatastore

        /// <summary>
        /// Create a data store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDatastore service method.</param>
        /// 
        /// <returns>The response from the CreateDatastore service method, as returned by MedicalImaging.</returns>
        /// <exception cref="Amazon.MedicalImaging.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.InternalServerException">
        /// An unexpected error occurred during processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ServiceQuotaExceededException">
        /// The request caused a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ThrottlingException">
        /// The request was denied due to throttling.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/CreateDatastore">REST API Reference for CreateDatastore Operation</seealso>
        public virtual CreateDatastoreResponse CreateDatastore(CreateDatastoreRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDatastoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatastoreResponseUnmarshaller.Instance;

            return Invoke<CreateDatastoreResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDatastore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDatastore operation on AmazonMedicalImagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDatastore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/CreateDatastore">REST API Reference for CreateDatastore Operation</seealso>
        public virtual IAsyncResult BeginCreateDatastore(CreateDatastoreRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDatastoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatastoreResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDatastore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDatastore.</param>
        /// 
        /// <returns>Returns a  CreateDatastoreResult from MedicalImaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/CreateDatastore">REST API Reference for CreateDatastore Operation</seealso>
        public virtual CreateDatastoreResponse EndCreateDatastore(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDatastoreResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDatastore

        /// <summary>
        /// Delete a data store.
        /// 
        ///  <note> 
        /// <para>
        /// Before a data store can be deleted, you must first delete all image sets within it.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDatastore service method.</param>
        /// 
        /// <returns>The response from the DeleteDatastore service method, as returned by MedicalImaging.</returns>
        /// <exception cref="Amazon.MedicalImaging.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.InternalServerException">
        /// An unexpected error occurred during processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ThrottlingException">
        /// The request was denied due to throttling.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/DeleteDatastore">REST API Reference for DeleteDatastore Operation</seealso>
        public virtual DeleteDatastoreResponse DeleteDatastore(DeleteDatastoreRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDatastoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatastoreResponseUnmarshaller.Instance;

            return Invoke<DeleteDatastoreResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDatastore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDatastore operation on AmazonMedicalImagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDatastore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/DeleteDatastore">REST API Reference for DeleteDatastore Operation</seealso>
        public virtual IAsyncResult BeginDeleteDatastore(DeleteDatastoreRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDatastoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatastoreResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDatastore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDatastore.</param>
        /// 
        /// <returns>Returns a  DeleteDatastoreResult from MedicalImaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/DeleteDatastore">REST API Reference for DeleteDatastore Operation</seealso>
        public virtual DeleteDatastoreResponse EndDeleteDatastore(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDatastoreResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteImageSet

        /// <summary>
        /// Delete an image set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteImageSet service method.</param>
        /// 
        /// <returns>The response from the DeleteImageSet service method, as returned by MedicalImaging.</returns>
        /// <exception cref="Amazon.MedicalImaging.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.InternalServerException">
        /// An unexpected error occurred during processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ThrottlingException">
        /// The request was denied due to throttling.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/DeleteImageSet">REST API Reference for DeleteImageSet Operation</seealso>
        public virtual DeleteImageSetResponse DeleteImageSet(DeleteImageSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteImageSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteImageSetResponseUnmarshaller.Instance;

            return Invoke<DeleteImageSetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteImageSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteImageSet operation on AmazonMedicalImagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteImageSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/DeleteImageSet">REST API Reference for DeleteImageSet Operation</seealso>
        public virtual IAsyncResult BeginDeleteImageSet(DeleteImageSetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteImageSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteImageSetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteImageSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteImageSet.</param>
        /// 
        /// <returns>Returns a  DeleteImageSetResult from MedicalImaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/DeleteImageSet">REST API Reference for DeleteImageSet Operation</seealso>
        public virtual DeleteImageSetResponse EndDeleteImageSet(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteImageSetResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDatastore

        /// <summary>
        /// Get data store properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDatastore service method.</param>
        /// 
        /// <returns>The response from the GetDatastore service method, as returned by MedicalImaging.</returns>
        /// <exception cref="Amazon.MedicalImaging.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.InternalServerException">
        /// An unexpected error occurred during processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ThrottlingException">
        /// The request was denied due to throttling.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/GetDatastore">REST API Reference for GetDatastore Operation</seealso>
        public virtual GetDatastoreResponse GetDatastore(GetDatastoreRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDatastoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDatastoreResponseUnmarshaller.Instance;

            return Invoke<GetDatastoreResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDatastore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDatastore operation on AmazonMedicalImagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDatastore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/GetDatastore">REST API Reference for GetDatastore Operation</seealso>
        public virtual IAsyncResult BeginGetDatastore(GetDatastoreRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDatastoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDatastoreResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDatastore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDatastore.</param>
        /// 
        /// <returns>Returns a  GetDatastoreResult from MedicalImaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/GetDatastore">REST API Reference for GetDatastore Operation</seealso>
        public virtual GetDatastoreResponse EndGetDatastore(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDatastoreResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDICOMImportJob

        /// <summary>
        /// Get the import job properties to learn more about the job or job progress.
        /// 
        ///  <note> 
        /// <para>
        /// The <c>jobStatus</c> refers to the execution of the import job. Therefore, an import
        /// job can return a <c>jobStatus</c> as <c>COMPLETED</c> even if validation issues are
        /// discovered during the import process. If a <c>jobStatus</c> returns as <c>COMPLETED</c>,
        /// we still recommend you review the output manifests written to S3, as they provide
        /// details on the success or failure of individual P10 object imports.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDICOMImportJob service method.</param>
        /// 
        /// <returns>The response from the GetDICOMImportJob service method, as returned by MedicalImaging.</returns>
        /// <exception cref="Amazon.MedicalImaging.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.InternalServerException">
        /// An unexpected error occurred during processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ThrottlingException">
        /// The request was denied due to throttling.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/GetDICOMImportJob">REST API Reference for GetDICOMImportJob Operation</seealso>
        public virtual GetDICOMImportJobResponse GetDICOMImportJob(GetDICOMImportJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDICOMImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDICOMImportJobResponseUnmarshaller.Instance;

            return Invoke<GetDICOMImportJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDICOMImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDICOMImportJob operation on AmazonMedicalImagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDICOMImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/GetDICOMImportJob">REST API Reference for GetDICOMImportJob Operation</seealso>
        public virtual IAsyncResult BeginGetDICOMImportJob(GetDICOMImportJobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDICOMImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDICOMImportJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDICOMImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDICOMImportJob.</param>
        /// 
        /// <returns>Returns a  GetDICOMImportJobResult from MedicalImaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/GetDICOMImportJob">REST API Reference for GetDICOMImportJob Operation</seealso>
        public virtual GetDICOMImportJobResponse EndGetDICOMImportJob(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDICOMImportJobResponse>(asyncResult);
        }

        #endregion
        
        #region  GetImageFrame

        /// <summary>
        /// Get an image frame (pixel data) for an image set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetImageFrame service method.</param>
        /// 
        /// <returns>The response from the GetImageFrame service method, as returned by MedicalImaging.</returns>
        /// <exception cref="Amazon.MedicalImaging.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.InternalServerException">
        /// An unexpected error occurred during processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ThrottlingException">
        /// The request was denied due to throttling.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/GetImageFrame">REST API Reference for GetImageFrame Operation</seealso>
        public virtual GetImageFrameResponse GetImageFrame(GetImageFrameRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetImageFrameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImageFrameResponseUnmarshaller.Instance;

            return Invoke<GetImageFrameResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetImageFrame operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetImageFrame operation on AmazonMedicalImagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetImageFrame
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/GetImageFrame">REST API Reference for GetImageFrame Operation</seealso>
        public virtual IAsyncResult BeginGetImageFrame(GetImageFrameRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetImageFrameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImageFrameResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetImageFrame operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetImageFrame.</param>
        /// 
        /// <returns>Returns a  GetImageFrameResult from MedicalImaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/GetImageFrame">REST API Reference for GetImageFrame Operation</seealso>
        public virtual GetImageFrameResponse EndGetImageFrame(IAsyncResult asyncResult)
        {
            return EndInvoke<GetImageFrameResponse>(asyncResult);
        }

        #endregion
        
        #region  GetImageSet

        /// <summary>
        /// Get image set properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetImageSet service method.</param>
        /// 
        /// <returns>The response from the GetImageSet service method, as returned by MedicalImaging.</returns>
        /// <exception cref="Amazon.MedicalImaging.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.InternalServerException">
        /// An unexpected error occurred during processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ThrottlingException">
        /// The request was denied due to throttling.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/GetImageSet">REST API Reference for GetImageSet Operation</seealso>
        public virtual GetImageSetResponse GetImageSet(GetImageSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetImageSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImageSetResponseUnmarshaller.Instance;

            return Invoke<GetImageSetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetImageSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetImageSet operation on AmazonMedicalImagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetImageSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/GetImageSet">REST API Reference for GetImageSet Operation</seealso>
        public virtual IAsyncResult BeginGetImageSet(GetImageSetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetImageSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImageSetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetImageSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetImageSet.</param>
        /// 
        /// <returns>Returns a  GetImageSetResult from MedicalImaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/GetImageSet">REST API Reference for GetImageSet Operation</seealso>
        public virtual GetImageSetResponse EndGetImageSet(IAsyncResult asyncResult)
        {
            return EndInvoke<GetImageSetResponse>(asyncResult);
        }

        #endregion
        
        #region  GetImageSetMetadata

        /// <summary>
        /// Get metadata attributes for an image set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetImageSetMetadata service method.</param>
        /// 
        /// <returns>The response from the GetImageSetMetadata service method, as returned by MedicalImaging.</returns>
        /// <exception cref="Amazon.MedicalImaging.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.InternalServerException">
        /// An unexpected error occurred during processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ThrottlingException">
        /// The request was denied due to throttling.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/GetImageSetMetadata">REST API Reference for GetImageSetMetadata Operation</seealso>
        public virtual GetImageSetMetadataResponse GetImageSetMetadata(GetImageSetMetadataRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetImageSetMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImageSetMetadataResponseUnmarshaller.Instance;

            return Invoke<GetImageSetMetadataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetImageSetMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetImageSetMetadata operation on AmazonMedicalImagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetImageSetMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/GetImageSetMetadata">REST API Reference for GetImageSetMetadata Operation</seealso>
        public virtual IAsyncResult BeginGetImageSetMetadata(GetImageSetMetadataRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetImageSetMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImageSetMetadataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetImageSetMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetImageSetMetadata.</param>
        /// 
        /// <returns>Returns a  GetImageSetMetadataResult from MedicalImaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/GetImageSetMetadata">REST API Reference for GetImageSetMetadata Operation</seealso>
        public virtual GetImageSetMetadataResponse EndGetImageSetMetadata(IAsyncResult asyncResult)
        {
            return EndInvoke<GetImageSetMetadataResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDatastores

        /// <summary>
        /// List data stores.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatastores service method.</param>
        /// 
        /// <returns>The response from the ListDatastores service method, as returned by MedicalImaging.</returns>
        /// <exception cref="Amazon.MedicalImaging.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.InternalServerException">
        /// An unexpected error occurred during processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ThrottlingException">
        /// The request was denied due to throttling.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/ListDatastores">REST API Reference for ListDatastores Operation</seealso>
        public virtual ListDatastoresResponse ListDatastores(ListDatastoresRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDatastoresRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatastoresResponseUnmarshaller.Instance;

            return Invoke<ListDatastoresResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDatastores operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDatastores operation on AmazonMedicalImagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDatastores
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/ListDatastores">REST API Reference for ListDatastores Operation</seealso>
        public virtual IAsyncResult BeginListDatastores(ListDatastoresRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDatastoresRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatastoresResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDatastores operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDatastores.</param>
        /// 
        /// <returns>Returns a  ListDatastoresResult from MedicalImaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/ListDatastores">REST API Reference for ListDatastores Operation</seealso>
        public virtual ListDatastoresResponse EndListDatastores(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDatastoresResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDICOMImportJobs

        /// <summary>
        /// List import jobs created for a specific data store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDICOMImportJobs service method.</param>
        /// 
        /// <returns>The response from the ListDICOMImportJobs service method, as returned by MedicalImaging.</returns>
        /// <exception cref="Amazon.MedicalImaging.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.InternalServerException">
        /// An unexpected error occurred during processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ThrottlingException">
        /// The request was denied due to throttling.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/ListDICOMImportJobs">REST API Reference for ListDICOMImportJobs Operation</seealso>
        public virtual ListDICOMImportJobsResponse ListDICOMImportJobs(ListDICOMImportJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDICOMImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDICOMImportJobsResponseUnmarshaller.Instance;

            return Invoke<ListDICOMImportJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDICOMImportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDICOMImportJobs operation on AmazonMedicalImagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDICOMImportJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/ListDICOMImportJobs">REST API Reference for ListDICOMImportJobs Operation</seealso>
        public virtual IAsyncResult BeginListDICOMImportJobs(ListDICOMImportJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDICOMImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDICOMImportJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDICOMImportJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDICOMImportJobs.</param>
        /// 
        /// <returns>Returns a  ListDICOMImportJobsResult from MedicalImaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/ListDICOMImportJobs">REST API Reference for ListDICOMImportJobs Operation</seealso>
        public virtual ListDICOMImportJobsResponse EndListDICOMImportJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDICOMImportJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListImageSetVersions

        /// <summary>
        /// List image set versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImageSetVersions service method.</param>
        /// 
        /// <returns>The response from the ListImageSetVersions service method, as returned by MedicalImaging.</returns>
        /// <exception cref="Amazon.MedicalImaging.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.InternalServerException">
        /// An unexpected error occurred during processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ThrottlingException">
        /// The request was denied due to throttling.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/ListImageSetVersions">REST API Reference for ListImageSetVersions Operation</seealso>
        public virtual ListImageSetVersionsResponse ListImageSetVersions(ListImageSetVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListImageSetVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImageSetVersionsResponseUnmarshaller.Instance;

            return Invoke<ListImageSetVersionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListImageSetVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListImageSetVersions operation on AmazonMedicalImagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListImageSetVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/ListImageSetVersions">REST API Reference for ListImageSetVersions Operation</seealso>
        public virtual IAsyncResult BeginListImageSetVersions(ListImageSetVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListImageSetVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImageSetVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListImageSetVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListImageSetVersions.</param>
        /// 
        /// <returns>Returns a  ListImageSetVersionsResult from MedicalImaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/ListImageSetVersions">REST API Reference for ListImageSetVersions Operation</seealso>
        public virtual ListImageSetVersionsResponse EndListImageSetVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListImageSetVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists all tags associated with a medical imaging resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by MedicalImaging.</returns>
        /// <exception cref="Amazon.MedicalImaging.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.InternalServerException">
        /// An unexpected error occurred during processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ThrottlingException">
        /// The request was denied due to throttling.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonMedicalImagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from MedicalImaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  SearchImageSets

        /// <summary>
        /// Search image sets based on defined input attributes.
        /// 
        ///  <note> 
        /// <para>
        ///  <c>SearchImageSets</c> accepts a single search query parameter and returns a paginated
        /// response of all image sets that have the matching criteria. All date range queries
        /// must be input as <c>(lowerBound, upperBound)</c>.
        /// </para>
        ///  
        /// <para>
        /// By default, <c>SearchImageSets</c> uses the <c>updatedAt</c> field for sorting in
        /// descending order from newest to oldest.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchImageSets service method.</param>
        /// 
        /// <returns>The response from the SearchImageSets service method, as returned by MedicalImaging.</returns>
        /// <exception cref="Amazon.MedicalImaging.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.InternalServerException">
        /// An unexpected error occurred during processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ThrottlingException">
        /// The request was denied due to throttling.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/SearchImageSets">REST API Reference for SearchImageSets Operation</seealso>
        public virtual SearchImageSetsResponse SearchImageSets(SearchImageSetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchImageSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchImageSetsResponseUnmarshaller.Instance;

            return Invoke<SearchImageSetsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SearchImageSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchImageSets operation on AmazonMedicalImagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchImageSets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/SearchImageSets">REST API Reference for SearchImageSets Operation</seealso>
        public virtual IAsyncResult BeginSearchImageSets(SearchImageSetsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchImageSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchImageSetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SearchImageSets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchImageSets.</param>
        /// 
        /// <returns>Returns a  SearchImageSetsResult from MedicalImaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/SearchImageSets">REST API Reference for SearchImageSets Operation</seealso>
        public virtual SearchImageSetsResponse EndSearchImageSets(IAsyncResult asyncResult)
        {
            return EndInvoke<SearchImageSetsResponse>(asyncResult);
        }

        #endregion
        
        #region  StartDICOMImportJob

        /// <summary>
        /// Start importing bulk data into an <c>ACTIVE</c> data store. The import job imports
        /// DICOM P10 files found in the S3 prefix specified by the <c>inputS3Uri</c> parameter.
        /// The import job stores processing results in the file specified by the <c>outputS3Uri</c>
        /// parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDICOMImportJob service method.</param>
        /// 
        /// <returns>The response from the StartDICOMImportJob service method, as returned by MedicalImaging.</returns>
        /// <exception cref="Amazon.MedicalImaging.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.InternalServerException">
        /// An unexpected error occurred during processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ServiceQuotaExceededException">
        /// The request caused a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ThrottlingException">
        /// The request was denied due to throttling.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/StartDICOMImportJob">REST API Reference for StartDICOMImportJob Operation</seealso>
        public virtual StartDICOMImportJobResponse StartDICOMImportJob(StartDICOMImportJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartDICOMImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDICOMImportJobResponseUnmarshaller.Instance;

            return Invoke<StartDICOMImportJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartDICOMImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartDICOMImportJob operation on AmazonMedicalImagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartDICOMImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/StartDICOMImportJob">REST API Reference for StartDICOMImportJob Operation</seealso>
        public virtual IAsyncResult BeginStartDICOMImportJob(StartDICOMImportJobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartDICOMImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDICOMImportJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartDICOMImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartDICOMImportJob.</param>
        /// 
        /// <returns>Returns a  StartDICOMImportJobResult from MedicalImaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/StartDICOMImportJob">REST API Reference for StartDICOMImportJob Operation</seealso>
        public virtual StartDICOMImportJobResponse EndStartDICOMImportJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StartDICOMImportJobResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds a user-specifed key and value tag to a medical imaging resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by MedicalImaging.</returns>
        /// <exception cref="Amazon.MedicalImaging.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.InternalServerException">
        /// An unexpected error occurred during processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ThrottlingException">
        /// The request was denied due to throttling.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonMedicalImagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from MedicalImaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes tags from a medical imaging resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by MedicalImaging.</returns>
        /// <exception cref="Amazon.MedicalImaging.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.InternalServerException">
        /// An unexpected error occurred during processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ThrottlingException">
        /// The request was denied due to throttling.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonMedicalImagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from MedicalImaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateImageSetMetadata

        /// <summary>
        /// Update image set metadata attributes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateImageSetMetadata service method.</param>
        /// 
        /// <returns>The response from the UpdateImageSetMetadata service method, as returned by MedicalImaging.</returns>
        /// <exception cref="Amazon.MedicalImaging.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.InternalServerException">
        /// An unexpected error occurred during processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ServiceQuotaExceededException">
        /// The request caused a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ThrottlingException">
        /// The request was denied due to throttling.
        /// </exception>
        /// <exception cref="Amazon.MedicalImaging.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/UpdateImageSetMetadata">REST API Reference for UpdateImageSetMetadata Operation</seealso>
        public virtual UpdateImageSetMetadataResponse UpdateImageSetMetadata(UpdateImageSetMetadataRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateImageSetMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateImageSetMetadataResponseUnmarshaller.Instance;

            return Invoke<UpdateImageSetMetadataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateImageSetMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateImageSetMetadata operation on AmazonMedicalImagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateImageSetMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/UpdateImageSetMetadata">REST API Reference for UpdateImageSetMetadata Operation</seealso>
        public virtual IAsyncResult BeginUpdateImageSetMetadata(UpdateImageSetMetadataRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateImageSetMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateImageSetMetadataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateImageSetMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateImageSetMetadata.</param>
        /// 
        /// <returns>Returns a  UpdateImageSetMetadataResult from MedicalImaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medical-imaging-2023-07-19/UpdateImageSetMetadata">REST API Reference for UpdateImageSetMetadata Operation</seealso>
        public virtual UpdateImageSetMetadataResponse EndUpdateImageSetMetadata(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateImageSetMetadataResponse>(asyncResult);
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
            var resolver = new AmazonMedicalImagingEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}