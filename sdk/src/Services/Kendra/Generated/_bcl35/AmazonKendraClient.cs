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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.Kendra.Model;
using Amazon.Kendra.Model.Internal.MarshallTransformations;
using Amazon.Kendra.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Kendra
{
    /// <summary>
    /// Implementation for accessing Kendra
    ///
    /// Amazon Kendra is a service for indexing large document sets.
    /// </summary>
    public partial class AmazonKendraClient : AmazonServiceClient, IAmazonKendra
    {
        private static IServiceMetadata serviceMetadata = new AmazonKendraMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IKendraPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IKendraPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new KendraPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonKendraClient with the credentials loaded from the application's
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
        public AmazonKendraClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonKendraConfig()) { }

        /// <summary>
        /// Constructs AmazonKendraClient with the credentials loaded from the application's
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
        public AmazonKendraClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonKendraConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonKendraClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonKendraClient Configuration Object</param>
        public AmazonKendraClient(AmazonKendraConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonKendraClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonKendraClient(AWSCredentials credentials)
            : this(credentials, new AmazonKendraConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonKendraClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKendraClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonKendraConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonKendraClient with AWS Credentials and an
        /// AmazonKendraClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonKendraClient Configuration Object</param>
        public AmazonKendraClient(AWSCredentials credentials, AmazonKendraConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonKendraClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonKendraClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonKendraConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonKendraClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKendraClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonKendraConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonKendraClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonKendraClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonKendraClient Configuration Object</param>
        public AmazonKendraClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonKendraConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonKendraClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonKendraClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonKendraConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonKendraClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKendraClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonKendraConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonKendraClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonKendraClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonKendraClient Configuration Object</param>
        public AmazonKendraClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonKendraConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonKendraEndpointResolver());
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


        #region  AssociateEntitiesToExperience

        /// <summary>
        /// Grants users or groups in your IAM Identity Center identity source access to your
        /// Amazon Kendra experience. You can create an Amazon Kendra experience such as a search
        /// application. For more information on creating a search application experience, see
        /// <a href="https://docs.aws.amazon.com/kendra/latest/dg/deploying-search-experience-no-code.html">Building
        /// a search experience with no code</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateEntitiesToExperience service method.</param>
        /// 
        /// <returns>The response from the AssociateEntitiesToExperience service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceAlreadyExistException">
        /// The resource you want to use already exists. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/AssociateEntitiesToExperience">REST API Reference for AssociateEntitiesToExperience Operation</seealso>
        public virtual AssociateEntitiesToExperienceResponse AssociateEntitiesToExperience(AssociateEntitiesToExperienceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateEntitiesToExperienceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateEntitiesToExperienceResponseUnmarshaller.Instance;

            return Invoke<AssociateEntitiesToExperienceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateEntitiesToExperience operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateEntitiesToExperience operation on AmazonKendraClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateEntitiesToExperience
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/AssociateEntitiesToExperience">REST API Reference for AssociateEntitiesToExperience Operation</seealso>
        public virtual IAsyncResult BeginAssociateEntitiesToExperience(AssociateEntitiesToExperienceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateEntitiesToExperienceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateEntitiesToExperienceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateEntitiesToExperience operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateEntitiesToExperience.</param>
        /// 
        /// <returns>Returns a  AssociateEntitiesToExperienceResult from Kendra.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/AssociateEntitiesToExperience">REST API Reference for AssociateEntitiesToExperience Operation</seealso>
        public virtual AssociateEntitiesToExperienceResponse EndAssociateEntitiesToExperience(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateEntitiesToExperienceResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociatePersonasToEntities

        /// <summary>
        /// Defines the specific permissions of users or groups in your IAM Identity Center identity
        /// source with access to your Amazon Kendra experience. You can create an Amazon Kendra
        /// experience such as a search application. For more information on creating a search
        /// application experience, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/deploying-search-experience-no-code.html">Building
        /// a search experience with no code</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociatePersonasToEntities service method.</param>
        /// 
        /// <returns>The response from the AssociatePersonasToEntities service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceAlreadyExistException">
        /// The resource you want to use already exists. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/AssociatePersonasToEntities">REST API Reference for AssociatePersonasToEntities Operation</seealso>
        public virtual AssociatePersonasToEntitiesResponse AssociatePersonasToEntities(AssociatePersonasToEntitiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociatePersonasToEntitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociatePersonasToEntitiesResponseUnmarshaller.Instance;

            return Invoke<AssociatePersonasToEntitiesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociatePersonasToEntities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociatePersonasToEntities operation on AmazonKendraClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociatePersonasToEntities
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/AssociatePersonasToEntities">REST API Reference for AssociatePersonasToEntities Operation</seealso>
        public virtual IAsyncResult BeginAssociatePersonasToEntities(AssociatePersonasToEntitiesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociatePersonasToEntitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociatePersonasToEntitiesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociatePersonasToEntities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociatePersonasToEntities.</param>
        /// 
        /// <returns>Returns a  AssociatePersonasToEntitiesResult from Kendra.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/AssociatePersonasToEntities">REST API Reference for AssociatePersonasToEntities Operation</seealso>
        public virtual AssociatePersonasToEntitiesResponse EndAssociatePersonasToEntities(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociatePersonasToEntitiesResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchDeleteDocument

        /// <summary>
        /// Removes one or more documents from an index. The documents must have been added with
        /// the <code>BatchPutDocument</code> API.
        /// 
        ///  
        /// <para>
        /// The documents are deleted asynchronously. You can see the progress of the deletion
        /// by using Amazon Web Services CloudWatch. Any error messages related to the processing
        /// of the batch are sent to you CloudWatch log.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteDocument service method.</param>
        /// 
        /// <returns>The response from the BatchDeleteDocument service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/BatchDeleteDocument">REST API Reference for BatchDeleteDocument Operation</seealso>
        public virtual BatchDeleteDocumentResponse BatchDeleteDocument(BatchDeleteDocumentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeleteDocumentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteDocumentResponseUnmarshaller.Instance;

            return Invoke<BatchDeleteDocumentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeleteDocument operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteDocument operation on AmazonKendraClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDeleteDocument
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/BatchDeleteDocument">REST API Reference for BatchDeleteDocument Operation</seealso>
        public virtual IAsyncResult BeginBatchDeleteDocument(BatchDeleteDocumentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeleteDocumentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteDocumentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDeleteDocument operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDeleteDocument.</param>
        /// 
        /// <returns>Returns a  BatchDeleteDocumentResult from Kendra.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/BatchDeleteDocument">REST API Reference for BatchDeleteDocument Operation</seealso>
        public virtual BatchDeleteDocumentResponse EndBatchDeleteDocument(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchDeleteDocumentResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchGetDocumentStatus

        /// <summary>
        /// Returns the indexing status for one or more documents submitted with the <a href="https://docs.aws.amazon.com/kendra/latest/dg/API_BatchPutDocument.html">
        /// BatchPutDocument</a> API.
        /// 
        ///  
        /// <para>
        /// When you use the <code>BatchPutDocument</code> API, documents are indexed asynchronously.
        /// You can use the <code>BatchGetDocumentStatus</code> API to get the current status
        /// of a list of documents so that you can determine if they have been successfully indexed.
        /// </para>
        ///  
        /// <para>
        /// You can also use the <code>BatchGetDocumentStatus</code> API to check the status of
        /// the <a href="https://docs.aws.amazon.com/kendra/latest/dg/API_BatchDeleteDocument.html">
        /// BatchDeleteDocument</a> API. When a document is deleted from the index, Amazon Kendra
        /// returns <code>NOT_FOUND</code> as the status.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetDocumentStatus service method.</param>
        /// 
        /// <returns>The response from the BatchGetDocumentStatus service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/BatchGetDocumentStatus">REST API Reference for BatchGetDocumentStatus Operation</seealso>
        public virtual BatchGetDocumentStatusResponse BatchGetDocumentStatus(BatchGetDocumentStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetDocumentStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetDocumentStatusResponseUnmarshaller.Instance;

            return Invoke<BatchGetDocumentStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetDocumentStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetDocumentStatus operation on AmazonKendraClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetDocumentStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/BatchGetDocumentStatus">REST API Reference for BatchGetDocumentStatus Operation</seealso>
        public virtual IAsyncResult BeginBatchGetDocumentStatus(BatchGetDocumentStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetDocumentStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetDocumentStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetDocumentStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetDocumentStatus.</param>
        /// 
        /// <returns>Returns a  BatchGetDocumentStatusResult from Kendra.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/BatchGetDocumentStatus">REST API Reference for BatchGetDocumentStatus Operation</seealso>
        public virtual BatchGetDocumentStatusResponse EndBatchGetDocumentStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchGetDocumentStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchPutDocument

        /// <summary>
        /// Adds one or more documents to an index.
        /// 
        ///  
        /// <para>
        /// The <code>BatchPutDocument</code> API enables you to ingest inline documents or a
        /// set of documents stored in an Amazon S3 bucket. Use this API to ingest your text and
        /// unstructured text into an index, add custom attributes to the documents, and to attach
        /// an access control list to the documents added to the index.
        /// </para>
        ///  
        /// <para>
        /// The documents are indexed asynchronously. You can see the progress of the batch using
        /// Amazon Web Services CloudWatch. Any error messages related to processing the batch
        /// are sent to your Amazon Web Services CloudWatch log.
        /// </para>
        ///  
        /// <para>
        /// For an example of ingesting inline documents using Python and Java SDKs, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/in-adding-binary-doc.html">Adding
        /// files directly to an index</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchPutDocument service method.</param>
        /// 
        /// <returns>The response from the BatchPutDocument service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra service. Please see Quotas[hyperlink
        /// Kendra Quotas pg] for more information, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> to inquire about an increase of limits.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/BatchPutDocument">REST API Reference for BatchPutDocument Operation</seealso>
        public virtual BatchPutDocumentResponse BatchPutDocument(BatchPutDocumentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchPutDocumentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchPutDocumentResponseUnmarshaller.Instance;

            return Invoke<BatchPutDocumentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchPutDocument operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchPutDocument operation on AmazonKendraClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchPutDocument
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/BatchPutDocument">REST API Reference for BatchPutDocument Operation</seealso>
        public virtual IAsyncResult BeginBatchPutDocument(BatchPutDocumentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchPutDocumentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchPutDocumentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchPutDocument operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchPutDocument.</param>
        /// 
        /// <returns>Returns a  BatchPutDocumentResult from Kendra.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/BatchPutDocument">REST API Reference for BatchPutDocument Operation</seealso>
        public virtual BatchPutDocumentResponse EndBatchPutDocument(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchPutDocumentResponse>(asyncResult);
        }

        #endregion
        
        #region  ClearQuerySuggestions

        /// <summary>
        /// Clears existing query suggestions from an index.
        /// 
        ///  
        /// <para>
        /// This deletes existing suggestions only, not the queries in the query log. After you
        /// clear suggestions, Amazon Kendra learns new suggestions based on new queries added
        /// to the query log from the time you cleared suggestions. If you do not see any new
        /// suggestions, then please allow Amazon Kendra to collect enough queries to learn new
        /// suggestions.
        /// </para>
        ///  
        /// <para>
        ///  <code>ClearQuerySuggestions</code> is currently not supported in the Amazon Web Services
        /// GovCloud (US-West) region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ClearQuerySuggestions service method.</param>
        /// 
        /// <returns>The response from the ClearQuerySuggestions service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ClearQuerySuggestions">REST API Reference for ClearQuerySuggestions Operation</seealso>
        public virtual ClearQuerySuggestionsResponse ClearQuerySuggestions(ClearQuerySuggestionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ClearQuerySuggestionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ClearQuerySuggestionsResponseUnmarshaller.Instance;

            return Invoke<ClearQuerySuggestionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ClearQuerySuggestions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ClearQuerySuggestions operation on AmazonKendraClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndClearQuerySuggestions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ClearQuerySuggestions">REST API Reference for ClearQuerySuggestions Operation</seealso>
        public virtual IAsyncResult BeginClearQuerySuggestions(ClearQuerySuggestionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ClearQuerySuggestionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ClearQuerySuggestionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ClearQuerySuggestions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginClearQuerySuggestions.</param>
        /// 
        /// <returns>Returns a  ClearQuerySuggestionsResult from Kendra.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ClearQuerySuggestions">REST API Reference for ClearQuerySuggestions Operation</seealso>
        public virtual ClearQuerySuggestionsResponse EndClearQuerySuggestions(IAsyncResult asyncResult)
        {
            return EndInvoke<ClearQuerySuggestionsResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAccessControlConfiguration

        /// <summary>
        /// Creates an access configuration for your documents. This includes user and group access
        /// information for your documents. This is useful for user context filtering, where search
        /// results are filtered based on the user or their group access to documents.
        /// 
        ///  
        /// <para>
        /// You can use this to re-configure your existing document level access control without
        /// indexing all of your documents again. For example, your index contains top-secret
        /// company documents that only certain employees or users should access. One of these
        /// users leaves the company or switches to a team that should be blocked from accessing
        /// top-secret documents. The user still has access to top-secret documents because the
        /// user had access when your documents were previously indexed. You can create a specific
        /// access control configuration for the user with deny access. You can later update the
        /// access control configuration to allow access if the user returns to the company and
        /// re-joins the 'top-secret' team. You can re-configure access control for your documents
        /// as circumstances change.
        /// </para>
        ///  
        /// <para>
        /// To apply your access control configuration to certain documents, you call the <a href="https://docs.aws.amazon.com/kendra/latest/dg/API_BatchPutDocument.html">BatchPutDocument</a>
        /// API with the <code>AccessControlConfigurationId</code> included in the <a href="https://docs.aws.amazon.com/kendra/latest/dg/API_Document.html">Document</a>
        /// object. If you use an S3 bucket as a data source, you update the <code>.metadata.json</code>
        /// with the <code>AccessControlConfigurationId</code> and synchronize your data source.
        /// Amazon Kendra currently only supports access control configuration for S3 data sources
        /// and documents indexed using the <code>BatchPutDocument</code> API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessControlConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateAccessControlConfiguration service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra service. Please see Quotas[hyperlink
        /// Kendra Quotas pg] for more information, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> to inquire about an increase of limits.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/CreateAccessControlConfiguration">REST API Reference for CreateAccessControlConfiguration Operation</seealso>
        public virtual CreateAccessControlConfigurationResponse CreateAccessControlConfiguration(CreateAccessControlConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAccessControlConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccessControlConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateAccessControlConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAccessControlConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessControlConfiguration operation on AmazonKendraClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAccessControlConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/CreateAccessControlConfiguration">REST API Reference for CreateAccessControlConfiguration Operation</seealso>
        public virtual IAsyncResult BeginCreateAccessControlConfiguration(CreateAccessControlConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAccessControlConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccessControlConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAccessControlConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAccessControlConfiguration.</param>
        /// 
        /// <returns>Returns a  CreateAccessControlConfigurationResult from Kendra.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/CreateAccessControlConfiguration">REST API Reference for CreateAccessControlConfiguration Operation</seealso>
        public virtual CreateAccessControlConfigurationResponse EndCreateAccessControlConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAccessControlConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDataSource

        /// <summary>
        /// Creates a data source connector that you want to use with an Amazon Kendra index.
        /// 
        ///  
        /// <para>
        /// You specify a name, data source connector type and description for your data source.
        /// You also specify configuration information for the data source connector.
        /// </para>
        ///  
        /// <para>
        ///  <code>CreateDataSource</code> is a synchronous operation. The operation returns 200
        /// if the data source was successfully created. Otherwise, an exception is raised.
        /// </para>
        ///  
        /// <para>
        /// Amazon S3 and <a href="https://docs.aws.amazon.com/kendra/latest/dg/data-source-custom.html">custom</a>
        /// data sources are the only supported data sources in the Amazon Web Services GovCloud
        /// (US-West) region.
        /// </para>
        ///  
        /// <para>
        /// For an example of creating an index and data source using the Python SDK, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/gs-python.html">Getting
        /// started with Python SDK</a>. For an example of creating an index and data source using
        /// the Java SDK, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/gs-java.html">Getting
        /// started with Java SDK</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSource service method.</param>
        /// 
        /// <returns>The response from the CreateDataSource service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceAlreadyExistException">
        /// The resource you want to use already exists. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra service. Please see Quotas[hyperlink
        /// Kendra Quotas pg] for more information, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> to inquire about an increase of limits.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/CreateDataSource">REST API Reference for CreateDataSource Operation</seealso>
        public virtual CreateDataSourceResponse CreateDataSource(CreateDataSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataSourceResponseUnmarshaller.Instance;

            return Invoke<CreateDataSourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSource operation on AmazonKendraClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDataSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/CreateDataSource">REST API Reference for CreateDataSource Operation</seealso>
        public virtual IAsyncResult BeginCreateDataSource(CreateDataSourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataSourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataSource.</param>
        /// 
        /// <returns>Returns a  CreateDataSourceResult from Kendra.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/CreateDataSource">REST API Reference for CreateDataSource Operation</seealso>
        public virtual CreateDataSourceResponse EndCreateDataSource(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDataSourceResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateExperience

        /// <summary>
        /// Creates an Amazon Kendra experience such as a search application. For more information
        /// on creating a search application experience, including using the Python and Java SDKs,
        /// see <a href="https://docs.aws.amazon.com/kendra/latest/dg/deploying-search-experience-no-code.html">Building
        /// a search experience with no code</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateExperience service method.</param>
        /// 
        /// <returns>The response from the CreateExperience service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra service. Please see Quotas[hyperlink
        /// Kendra Quotas pg] for more information, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> to inquire about an increase of limits.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/CreateExperience">REST API Reference for CreateExperience Operation</seealso>
        public virtual CreateExperienceResponse CreateExperience(CreateExperienceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateExperienceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateExperienceResponseUnmarshaller.Instance;

            return Invoke<CreateExperienceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateExperience operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateExperience operation on AmazonKendraClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateExperience
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/CreateExperience">REST API Reference for CreateExperience Operation</seealso>
        public virtual IAsyncResult BeginCreateExperience(CreateExperienceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateExperienceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateExperienceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateExperience operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateExperience.</param>
        /// 
        /// <returns>Returns a  CreateExperienceResult from Kendra.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/CreateExperience">REST API Reference for CreateExperience Operation</seealso>
        public virtual CreateExperienceResponse EndCreateExperience(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateExperienceResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateFaq

        /// <summary>
        /// Creates an new set of frequently asked question (FAQ) questions and answers.
        /// 
        ///  
        /// <para>
        /// Adding FAQs to an index is an asynchronous operation.
        /// </para>
        ///  
        /// <para>
        /// For an example of adding an FAQ to an index using Python and Java SDKs, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/in-creating-faq.html#using-faq-file">Using
        /// your FAQ file</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFaq service method.</param>
        /// 
        /// <returns>The response from the CreateFaq service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra service. Please see Quotas[hyperlink
        /// Kendra Quotas pg] for more information, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> to inquire about an increase of limits.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/CreateFaq">REST API Reference for CreateFaq Operation</seealso>
        public virtual CreateFaqResponse CreateFaq(CreateFaqRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFaqRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFaqResponseUnmarshaller.Instance;

            return Invoke<CreateFaqResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFaq operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFaq operation on AmazonKendraClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFaq
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/CreateFaq">REST API Reference for CreateFaq Operation</seealso>
        public virtual IAsyncResult BeginCreateFaq(CreateFaqRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFaqRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFaqResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFaq operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFaq.</param>
        /// 
        /// <returns>Returns a  CreateFaqResult from Kendra.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/CreateFaq">REST API Reference for CreateFaq Operation</seealso>
        public virtual CreateFaqResponse EndCreateFaq(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateFaqResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateIndex

        /// <summary>
        /// Creates an Amazon Kendra index. Index creation is an asynchronous API. To determine
        /// if index creation has completed, check the <code>Status</code> field returned from
        /// a call to <code>DescribeIndex</code>. The <code>Status</code> field is set to <code>ACTIVE</code>
        /// when the index is ready to use.
        /// 
        ///  
        /// <para>
        /// Once the index is active you can index your documents using the <code>BatchPutDocument</code>
        /// API or using one of the supported data sources.
        /// </para>
        ///  
        /// <para>
        /// For an example of creating an index and data source using the Python SDK, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/gs-python.html">Getting
        /// started with Python SDK</a>. For an example of creating an index and data source using
        /// the Java SDK, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/gs-java.html">Getting
        /// started with Java SDK</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIndex service method.</param>
        /// 
        /// <returns>The response from the CreateIndex service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceAlreadyExistException">
        /// The resource you want to use already exists. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra service. Please see Quotas[hyperlink
        /// Kendra Quotas pg] for more information, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> to inquire about an increase of limits.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/CreateIndex">REST API Reference for CreateIndex Operation</seealso>
        public virtual CreateIndexResponse CreateIndex(CreateIndexRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIndexResponseUnmarshaller.Instance;

            return Invoke<CreateIndexResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateIndex operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateIndex operation on AmazonKendraClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateIndex
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/CreateIndex">REST API Reference for CreateIndex Operation</seealso>
        public virtual IAsyncResult BeginCreateIndex(CreateIndexRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIndexResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateIndex operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateIndex.</param>
        /// 
        /// <returns>Returns a  CreateIndexResult from Kendra.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/CreateIndex">REST API Reference for CreateIndex Operation</seealso>
        public virtual CreateIndexResponse EndCreateIndex(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateIndexResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateQuerySuggestionsBlockList

        /// <summary>
        /// Creates a block list to exlcude certain queries from suggestions.
        /// 
        ///  
        /// <para>
        /// Any query that contains words or phrases specified in the block list is blocked or
        /// filtered out from being shown as a suggestion.
        /// </para>
        ///  
        /// <para>
        /// You need to provide the file location of your block list text file in your S3 bucket.
        /// In your text file, enter each block word or phrase on a separate line.
        /// </para>
        ///  
        /// <para>
        /// For information on the current quota limits for block lists, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas
        /// for Amazon Kendra</a>.
        /// </para>
        ///  
        /// <para>
        ///  <code>CreateQuerySuggestionsBlockList</code> is currently not supported in the Amazon
        /// Web Services GovCloud (US-West) region.
        /// </para>
        ///  
        /// <para>
        /// For an example of creating a block list for query suggestions using the Python SDK,
        /// see <a href="https://docs.aws.amazon.com/kendra/latest/dg/query-suggestions.html#suggestions-block-list">Query
        /// suggestions block list</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateQuerySuggestionsBlockList service method.</param>
        /// 
        /// <returns>The response from the CreateQuerySuggestionsBlockList service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra service. Please see Quotas[hyperlink
        /// Kendra Quotas pg] for more information, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> to inquire about an increase of limits.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/CreateQuerySuggestionsBlockList">REST API Reference for CreateQuerySuggestionsBlockList Operation</seealso>
        public virtual CreateQuerySuggestionsBlockListResponse CreateQuerySuggestionsBlockList(CreateQuerySuggestionsBlockListRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateQuerySuggestionsBlockListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateQuerySuggestionsBlockListResponseUnmarshaller.Instance;

            return Invoke<CreateQuerySuggestionsBlockListResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateQuerySuggestionsBlockList operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateQuerySuggestionsBlockList operation on AmazonKendraClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateQuerySuggestionsBlockList
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/CreateQuerySuggestionsBlockList">REST API Reference for CreateQuerySuggestionsBlockList Operation</seealso>
        public virtual IAsyncResult BeginCreateQuerySuggestionsBlockList(CreateQuerySuggestionsBlockListRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateQuerySuggestionsBlockListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateQuerySuggestionsBlockListResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateQuerySuggestionsBlockList operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateQuerySuggestionsBlockList.</param>
        /// 
        /// <returns>Returns a  CreateQuerySuggestionsBlockListResult from Kendra.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/CreateQuerySuggestionsBlockList">REST API Reference for CreateQuerySuggestionsBlockList Operation</seealso>
        public virtual CreateQuerySuggestionsBlockListResponse EndCreateQuerySuggestionsBlockList(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateQuerySuggestionsBlockListResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateThesaurus

        /// <summary>
        /// Creates a thesaurus for an index. The thesaurus contains a list of synonyms in Solr
        /// format.
        /// 
        ///  
        /// <para>
        /// For an example of adding a thesaurus file to an index, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/index-synonyms-adding-thesaurus-file.html">Adding
        /// custom synonyms to an index</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateThesaurus service method.</param>
        /// 
        /// <returns>The response from the CreateThesaurus service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra service. Please see Quotas[hyperlink
        /// Kendra Quotas pg] for more information, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> to inquire about an increase of limits.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/CreateThesaurus">REST API Reference for CreateThesaurus Operation</seealso>
        public virtual CreateThesaurusResponse CreateThesaurus(CreateThesaurusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateThesaurusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateThesaurusResponseUnmarshaller.Instance;

            return Invoke<CreateThesaurusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateThesaurus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateThesaurus operation on AmazonKendraClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateThesaurus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/CreateThesaurus">REST API Reference for CreateThesaurus Operation</seealso>
        public virtual IAsyncResult BeginCreateThesaurus(CreateThesaurusRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateThesaurusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateThesaurusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateThesaurus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateThesaurus.</param>
        /// 
        /// <returns>Returns a  CreateThesaurusResult from Kendra.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/CreateThesaurus">REST API Reference for CreateThesaurus Operation</seealso>
        public virtual CreateThesaurusResponse EndCreateThesaurus(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateThesaurusResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAccessControlConfiguration

        /// <summary>
        /// Deletes an access control configuration that you created for your documents in an
        /// index. This includes user and group access information for your documents. This is
        /// useful for user context filtering, where search results are filtered based on the
        /// user or their group access to documents.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessControlConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteAccessControlConfiguration service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DeleteAccessControlConfiguration">REST API Reference for DeleteAccessControlConfiguration Operation</seealso>
        public virtual DeleteAccessControlConfigurationResponse DeleteAccessControlConfiguration(DeleteAccessControlConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAccessControlConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccessControlConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteAccessControlConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccessControlConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessControlConfiguration operation on AmazonKendraClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAccessControlConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DeleteAccessControlConfiguration">REST API Reference for DeleteAccessControlConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDeleteAccessControlConfiguration(DeleteAccessControlConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAccessControlConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccessControlConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAccessControlConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAccessControlConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteAccessControlConfigurationResult from Kendra.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DeleteAccessControlConfiguration">REST API Reference for DeleteAccessControlConfiguration Operation</seealso>
        public virtual DeleteAccessControlConfigurationResponse EndDeleteAccessControlConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAccessControlConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDataSource

        /// <summary>
        /// Deletes an Amazon Kendra data source connector. An exception is not thrown if the
        /// data source is already being deleted. While the data source is being deleted, the
        /// <code>Status</code> field returned by a call to the <code>DescribeDataSource</code>
        /// API is set to <code>DELETING</code>. For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/delete-data-source.html">Deleting
        /// Data Sources</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataSource service method.</param>
        /// 
        /// <returns>The response from the DeleteDataSource service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DeleteDataSource">REST API Reference for DeleteDataSource Operation</seealso>
        public virtual DeleteDataSourceResponse DeleteDataSource(DeleteDataSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataSourceResponseUnmarshaller.Instance;

            return Invoke<DeleteDataSourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDataSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataSource operation on AmazonKendraClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDataSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DeleteDataSource">REST API Reference for DeleteDataSource Operation</seealso>
        public virtual IAsyncResult BeginDeleteDataSource(DeleteDataSourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataSourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDataSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDataSource.</param>
        /// 
        /// <returns>Returns a  DeleteDataSourceResult from Kendra.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DeleteDataSource">REST API Reference for DeleteDataSource Operation</seealso>
        public virtual DeleteDataSourceResponse EndDeleteDataSource(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDataSourceResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteExperience

        /// <summary>
        /// Deletes your Amazon Kendra experience such as a search application. For more information
        /// on creating a search application experience, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/deploying-search-experience-no-code.html">Building
        /// a search experience with no code</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteExperience service method.</param>
        /// 
        /// <returns>The response from the DeleteExperience service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DeleteExperience">REST API Reference for DeleteExperience Operation</seealso>
        public virtual DeleteExperienceResponse DeleteExperience(DeleteExperienceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteExperienceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteExperienceResponseUnmarshaller.Instance;

            return Invoke<DeleteExperienceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteExperience operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteExperience operation on AmazonKendraClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteExperience
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DeleteExperience">REST API Reference for DeleteExperience Operation</seealso>
        public virtual IAsyncResult BeginDeleteExperience(DeleteExperienceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteExperienceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteExperienceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteExperience operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteExperience.</param>
        /// 
        /// <returns>Returns a  DeleteExperienceResult from Kendra.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DeleteExperience">REST API Reference for DeleteExperience Operation</seealso>
        public virtual DeleteExperienceResponse EndDeleteExperience(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteExperienceResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteFaq

        /// <summary>
        /// Removes an FAQ from an index.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFaq service method.</param>
        /// 
        /// <returns>The response from the DeleteFaq service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DeleteFaq">REST API Reference for DeleteFaq Operation</seealso>
        public virtual DeleteFaqResponse DeleteFaq(DeleteFaqRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFaqRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFaqResponseUnmarshaller.Instance;

            return Invoke<DeleteFaqResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFaq operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFaq operation on AmazonKendraClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFaq
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DeleteFaq">REST API Reference for DeleteFaq Operation</seealso>
        public virtual IAsyncResult BeginDeleteFaq(DeleteFaqRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFaqRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFaqResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFaq operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFaq.</param>
        /// 
        /// <returns>Returns a  DeleteFaqResult from Kendra.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DeleteFaq">REST API Reference for DeleteFaq Operation</seealso>
        public virtual DeleteFaqResponse EndDeleteFaq(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteFaqResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteIndex

        /// <summary>
        /// Deletes an existing Amazon Kendra index. An exception is not thrown if the index is
        /// already being deleted. While the index is being deleted, the <code>Status</code> field
        /// returned by a call to the <code>DescribeIndex</code> API is set to <code>DELETING</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIndex service method.</param>
        /// 
        /// <returns>The response from the DeleteIndex service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DeleteIndex">REST API Reference for DeleteIndex Operation</seealso>
        public virtual DeleteIndexResponse DeleteIndex(DeleteIndexRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIndexResponseUnmarshaller.Instance;

            return Invoke<DeleteIndexResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIndex operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIndex operation on AmazonKendraClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteIndex
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DeleteIndex">REST API Reference for DeleteIndex Operation</seealso>
        public virtual IAsyncResult BeginDeleteIndex(DeleteIndexRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIndexResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteIndex operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIndex.</param>
        /// 
        /// <returns>Returns a  DeleteIndexResult from Kendra.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DeleteIndex">REST API Reference for DeleteIndex Operation</seealso>
        public virtual DeleteIndexResponse EndDeleteIndex(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteIndexResponse>(asyncResult);
        }

        #endregion
        
        #region  DeletePrincipalMapping

        /// <summary>
        /// Deletes a group so that all users and sub groups that belong to the group can no longer
        /// access documents only available to that group.
        /// 
        ///  
        /// <para>
        /// For example, after deleting the group "Summer Interns", all interns who belonged to
        /// that group no longer see intern-only documents in their search results.
        /// </para>
        ///  
        /// <para>
        /// If you want to delete or replace users or sub groups of a group, you need to use the
        /// <code>PutPrincipalMapping</code> operation. For example, if a user in the group "Engineering"
        /// leaves the engineering team and another user takes their place, you provide an updated
        /// list of users or sub groups that belong to the "Engineering" group when calling <code>PutPrincipalMapping</code>.
        /// You can update your internal list of users or sub groups and input this list when
        /// calling <code>PutPrincipalMapping</code>.
        /// </para>
        ///  
        /// <para>
        ///  <code>DeletePrincipalMapping</code> is currently not supported in the Amazon Web
        /// Services GovCloud (US-West) region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePrincipalMapping service method.</param>
        /// 
        /// <returns>The response from the DeletePrincipalMapping service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DeletePrincipalMapping">REST API Reference for DeletePrincipalMapping Operation</seealso>
        public virtual DeletePrincipalMappingResponse DeletePrincipalMapping(DeletePrincipalMappingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePrincipalMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePrincipalMappingResponseUnmarshaller.Instance;

            return Invoke<DeletePrincipalMappingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePrincipalMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePrincipalMapping operation on AmazonKendraClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePrincipalMapping
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DeletePrincipalMapping">REST API Reference for DeletePrincipalMapping Operation</seealso>
        public virtual IAsyncResult BeginDeletePrincipalMapping(DeletePrincipalMappingRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePrincipalMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePrincipalMappingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePrincipalMapping operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePrincipalMapping.</param>
        /// 
        /// <returns>Returns a  DeletePrincipalMappingResult from Kendra.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DeletePrincipalMapping">REST API Reference for DeletePrincipalMapping Operation</seealso>
        public virtual DeletePrincipalMappingResponse EndDeletePrincipalMapping(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePrincipalMappingResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteQuerySuggestionsBlockList

        /// <summary>
        /// Deletes a block list used for query suggestions for an index.
        /// 
        ///  
        /// <para>
        /// A deleted block list might not take effect right away. Amazon Kendra needs to refresh
        /// the entire suggestions list to add back the queries that were previously blocked.
        /// </para>
        ///  
        /// <para>
        ///  <code>DeleteQuerySuggestionsBlockList</code> is currently not supported in the Amazon
        /// Web Services GovCloud (US-West) region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteQuerySuggestionsBlockList service method.</param>
        /// 
        /// <returns>The response from the DeleteQuerySuggestionsBlockList service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DeleteQuerySuggestionsBlockList">REST API Reference for DeleteQuerySuggestionsBlockList Operation</seealso>
        public virtual DeleteQuerySuggestionsBlockListResponse DeleteQuerySuggestionsBlockList(DeleteQuerySuggestionsBlockListRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteQuerySuggestionsBlockListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteQuerySuggestionsBlockListResponseUnmarshaller.Instance;

            return Invoke<DeleteQuerySuggestionsBlockListResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteQuerySuggestionsBlockList operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteQuerySuggestionsBlockList operation on AmazonKendraClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteQuerySuggestionsBlockList
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DeleteQuerySuggestionsBlockList">REST API Reference for DeleteQuerySuggestionsBlockList Operation</seealso>
        public virtual IAsyncResult BeginDeleteQuerySuggestionsBlockList(DeleteQuerySuggestionsBlockListRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteQuerySuggestionsBlockListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteQuerySuggestionsBlockListResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteQuerySuggestionsBlockList operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteQuerySuggestionsBlockList.</param>
        /// 
        /// <returns>Returns a  DeleteQuerySuggestionsBlockListResult from Kendra.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DeleteQuerySuggestionsBlockList">REST API Reference for DeleteQuerySuggestionsBlockList Operation</seealso>
        public virtual DeleteQuerySuggestionsBlockListResponse EndDeleteQuerySuggestionsBlockList(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteQuerySuggestionsBlockListResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteThesaurus

        /// <summary>
        /// Deletes an existing Amazon Kendra thesaurus.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteThesaurus service method.</param>
        /// 
        /// <returns>The response from the DeleteThesaurus service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DeleteThesaurus">REST API Reference for DeleteThesaurus Operation</seealso>
        public virtual DeleteThesaurusResponse DeleteThesaurus(DeleteThesaurusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteThesaurusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteThesaurusResponseUnmarshaller.Instance;

            return Invoke<DeleteThesaurusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteThesaurus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteThesaurus operation on AmazonKendraClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteThesaurus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DeleteThesaurus">REST API Reference for DeleteThesaurus Operation</seealso>
        public virtual IAsyncResult BeginDeleteThesaurus(DeleteThesaurusRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteThesaurusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteThesaurusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteThesaurus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteThesaurus.</param>
        /// 
        /// <returns>Returns a  DeleteThesaurusResult from Kendra.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DeleteThesaurus">REST API Reference for DeleteThesaurus Operation</seealso>
        public virtual DeleteThesaurusResponse EndDeleteThesaurus(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteThesaurusResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAccessControlConfiguration

        /// <summary>
        /// Gets information about an access control configuration that you created for your documents
        /// in an index. This includes user and group access information for your documents. This
        /// is useful for user context filtering, where search results are filtered based on the
        /// user or their group access to documents.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccessControlConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeAccessControlConfiguration service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DescribeAccessControlConfiguration">REST API Reference for DescribeAccessControlConfiguration Operation</seealso>
        public virtual DescribeAccessControlConfigurationResponse DescribeAccessControlConfiguration(DescribeAccessControlConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccessControlConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccessControlConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeAccessControlConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAccessControlConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccessControlConfiguration operation on AmazonKendraClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAccessControlConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DescribeAccessControlConfiguration">REST API Reference for DescribeAccessControlConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDescribeAccessControlConfiguration(DescribeAccessControlConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccessControlConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccessControlConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAccessControlConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAccessControlConfiguration.</param>
        /// 
        /// <returns>Returns a  DescribeAccessControlConfigurationResult from Kendra.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DescribeAccessControlConfiguration">REST API Reference for DescribeAccessControlConfiguration Operation</seealso>
        public virtual DescribeAccessControlConfigurationResponse EndDescribeAccessControlConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAccessControlConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDataSource

        /// <summary>
        /// Gets information about an Amazon Kendra data source connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataSource service method.</param>
        /// 
        /// <returns>The response from the DescribeDataSource service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DescribeDataSource">REST API Reference for DescribeDataSource Operation</seealso>
        public virtual DescribeDataSourceResponse DescribeDataSource(DescribeDataSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDataSourceResponseUnmarshaller.Instance;

            return Invoke<DescribeDataSourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDataSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataSource operation on AmazonKendraClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDataSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DescribeDataSource">REST API Reference for DescribeDataSource Operation</seealso>
        public virtual IAsyncResult BeginDescribeDataSource(DescribeDataSourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDataSourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDataSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDataSource.</param>
        /// 
        /// <returns>Returns a  DescribeDataSourceResult from Kendra.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DescribeDataSource">REST API Reference for DescribeDataSource Operation</seealso>
        public virtual DescribeDataSourceResponse EndDescribeDataSource(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDataSourceResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeExperience

        /// <summary>
        /// Gets information about your Amazon Kendra experience such as a search application.
        /// For more information on creating a search application experience, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/deploying-search-experience-no-code.html">Building
        /// a search experience with no code</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeExperience service method.</param>
        /// 
        /// <returns>The response from the DescribeExperience service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DescribeExperience">REST API Reference for DescribeExperience Operation</seealso>
        public virtual DescribeExperienceResponse DescribeExperience(DescribeExperienceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeExperienceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeExperienceResponseUnmarshaller.Instance;

            return Invoke<DescribeExperienceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeExperience operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeExperience operation on AmazonKendraClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeExperience
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DescribeExperience">REST API Reference for DescribeExperience Operation</seealso>
        public virtual IAsyncResult BeginDescribeExperience(DescribeExperienceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeExperienceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeExperienceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeExperience operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeExperience.</param>
        /// 
        /// <returns>Returns a  DescribeExperienceResult from Kendra.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DescribeExperience">REST API Reference for DescribeExperience Operation</seealso>
        public virtual DescribeExperienceResponse EndDescribeExperience(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeExperienceResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeFaq

        /// <summary>
        /// Gets information about an FAQ list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFaq service method.</param>
        /// 
        /// <returns>The response from the DescribeFaq service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DescribeFaq">REST API Reference for DescribeFaq Operation</seealso>
        public virtual DescribeFaqResponse DescribeFaq(DescribeFaqRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFaqRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFaqResponseUnmarshaller.Instance;

            return Invoke<DescribeFaqResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFaq operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFaq operation on AmazonKendraClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFaq
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DescribeFaq">REST API Reference for DescribeFaq Operation</seealso>
        public virtual IAsyncResult BeginDescribeFaq(DescribeFaqRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFaqRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFaqResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFaq operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFaq.</param>
        /// 
        /// <returns>Returns a  DescribeFaqResult from Kendra.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DescribeFaq">REST API Reference for DescribeFaq Operation</seealso>
        public virtual DescribeFaqResponse EndDescribeFaq(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeFaqResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeIndex

        /// <summary>
        /// Gets information about an existing Amazon Kendra index.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIndex service method.</param>
        /// 
        /// <returns>The response from the DescribeIndex service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DescribeIndex">REST API Reference for DescribeIndex Operation</seealso>
        public virtual DescribeIndexResponse DescribeIndex(DescribeIndexRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIndexResponseUnmarshaller.Instance;

            return Invoke<DescribeIndexResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeIndex operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeIndex operation on AmazonKendraClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeIndex
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DescribeIndex">REST API Reference for DescribeIndex Operation</seealso>
        public virtual IAsyncResult BeginDescribeIndex(DescribeIndexRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIndexResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeIndex operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeIndex.</param>
        /// 
        /// <returns>Returns a  DescribeIndexResult from Kendra.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DescribeIndex">REST API Reference for DescribeIndex Operation</seealso>
        public virtual DescribeIndexResponse EndDescribeIndex(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeIndexResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribePrincipalMapping

        /// <summary>
        /// Describes the processing of <code>PUT</code> and <code>DELETE</code> actions for mapping
        /// users to their groups. This includes information on the status of actions currently
        /// processing or yet to be processed, when actions were last updated, when actions were
        /// received by Amazon Kendra, the latest action that should process and apply after other
        /// actions, and useful error messages if an action could not be processed.
        /// 
        ///  
        /// <para>
        ///  <code>DescribePrincipalMapping</code> is currently not supported in the Amazon Web
        /// Services GovCloud (US-West) region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePrincipalMapping service method.</param>
        /// 
        /// <returns>The response from the DescribePrincipalMapping service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DescribePrincipalMapping">REST API Reference for DescribePrincipalMapping Operation</seealso>
        public virtual DescribePrincipalMappingResponse DescribePrincipalMapping(DescribePrincipalMappingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePrincipalMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePrincipalMappingResponseUnmarshaller.Instance;

            return Invoke<DescribePrincipalMappingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePrincipalMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePrincipalMapping operation on AmazonKendraClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePrincipalMapping
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DescribePrincipalMapping">REST API Reference for DescribePrincipalMapping Operation</seealso>
        public virtual IAsyncResult BeginDescribePrincipalMapping(DescribePrincipalMappingRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePrincipalMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePrincipalMappingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePrincipalMapping operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePrincipalMapping.</param>
        /// 
        /// <returns>Returns a  DescribePrincipalMappingResult from Kendra.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DescribePrincipalMapping">REST API Reference for DescribePrincipalMapping Operation</seealso>
        public virtual DescribePrincipalMappingResponse EndDescribePrincipalMapping(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribePrincipalMappingResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeQuerySuggestionsBlockList

        /// <summary>
        /// Gets information about a block list used for query suggestions for an index.
        /// 
        ///  
        /// <para>
        /// This is used to check the current settings that are applied to a block list.
        /// </para>
        ///  
        /// <para>
        ///  <code>DescribeQuerySuggestionsBlockList</code> is currently not supported in the
        /// Amazon Web Services GovCloud (US-West) region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeQuerySuggestionsBlockList service method.</param>
        /// 
        /// <returns>The response from the DescribeQuerySuggestionsBlockList service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DescribeQuerySuggestionsBlockList">REST API Reference for DescribeQuerySuggestionsBlockList Operation</seealso>
        public virtual DescribeQuerySuggestionsBlockListResponse DescribeQuerySuggestionsBlockList(DescribeQuerySuggestionsBlockListRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeQuerySuggestionsBlockListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeQuerySuggestionsBlockListResponseUnmarshaller.Instance;

            return Invoke<DescribeQuerySuggestionsBlockListResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeQuerySuggestionsBlockList operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeQuerySuggestionsBlockList operation on AmazonKendraClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeQuerySuggestionsBlockList
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DescribeQuerySuggestionsBlockList">REST API Reference for DescribeQuerySuggestionsBlockList Operation</seealso>
        public virtual IAsyncResult BeginDescribeQuerySuggestionsBlockList(DescribeQuerySuggestionsBlockListRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeQuerySuggestionsBlockListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeQuerySuggestionsBlockListResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeQuerySuggestionsBlockList operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeQuerySuggestionsBlockList.</param>
        /// 
        /// <returns>Returns a  DescribeQuerySuggestionsBlockListResult from Kendra.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DescribeQuerySuggestionsBlockList">REST API Reference for DescribeQuerySuggestionsBlockList Operation</seealso>
        public virtual DescribeQuerySuggestionsBlockListResponse EndDescribeQuerySuggestionsBlockList(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeQuerySuggestionsBlockListResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeQuerySuggestionsConfig

        /// <summary>
        /// Gets information on the settings of query suggestions for an index.
        /// 
        ///  
        /// <para>
        /// This is used to check the current settings applied to query suggestions.
        /// </para>
        ///  
        /// <para>
        ///  <code>DescribeQuerySuggestionsConfig</code> is currently not supported in the Amazon
        /// Web Services GovCloud (US-West) region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeQuerySuggestionsConfig service method.</param>
        /// 
        /// <returns>The response from the DescribeQuerySuggestionsConfig service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DescribeQuerySuggestionsConfig">REST API Reference for DescribeQuerySuggestionsConfig Operation</seealso>
        public virtual DescribeQuerySuggestionsConfigResponse DescribeQuerySuggestionsConfig(DescribeQuerySuggestionsConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeQuerySuggestionsConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeQuerySuggestionsConfigResponseUnmarshaller.Instance;

            return Invoke<DescribeQuerySuggestionsConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeQuerySuggestionsConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeQuerySuggestionsConfig operation on AmazonKendraClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeQuerySuggestionsConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DescribeQuerySuggestionsConfig">REST API Reference for DescribeQuerySuggestionsConfig Operation</seealso>
        public virtual IAsyncResult BeginDescribeQuerySuggestionsConfig(DescribeQuerySuggestionsConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeQuerySuggestionsConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeQuerySuggestionsConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeQuerySuggestionsConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeQuerySuggestionsConfig.</param>
        /// 
        /// <returns>Returns a  DescribeQuerySuggestionsConfigResult from Kendra.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DescribeQuerySuggestionsConfig">REST API Reference for DescribeQuerySuggestionsConfig Operation</seealso>
        public virtual DescribeQuerySuggestionsConfigResponse EndDescribeQuerySuggestionsConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeQuerySuggestionsConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeThesaurus

        /// <summary>
        /// Gets information about an existing Amazon Kendra thesaurus.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeThesaurus service method.</param>
        /// 
        /// <returns>The response from the DescribeThesaurus service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DescribeThesaurus">REST API Reference for DescribeThesaurus Operation</seealso>
        public virtual DescribeThesaurusResponse DescribeThesaurus(DescribeThesaurusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeThesaurusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeThesaurusResponseUnmarshaller.Instance;

            return Invoke<DescribeThesaurusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeThesaurus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeThesaurus operation on AmazonKendraClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeThesaurus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DescribeThesaurus">REST API Reference for DescribeThesaurus Operation</seealso>
        public virtual IAsyncResult BeginDescribeThesaurus(DescribeThesaurusRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeThesaurusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeThesaurusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeThesaurus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeThesaurus.</param>
        /// 
        /// <returns>Returns a  DescribeThesaurusResult from Kendra.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DescribeThesaurus">REST API Reference for DescribeThesaurus Operation</seealso>
        public virtual DescribeThesaurusResponse EndDescribeThesaurus(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeThesaurusResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateEntitiesFromExperience

        /// <summary>
        /// Prevents users or groups in your IAM Identity Center identity source from accessing
        /// your Amazon Kendra experience. You can create an Amazon Kendra experience such as
        /// a search application. For more information on creating a search application experience,
        /// see <a href="https://docs.aws.amazon.com/kendra/latest/dg/deploying-search-experience-no-code.html">Building
        /// a search experience with no code</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateEntitiesFromExperience service method.</param>
        /// 
        /// <returns>The response from the DisassociateEntitiesFromExperience service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DisassociateEntitiesFromExperience">REST API Reference for DisassociateEntitiesFromExperience Operation</seealso>
        public virtual DisassociateEntitiesFromExperienceResponse DisassociateEntitiesFromExperience(DisassociateEntitiesFromExperienceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateEntitiesFromExperienceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateEntitiesFromExperienceResponseUnmarshaller.Instance;

            return Invoke<DisassociateEntitiesFromExperienceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateEntitiesFromExperience operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateEntitiesFromExperience operation on AmazonKendraClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateEntitiesFromExperience
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DisassociateEntitiesFromExperience">REST API Reference for DisassociateEntitiesFromExperience Operation</seealso>
        public virtual IAsyncResult BeginDisassociateEntitiesFromExperience(DisassociateEntitiesFromExperienceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateEntitiesFromExperienceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateEntitiesFromExperienceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateEntitiesFromExperience operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateEntitiesFromExperience.</param>
        /// 
        /// <returns>Returns a  DisassociateEntitiesFromExperienceResult from Kendra.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DisassociateEntitiesFromExperience">REST API Reference for DisassociateEntitiesFromExperience Operation</seealso>
        public virtual DisassociateEntitiesFromExperienceResponse EndDisassociateEntitiesFromExperience(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateEntitiesFromExperienceResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociatePersonasFromEntities

        /// <summary>
        /// Removes the specific permissions of users or groups in your IAM Identity Center identity
        /// source with access to your Amazon Kendra experience. You can create an Amazon Kendra
        /// experience such as a search application. For more information on creating a search
        /// application experience, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/deploying-search-experience-no-code.html">Building
        /// a search experience with no code</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociatePersonasFromEntities service method.</param>
        /// 
        /// <returns>The response from the DisassociatePersonasFromEntities service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DisassociatePersonasFromEntities">REST API Reference for DisassociatePersonasFromEntities Operation</seealso>
        public virtual DisassociatePersonasFromEntitiesResponse DisassociatePersonasFromEntities(DisassociatePersonasFromEntitiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociatePersonasFromEntitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociatePersonasFromEntitiesResponseUnmarshaller.Instance;

            return Invoke<DisassociatePersonasFromEntitiesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociatePersonasFromEntities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociatePersonasFromEntities operation on AmazonKendraClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociatePersonasFromEntities
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DisassociatePersonasFromEntities">REST API Reference for DisassociatePersonasFromEntities Operation</seealso>
        public virtual IAsyncResult BeginDisassociatePersonasFromEntities(DisassociatePersonasFromEntitiesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociatePersonasFromEntitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociatePersonasFromEntitiesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociatePersonasFromEntities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociatePersonasFromEntities.</param>
        /// 
        /// <returns>Returns a  DisassociatePersonasFromEntitiesResult from Kendra.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DisassociatePersonasFromEntities">REST API Reference for DisassociatePersonasFromEntities Operation</seealso>
        public virtual DisassociatePersonasFromEntitiesResponse EndDisassociatePersonasFromEntities(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociatePersonasFromEntitiesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetQuerySuggestions

        /// <summary>
        /// Fetches the queries that are suggested to your users.
        /// 
        ///  
        /// <para>
        ///  <code>GetQuerySuggestions</code> is currently not supported in the Amazon Web Services
        /// GovCloud (US-West) region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQuerySuggestions service method.</param>
        /// 
        /// <returns>The response from the GetQuerySuggestions service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra service. Please see Quotas[hyperlink
        /// Kendra Quotas pg] for more information, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> to inquire about an increase of limits.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/GetQuerySuggestions">REST API Reference for GetQuerySuggestions Operation</seealso>
        public virtual GetQuerySuggestionsResponse GetQuerySuggestions(GetQuerySuggestionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetQuerySuggestionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQuerySuggestionsResponseUnmarshaller.Instance;

            return Invoke<GetQuerySuggestionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetQuerySuggestions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetQuerySuggestions operation on AmazonKendraClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetQuerySuggestions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/GetQuerySuggestions">REST API Reference for GetQuerySuggestions Operation</seealso>
        public virtual IAsyncResult BeginGetQuerySuggestions(GetQuerySuggestionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetQuerySuggestionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQuerySuggestionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetQuerySuggestions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetQuerySuggestions.</param>
        /// 
        /// <returns>Returns a  GetQuerySuggestionsResult from Kendra.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/GetQuerySuggestions">REST API Reference for GetQuerySuggestions Operation</seealso>
        public virtual GetQuerySuggestionsResponse EndGetQuerySuggestions(IAsyncResult asyncResult)
        {
            return EndInvoke<GetQuerySuggestionsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSnapshots

        /// <summary>
        /// Retrieves search metrics data. The data provides a snapshot of how your users interact
        /// with your search application and how effective the application is.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSnapshots service method.</param>
        /// 
        /// <returns>The response from the GetSnapshots service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InvalidRequestException">
        /// The input to the request is not valid. Please provide the correct input and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/GetSnapshots">REST API Reference for GetSnapshots Operation</seealso>
        public virtual GetSnapshotsResponse GetSnapshots(GetSnapshotsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSnapshotsResponseUnmarshaller.Instance;

            return Invoke<GetSnapshotsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSnapshots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSnapshots operation on AmazonKendraClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSnapshots
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/GetSnapshots">REST API Reference for GetSnapshots Operation</seealso>
        public virtual IAsyncResult BeginGetSnapshots(GetSnapshotsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSnapshotsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSnapshots operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSnapshots.</param>
        /// 
        /// <returns>Returns a  GetSnapshotsResult from Kendra.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/GetSnapshots">REST API Reference for GetSnapshots Operation</seealso>
        public virtual GetSnapshotsResponse EndGetSnapshots(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSnapshotsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAccessControlConfigurations

        /// <summary>
        /// Lists one or more access control configurations for an index. This includes user and
        /// group access information for your documents. This is useful for user context filtering,
        /// where search results are filtered based on the user or their group access to documents.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessControlConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListAccessControlConfigurations service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListAccessControlConfigurations">REST API Reference for ListAccessControlConfigurations Operation</seealso>
        public virtual ListAccessControlConfigurationsResponse ListAccessControlConfigurations(ListAccessControlConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAccessControlConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccessControlConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListAccessControlConfigurationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAccessControlConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccessControlConfigurations operation on AmazonKendraClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAccessControlConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListAccessControlConfigurations">REST API Reference for ListAccessControlConfigurations Operation</seealso>
        public virtual IAsyncResult BeginListAccessControlConfigurations(ListAccessControlConfigurationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAccessControlConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccessControlConfigurationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAccessControlConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAccessControlConfigurations.</param>
        /// 
        /// <returns>Returns a  ListAccessControlConfigurationsResult from Kendra.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListAccessControlConfigurations">REST API Reference for ListAccessControlConfigurations Operation</seealso>
        public virtual ListAccessControlConfigurationsResponse EndListAccessControlConfigurations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAccessControlConfigurationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDataSources

        /// <summary>
        /// Lists the data source connectors that you have created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataSources service method.</param>
        /// 
        /// <returns>The response from the ListDataSources service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListDataSources">REST API Reference for ListDataSources Operation</seealso>
        public virtual ListDataSourcesResponse ListDataSources(ListDataSourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataSourcesResponseUnmarshaller.Instance;

            return Invoke<ListDataSourcesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDataSources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDataSources operation on AmazonKendraClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDataSources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListDataSources">REST API Reference for ListDataSources Operation</seealso>
        public virtual IAsyncResult BeginListDataSources(ListDataSourcesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataSourcesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDataSources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDataSources.</param>
        /// 
        /// <returns>Returns a  ListDataSourcesResult from Kendra.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListDataSources">REST API Reference for ListDataSources Operation</seealso>
        public virtual ListDataSourcesResponse EndListDataSources(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDataSourcesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDataSourceSyncJobs

        /// <summary>
        /// Gets statistics about synchronizing a data source connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataSourceSyncJobs service method.</param>
        /// 
        /// <returns>The response from the ListDataSourceSyncJobs service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListDataSourceSyncJobs">REST API Reference for ListDataSourceSyncJobs Operation</seealso>
        public virtual ListDataSourceSyncJobsResponse ListDataSourceSyncJobs(ListDataSourceSyncJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataSourceSyncJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataSourceSyncJobsResponseUnmarshaller.Instance;

            return Invoke<ListDataSourceSyncJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDataSourceSyncJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDataSourceSyncJobs operation on AmazonKendraClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDataSourceSyncJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListDataSourceSyncJobs">REST API Reference for ListDataSourceSyncJobs Operation</seealso>
        public virtual IAsyncResult BeginListDataSourceSyncJobs(ListDataSourceSyncJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataSourceSyncJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataSourceSyncJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDataSourceSyncJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDataSourceSyncJobs.</param>
        /// 
        /// <returns>Returns a  ListDataSourceSyncJobsResult from Kendra.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListDataSourceSyncJobs">REST API Reference for ListDataSourceSyncJobs Operation</seealso>
        public virtual ListDataSourceSyncJobsResponse EndListDataSourceSyncJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDataSourceSyncJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListEntityPersonas

        /// <summary>
        /// Lists specific permissions of users and groups with access to your Amazon Kendra experience.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEntityPersonas service method.</param>
        /// 
        /// <returns>The response from the ListEntityPersonas service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListEntityPersonas">REST API Reference for ListEntityPersonas Operation</seealso>
        public virtual ListEntityPersonasResponse ListEntityPersonas(ListEntityPersonasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEntityPersonasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEntityPersonasResponseUnmarshaller.Instance;

            return Invoke<ListEntityPersonasResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListEntityPersonas operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEntityPersonas operation on AmazonKendraClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEntityPersonas
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListEntityPersonas">REST API Reference for ListEntityPersonas Operation</seealso>
        public virtual IAsyncResult BeginListEntityPersonas(ListEntityPersonasRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEntityPersonasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEntityPersonasResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListEntityPersonas operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEntityPersonas.</param>
        /// 
        /// <returns>Returns a  ListEntityPersonasResult from Kendra.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListEntityPersonas">REST API Reference for ListEntityPersonas Operation</seealso>
        public virtual ListEntityPersonasResponse EndListEntityPersonas(IAsyncResult asyncResult)
        {
            return EndInvoke<ListEntityPersonasResponse>(asyncResult);
        }

        #endregion
        
        #region  ListExperienceEntities

        /// <summary>
        /// Lists users or groups in your IAM Identity Center identity source that are granted
        /// access to your Amazon Kendra experience. You can create an Amazon Kendra experience
        /// such as a search application. For more information on creating a search application
        /// experience, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/deploying-search-experience-no-code.html">Building
        /// a search experience with no code</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExperienceEntities service method.</param>
        /// 
        /// <returns>The response from the ListExperienceEntities service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListExperienceEntities">REST API Reference for ListExperienceEntities Operation</seealso>
        public virtual ListExperienceEntitiesResponse ListExperienceEntities(ListExperienceEntitiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListExperienceEntitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExperienceEntitiesResponseUnmarshaller.Instance;

            return Invoke<ListExperienceEntitiesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListExperienceEntities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListExperienceEntities operation on AmazonKendraClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListExperienceEntities
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListExperienceEntities">REST API Reference for ListExperienceEntities Operation</seealso>
        public virtual IAsyncResult BeginListExperienceEntities(ListExperienceEntitiesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListExperienceEntitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExperienceEntitiesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListExperienceEntities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListExperienceEntities.</param>
        /// 
        /// <returns>Returns a  ListExperienceEntitiesResult from Kendra.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListExperienceEntities">REST API Reference for ListExperienceEntities Operation</seealso>
        public virtual ListExperienceEntitiesResponse EndListExperienceEntities(IAsyncResult asyncResult)
        {
            return EndInvoke<ListExperienceEntitiesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListExperiences

        /// <summary>
        /// Lists one or more Amazon Kendra experiences. You can create an Amazon Kendra experience
        /// such as a search application. For more information on creating a search application
        /// experience, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/deploying-search-experience-no-code.html">Building
        /// a search experience with no code</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExperiences service method.</param>
        /// 
        /// <returns>The response from the ListExperiences service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListExperiences">REST API Reference for ListExperiences Operation</seealso>
        public virtual ListExperiencesResponse ListExperiences(ListExperiencesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListExperiencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExperiencesResponseUnmarshaller.Instance;

            return Invoke<ListExperiencesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListExperiences operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListExperiences operation on AmazonKendraClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListExperiences
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListExperiences">REST API Reference for ListExperiences Operation</seealso>
        public virtual IAsyncResult BeginListExperiences(ListExperiencesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListExperiencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExperiencesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListExperiences operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListExperiences.</param>
        /// 
        /// <returns>Returns a  ListExperiencesResult from Kendra.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListExperiences">REST API Reference for ListExperiences Operation</seealso>
        public virtual ListExperiencesResponse EndListExperiences(IAsyncResult asyncResult)
        {
            return EndInvoke<ListExperiencesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListFaqs

        /// <summary>
        /// Gets a list of FAQ lists associated with an index.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFaqs service method.</param>
        /// 
        /// <returns>The response from the ListFaqs service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListFaqs">REST API Reference for ListFaqs Operation</seealso>
        public virtual ListFaqsResponse ListFaqs(ListFaqsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFaqsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFaqsResponseUnmarshaller.Instance;

            return Invoke<ListFaqsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListFaqs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFaqs operation on AmazonKendraClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFaqs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListFaqs">REST API Reference for ListFaqs Operation</seealso>
        public virtual IAsyncResult BeginListFaqs(ListFaqsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFaqsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFaqsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListFaqs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFaqs.</param>
        /// 
        /// <returns>Returns a  ListFaqsResult from Kendra.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListFaqs">REST API Reference for ListFaqs Operation</seealso>
        public virtual ListFaqsResponse EndListFaqs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListFaqsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListGroupsOlderThanOrderingId

        /// <summary>
        /// Provides a list of groups that are mapped to users before a given ordering or timestamp
        /// identifier.
        /// 
        ///  
        /// <para>
        ///  <code>ListGroupsOlderThanOrderingId</code> is currently not supported in the Amazon
        /// Web Services GovCloud (US-West) region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroupsOlderThanOrderingId service method.</param>
        /// 
        /// <returns>The response from the ListGroupsOlderThanOrderingId service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListGroupsOlderThanOrderingId">REST API Reference for ListGroupsOlderThanOrderingId Operation</seealso>
        public virtual ListGroupsOlderThanOrderingIdResponse ListGroupsOlderThanOrderingId(ListGroupsOlderThanOrderingIdRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGroupsOlderThanOrderingIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupsOlderThanOrderingIdResponseUnmarshaller.Instance;

            return Invoke<ListGroupsOlderThanOrderingIdResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListGroupsOlderThanOrderingId operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroupsOlderThanOrderingId operation on AmazonKendraClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGroupsOlderThanOrderingId
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListGroupsOlderThanOrderingId">REST API Reference for ListGroupsOlderThanOrderingId Operation</seealso>
        public virtual IAsyncResult BeginListGroupsOlderThanOrderingId(ListGroupsOlderThanOrderingIdRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGroupsOlderThanOrderingIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupsOlderThanOrderingIdResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListGroupsOlderThanOrderingId operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGroupsOlderThanOrderingId.</param>
        /// 
        /// <returns>Returns a  ListGroupsOlderThanOrderingIdResult from Kendra.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListGroupsOlderThanOrderingId">REST API Reference for ListGroupsOlderThanOrderingId Operation</seealso>
        public virtual ListGroupsOlderThanOrderingIdResponse EndListGroupsOlderThanOrderingId(IAsyncResult asyncResult)
        {
            return EndInvoke<ListGroupsOlderThanOrderingIdResponse>(asyncResult);
        }

        #endregion
        
        #region  ListIndices

        /// <summary>
        /// Lists the Amazon Kendra indexes that you created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIndices service method.</param>
        /// 
        /// <returns>The response from the ListIndices service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListIndices">REST API Reference for ListIndices Operation</seealso>
        public virtual ListIndicesResponse ListIndices(ListIndicesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIndicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIndicesResponseUnmarshaller.Instance;

            return Invoke<ListIndicesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListIndices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIndices operation on AmazonKendraClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListIndices
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListIndices">REST API Reference for ListIndices Operation</seealso>
        public virtual IAsyncResult BeginListIndices(ListIndicesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIndicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIndicesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListIndices operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIndices.</param>
        /// 
        /// <returns>Returns a  ListIndicesResult from Kendra.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListIndices">REST API Reference for ListIndices Operation</seealso>
        public virtual ListIndicesResponse EndListIndices(IAsyncResult asyncResult)
        {
            return EndInvoke<ListIndicesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListQuerySuggestionsBlockLists

        /// <summary>
        /// Lists the block lists used for query suggestions for an index.
        /// 
        ///  
        /// <para>
        /// For information on the current quota limits for block lists, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas
        /// for Amazon Kendra</a>.
        /// </para>
        ///  
        /// <para>
        ///  <code>ListQuerySuggestionsBlockLists</code> is currently not supported in the Amazon
        /// Web Services GovCloud (US-West) region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQuerySuggestionsBlockLists service method.</param>
        /// 
        /// <returns>The response from the ListQuerySuggestionsBlockLists service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListQuerySuggestionsBlockLists">REST API Reference for ListQuerySuggestionsBlockLists Operation</seealso>
        public virtual ListQuerySuggestionsBlockListsResponse ListQuerySuggestionsBlockLists(ListQuerySuggestionsBlockListsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListQuerySuggestionsBlockListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQuerySuggestionsBlockListsResponseUnmarshaller.Instance;

            return Invoke<ListQuerySuggestionsBlockListsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListQuerySuggestionsBlockLists operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListQuerySuggestionsBlockLists operation on AmazonKendraClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListQuerySuggestionsBlockLists
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListQuerySuggestionsBlockLists">REST API Reference for ListQuerySuggestionsBlockLists Operation</seealso>
        public virtual IAsyncResult BeginListQuerySuggestionsBlockLists(ListQuerySuggestionsBlockListsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListQuerySuggestionsBlockListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQuerySuggestionsBlockListsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListQuerySuggestionsBlockLists operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListQuerySuggestionsBlockLists.</param>
        /// 
        /// <returns>Returns a  ListQuerySuggestionsBlockListsResult from Kendra.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListQuerySuggestionsBlockLists">REST API Reference for ListQuerySuggestionsBlockLists Operation</seealso>
        public virtual ListQuerySuggestionsBlockListsResponse EndListQuerySuggestionsBlockLists(IAsyncResult asyncResult)
        {
            return EndInvoke<ListQuerySuggestionsBlockListsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Gets a list of tags associated with a specified resource. Indexes, FAQs, and data
        /// sources can have tags associated with them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceUnavailableException">
        /// The resource you want to use isn't available. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonKendraClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from Kendra.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListThesauri

        /// <summary>
        /// Lists the thesauri for an index.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListThesauri service method.</param>
        /// 
        /// <returns>The response from the ListThesauri service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListThesauri">REST API Reference for ListThesauri Operation</seealso>
        public virtual ListThesauriResponse ListThesauri(ListThesauriRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListThesauriRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListThesauriResponseUnmarshaller.Instance;

            return Invoke<ListThesauriResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListThesauri operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListThesauri operation on AmazonKendraClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListThesauri
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListThesauri">REST API Reference for ListThesauri Operation</seealso>
        public virtual IAsyncResult BeginListThesauri(ListThesauriRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListThesauriRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListThesauriResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListThesauri operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListThesauri.</param>
        /// 
        /// <returns>Returns a  ListThesauriResult from Kendra.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListThesauri">REST API Reference for ListThesauri Operation</seealso>
        public virtual ListThesauriResponse EndListThesauri(IAsyncResult asyncResult)
        {
            return EndInvoke<ListThesauriResponse>(asyncResult);
        }

        #endregion
        
        #region  PutPrincipalMapping

        /// <summary>
        /// Maps users to their groups so that you only need to provide the user ID when you issue
        /// the query.
        /// 
        ///  
        /// <para>
        /// You can also map sub groups to groups. For example, the group "Company Intellectual
        /// Property Teams" includes sub groups "Research" and "Engineering". These sub groups
        /// include their own list of users or people who work in these teams. Only users who
        /// work in research and engineering, and therefore belong in the intellectual property
        /// group, can see top-secret company documents in their search results.
        /// </para>
        ///  
        /// <para>
        /// This is useful for user context filtering, where search results are filtered based
        /// on the user or their group access to documents. For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/user-context-filter.html">Filtering
        /// on user context</a>.
        /// </para>
        ///  
        /// <para>
        /// If more than five <code>PUT</code> actions for a group are currently processing, a
        /// validation exception is thrown.
        /// </para>
        ///  
        /// <para>
        ///  <code>PutPrincipalMapping</code> is currently not supported in the Amazon Web Services
        /// GovCloud (US-West) region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutPrincipalMapping service method.</param>
        /// 
        /// <returns>The response from the PutPrincipalMapping service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra service. Please see Quotas[hyperlink
        /// Kendra Quotas pg] for more information, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> to inquire about an increase of limits.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/PutPrincipalMapping">REST API Reference for PutPrincipalMapping Operation</seealso>
        public virtual PutPrincipalMappingResponse PutPrincipalMapping(PutPrincipalMappingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutPrincipalMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutPrincipalMappingResponseUnmarshaller.Instance;

            return Invoke<PutPrincipalMappingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutPrincipalMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutPrincipalMapping operation on AmazonKendraClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutPrincipalMapping
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/PutPrincipalMapping">REST API Reference for PutPrincipalMapping Operation</seealso>
        public virtual IAsyncResult BeginPutPrincipalMapping(PutPrincipalMappingRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutPrincipalMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutPrincipalMappingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutPrincipalMapping operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutPrincipalMapping.</param>
        /// 
        /// <returns>Returns a  PutPrincipalMappingResult from Kendra.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/PutPrincipalMapping">REST API Reference for PutPrincipalMapping Operation</seealso>
        public virtual PutPrincipalMappingResponse EndPutPrincipalMapping(IAsyncResult asyncResult)
        {
            return EndInvoke<PutPrincipalMappingResponse>(asyncResult);
        }

        #endregion
        
        #region  Query

        /// <summary>
        /// Searches an active index. Use this API to search your documents using query. The <code>Query</code>
        /// API enables to do faceted search and to filter results based on document attributes.
        /// 
        ///  
        /// <para>
        /// It also enables you to provide user context that Amazon Kendra uses to enforce document
        /// access control in the search results.
        /// </para>
        ///  
        /// <para>
        /// Amazon Kendra searches your index for text content and question and answer (FAQ) content.
        /// By default the response contains three types of results.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Relevant passages
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Matching FAQs
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Relevant documents
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can specify that the query return only one type of result using the <code>QueryResultTypeFilter</code>
        /// parameter.
        /// </para>
        ///  
        /// <para>
        /// Each query returns the 100 most relevant results. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Query service method.</param>
        /// 
        /// <returns>The response from the Query service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra service. Please see Quotas[hyperlink
        /// Kendra Quotas pg] for more information, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> to inquire about an increase of limits.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/Query">REST API Reference for Query Operation</seealso>
        public virtual QueryResponse Query(QueryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = QueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryResponseUnmarshaller.Instance;

            return Invoke<QueryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the Query operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Query operation on AmazonKendraClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndQuery
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/Query">REST API Reference for Query Operation</seealso>
        public virtual IAsyncResult BeginQuery(QueryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = QueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  Query operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginQuery.</param>
        /// 
        /// <returns>Returns a  QueryResult from Kendra.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/Query">REST API Reference for Query Operation</seealso>
        public virtual QueryResponse EndQuery(IAsyncResult asyncResult)
        {
            return EndInvoke<QueryResponse>(asyncResult);
        }

        #endregion
        
        #region  StartDataSourceSyncJob

        /// <summary>
        /// Starts a synchronization job for a data source connector. If a synchronization job
        /// is already in progress, Amazon Kendra returns a <code>ResourceInUseException</code>
        /// exception.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDataSourceSyncJob service method.</param>
        /// 
        /// <returns>The response from the StartDataSourceSyncJob service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceInUseException">
        /// The resource you want to use is currently in use. Please check you have provided the
        /// correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/StartDataSourceSyncJob">REST API Reference for StartDataSourceSyncJob Operation</seealso>
        public virtual StartDataSourceSyncJobResponse StartDataSourceSyncJob(StartDataSourceSyncJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDataSourceSyncJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDataSourceSyncJobResponseUnmarshaller.Instance;

            return Invoke<StartDataSourceSyncJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartDataSourceSyncJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartDataSourceSyncJob operation on AmazonKendraClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartDataSourceSyncJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/StartDataSourceSyncJob">REST API Reference for StartDataSourceSyncJob Operation</seealso>
        public virtual IAsyncResult BeginStartDataSourceSyncJob(StartDataSourceSyncJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDataSourceSyncJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDataSourceSyncJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartDataSourceSyncJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartDataSourceSyncJob.</param>
        /// 
        /// <returns>Returns a  StartDataSourceSyncJobResult from Kendra.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/StartDataSourceSyncJob">REST API Reference for StartDataSourceSyncJob Operation</seealso>
        public virtual StartDataSourceSyncJobResponse EndStartDataSourceSyncJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StartDataSourceSyncJobResponse>(asyncResult);
        }

        #endregion
        
        #region  StopDataSourceSyncJob

        /// <summary>
        /// Stops a synchronization job that is currently running. You can't stop a scheduled
        /// synchronization job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopDataSourceSyncJob service method.</param>
        /// 
        /// <returns>The response from the StopDataSourceSyncJob service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/StopDataSourceSyncJob">REST API Reference for StopDataSourceSyncJob Operation</seealso>
        public virtual StopDataSourceSyncJobResponse StopDataSourceSyncJob(StopDataSourceSyncJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopDataSourceSyncJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopDataSourceSyncJobResponseUnmarshaller.Instance;

            return Invoke<StopDataSourceSyncJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopDataSourceSyncJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopDataSourceSyncJob operation on AmazonKendraClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopDataSourceSyncJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/StopDataSourceSyncJob">REST API Reference for StopDataSourceSyncJob Operation</seealso>
        public virtual IAsyncResult BeginStopDataSourceSyncJob(StopDataSourceSyncJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopDataSourceSyncJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopDataSourceSyncJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopDataSourceSyncJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopDataSourceSyncJob.</param>
        /// 
        /// <returns>Returns a  StopDataSourceSyncJobResult from Kendra.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/StopDataSourceSyncJob">REST API Reference for StopDataSourceSyncJob Operation</seealso>
        public virtual StopDataSourceSyncJobResponse EndStopDataSourceSyncJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StopDataSourceSyncJobResponse>(asyncResult);
        }

        #endregion
        
        #region  SubmitFeedback

        /// <summary>
        /// Enables you to provide feedback to Amazon Kendra to improve the performance of your
        /// index.
        /// 
        ///  
        /// <para>
        ///  <code>SubmitFeedback</code> is currently not supported in the Amazon Web Services
        /// GovCloud (US-West) region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SubmitFeedback service method.</param>
        /// 
        /// <returns>The response from the SubmitFeedback service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceUnavailableException">
        /// The resource you want to use isn't available. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/SubmitFeedback">REST API Reference for SubmitFeedback Operation</seealso>
        public virtual SubmitFeedbackResponse SubmitFeedback(SubmitFeedbackRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SubmitFeedbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SubmitFeedbackResponseUnmarshaller.Instance;

            return Invoke<SubmitFeedbackResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SubmitFeedback operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SubmitFeedback operation on AmazonKendraClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSubmitFeedback
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/SubmitFeedback">REST API Reference for SubmitFeedback Operation</seealso>
        public virtual IAsyncResult BeginSubmitFeedback(SubmitFeedbackRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SubmitFeedbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SubmitFeedbackResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SubmitFeedback operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSubmitFeedback.</param>
        /// 
        /// <returns>Returns a  SubmitFeedbackResult from Kendra.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/SubmitFeedback">REST API Reference for SubmitFeedback Operation</seealso>
        public virtual SubmitFeedbackResponse EndSubmitFeedback(IAsyncResult asyncResult)
        {
            return EndInvoke<SubmitFeedbackResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds the specified tag to the specified index, FAQ, or data source resource. If the
        /// tag already exists, the existing value is replaced with the new value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceUnavailableException">
        /// The resource you want to use isn't available. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonKendraClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from Kendra.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes a tag from an index, FAQ, or a data source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceUnavailableException">
        /// The resource you want to use isn't available. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonKendraClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from Kendra.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAccessControlConfiguration

        /// <summary>
        /// Updates an access control configuration for your documents in an index. This includes
        /// user and group access information for your documents. This is useful for user context
        /// filtering, where search results are filtered based on the user or their group access
        /// to documents.
        /// 
        ///  
        /// <para>
        /// You can update an access control configuration you created without indexing all of
        /// your documents again. For example, your index contains top-secret company documents
        /// that only certain employees or users should access. You created an 'allow' access
        /// control configuration for one user who recently joined the 'top-secret' team, switching
        /// from a team with 'deny' access to top-secret documents. However, the user suddenly
        /// returns to their previous team and should no longer have access to top secret documents.
        /// You can update the access control configuration to re-configure access control for
        /// your documents as circumstances change.
        /// </para>
        ///  
        /// <para>
        /// You call the <a href="https://docs.aws.amazon.com/kendra/latest/dg/API_BatchPutDocument.html">BatchPutDocument</a>
        /// API to apply the updated access control configuration, with the <code>AccessControlConfigurationId</code>
        /// included in the <a href="https://docs.aws.amazon.com/kendra/latest/dg/API_Document.html">Document</a>
        /// object. If you use an S3 bucket as a data source, you synchronize your data source
        /// to apply the <code>AccessControlConfigurationId</code> in the <code>.metadata.json</code>
        /// file. Amazon Kendra currently only supports access control configuration for S3 data
        /// sources and documents indexed using the <code>BatchPutDocument</code> API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccessControlConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateAccessControlConfiguration service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra service. Please see Quotas[hyperlink
        /// Kendra Quotas pg] for more information, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> to inquire about an increase of limits.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/UpdateAccessControlConfiguration">REST API Reference for UpdateAccessControlConfiguration Operation</seealso>
        public virtual UpdateAccessControlConfigurationResponse UpdateAccessControlConfiguration(UpdateAccessControlConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAccessControlConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccessControlConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateAccessControlConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAccessControlConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccessControlConfiguration operation on AmazonKendraClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAccessControlConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/UpdateAccessControlConfiguration">REST API Reference for UpdateAccessControlConfiguration Operation</seealso>
        public virtual IAsyncResult BeginUpdateAccessControlConfiguration(UpdateAccessControlConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAccessControlConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccessControlConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAccessControlConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAccessControlConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateAccessControlConfigurationResult from Kendra.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/UpdateAccessControlConfiguration">REST API Reference for UpdateAccessControlConfiguration Operation</seealso>
        public virtual UpdateAccessControlConfigurationResponse EndUpdateAccessControlConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAccessControlConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDataSource

        /// <summary>
        /// Updates an existing Amazon Kendra data source connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSource service method.</param>
        /// 
        /// <returns>The response from the UpdateDataSource service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/UpdateDataSource">REST API Reference for UpdateDataSource Operation</seealso>
        public virtual UpdateDataSourceResponse UpdateDataSource(UpdateDataSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataSourceResponseUnmarshaller.Instance;

            return Invoke<UpdateDataSourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDataSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSource operation on AmazonKendraClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDataSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/UpdateDataSource">REST API Reference for UpdateDataSource Operation</seealso>
        public virtual IAsyncResult BeginUpdateDataSource(UpdateDataSourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataSourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDataSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDataSource.</param>
        /// 
        /// <returns>Returns a  UpdateDataSourceResult from Kendra.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/UpdateDataSource">REST API Reference for UpdateDataSource Operation</seealso>
        public virtual UpdateDataSourceResponse EndUpdateDataSource(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDataSourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateExperience

        /// <summary>
        /// Updates your Amazon Kendra experience such as a search application. For more information
        /// on creating a search application experience, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/deploying-search-experience-no-code.html">Building
        /// a search experience with no code</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateExperience service method.</param>
        /// 
        /// <returns>The response from the UpdateExperience service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/UpdateExperience">REST API Reference for UpdateExperience Operation</seealso>
        public virtual UpdateExperienceResponse UpdateExperience(UpdateExperienceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateExperienceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateExperienceResponseUnmarshaller.Instance;

            return Invoke<UpdateExperienceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateExperience operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateExperience operation on AmazonKendraClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateExperience
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/UpdateExperience">REST API Reference for UpdateExperience Operation</seealso>
        public virtual IAsyncResult BeginUpdateExperience(UpdateExperienceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateExperienceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateExperienceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateExperience operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateExperience.</param>
        /// 
        /// <returns>Returns a  UpdateExperienceResult from Kendra.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/UpdateExperience">REST API Reference for UpdateExperience Operation</seealso>
        public virtual UpdateExperienceResponse EndUpdateExperience(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateExperienceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateIndex

        /// <summary>
        /// Updates an existing Amazon Kendra index.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIndex service method.</param>
        /// 
        /// <returns>The response from the UpdateIndex service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra service. Please see Quotas[hyperlink
        /// Kendra Quotas pg] for more information, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> to inquire about an increase of limits.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/UpdateIndex">REST API Reference for UpdateIndex Operation</seealso>
        public virtual UpdateIndexResponse UpdateIndex(UpdateIndexRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIndexResponseUnmarshaller.Instance;

            return Invoke<UpdateIndexResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateIndex operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateIndex operation on AmazonKendraClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateIndex
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/UpdateIndex">REST API Reference for UpdateIndex Operation</seealso>
        public virtual IAsyncResult BeginUpdateIndex(UpdateIndexRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIndexResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateIndex operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateIndex.</param>
        /// 
        /// <returns>Returns a  UpdateIndexResult from Kendra.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/UpdateIndex">REST API Reference for UpdateIndex Operation</seealso>
        public virtual UpdateIndexResponse EndUpdateIndex(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateIndexResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateQuerySuggestionsBlockList

        /// <summary>
        /// Updates a block list used for query suggestions for an index.
        /// 
        ///  
        /// <para>
        /// Updates to a block list might not take effect right away. Amazon Kendra needs to refresh
        /// the entire suggestions list to apply any updates to the block list. Other changes
        /// not related to the block list apply immediately.
        /// </para>
        ///  
        /// <para>
        /// If a block list is updating, then you need to wait for the first update to finish
        /// before submitting another update.
        /// </para>
        ///  
        /// <para>
        /// Amazon Kendra supports partial updates, so you only need to provide the fields you
        /// want to update.
        /// </para>
        ///  
        /// <para>
        ///  <code>UpdateQuerySuggestionsBlockList</code> is currently not supported in the Amazon
        /// Web Services GovCloud (US-West) region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQuerySuggestionsBlockList service method.</param>
        /// 
        /// <returns>The response from the UpdateQuerySuggestionsBlockList service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/UpdateQuerySuggestionsBlockList">REST API Reference for UpdateQuerySuggestionsBlockList Operation</seealso>
        public virtual UpdateQuerySuggestionsBlockListResponse UpdateQuerySuggestionsBlockList(UpdateQuerySuggestionsBlockListRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateQuerySuggestionsBlockListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQuerySuggestionsBlockListResponseUnmarshaller.Instance;

            return Invoke<UpdateQuerySuggestionsBlockListResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateQuerySuggestionsBlockList operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateQuerySuggestionsBlockList operation on AmazonKendraClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateQuerySuggestionsBlockList
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/UpdateQuerySuggestionsBlockList">REST API Reference for UpdateQuerySuggestionsBlockList Operation</seealso>
        public virtual IAsyncResult BeginUpdateQuerySuggestionsBlockList(UpdateQuerySuggestionsBlockListRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateQuerySuggestionsBlockListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQuerySuggestionsBlockListResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateQuerySuggestionsBlockList operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateQuerySuggestionsBlockList.</param>
        /// 
        /// <returns>Returns a  UpdateQuerySuggestionsBlockListResult from Kendra.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/UpdateQuerySuggestionsBlockList">REST API Reference for UpdateQuerySuggestionsBlockList Operation</seealso>
        public virtual UpdateQuerySuggestionsBlockListResponse EndUpdateQuerySuggestionsBlockList(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateQuerySuggestionsBlockListResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateQuerySuggestionsConfig

        /// <summary>
        /// Updates the settings of query suggestions for an index.
        /// 
        ///  
        /// <para>
        /// Amazon Kendra supports partial updates, so you only need to provide the fields you
        /// want to update.
        /// </para>
        ///  
        /// <para>
        /// If an update is currently processing (i.e. 'happening'), you need to wait for the
        /// update to finish before making another update.
        /// </para>
        ///  
        /// <para>
        /// Updates to query suggestions settings might not take effect right away. The time for
        /// your updated settings to take effect depends on the updates made and the number of
        /// search queries in your index.
        /// </para>
        ///  
        /// <para>
        /// You can still enable/disable query suggestions at any time.
        /// </para>
        ///  
        /// <para>
        ///  <code>UpdateQuerySuggestionsConfig</code> is currently not supported in the Amazon
        /// Web Services GovCloud (US-West) region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQuerySuggestionsConfig service method.</param>
        /// 
        /// <returns>The response from the UpdateQuerySuggestionsConfig service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/UpdateQuerySuggestionsConfig">REST API Reference for UpdateQuerySuggestionsConfig Operation</seealso>
        public virtual UpdateQuerySuggestionsConfigResponse UpdateQuerySuggestionsConfig(UpdateQuerySuggestionsConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateQuerySuggestionsConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQuerySuggestionsConfigResponseUnmarshaller.Instance;

            return Invoke<UpdateQuerySuggestionsConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateQuerySuggestionsConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateQuerySuggestionsConfig operation on AmazonKendraClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateQuerySuggestionsConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/UpdateQuerySuggestionsConfig">REST API Reference for UpdateQuerySuggestionsConfig Operation</seealso>
        public virtual IAsyncResult BeginUpdateQuerySuggestionsConfig(UpdateQuerySuggestionsConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateQuerySuggestionsConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQuerySuggestionsConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateQuerySuggestionsConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateQuerySuggestionsConfig.</param>
        /// 
        /// <returns>Returns a  UpdateQuerySuggestionsConfigResult from Kendra.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/UpdateQuerySuggestionsConfig">REST API Reference for UpdateQuerySuggestionsConfig Operation</seealso>
        public virtual UpdateQuerySuggestionsConfigResponse EndUpdateQuerySuggestionsConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateQuerySuggestionsConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateThesaurus

        /// <summary>
        /// Updates a thesaurus for an index.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateThesaurus service method.</param>
        /// 
        /// <returns>The response from the UpdateThesaurus service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/aws.amazon.com/contact-us">
        /// Support</a> for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/UpdateThesaurus">REST API Reference for UpdateThesaurus Operation</seealso>
        public virtual UpdateThesaurusResponse UpdateThesaurus(UpdateThesaurusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateThesaurusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateThesaurusResponseUnmarshaller.Instance;

            return Invoke<UpdateThesaurusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateThesaurus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateThesaurus operation on AmazonKendraClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateThesaurus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/UpdateThesaurus">REST API Reference for UpdateThesaurus Operation</seealso>
        public virtual IAsyncResult BeginUpdateThesaurus(UpdateThesaurusRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateThesaurusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateThesaurusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateThesaurus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateThesaurus.</param>
        /// 
        /// <returns>Returns a  UpdateThesaurusResult from Kendra.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/UpdateThesaurus">REST API Reference for UpdateThesaurus Operation</seealso>
        public virtual UpdateThesaurusResponse EndUpdateThesaurus(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateThesaurusResponse>(asyncResult);
        }

        #endregion
        
    }
}