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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        /// Grants users or groups in your IAM Identity Center identity source access to your
        /// Amazon Kendra experience. You can create an Amazon Kendra experience such as a search
        /// application. For more information on creating a search application experience, see
        /// <a href="https://docs.aws.amazon.com/kendra/latest/dg/deploying-search-experience-no-code.html">Building
        /// a search experience with no code</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateEntitiesToExperience service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateEntitiesToExperience service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        public virtual Task<AssociateEntitiesToExperienceResponse> AssociateEntitiesToExperienceAsync(AssociateEntitiesToExperienceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateEntitiesToExperienceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateEntitiesToExperienceResponseUnmarshaller.Instance;
            
            return InvokeAsync<AssociateEntitiesToExperienceResponse>(request, options, cancellationToken);
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        /// Defines the specific permissions of users or groups in your IAM Identity Center identity
        /// source with access to your Amazon Kendra experience. You can create an Amazon Kendra
        /// experience such as a search application. For more information on creating a search
        /// application experience, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/deploying-search-experience-no-code.html">Building
        /// a search experience with no code</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociatePersonasToEntities service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociatePersonasToEntities service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        public virtual Task<AssociatePersonasToEntitiesResponse> AssociatePersonasToEntitiesAsync(AssociatePersonasToEntitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociatePersonasToEntitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociatePersonasToEntitiesResponseUnmarshaller.Instance;
            
            return InvokeAsync<AssociatePersonasToEntitiesResponse>(request, options, cancellationToken);
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        public virtual Task<BatchDeleteDocumentResponse> BatchDeleteDocumentAsync(BatchDeleteDocumentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeleteDocumentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteDocumentResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchDeleteDocumentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchDeleteFeaturedResultsSet


        /// <summary>
        /// Removes one or more sets of featured results. Features results are placed above all
        /// other results for certain queries. If there's an exact match of a query, then one
        /// or more specific documents are featured in the search results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteFeaturedResultsSet service method.</param>
        /// 
        /// <returns>The response from the BatchDeleteFeaturedResultsSet service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/BatchDeleteFeaturedResultsSet">REST API Reference for BatchDeleteFeaturedResultsSet Operation</seealso>
        public virtual BatchDeleteFeaturedResultsSetResponse BatchDeleteFeaturedResultsSet(BatchDeleteFeaturedResultsSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeleteFeaturedResultsSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteFeaturedResultsSetResponseUnmarshaller.Instance;

            return Invoke<BatchDeleteFeaturedResultsSetResponse>(request, options);
        }


        /// <summary>
        /// Removes one or more sets of featured results. Features results are placed above all
        /// other results for certain queries. If there's an exact match of a query, then one
        /// or more specific documents are featured in the search results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteFeaturedResultsSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDeleteFeaturedResultsSet service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/BatchDeleteFeaturedResultsSet">REST API Reference for BatchDeleteFeaturedResultsSet Operation</seealso>
        public virtual Task<BatchDeleteFeaturedResultsSetResponse> BatchDeleteFeaturedResultsSetAsync(BatchDeleteFeaturedResultsSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeleteFeaturedResultsSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteFeaturedResultsSetResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchDeleteFeaturedResultsSetResponse>(request, options, cancellationToken);
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        public virtual Task<BatchGetDocumentStatusResponse> BatchGetDocumentStatusAsync(BatchGetDocumentStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetDocumentStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetDocumentStatusResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchGetDocumentStatusResponse>(request, options, cancellationToken);
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra service. Please see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas</a>
        /// for more information, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// to inquire about an increase of limits.
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra service. Please see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas</a>
        /// for more information, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// to inquire about an increase of limits.
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
        public virtual Task<BatchPutDocumentResponse> BatchPutDocumentAsync(BatchPutDocumentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchPutDocumentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchPutDocumentResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchPutDocumentResponse>(request, options, cancellationToken);
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        public virtual Task<ClearQuerySuggestionsResponse> ClearQuerySuggestionsAsync(ClearQuerySuggestionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ClearQuerySuggestionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ClearQuerySuggestionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ClearQuerySuggestionsResponse>(request, options, cancellationToken);
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra service. Please see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas</a>
        /// for more information, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// to inquire about an increase of limits.
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra service. Please see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas</a>
        /// for more information, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// to inquire about an increase of limits.
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
        public virtual Task<CreateAccessControlConfigurationResponse> CreateAccessControlConfigurationAsync(CreateAccessControlConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAccessControlConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccessControlConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateAccessControlConfigurationResponse>(request, options, cancellationToken);
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        /// You have exceeded the set limits for your Amazon Kendra service. Please see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas</a>
        /// for more information, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// to inquire about an increase of limits.
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
        /// For an example of creating an index and data source using the Python SDK, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/gs-python.html">Getting
        /// started with Python SDK</a>. For an example of creating an index and data source using
        /// the Java SDK, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/gs-java.html">Getting
        /// started with Java SDK</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        /// You have exceeded the set limits for your Amazon Kendra service. Please see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas</a>
        /// for more information, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// to inquire about an increase of limits.
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
        public virtual Task<CreateDataSourceResponse> CreateDataSourceAsync(CreateDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataSourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateDataSourceResponse>(request, options, cancellationToken);
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra service. Please see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas</a>
        /// for more information, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// to inquire about an increase of limits.
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
        /// Creates an Amazon Kendra experience such as a search application. For more information
        /// on creating a search application experience, including using the Python and Java SDKs,
        /// see <a href="https://docs.aws.amazon.com/kendra/latest/dg/deploying-search-experience-no-code.html">Building
        /// a search experience with no code</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateExperience service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra service. Please see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas</a>
        /// for more information, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// to inquire about an increase of limits.
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
        public virtual Task<CreateExperienceResponse> CreateExperienceAsync(CreateExperienceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateExperienceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateExperienceResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateExperienceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateFaq


        /// <summary>
        /// Creates a set of frequently ask questions (FAQs) using a specified FAQ file stored
        /// in an Amazon S3 bucket.
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra service. Please see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas</a>
        /// for more information, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// to inquire about an increase of limits.
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
        /// Creates a set of frequently ask questions (FAQs) using a specified FAQ file stored
        /// in an Amazon S3 bucket.
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra service. Please see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas</a>
        /// for more information, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// to inquire about an increase of limits.
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
        public virtual Task<CreateFaqResponse> CreateFaqAsync(CreateFaqRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFaqRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFaqResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateFaqResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateFeaturedResultsSet


        /// <summary>
        /// Creates a set of featured results to display at the top of the search results page.
        /// Featured results are placed above all other results for certain queries. You map specific
        /// queries to specific documents for featuring in the results. If a query contains an
        /// exact match, then one or more specific documents are featured in the search results.
        /// 
        ///  
        /// <para>
        /// You can create up to 50 sets of featured results per index. You can request to increase
        /// this limit by contacting <a href="http://aws.amazon.com/contact-us/">Support</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFeaturedResultsSet service method.</param>
        /// 
        /// <returns>The response from the CreateFeaturedResultsSet service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.FeaturedResultsConflictException">
        /// An error message with a list of conflicting queries used across different sets of
        /// featured results. This occurred with the request for a new featured results set. Check
        /// that the queries you specified for featured results are unique per featured results
        /// set for each index.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/CreateFeaturedResultsSet">REST API Reference for CreateFeaturedResultsSet Operation</seealso>
        public virtual CreateFeaturedResultsSetResponse CreateFeaturedResultsSet(CreateFeaturedResultsSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFeaturedResultsSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFeaturedResultsSetResponseUnmarshaller.Instance;

            return Invoke<CreateFeaturedResultsSetResponse>(request, options);
        }


        /// <summary>
        /// Creates a set of featured results to display at the top of the search results page.
        /// Featured results are placed above all other results for certain queries. You map specific
        /// queries to specific documents for featuring in the results. If a query contains an
        /// exact match, then one or more specific documents are featured in the search results.
        /// 
        ///  
        /// <para>
        /// You can create up to 50 sets of featured results per index. You can request to increase
        /// this limit by contacting <a href="http://aws.amazon.com/contact-us/">Support</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFeaturedResultsSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFeaturedResultsSet service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.FeaturedResultsConflictException">
        /// An error message with a list of conflicting queries used across different sets of
        /// featured results. This occurred with the request for a new featured results set. Check
        /// that the queries you specified for featured results are unique per featured results
        /// set for each index.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/CreateFeaturedResultsSet">REST API Reference for CreateFeaturedResultsSet Operation</seealso>
        public virtual Task<CreateFeaturedResultsSetResponse> CreateFeaturedResultsSetAsync(CreateFeaturedResultsSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFeaturedResultsSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFeaturedResultsSetResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateFeaturedResultsSetResponse>(request, options, cancellationToken);
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceAlreadyExistException">
        /// The resource you want to use already exists. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra service. Please see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas</a>
        /// for more information, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// to inquire about an increase of limits.
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceAlreadyExistException">
        /// The resource you want to use already exists. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra service. Please see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas</a>
        /// for more information, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// to inquire about an increase of limits.
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
        public virtual Task<CreateIndexResponse> CreateIndexAsync(CreateIndexRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIndexResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateIndexResponse>(request, options, cancellationToken);
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra service. Please see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas</a>
        /// for more information, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// to inquire about an increase of limits.
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra service. Please see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas</a>
        /// for more information, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// to inquire about an increase of limits.
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
        public virtual Task<CreateQuerySuggestionsBlockListResponse> CreateQuerySuggestionsBlockListAsync(CreateQuerySuggestionsBlockListRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateQuerySuggestionsBlockListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateQuerySuggestionsBlockListResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateQuerySuggestionsBlockListResponse>(request, options, cancellationToken);
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra service. Please see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas</a>
        /// for more information, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// to inquire about an increase of limits.
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra service. Please see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas</a>
        /// for more information, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// to inquire about an increase of limits.
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
        public virtual Task<CreateThesaurusResponse> CreateThesaurusAsync(CreateThesaurusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateThesaurusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateThesaurusResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateThesaurusResponse>(request, options, cancellationToken);
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        /// Deletes an access control configuration that you created for your documents in an
        /// index. This includes user and group access information for your documents. This is
        /// useful for user context filtering, where search results are filtered based on the
        /// user or their group access to documents.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessControlConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        public virtual Task<DeleteAccessControlConfigurationResponse> DeleteAccessControlConfigurationAsync(DeleteAccessControlConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAccessControlConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccessControlConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteAccessControlConfigurationResponse>(request, options, cancellationToken);
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        /// Deletes an Amazon Kendra data source connector. An exception is not thrown if the
        /// data source is already being deleted. While the data source is being deleted, the
        /// <code>Status</code> field returned by a call to the <code>DescribeDataSource</code>
        /// API is set to <code>DELETING</code>. For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/delete-data-source.html">Deleting
        /// Data Sources</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        public virtual Task<DeleteDataSourceResponse> DeleteDataSourceAsync(DeleteDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataSourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteDataSourceResponse>(request, options, cancellationToken);
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        /// Deletes your Amazon Kendra experience such as a search application. For more information
        /// on creating a search application experience, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/deploying-search-experience-no-code.html">Building
        /// a search experience with no code</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteExperience service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        public virtual Task<DeleteExperienceResponse> DeleteExperienceAsync(DeleteExperienceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteExperienceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteExperienceResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteExperienceResponse>(request, options, cancellationToken);
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        /// Removes an FAQ from an index.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFaq service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        public virtual Task<DeleteFaqResponse> DeleteFaqAsync(DeleteFaqRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFaqRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFaqResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteFaqResponse>(request, options, cancellationToken);
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        /// Deletes an existing Amazon Kendra index. An exception is not thrown if the index is
        /// already being deleted. While the index is being deleted, the <code>Status</code> field
        /// returned by a call to the <code>DescribeIndex</code> API is set to <code>DELETING</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIndex service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        public virtual Task<DeleteIndexResponse> DeleteIndexAsync(DeleteIndexRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIndexResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteIndexResponse>(request, options, cancellationToken);
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        public virtual Task<DeletePrincipalMappingResponse> DeletePrincipalMappingAsync(DeletePrincipalMappingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePrincipalMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePrincipalMappingResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeletePrincipalMappingResponse>(request, options, cancellationToken);
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        public virtual Task<DeleteQuerySuggestionsBlockListResponse> DeleteQuerySuggestionsBlockListAsync(DeleteQuerySuggestionsBlockListRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteQuerySuggestionsBlockListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteQuerySuggestionsBlockListResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteQuerySuggestionsBlockListResponse>(request, options, cancellationToken);
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        /// Deletes an existing Amazon Kendra thesaurus.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteThesaurus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        public virtual Task<DeleteThesaurusResponse> DeleteThesaurusAsync(DeleteThesaurusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteThesaurusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteThesaurusResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteThesaurusResponse>(request, options, cancellationToken);
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        /// Gets information about an access control configuration that you created for your documents
        /// in an index. This includes user and group access information for your documents. This
        /// is useful for user context filtering, where search results are filtered based on the
        /// user or their group access to documents.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccessControlConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAccessControlConfiguration service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        public virtual Task<DescribeAccessControlConfigurationResponse> DescribeAccessControlConfigurationAsync(DescribeAccessControlConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccessControlConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccessControlConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeAccessControlConfigurationResponse>(request, options, cancellationToken);
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        /// Gets information about an Amazon Kendra data source connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDataSource service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        public virtual Task<DescribeDataSourceResponse> DescribeDataSourceAsync(DescribeDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDataSourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeDataSourceResponse>(request, options, cancellationToken);
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        /// Gets information about your Amazon Kendra experience such as a search application.
        /// For more information on creating a search application experience, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/deploying-search-experience-no-code.html">Building
        /// a search experience with no code</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeExperience service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeExperience service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        public virtual Task<DescribeExperienceResponse> DescribeExperienceAsync(DescribeExperienceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeExperienceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeExperienceResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeExperienceResponse>(request, options, cancellationToken);
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        /// Gets information about an FAQ list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFaq service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFaq service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        public virtual Task<DescribeFaqResponse> DescribeFaqAsync(DescribeFaqRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFaqRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFaqResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeFaqResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeFeaturedResultsSet


        /// <summary>
        /// Gets information about a set of featured results. Features results are placed above
        /// all other results for certain queries. If there's an exact match of a query, then
        /// one or more specific documents are featured in the search results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFeaturedResultsSet service method.</param>
        /// 
        /// <returns>The response from the DescribeFeaturedResultsSet service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DescribeFeaturedResultsSet">REST API Reference for DescribeFeaturedResultsSet Operation</seealso>
        public virtual DescribeFeaturedResultsSetResponse DescribeFeaturedResultsSet(DescribeFeaturedResultsSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFeaturedResultsSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFeaturedResultsSetResponseUnmarshaller.Instance;

            return Invoke<DescribeFeaturedResultsSetResponse>(request, options);
        }


        /// <summary>
        /// Gets information about a set of featured results. Features results are placed above
        /// all other results for certain queries. If there's an exact match of a query, then
        /// one or more specific documents are featured in the search results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFeaturedResultsSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFeaturedResultsSet service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DescribeFeaturedResultsSet">REST API Reference for DescribeFeaturedResultsSet Operation</seealso>
        public virtual Task<DescribeFeaturedResultsSetResponse> DescribeFeaturedResultsSetAsync(DescribeFeaturedResultsSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFeaturedResultsSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFeaturedResultsSetResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeFeaturedResultsSetResponse>(request, options, cancellationToken);
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        /// Gets information about an existing Amazon Kendra index.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIndex service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeIndex service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        public virtual Task<DescribeIndexResponse> DescribeIndexAsync(DescribeIndexRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIndexResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeIndexResponse>(request, options, cancellationToken);
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePrincipalMapping service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        public virtual Task<DescribePrincipalMappingResponse> DescribePrincipalMappingAsync(DescribePrincipalMappingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePrincipalMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePrincipalMappingResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribePrincipalMappingResponse>(request, options, cancellationToken);
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeQuerySuggestionsBlockList service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        public virtual Task<DescribeQuerySuggestionsBlockListResponse> DescribeQuerySuggestionsBlockListAsync(DescribeQuerySuggestionsBlockListRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeQuerySuggestionsBlockListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeQuerySuggestionsBlockListResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeQuerySuggestionsBlockListResponse>(request, options, cancellationToken);
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeQuerySuggestionsConfig service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        public virtual Task<DescribeQuerySuggestionsConfigResponse> DescribeQuerySuggestionsConfigAsync(DescribeQuerySuggestionsConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeQuerySuggestionsConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeQuerySuggestionsConfigResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeQuerySuggestionsConfigResponse>(request, options, cancellationToken);
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        /// Gets information about an existing Amazon Kendra thesaurus.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeThesaurus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeThesaurus service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        public virtual Task<DescribeThesaurusResponse> DescribeThesaurusAsync(DescribeThesaurusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeThesaurusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeThesaurusResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeThesaurusResponse>(request, options, cancellationToken);
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        /// Prevents users or groups in your IAM Identity Center identity source from accessing
        /// your Amazon Kendra experience. You can create an Amazon Kendra experience such as
        /// a search application. For more information on creating a search application experience,
        /// see <a href="https://docs.aws.amazon.com/kendra/latest/dg/deploying-search-experience-no-code.html">Building
        /// a search experience with no code</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateEntitiesFromExperience service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateEntitiesFromExperience service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        public virtual Task<DisassociateEntitiesFromExperienceResponse> DisassociateEntitiesFromExperienceAsync(DisassociateEntitiesFromExperienceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateEntitiesFromExperienceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateEntitiesFromExperienceResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisassociateEntitiesFromExperienceResponse>(request, options, cancellationToken);
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        /// Removes the specific permissions of users or groups in your IAM Identity Center identity
        /// source with access to your Amazon Kendra experience. You can create an Amazon Kendra
        /// experience such as a search application. For more information on creating a search
        /// application experience, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/deploying-search-experience-no-code.html">Building
        /// a search experience with no code</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociatePersonasFromEntities service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociatePersonasFromEntities service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        public virtual Task<DisassociatePersonasFromEntitiesResponse> DisassociatePersonasFromEntitiesAsync(DisassociatePersonasFromEntitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociatePersonasFromEntitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociatePersonasFromEntitiesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisassociatePersonasFromEntitiesResponse>(request, options, cancellationToken);
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra service. Please see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas</a>
        /// for more information, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// to inquire about an increase of limits.
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
        /// Fetches the queries that are suggested to your users.
        /// 
        ///  
        /// <para>
        ///  <code>GetQuerySuggestions</code> is currently not supported in the Amazon Web Services
        /// GovCloud (US-West) region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQuerySuggestions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra service. Please see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas</a>
        /// for more information, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// to inquire about an increase of limits.
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
        public virtual Task<GetQuerySuggestionsResponse> GetQuerySuggestionsAsync(GetQuerySuggestionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetQuerySuggestionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQuerySuggestionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetQuerySuggestionsResponse>(request, options, cancellationToken);
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        /// Retrieves search metrics data. The data provides a snapshot of how your users interact
        /// with your search application and how effective the application is.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSnapshots service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSnapshots service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InvalidRequestException">
        /// The input to the request is not valid. Please provide the correct input and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/GetSnapshots">REST API Reference for GetSnapshots Operation</seealso>
        public virtual Task<GetSnapshotsResponse> GetSnapshotsAsync(GetSnapshotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSnapshotsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetSnapshotsResponse>(request, options, cancellationToken);
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        /// Lists one or more access control configurations for an index. This includes user and
        /// group access information for your documents. This is useful for user context filtering,
        /// where search results are filtered based on the user or their group access to documents.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessControlConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAccessControlConfigurations service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        public virtual Task<ListAccessControlConfigurationsResponse> ListAccessControlConfigurationsAsync(ListAccessControlConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAccessControlConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccessControlConfigurationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAccessControlConfigurationsResponse>(request, options, cancellationToken);
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        /// Lists the data source connectors that you have created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataSources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDataSources service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        public virtual Task<ListDataSourcesResponse> ListDataSourcesAsync(ListDataSourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataSourcesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListDataSourcesResponse>(request, options, cancellationToken);
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        /// Gets statistics about synchronizing a data source connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataSourceSyncJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        public virtual Task<ListDataSourceSyncJobsResponse> ListDataSourceSyncJobsAsync(ListDataSourceSyncJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataSourceSyncJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataSourceSyncJobsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListDataSourceSyncJobsResponse>(request, options, cancellationToken);
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        /// Lists specific permissions of users and groups with access to your Amazon Kendra experience.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEntityPersonas service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEntityPersonas service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        public virtual Task<ListEntityPersonasResponse> ListEntityPersonasAsync(ListEntityPersonasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEntityPersonasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEntityPersonasResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListEntityPersonasResponse>(request, options, cancellationToken);
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        /// Lists users or groups in your IAM Identity Center identity source that are granted
        /// access to your Amazon Kendra experience. You can create an Amazon Kendra experience
        /// such as a search application. For more information on creating a search application
        /// experience, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/deploying-search-experience-no-code.html">Building
        /// a search experience with no code</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExperienceEntities service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListExperienceEntities service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        public virtual Task<ListExperienceEntitiesResponse> ListExperienceEntitiesAsync(ListExperienceEntitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListExperienceEntitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExperienceEntitiesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListExperienceEntitiesResponse>(request, options, cancellationToken);
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        /// Lists one or more Amazon Kendra experiences. You can create an Amazon Kendra experience
        /// such as a search application. For more information on creating a search application
        /// experience, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/deploying-search-experience-no-code.html">Building
        /// a search experience with no code</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExperiences service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListExperiences service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        public virtual Task<ListExperiencesResponse> ListExperiencesAsync(ListExperiencesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListExperiencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExperiencesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListExperiencesResponse>(request, options, cancellationToken);
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        /// Gets a list of FAQ lists associated with an index.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFaqs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFaqs service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        public virtual Task<ListFaqsResponse> ListFaqsAsync(ListFaqsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFaqsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFaqsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListFaqsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListFeaturedResultsSets


        /// <summary>
        /// Lists all your sets of featured results for a given index. Features results are placed
        /// above all other results for certain queries. If there's an exact match of a query,
        /// then one or more specific documents are featured in the search results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFeaturedResultsSets service method.</param>
        /// 
        /// <returns>The response from the ListFeaturedResultsSets service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListFeaturedResultsSets">REST API Reference for ListFeaturedResultsSets Operation</seealso>
        public virtual ListFeaturedResultsSetsResponse ListFeaturedResultsSets(ListFeaturedResultsSetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFeaturedResultsSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFeaturedResultsSetsResponseUnmarshaller.Instance;

            return Invoke<ListFeaturedResultsSetsResponse>(request, options);
        }


        /// <summary>
        /// Lists all your sets of featured results for a given index. Features results are placed
        /// above all other results for certain queries. If there's an exact match of a query,
        /// then one or more specific documents are featured in the search results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFeaturedResultsSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFeaturedResultsSets service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListFeaturedResultsSets">REST API Reference for ListFeaturedResultsSets Operation</seealso>
        public virtual Task<ListFeaturedResultsSetsResponse> ListFeaturedResultsSetsAsync(ListFeaturedResultsSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFeaturedResultsSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFeaturedResultsSetsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListFeaturedResultsSetsResponse>(request, options, cancellationToken);
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        public virtual Task<ListGroupsOlderThanOrderingIdResponse> ListGroupsOlderThanOrderingIdAsync(ListGroupsOlderThanOrderingIdRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGroupsOlderThanOrderingIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupsOlderThanOrderingIdResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListGroupsOlderThanOrderingIdResponse>(request, options, cancellationToken);
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        /// Lists the Amazon Kendra indexes that you created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIndices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIndices service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        public virtual Task<ListIndicesResponse> ListIndicesAsync(ListIndicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIndicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIndicesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListIndicesResponse>(request, options, cancellationToken);
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListQuerySuggestionsBlockLists service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        public virtual Task<ListQuerySuggestionsBlockListsResponse> ListQuerySuggestionsBlockListsAsync(ListQuerySuggestionsBlockListsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListQuerySuggestionsBlockListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQuerySuggestionsBlockListsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListQuerySuggestionsBlockListsResponse>(request, options, cancellationToken);
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        /// Gets a list of tags associated with a specified resource. Indexes, FAQs, and data
        /// sources can have tags associated with them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        /// Lists the thesauri for an index.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListThesauri service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListThesauri service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        public virtual Task<ListThesauriResponse> ListThesauriAsync(ListThesauriRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListThesauriRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListThesauriResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListThesauriResponse>(request, options, cancellationToken);
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra service. Please see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas</a>
        /// for more information, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// to inquire about an increase of limits.
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
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutPrincipalMapping service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra service. Please see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas</a>
        /// for more information, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// to inquire about an increase of limits.
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
        public virtual Task<PutPrincipalMappingResponse> PutPrincipalMappingAsync(PutPrincipalMappingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutPrincipalMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutPrincipalMappingResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutPrincipalMappingResponse>(request, options, cancellationToken);
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra service. Please see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas</a>
        /// for more information, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// to inquire about an increase of limits.
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra service. Please see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas</a>
        /// for more information, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// to inquire about an increase of limits.
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
        public virtual Task<QueryResponse> QueryAsync(QueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = QueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryResponseUnmarshaller.Instance;
            
            return InvokeAsync<QueryResponse>(request, options, cancellationToken);
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        /// Starts a synchronization job for a data source connector. If a synchronization job
        /// is already in progress, Amazon Kendra returns a <code>ResourceInUseException</code>
        /// exception.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDataSourceSyncJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        public virtual Task<StartDataSourceSyncJobResponse> StartDataSourceSyncJobAsync(StartDataSourceSyncJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDataSourceSyncJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDataSourceSyncJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartDataSourceSyncJobResponse>(request, options, cancellationToken);
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        /// Stops a synchronization job that is currently running. You can't stop a scheduled
        /// synchronization job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopDataSourceSyncJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopDataSourceSyncJob service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        public virtual Task<StopDataSourceSyncJobResponse> StopDataSourceSyncJobAsync(StopDataSourceSyncJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopDataSourceSyncJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopDataSourceSyncJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<StopDataSourceSyncJobResponse>(request, options, cancellationToken);
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SubmitFeedback service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        public virtual Task<SubmitFeedbackResponse> SubmitFeedbackAsync(SubmitFeedbackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SubmitFeedbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SubmitFeedbackResponseUnmarshaller.Instance;
            
            return InvokeAsync<SubmitFeedbackResponse>(request, options, cancellationToken);
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        /// Adds the specified tag to the specified index, FAQ, or data source resource. If the
        /// tag already exists, the existing value is replaced with the new value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        /// Removes a tag from an index, FAQ, or a data source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra service. Please see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas</a>
        /// for more information, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// to inquire about an increase of limits.
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra service. Please see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas</a>
        /// for more information, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// to inquire about an increase of limits.
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
        public virtual Task<UpdateAccessControlConfigurationResponse> UpdateAccessControlConfigurationAsync(UpdateAccessControlConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAccessControlConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccessControlConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateAccessControlConfigurationResponse>(request, options, cancellationToken);
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        /// Updates an existing Amazon Kendra data source connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        public virtual Task<UpdateDataSourceResponse> UpdateDataSourceAsync(UpdateDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataSourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateDataSourceResponse>(request, options, cancellationToken);
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        /// Updates your Amazon Kendra experience such as a search application. For more information
        /// on creating a search application experience, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/deploying-search-experience-no-code.html">Building
        /// a search experience with no code</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateExperience service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        public virtual Task<UpdateExperienceResponse> UpdateExperienceAsync(UpdateExperienceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateExperienceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateExperienceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateExperienceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateFeaturedResultsSet


        /// <summary>
        /// Updates a set of featured results. Features results are placed above all other results
        /// for certain queries. You map specific queries to specific documents for featuring
        /// in the results. If a query contains an exact match of a query, then one or more specific
        /// documents are featured in the search results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFeaturedResultsSet service method.</param>
        /// 
        /// <returns>The response from the UpdateFeaturedResultsSet service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.FeaturedResultsConflictException">
        /// An error message with a list of conflicting queries used across different sets of
        /// featured results. This occurred with the request for a new featured results set. Check
        /// that the queries you specified for featured results are unique per featured results
        /// set for each index.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/UpdateFeaturedResultsSet">REST API Reference for UpdateFeaturedResultsSet Operation</seealso>
        public virtual UpdateFeaturedResultsSetResponse UpdateFeaturedResultsSet(UpdateFeaturedResultsSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFeaturedResultsSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFeaturedResultsSetResponseUnmarshaller.Instance;

            return Invoke<UpdateFeaturedResultsSetResponse>(request, options);
        }


        /// <summary>
        /// Updates a set of featured results. Features results are placed above all other results
        /// for certain queries. You map specific queries to specific documents for featuring
        /// in the results. If a query contains an exact match of a query, then one or more specific
        /// documents are featured in the search results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFeaturedResultsSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFeaturedResultsSet service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.FeaturedResultsConflictException">
        /// An error message with a list of conflicting queries used across different sets of
        /// featured results. This occurred with the request for a new featured results set. Check
        /// that the queries you specified for featured results are unique per featured results
        /// set for each index.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/UpdateFeaturedResultsSet">REST API Reference for UpdateFeaturedResultsSet Operation</seealso>
        public virtual Task<UpdateFeaturedResultsSetResponse> UpdateFeaturedResultsSetAsync(UpdateFeaturedResultsSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFeaturedResultsSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFeaturedResultsSetResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateFeaturedResultsSetResponse>(request, options, cancellationToken);
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra service. Please see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas</a>
        /// for more information, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// to inquire about an increase of limits.
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
        /// Updates an existing Amazon Kendra index.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIndex service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra service. Please see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas</a>
        /// for more information, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// to inquire about an increase of limits.
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
        public virtual Task<UpdateIndexResponse> UpdateIndexAsync(UpdateIndexRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIndexResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateIndexResponse>(request, options, cancellationToken);
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        public virtual Task<UpdateQuerySuggestionsBlockListResponse> UpdateQuerySuggestionsBlockListAsync(UpdateQuerySuggestionsBlockListRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateQuerySuggestionsBlockListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQuerySuggestionsBlockListResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateQuerySuggestionsBlockListResponse>(request, options, cancellationToken);
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        public virtual Task<UpdateQuerySuggestionsConfigResponse> UpdateQuerySuggestionsConfigAsync(UpdateQuerySuggestionsConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateQuerySuggestionsConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQuerySuggestionsConfigResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateQuerySuggestionsConfigResponse>(request, options, cancellationToken);
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        /// Updates a thesaurus for an index.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateThesaurus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
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
        public virtual Task<UpdateThesaurusResponse> UpdateThesaurusAsync(UpdateThesaurusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateThesaurusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateThesaurusResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateThesaurusResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}