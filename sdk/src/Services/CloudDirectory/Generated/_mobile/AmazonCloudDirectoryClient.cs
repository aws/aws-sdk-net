/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the clouddirectory-2016-05-10.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.CloudDirectory.Model;
using Amazon.CloudDirectory.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CloudDirectory
{
    /// <summary>
    /// Implementation for accessing CloudDirectory
    ///
    /// Amazon Cloud Directory 
    /// <para>
    /// Amazon Cloud Directory is a component of the AWS Directory Service that simplifies
    /// the development and management of cloud-scale web, mobile, and IoT applications. This
    /// guide describes the Cloud Directory operations that you can call programmatically
    /// and includes detailed information on data types and errors. For information about
    /// AWS Directory Services features, see <a href="https://aws.amazon.com/directoryservice/">AWS
    /// Directory Service</a> and the <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/what_is.html">AWS
    /// Directory Service Administration Guide</a>.
    /// </para>
    /// </summary>
    public partial class AmazonCloudDirectoryClient : AmazonServiceClient, IAmazonCloudDirectory
    {
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonCloudDirectoryClient with the credentials loaded from the application's
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
        public AmazonCloudDirectoryClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudDirectoryConfig()) { }

        /// <summary>
        /// Constructs AmazonCloudDirectoryClient with the credentials loaded from the application's
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
        public AmazonCloudDirectoryClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudDirectoryConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonCloudDirectoryClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonCloudDirectoryClient Configuration Object</param>
        public AmazonCloudDirectoryClient(AmazonCloudDirectoryConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonCloudDirectoryClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCloudDirectoryClient(AWSCredentials credentials)
            : this(credentials, new AmazonCloudDirectoryConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudDirectoryClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudDirectoryClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCloudDirectoryConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudDirectoryClient with AWS Credentials and an
        /// AmazonCloudDirectoryClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCloudDirectoryClient Configuration Object</param>
        public AmazonCloudDirectoryClient(AWSCredentials credentials, AmazonCloudDirectoryConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCloudDirectoryClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCloudDirectoryClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloudDirectoryConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudDirectoryClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudDirectoryClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloudDirectoryConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudDirectoryClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudDirectoryClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCloudDirectoryClient Configuration Object</param>
        public AmazonCloudDirectoryClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCloudDirectoryConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCloudDirectoryClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCloudDirectoryClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudDirectoryConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudDirectoryClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudDirectoryClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudDirectoryConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudDirectoryClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudDirectoryClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCloudDirectoryClient Configuration Object</param>
        public AmazonCloudDirectoryClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCloudDirectoryConfig clientConfig)
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

        
        #region  AddFacetToObject

        internal AddFacetToObjectResponse AddFacetToObject(AddFacetToObjectRequest request)
        {
            var marshaller = new AddFacetToObjectRequestMarshaller();
            var unmarshaller = AddFacetToObjectResponseUnmarshaller.Instance;

            return Invoke<AddFacetToObjectRequest,AddFacetToObjectResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AddFacetToObject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddFacetToObject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/AddFacetToObject">REST API Reference for AddFacetToObject Operation</seealso>
        public Task<AddFacetToObjectResponse> AddFacetToObjectAsync(AddFacetToObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AddFacetToObjectRequestMarshaller();
            var unmarshaller = AddFacetToObjectResponseUnmarshaller.Instance;

            return InvokeAsync<AddFacetToObjectRequest,AddFacetToObjectResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ApplySchema

        internal ApplySchemaResponse ApplySchema(ApplySchemaRequest request)
        {
            var marshaller = new ApplySchemaRequestMarshaller();
            var unmarshaller = ApplySchemaResponseUnmarshaller.Instance;

            return Invoke<ApplySchemaRequest,ApplySchemaResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ApplySchema operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ApplySchema operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ApplySchema">REST API Reference for ApplySchema Operation</seealso>
        public Task<ApplySchemaResponse> ApplySchemaAsync(ApplySchemaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ApplySchemaRequestMarshaller();
            var unmarshaller = ApplySchemaResponseUnmarshaller.Instance;

            return InvokeAsync<ApplySchemaRequest,ApplySchemaResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AttachObject

        internal AttachObjectResponse AttachObject(AttachObjectRequest request)
        {
            var marshaller = new AttachObjectRequestMarshaller();
            var unmarshaller = AttachObjectResponseUnmarshaller.Instance;

            return Invoke<AttachObjectRequest,AttachObjectResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AttachObject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachObject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/AttachObject">REST API Reference for AttachObject Operation</seealso>
        public Task<AttachObjectResponse> AttachObjectAsync(AttachObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AttachObjectRequestMarshaller();
            var unmarshaller = AttachObjectResponseUnmarshaller.Instance;

            return InvokeAsync<AttachObjectRequest,AttachObjectResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AttachPolicy

        internal AttachPolicyResponse AttachPolicy(AttachPolicyRequest request)
        {
            var marshaller = new AttachPolicyRequestMarshaller();
            var unmarshaller = AttachPolicyResponseUnmarshaller.Instance;

            return Invoke<AttachPolicyRequest,AttachPolicyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AttachPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/AttachPolicy">REST API Reference for AttachPolicy Operation</seealso>
        public Task<AttachPolicyResponse> AttachPolicyAsync(AttachPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AttachPolicyRequestMarshaller();
            var unmarshaller = AttachPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<AttachPolicyRequest,AttachPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AttachToIndex

        internal AttachToIndexResponse AttachToIndex(AttachToIndexRequest request)
        {
            var marshaller = new AttachToIndexRequestMarshaller();
            var unmarshaller = AttachToIndexResponseUnmarshaller.Instance;

            return Invoke<AttachToIndexRequest,AttachToIndexResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AttachToIndex operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachToIndex operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/AttachToIndex">REST API Reference for AttachToIndex Operation</seealso>
        public Task<AttachToIndexResponse> AttachToIndexAsync(AttachToIndexRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AttachToIndexRequestMarshaller();
            var unmarshaller = AttachToIndexResponseUnmarshaller.Instance;

            return InvokeAsync<AttachToIndexRequest,AttachToIndexResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AttachTypedLink

        internal AttachTypedLinkResponse AttachTypedLink(AttachTypedLinkRequest request)
        {
            var marshaller = new AttachTypedLinkRequestMarshaller();
            var unmarshaller = AttachTypedLinkResponseUnmarshaller.Instance;

            return Invoke<AttachTypedLinkRequest,AttachTypedLinkResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AttachTypedLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachTypedLink operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/AttachTypedLink">REST API Reference for AttachTypedLink Operation</seealso>
        public Task<AttachTypedLinkResponse> AttachTypedLinkAsync(AttachTypedLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AttachTypedLinkRequestMarshaller();
            var unmarshaller = AttachTypedLinkResponseUnmarshaller.Instance;

            return InvokeAsync<AttachTypedLinkRequest,AttachTypedLinkResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  BatchRead

        internal BatchReadResponse BatchRead(BatchReadRequest request)
        {
            var marshaller = new BatchReadRequestMarshaller();
            var unmarshaller = BatchReadResponseUnmarshaller.Instance;

            return Invoke<BatchReadRequest,BatchReadResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the BatchRead operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchRead operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/BatchRead">REST API Reference for BatchRead Operation</seealso>
        public Task<BatchReadResponse> BatchReadAsync(BatchReadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new BatchReadRequestMarshaller();
            var unmarshaller = BatchReadResponseUnmarshaller.Instance;

            return InvokeAsync<BatchReadRequest,BatchReadResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  BatchWrite

        internal BatchWriteResponse BatchWrite(BatchWriteRequest request)
        {
            var marshaller = new BatchWriteRequestMarshaller();
            var unmarshaller = BatchWriteResponseUnmarshaller.Instance;

            return Invoke<BatchWriteRequest,BatchWriteResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the BatchWrite operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchWrite operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/BatchWrite">REST API Reference for BatchWrite Operation</seealso>
        public Task<BatchWriteResponse> BatchWriteAsync(BatchWriteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new BatchWriteRequestMarshaller();
            var unmarshaller = BatchWriteResponseUnmarshaller.Instance;

            return InvokeAsync<BatchWriteRequest,BatchWriteResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDirectory

        internal CreateDirectoryResponse CreateDirectory(CreateDirectoryRequest request)
        {
            var marshaller = new CreateDirectoryRequestMarshaller();
            var unmarshaller = CreateDirectoryResponseUnmarshaller.Instance;

            return Invoke<CreateDirectoryRequest,CreateDirectoryResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDirectory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDirectory operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/CreateDirectory">REST API Reference for CreateDirectory Operation</seealso>
        public Task<CreateDirectoryResponse> CreateDirectoryAsync(CreateDirectoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateDirectoryRequestMarshaller();
            var unmarshaller = CreateDirectoryResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDirectoryRequest,CreateDirectoryResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateFacet

        internal CreateFacetResponse CreateFacet(CreateFacetRequest request)
        {
            var marshaller = new CreateFacetRequestMarshaller();
            var unmarshaller = CreateFacetResponseUnmarshaller.Instance;

            return Invoke<CreateFacetRequest,CreateFacetResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateFacet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFacet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/CreateFacet">REST API Reference for CreateFacet Operation</seealso>
        public Task<CreateFacetResponse> CreateFacetAsync(CreateFacetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateFacetRequestMarshaller();
            var unmarshaller = CreateFacetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFacetRequest,CreateFacetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateIndex

        internal CreateIndexResponse CreateIndex(CreateIndexRequest request)
        {
            var marshaller = new CreateIndexRequestMarshaller();
            var unmarshaller = CreateIndexResponseUnmarshaller.Instance;

            return Invoke<CreateIndexRequest,CreateIndexResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateIndex operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateIndex operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/CreateIndex">REST API Reference for CreateIndex Operation</seealso>
        public Task<CreateIndexResponse> CreateIndexAsync(CreateIndexRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateIndexRequestMarshaller();
            var unmarshaller = CreateIndexResponseUnmarshaller.Instance;

            return InvokeAsync<CreateIndexRequest,CreateIndexResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateObject

        internal CreateObjectResponse CreateObject(CreateObjectRequest request)
        {
            var marshaller = new CreateObjectRequestMarshaller();
            var unmarshaller = CreateObjectResponseUnmarshaller.Instance;

            return Invoke<CreateObjectRequest,CreateObjectResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateObject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateObject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/CreateObject">REST API Reference for CreateObject Operation</seealso>
        public Task<CreateObjectResponse> CreateObjectAsync(CreateObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateObjectRequestMarshaller();
            var unmarshaller = CreateObjectResponseUnmarshaller.Instance;

            return InvokeAsync<CreateObjectRequest,CreateObjectResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateSchema

        internal CreateSchemaResponse CreateSchema(CreateSchemaRequest request)
        {
            var marshaller = new CreateSchemaRequestMarshaller();
            var unmarshaller = CreateSchemaResponseUnmarshaller.Instance;

            return Invoke<CreateSchemaRequest,CreateSchemaResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateSchema operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSchema operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/CreateSchema">REST API Reference for CreateSchema Operation</seealso>
        public Task<CreateSchemaResponse> CreateSchemaAsync(CreateSchemaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateSchemaRequestMarshaller();
            var unmarshaller = CreateSchemaResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSchemaRequest,CreateSchemaResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateTypedLinkFacet

        internal CreateTypedLinkFacetResponse CreateTypedLinkFacet(CreateTypedLinkFacetRequest request)
        {
            var marshaller = new CreateTypedLinkFacetRequestMarshaller();
            var unmarshaller = CreateTypedLinkFacetResponseUnmarshaller.Instance;

            return Invoke<CreateTypedLinkFacetRequest,CreateTypedLinkFacetResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateTypedLinkFacet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTypedLinkFacet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/CreateTypedLinkFacet">REST API Reference for CreateTypedLinkFacet Operation</seealso>
        public Task<CreateTypedLinkFacetResponse> CreateTypedLinkFacetAsync(CreateTypedLinkFacetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateTypedLinkFacetRequestMarshaller();
            var unmarshaller = CreateTypedLinkFacetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTypedLinkFacetRequest,CreateTypedLinkFacetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteDirectory

        internal DeleteDirectoryResponse DeleteDirectory(DeleteDirectoryRequest request)
        {
            var marshaller = new DeleteDirectoryRequestMarshaller();
            var unmarshaller = DeleteDirectoryResponseUnmarshaller.Instance;

            return Invoke<DeleteDirectoryRequest,DeleteDirectoryResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDirectory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDirectory operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DeleteDirectory">REST API Reference for DeleteDirectory Operation</seealso>
        public Task<DeleteDirectoryResponse> DeleteDirectoryAsync(DeleteDirectoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteDirectoryRequestMarshaller();
            var unmarshaller = DeleteDirectoryResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDirectoryRequest,DeleteDirectoryResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteFacet

        internal DeleteFacetResponse DeleteFacet(DeleteFacetRequest request)
        {
            var marshaller = new DeleteFacetRequestMarshaller();
            var unmarshaller = DeleteFacetResponseUnmarshaller.Instance;

            return Invoke<DeleteFacetRequest,DeleteFacetResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFacet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFacet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DeleteFacet">REST API Reference for DeleteFacet Operation</seealso>
        public Task<DeleteFacetResponse> DeleteFacetAsync(DeleteFacetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteFacetRequestMarshaller();
            var unmarshaller = DeleteFacetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFacetRequest,DeleteFacetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteObject

        internal DeleteObjectResponse DeleteObject(DeleteObjectRequest request)
        {
            var marshaller = new DeleteObjectRequestMarshaller();
            var unmarshaller = DeleteObjectResponseUnmarshaller.Instance;

            return Invoke<DeleteObjectRequest,DeleteObjectResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteObject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteObject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DeleteObject">REST API Reference for DeleteObject Operation</seealso>
        public Task<DeleteObjectResponse> DeleteObjectAsync(DeleteObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteObjectRequestMarshaller();
            var unmarshaller = DeleteObjectResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteObjectRequest,DeleteObjectResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteSchema

        internal DeleteSchemaResponse DeleteSchema(DeleteSchemaRequest request)
        {
            var marshaller = new DeleteSchemaRequestMarshaller();
            var unmarshaller = DeleteSchemaResponseUnmarshaller.Instance;

            return Invoke<DeleteSchemaRequest,DeleteSchemaResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSchema operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSchema operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DeleteSchema">REST API Reference for DeleteSchema Operation</seealso>
        public Task<DeleteSchemaResponse> DeleteSchemaAsync(DeleteSchemaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteSchemaRequestMarshaller();
            var unmarshaller = DeleteSchemaResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSchemaRequest,DeleteSchemaResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteTypedLinkFacet

        internal DeleteTypedLinkFacetResponse DeleteTypedLinkFacet(DeleteTypedLinkFacetRequest request)
        {
            var marshaller = new DeleteTypedLinkFacetRequestMarshaller();
            var unmarshaller = DeleteTypedLinkFacetResponseUnmarshaller.Instance;

            return Invoke<DeleteTypedLinkFacetRequest,DeleteTypedLinkFacetResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTypedLinkFacet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTypedLinkFacet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DeleteTypedLinkFacet">REST API Reference for DeleteTypedLinkFacet Operation</seealso>
        public Task<DeleteTypedLinkFacetResponse> DeleteTypedLinkFacetAsync(DeleteTypedLinkFacetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteTypedLinkFacetRequestMarshaller();
            var unmarshaller = DeleteTypedLinkFacetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTypedLinkFacetRequest,DeleteTypedLinkFacetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DetachFromIndex

        internal DetachFromIndexResponse DetachFromIndex(DetachFromIndexRequest request)
        {
            var marshaller = new DetachFromIndexRequestMarshaller();
            var unmarshaller = DetachFromIndexResponseUnmarshaller.Instance;

            return Invoke<DetachFromIndexRequest,DetachFromIndexResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DetachFromIndex operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachFromIndex operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DetachFromIndex">REST API Reference for DetachFromIndex Operation</seealso>
        public Task<DetachFromIndexResponse> DetachFromIndexAsync(DetachFromIndexRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DetachFromIndexRequestMarshaller();
            var unmarshaller = DetachFromIndexResponseUnmarshaller.Instance;

            return InvokeAsync<DetachFromIndexRequest,DetachFromIndexResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DetachObject

        internal DetachObjectResponse DetachObject(DetachObjectRequest request)
        {
            var marshaller = new DetachObjectRequestMarshaller();
            var unmarshaller = DetachObjectResponseUnmarshaller.Instance;

            return Invoke<DetachObjectRequest,DetachObjectResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DetachObject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachObject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DetachObject">REST API Reference for DetachObject Operation</seealso>
        public Task<DetachObjectResponse> DetachObjectAsync(DetachObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DetachObjectRequestMarshaller();
            var unmarshaller = DetachObjectResponseUnmarshaller.Instance;

            return InvokeAsync<DetachObjectRequest,DetachObjectResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DetachPolicy

        internal DetachPolicyResponse DetachPolicy(DetachPolicyRequest request)
        {
            var marshaller = new DetachPolicyRequestMarshaller();
            var unmarshaller = DetachPolicyResponseUnmarshaller.Instance;

            return Invoke<DetachPolicyRequest,DetachPolicyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DetachPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DetachPolicy">REST API Reference for DetachPolicy Operation</seealso>
        public Task<DetachPolicyResponse> DetachPolicyAsync(DetachPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DetachPolicyRequestMarshaller();
            var unmarshaller = DetachPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DetachPolicyRequest,DetachPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DetachTypedLink

        internal DetachTypedLinkResponse DetachTypedLink(DetachTypedLinkRequest request)
        {
            var marshaller = new DetachTypedLinkRequestMarshaller();
            var unmarshaller = DetachTypedLinkResponseUnmarshaller.Instance;

            return Invoke<DetachTypedLinkRequest,DetachTypedLinkResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DetachTypedLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachTypedLink operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DetachTypedLink">REST API Reference for DetachTypedLink Operation</seealso>
        public Task<DetachTypedLinkResponse> DetachTypedLinkAsync(DetachTypedLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DetachTypedLinkRequestMarshaller();
            var unmarshaller = DetachTypedLinkResponseUnmarshaller.Instance;

            return InvokeAsync<DetachTypedLinkRequest,DetachTypedLinkResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisableDirectory

        internal DisableDirectoryResponse DisableDirectory(DisableDirectoryRequest request)
        {
            var marshaller = new DisableDirectoryRequestMarshaller();
            var unmarshaller = DisableDirectoryResponseUnmarshaller.Instance;

            return Invoke<DisableDirectoryRequest,DisableDirectoryResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DisableDirectory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableDirectory operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DisableDirectory">REST API Reference for DisableDirectory Operation</seealso>
        public Task<DisableDirectoryResponse> DisableDirectoryAsync(DisableDirectoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DisableDirectoryRequestMarshaller();
            var unmarshaller = DisableDirectoryResponseUnmarshaller.Instance;

            return InvokeAsync<DisableDirectoryRequest,DisableDirectoryResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  EnableDirectory

        internal EnableDirectoryResponse EnableDirectory(EnableDirectoryRequest request)
        {
            var marshaller = new EnableDirectoryRequestMarshaller();
            var unmarshaller = EnableDirectoryResponseUnmarshaller.Instance;

            return Invoke<EnableDirectoryRequest,EnableDirectoryResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the EnableDirectory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableDirectory operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/EnableDirectory">REST API Reference for EnableDirectory Operation</seealso>
        public Task<EnableDirectoryResponse> EnableDirectoryAsync(EnableDirectoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new EnableDirectoryRequestMarshaller();
            var unmarshaller = EnableDirectoryResponseUnmarshaller.Instance;

            return InvokeAsync<EnableDirectoryRequest,EnableDirectoryResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDirectory

        internal GetDirectoryResponse GetDirectory(GetDirectoryRequest request)
        {
            var marshaller = new GetDirectoryRequestMarshaller();
            var unmarshaller = GetDirectoryResponseUnmarshaller.Instance;

            return Invoke<GetDirectoryRequest,GetDirectoryResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetDirectory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDirectory operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/GetDirectory">REST API Reference for GetDirectory Operation</seealso>
        public Task<GetDirectoryResponse> GetDirectoryAsync(GetDirectoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetDirectoryRequestMarshaller();
            var unmarshaller = GetDirectoryResponseUnmarshaller.Instance;

            return InvokeAsync<GetDirectoryRequest,GetDirectoryResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetFacet

        internal GetFacetResponse GetFacet(GetFacetRequest request)
        {
            var marshaller = new GetFacetRequestMarshaller();
            var unmarshaller = GetFacetResponseUnmarshaller.Instance;

            return Invoke<GetFacetRequest,GetFacetResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetFacet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFacet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/GetFacet">REST API Reference for GetFacet Operation</seealso>
        public Task<GetFacetResponse> GetFacetAsync(GetFacetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetFacetRequestMarshaller();
            var unmarshaller = GetFacetResponseUnmarshaller.Instance;

            return InvokeAsync<GetFacetRequest,GetFacetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetObjectInformation

        internal GetObjectInformationResponse GetObjectInformation(GetObjectInformationRequest request)
        {
            var marshaller = new GetObjectInformationRequestMarshaller();
            var unmarshaller = GetObjectInformationResponseUnmarshaller.Instance;

            return Invoke<GetObjectInformationRequest,GetObjectInformationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetObjectInformation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetObjectInformation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/GetObjectInformation">REST API Reference for GetObjectInformation Operation</seealso>
        public Task<GetObjectInformationResponse> GetObjectInformationAsync(GetObjectInformationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetObjectInformationRequestMarshaller();
            var unmarshaller = GetObjectInformationResponseUnmarshaller.Instance;

            return InvokeAsync<GetObjectInformationRequest,GetObjectInformationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetSchemaAsJson

        internal GetSchemaAsJsonResponse GetSchemaAsJson(GetSchemaAsJsonRequest request)
        {
            var marshaller = new GetSchemaAsJsonRequestMarshaller();
            var unmarshaller = GetSchemaAsJsonResponseUnmarshaller.Instance;

            return Invoke<GetSchemaAsJsonRequest,GetSchemaAsJsonResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetSchemaAsJson operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSchemaAsJson operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/GetSchemaAsJson">REST API Reference for GetSchemaAsJson Operation</seealso>
        public Task<GetSchemaAsJsonResponse> GetSchemaAsJsonAsync(GetSchemaAsJsonRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetSchemaAsJsonRequestMarshaller();
            var unmarshaller = GetSchemaAsJsonResponseUnmarshaller.Instance;

            return InvokeAsync<GetSchemaAsJsonRequest,GetSchemaAsJsonResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetTypedLinkFacetInformation

        internal GetTypedLinkFacetInformationResponse GetTypedLinkFacetInformation(GetTypedLinkFacetInformationRequest request)
        {
            var marshaller = new GetTypedLinkFacetInformationRequestMarshaller();
            var unmarshaller = GetTypedLinkFacetInformationResponseUnmarshaller.Instance;

            return Invoke<GetTypedLinkFacetInformationRequest,GetTypedLinkFacetInformationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetTypedLinkFacetInformation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTypedLinkFacetInformation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/GetTypedLinkFacetInformation">REST API Reference for GetTypedLinkFacetInformation Operation</seealso>
        public Task<GetTypedLinkFacetInformationResponse> GetTypedLinkFacetInformationAsync(GetTypedLinkFacetInformationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetTypedLinkFacetInformationRequestMarshaller();
            var unmarshaller = GetTypedLinkFacetInformationResponseUnmarshaller.Instance;

            return InvokeAsync<GetTypedLinkFacetInformationRequest,GetTypedLinkFacetInformationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListAppliedSchemaArns

        internal ListAppliedSchemaArnsResponse ListAppliedSchemaArns(ListAppliedSchemaArnsRequest request)
        {
            var marshaller = new ListAppliedSchemaArnsRequestMarshaller();
            var unmarshaller = ListAppliedSchemaArnsResponseUnmarshaller.Instance;

            return Invoke<ListAppliedSchemaArnsRequest,ListAppliedSchemaArnsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListAppliedSchemaArns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAppliedSchemaArns operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListAppliedSchemaArns">REST API Reference for ListAppliedSchemaArns Operation</seealso>
        public Task<ListAppliedSchemaArnsResponse> ListAppliedSchemaArnsAsync(ListAppliedSchemaArnsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListAppliedSchemaArnsRequestMarshaller();
            var unmarshaller = ListAppliedSchemaArnsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAppliedSchemaArnsRequest,ListAppliedSchemaArnsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListAttachedIndices

        internal ListAttachedIndicesResponse ListAttachedIndices(ListAttachedIndicesRequest request)
        {
            var marshaller = new ListAttachedIndicesRequestMarshaller();
            var unmarshaller = ListAttachedIndicesResponseUnmarshaller.Instance;

            return Invoke<ListAttachedIndicesRequest,ListAttachedIndicesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListAttachedIndices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAttachedIndices operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListAttachedIndices">REST API Reference for ListAttachedIndices Operation</seealso>
        public Task<ListAttachedIndicesResponse> ListAttachedIndicesAsync(ListAttachedIndicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListAttachedIndicesRequestMarshaller();
            var unmarshaller = ListAttachedIndicesResponseUnmarshaller.Instance;

            return InvokeAsync<ListAttachedIndicesRequest,ListAttachedIndicesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListDevelopmentSchemaArns

        internal ListDevelopmentSchemaArnsResponse ListDevelopmentSchemaArns(ListDevelopmentSchemaArnsRequest request)
        {
            var marshaller = new ListDevelopmentSchemaArnsRequestMarshaller();
            var unmarshaller = ListDevelopmentSchemaArnsResponseUnmarshaller.Instance;

            return Invoke<ListDevelopmentSchemaArnsRequest,ListDevelopmentSchemaArnsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListDevelopmentSchemaArns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDevelopmentSchemaArns operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListDevelopmentSchemaArns">REST API Reference for ListDevelopmentSchemaArns Operation</seealso>
        public Task<ListDevelopmentSchemaArnsResponse> ListDevelopmentSchemaArnsAsync(ListDevelopmentSchemaArnsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListDevelopmentSchemaArnsRequestMarshaller();
            var unmarshaller = ListDevelopmentSchemaArnsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDevelopmentSchemaArnsRequest,ListDevelopmentSchemaArnsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListDirectories

        internal ListDirectoriesResponse ListDirectories(ListDirectoriesRequest request)
        {
            var marshaller = new ListDirectoriesRequestMarshaller();
            var unmarshaller = ListDirectoriesResponseUnmarshaller.Instance;

            return Invoke<ListDirectoriesRequest,ListDirectoriesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListDirectories operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDirectories operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListDirectories">REST API Reference for ListDirectories Operation</seealso>
        public Task<ListDirectoriesResponse> ListDirectoriesAsync(ListDirectoriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListDirectoriesRequestMarshaller();
            var unmarshaller = ListDirectoriesResponseUnmarshaller.Instance;

            return InvokeAsync<ListDirectoriesRequest,ListDirectoriesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListFacetAttributes

        internal ListFacetAttributesResponse ListFacetAttributes(ListFacetAttributesRequest request)
        {
            var marshaller = new ListFacetAttributesRequestMarshaller();
            var unmarshaller = ListFacetAttributesResponseUnmarshaller.Instance;

            return Invoke<ListFacetAttributesRequest,ListFacetAttributesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListFacetAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFacetAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListFacetAttributes">REST API Reference for ListFacetAttributes Operation</seealso>
        public Task<ListFacetAttributesResponse> ListFacetAttributesAsync(ListFacetAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListFacetAttributesRequestMarshaller();
            var unmarshaller = ListFacetAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<ListFacetAttributesRequest,ListFacetAttributesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListFacetNames

        internal ListFacetNamesResponse ListFacetNames(ListFacetNamesRequest request)
        {
            var marshaller = new ListFacetNamesRequestMarshaller();
            var unmarshaller = ListFacetNamesResponseUnmarshaller.Instance;

            return Invoke<ListFacetNamesRequest,ListFacetNamesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListFacetNames operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFacetNames operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListFacetNames">REST API Reference for ListFacetNames Operation</seealso>
        public Task<ListFacetNamesResponse> ListFacetNamesAsync(ListFacetNamesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListFacetNamesRequestMarshaller();
            var unmarshaller = ListFacetNamesResponseUnmarshaller.Instance;

            return InvokeAsync<ListFacetNamesRequest,ListFacetNamesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListIncomingTypedLinks

        internal ListIncomingTypedLinksResponse ListIncomingTypedLinks(ListIncomingTypedLinksRequest request)
        {
            var marshaller = new ListIncomingTypedLinksRequestMarshaller();
            var unmarshaller = ListIncomingTypedLinksResponseUnmarshaller.Instance;

            return Invoke<ListIncomingTypedLinksRequest,ListIncomingTypedLinksResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListIncomingTypedLinks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIncomingTypedLinks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListIncomingTypedLinks">REST API Reference for ListIncomingTypedLinks Operation</seealso>
        public Task<ListIncomingTypedLinksResponse> ListIncomingTypedLinksAsync(ListIncomingTypedLinksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListIncomingTypedLinksRequestMarshaller();
            var unmarshaller = ListIncomingTypedLinksResponseUnmarshaller.Instance;

            return InvokeAsync<ListIncomingTypedLinksRequest,ListIncomingTypedLinksResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListIndex

        internal ListIndexResponse ListIndex(ListIndexRequest request)
        {
            var marshaller = new ListIndexRequestMarshaller();
            var unmarshaller = ListIndexResponseUnmarshaller.Instance;

            return Invoke<ListIndexRequest,ListIndexResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListIndex operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIndex operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListIndex">REST API Reference for ListIndex Operation</seealso>
        public Task<ListIndexResponse> ListIndexAsync(ListIndexRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListIndexRequestMarshaller();
            var unmarshaller = ListIndexResponseUnmarshaller.Instance;

            return InvokeAsync<ListIndexRequest,ListIndexResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListObjectAttributes

        internal ListObjectAttributesResponse ListObjectAttributes(ListObjectAttributesRequest request)
        {
            var marshaller = new ListObjectAttributesRequestMarshaller();
            var unmarshaller = ListObjectAttributesResponseUnmarshaller.Instance;

            return Invoke<ListObjectAttributesRequest,ListObjectAttributesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListObjectAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListObjectAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListObjectAttributes">REST API Reference for ListObjectAttributes Operation</seealso>
        public Task<ListObjectAttributesResponse> ListObjectAttributesAsync(ListObjectAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListObjectAttributesRequestMarshaller();
            var unmarshaller = ListObjectAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<ListObjectAttributesRequest,ListObjectAttributesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListObjectChildren

        internal ListObjectChildrenResponse ListObjectChildren(ListObjectChildrenRequest request)
        {
            var marshaller = new ListObjectChildrenRequestMarshaller();
            var unmarshaller = ListObjectChildrenResponseUnmarshaller.Instance;

            return Invoke<ListObjectChildrenRequest,ListObjectChildrenResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListObjectChildren operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListObjectChildren operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListObjectChildren">REST API Reference for ListObjectChildren Operation</seealso>
        public Task<ListObjectChildrenResponse> ListObjectChildrenAsync(ListObjectChildrenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListObjectChildrenRequestMarshaller();
            var unmarshaller = ListObjectChildrenResponseUnmarshaller.Instance;

            return InvokeAsync<ListObjectChildrenRequest,ListObjectChildrenResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListObjectParentPaths

        internal ListObjectParentPathsResponse ListObjectParentPaths(ListObjectParentPathsRequest request)
        {
            var marshaller = new ListObjectParentPathsRequestMarshaller();
            var unmarshaller = ListObjectParentPathsResponseUnmarshaller.Instance;

            return Invoke<ListObjectParentPathsRequest,ListObjectParentPathsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListObjectParentPaths operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListObjectParentPaths operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListObjectParentPaths">REST API Reference for ListObjectParentPaths Operation</seealso>
        public Task<ListObjectParentPathsResponse> ListObjectParentPathsAsync(ListObjectParentPathsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListObjectParentPathsRequestMarshaller();
            var unmarshaller = ListObjectParentPathsResponseUnmarshaller.Instance;

            return InvokeAsync<ListObjectParentPathsRequest,ListObjectParentPathsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListObjectParents

        internal ListObjectParentsResponse ListObjectParents(ListObjectParentsRequest request)
        {
            var marshaller = new ListObjectParentsRequestMarshaller();
            var unmarshaller = ListObjectParentsResponseUnmarshaller.Instance;

            return Invoke<ListObjectParentsRequest,ListObjectParentsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListObjectParents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListObjectParents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListObjectParents">REST API Reference for ListObjectParents Operation</seealso>
        public Task<ListObjectParentsResponse> ListObjectParentsAsync(ListObjectParentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListObjectParentsRequestMarshaller();
            var unmarshaller = ListObjectParentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListObjectParentsRequest,ListObjectParentsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListObjectPolicies

        internal ListObjectPoliciesResponse ListObjectPolicies(ListObjectPoliciesRequest request)
        {
            var marshaller = new ListObjectPoliciesRequestMarshaller();
            var unmarshaller = ListObjectPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListObjectPoliciesRequest,ListObjectPoliciesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListObjectPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListObjectPolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListObjectPolicies">REST API Reference for ListObjectPolicies Operation</seealso>
        public Task<ListObjectPoliciesResponse> ListObjectPoliciesAsync(ListObjectPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListObjectPoliciesRequestMarshaller();
            var unmarshaller = ListObjectPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<ListObjectPoliciesRequest,ListObjectPoliciesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListOutgoingTypedLinks

        internal ListOutgoingTypedLinksResponse ListOutgoingTypedLinks(ListOutgoingTypedLinksRequest request)
        {
            var marshaller = new ListOutgoingTypedLinksRequestMarshaller();
            var unmarshaller = ListOutgoingTypedLinksResponseUnmarshaller.Instance;

            return Invoke<ListOutgoingTypedLinksRequest,ListOutgoingTypedLinksResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListOutgoingTypedLinks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOutgoingTypedLinks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListOutgoingTypedLinks">REST API Reference for ListOutgoingTypedLinks Operation</seealso>
        public Task<ListOutgoingTypedLinksResponse> ListOutgoingTypedLinksAsync(ListOutgoingTypedLinksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListOutgoingTypedLinksRequestMarshaller();
            var unmarshaller = ListOutgoingTypedLinksResponseUnmarshaller.Instance;

            return InvokeAsync<ListOutgoingTypedLinksRequest,ListOutgoingTypedLinksResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListPolicyAttachments

        internal ListPolicyAttachmentsResponse ListPolicyAttachments(ListPolicyAttachmentsRequest request)
        {
            var marshaller = new ListPolicyAttachmentsRequestMarshaller();
            var unmarshaller = ListPolicyAttachmentsResponseUnmarshaller.Instance;

            return Invoke<ListPolicyAttachmentsRequest,ListPolicyAttachmentsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListPolicyAttachments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPolicyAttachments operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListPolicyAttachments">REST API Reference for ListPolicyAttachments Operation</seealso>
        public Task<ListPolicyAttachmentsResponse> ListPolicyAttachmentsAsync(ListPolicyAttachmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListPolicyAttachmentsRequestMarshaller();
            var unmarshaller = ListPolicyAttachmentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPolicyAttachmentsRequest,ListPolicyAttachmentsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListPublishedSchemaArns

        internal ListPublishedSchemaArnsResponse ListPublishedSchemaArns(ListPublishedSchemaArnsRequest request)
        {
            var marshaller = new ListPublishedSchemaArnsRequestMarshaller();
            var unmarshaller = ListPublishedSchemaArnsResponseUnmarshaller.Instance;

            return Invoke<ListPublishedSchemaArnsRequest,ListPublishedSchemaArnsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListPublishedSchemaArns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPublishedSchemaArns operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListPublishedSchemaArns">REST API Reference for ListPublishedSchemaArns Operation</seealso>
        public Task<ListPublishedSchemaArnsResponse> ListPublishedSchemaArnsAsync(ListPublishedSchemaArnsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListPublishedSchemaArnsRequestMarshaller();
            var unmarshaller = ListPublishedSchemaArnsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPublishedSchemaArnsRequest,ListPublishedSchemaArnsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource

        internal ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var marshaller = new ListTagsForResourceRequestMarshaller();
            var unmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceRequest,ListTagsForResourceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListTagsForResourceRequestMarshaller();
            var unmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceRequest,ListTagsForResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListTypedLinkFacetAttributes

        internal ListTypedLinkFacetAttributesResponse ListTypedLinkFacetAttributes(ListTypedLinkFacetAttributesRequest request)
        {
            var marshaller = new ListTypedLinkFacetAttributesRequestMarshaller();
            var unmarshaller = ListTypedLinkFacetAttributesResponseUnmarshaller.Instance;

            return Invoke<ListTypedLinkFacetAttributesRequest,ListTypedLinkFacetAttributesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListTypedLinkFacetAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTypedLinkFacetAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListTypedLinkFacetAttributes">REST API Reference for ListTypedLinkFacetAttributes Operation</seealso>
        public Task<ListTypedLinkFacetAttributesResponse> ListTypedLinkFacetAttributesAsync(ListTypedLinkFacetAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListTypedLinkFacetAttributesRequestMarshaller();
            var unmarshaller = ListTypedLinkFacetAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<ListTypedLinkFacetAttributesRequest,ListTypedLinkFacetAttributesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListTypedLinkFacetNames

        internal ListTypedLinkFacetNamesResponse ListTypedLinkFacetNames(ListTypedLinkFacetNamesRequest request)
        {
            var marshaller = new ListTypedLinkFacetNamesRequestMarshaller();
            var unmarshaller = ListTypedLinkFacetNamesResponseUnmarshaller.Instance;

            return Invoke<ListTypedLinkFacetNamesRequest,ListTypedLinkFacetNamesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListTypedLinkFacetNames operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTypedLinkFacetNames operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListTypedLinkFacetNames">REST API Reference for ListTypedLinkFacetNames Operation</seealso>
        public Task<ListTypedLinkFacetNamesResponse> ListTypedLinkFacetNamesAsync(ListTypedLinkFacetNamesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListTypedLinkFacetNamesRequestMarshaller();
            var unmarshaller = ListTypedLinkFacetNamesResponseUnmarshaller.Instance;

            return InvokeAsync<ListTypedLinkFacetNamesRequest,ListTypedLinkFacetNamesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  LookupPolicy

        internal LookupPolicyResponse LookupPolicy(LookupPolicyRequest request)
        {
            var marshaller = new LookupPolicyRequestMarshaller();
            var unmarshaller = LookupPolicyResponseUnmarshaller.Instance;

            return Invoke<LookupPolicyRequest,LookupPolicyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the LookupPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the LookupPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/LookupPolicy">REST API Reference for LookupPolicy Operation</seealso>
        public Task<LookupPolicyResponse> LookupPolicyAsync(LookupPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new LookupPolicyRequestMarshaller();
            var unmarshaller = LookupPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<LookupPolicyRequest,LookupPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PublishSchema

        internal PublishSchemaResponse PublishSchema(PublishSchemaRequest request)
        {
            var marshaller = new PublishSchemaRequestMarshaller();
            var unmarshaller = PublishSchemaResponseUnmarshaller.Instance;

            return Invoke<PublishSchemaRequest,PublishSchemaResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PublishSchema operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PublishSchema operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/PublishSchema">REST API Reference for PublishSchema Operation</seealso>
        public Task<PublishSchemaResponse> PublishSchemaAsync(PublishSchemaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PublishSchemaRequestMarshaller();
            var unmarshaller = PublishSchemaResponseUnmarshaller.Instance;

            return InvokeAsync<PublishSchemaRequest,PublishSchemaResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutSchemaFromJson

        internal PutSchemaFromJsonResponse PutSchemaFromJson(PutSchemaFromJsonRequest request)
        {
            var marshaller = new PutSchemaFromJsonRequestMarshaller();
            var unmarshaller = PutSchemaFromJsonResponseUnmarshaller.Instance;

            return Invoke<PutSchemaFromJsonRequest,PutSchemaFromJsonResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutSchemaFromJson operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutSchemaFromJson operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/PutSchemaFromJson">REST API Reference for PutSchemaFromJson Operation</seealso>
        public Task<PutSchemaFromJsonResponse> PutSchemaFromJsonAsync(PutSchemaFromJsonRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutSchemaFromJsonRequestMarshaller();
            var unmarshaller = PutSchemaFromJsonResponseUnmarshaller.Instance;

            return InvokeAsync<PutSchemaFromJsonRequest,PutSchemaFromJsonResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RemoveFacetFromObject

        internal RemoveFacetFromObjectResponse RemoveFacetFromObject(RemoveFacetFromObjectRequest request)
        {
            var marshaller = new RemoveFacetFromObjectRequestMarshaller();
            var unmarshaller = RemoveFacetFromObjectResponseUnmarshaller.Instance;

            return Invoke<RemoveFacetFromObjectRequest,RemoveFacetFromObjectResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RemoveFacetFromObject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveFacetFromObject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/RemoveFacetFromObject">REST API Reference for RemoveFacetFromObject Operation</seealso>
        public Task<RemoveFacetFromObjectResponse> RemoveFacetFromObjectAsync(RemoveFacetFromObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RemoveFacetFromObjectRequestMarshaller();
            var unmarshaller = RemoveFacetFromObjectResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveFacetFromObjectRequest,RemoveFacetFromObjectResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  TagResource

        internal TagResourceResponse TagResource(TagResourceRequest request)
        {
            var marshaller = new TagResourceRequestMarshaller();
            var unmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceRequest,TagResourceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        public Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new TagResourceRequestMarshaller();
            var unmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceRequest,TagResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UntagResource

        internal UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var marshaller = new UntagResourceRequestMarshaller();
            var unmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceRequest,UntagResourceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UntagResourceRequestMarshaller();
            var unmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceRequest,UntagResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateFacet

        internal UpdateFacetResponse UpdateFacet(UpdateFacetRequest request)
        {
            var marshaller = new UpdateFacetRequestMarshaller();
            var unmarshaller = UpdateFacetResponseUnmarshaller.Instance;

            return Invoke<UpdateFacetRequest,UpdateFacetResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFacet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFacet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/UpdateFacet">REST API Reference for UpdateFacet Operation</seealso>
        public Task<UpdateFacetResponse> UpdateFacetAsync(UpdateFacetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateFacetRequestMarshaller();
            var unmarshaller = UpdateFacetResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFacetRequest,UpdateFacetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateObjectAttributes

        internal UpdateObjectAttributesResponse UpdateObjectAttributes(UpdateObjectAttributesRequest request)
        {
            var marshaller = new UpdateObjectAttributesRequestMarshaller();
            var unmarshaller = UpdateObjectAttributesResponseUnmarshaller.Instance;

            return Invoke<UpdateObjectAttributesRequest,UpdateObjectAttributesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateObjectAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateObjectAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/UpdateObjectAttributes">REST API Reference for UpdateObjectAttributes Operation</seealso>
        public Task<UpdateObjectAttributesResponse> UpdateObjectAttributesAsync(UpdateObjectAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateObjectAttributesRequestMarshaller();
            var unmarshaller = UpdateObjectAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateObjectAttributesRequest,UpdateObjectAttributesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateSchema

        internal UpdateSchemaResponse UpdateSchema(UpdateSchemaRequest request)
        {
            var marshaller = new UpdateSchemaRequestMarshaller();
            var unmarshaller = UpdateSchemaResponseUnmarshaller.Instance;

            return Invoke<UpdateSchemaRequest,UpdateSchemaResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSchema operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSchema operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/UpdateSchema">REST API Reference for UpdateSchema Operation</seealso>
        public Task<UpdateSchemaResponse> UpdateSchemaAsync(UpdateSchemaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateSchemaRequestMarshaller();
            var unmarshaller = UpdateSchemaResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSchemaRequest,UpdateSchemaResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateTypedLinkFacet

        internal UpdateTypedLinkFacetResponse UpdateTypedLinkFacet(UpdateTypedLinkFacetRequest request)
        {
            var marshaller = new UpdateTypedLinkFacetRequestMarshaller();
            var unmarshaller = UpdateTypedLinkFacetResponseUnmarshaller.Instance;

            return Invoke<UpdateTypedLinkFacetRequest,UpdateTypedLinkFacetResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTypedLinkFacet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTypedLinkFacet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/UpdateTypedLinkFacet">REST API Reference for UpdateTypedLinkFacet Operation</seealso>
        public Task<UpdateTypedLinkFacetResponse> UpdateTypedLinkFacetAsync(UpdateTypedLinkFacetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateTypedLinkFacetRequestMarshaller();
            var unmarshaller = UpdateTypedLinkFacetResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTypedLinkFacetRequest,UpdateTypedLinkFacetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}