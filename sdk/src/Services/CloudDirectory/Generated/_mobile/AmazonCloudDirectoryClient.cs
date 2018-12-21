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
 * Do not modify this file. This file is generated from the clouddirectory-2017-01-11.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.CloudDirectory.Model;
using Amazon.CloudDirectory.Model.Internal.MarshallTransformations;
using Amazon.CloudDirectory.Internal;
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
    /// Cloud Directory features, see <a href="https://aws.amazon.com/directoryservice/">AWS
    /// Directory Service</a> and the <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/what_is_cloud_directory.html">Amazon
    /// Cloud Directory Developer Guide</a>.
    /// </para>
    /// </summary>
    public partial class AmazonCloudDirectoryClient : AmazonServiceClient, IAmazonCloudDirectory
    {
        private static IServiceMetadata serviceMetadata = new AmazonCloudDirectoryMetadata();
        
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


        #region  AddFacetToObject

        internal virtual AddFacetToObjectResponse AddFacetToObject(AddFacetToObjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddFacetToObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddFacetToObjectResponseUnmarshaller.Instance;

            return Invoke<AddFacetToObjectResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/AddFacetToObject">REST API Reference for AddFacetToObject Operation</seealso>
        public virtual Task<AddFacetToObjectResponse> AddFacetToObjectAsync(AddFacetToObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddFacetToObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddFacetToObjectResponseUnmarshaller.Instance;

            return InvokeAsync<AddFacetToObjectResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ApplySchema

        internal virtual ApplySchemaResponse ApplySchema(ApplySchemaRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ApplySchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ApplySchemaResponseUnmarshaller.Instance;

            return Invoke<ApplySchemaResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ApplySchema">REST API Reference for ApplySchema Operation</seealso>
        public virtual Task<ApplySchemaResponse> ApplySchemaAsync(ApplySchemaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ApplySchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ApplySchemaResponseUnmarshaller.Instance;

            return InvokeAsync<ApplySchemaResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AttachObject

        internal virtual AttachObjectResponse AttachObject(AttachObjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachObjectResponseUnmarshaller.Instance;

            return Invoke<AttachObjectResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/AttachObject">REST API Reference for AttachObject Operation</seealso>
        public virtual Task<AttachObjectResponse> AttachObjectAsync(AttachObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachObjectResponseUnmarshaller.Instance;

            return InvokeAsync<AttachObjectResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AttachPolicy

        internal virtual AttachPolicyResponse AttachPolicy(AttachPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachPolicyResponseUnmarshaller.Instance;

            return Invoke<AttachPolicyResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/AttachPolicy">REST API Reference for AttachPolicy Operation</seealso>
        public virtual Task<AttachPolicyResponse> AttachPolicyAsync(AttachPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<AttachPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AttachToIndex

        internal virtual AttachToIndexResponse AttachToIndex(AttachToIndexRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachToIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachToIndexResponseUnmarshaller.Instance;

            return Invoke<AttachToIndexResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/AttachToIndex">REST API Reference for AttachToIndex Operation</seealso>
        public virtual Task<AttachToIndexResponse> AttachToIndexAsync(AttachToIndexRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachToIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachToIndexResponseUnmarshaller.Instance;

            return InvokeAsync<AttachToIndexResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AttachTypedLink

        internal virtual AttachTypedLinkResponse AttachTypedLink(AttachTypedLinkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachTypedLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachTypedLinkResponseUnmarshaller.Instance;

            return Invoke<AttachTypedLinkResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/AttachTypedLink">REST API Reference for AttachTypedLink Operation</seealso>
        public virtual Task<AttachTypedLinkResponse> AttachTypedLinkAsync(AttachTypedLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachTypedLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachTypedLinkResponseUnmarshaller.Instance;

            return InvokeAsync<AttachTypedLinkResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchRead

        internal virtual BatchReadResponse BatchRead(BatchReadRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchReadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchReadResponseUnmarshaller.Instance;

            return Invoke<BatchReadResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/BatchRead">REST API Reference for BatchRead Operation</seealso>
        public virtual Task<BatchReadResponse> BatchReadAsync(BatchReadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchReadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchReadResponseUnmarshaller.Instance;

            return InvokeAsync<BatchReadResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchWrite

        internal virtual BatchWriteResponse BatchWrite(BatchWriteRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchWriteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchWriteResponseUnmarshaller.Instance;

            return Invoke<BatchWriteResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/BatchWrite">REST API Reference for BatchWrite Operation</seealso>
        public virtual Task<BatchWriteResponse> BatchWriteAsync(BatchWriteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchWriteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchWriteResponseUnmarshaller.Instance;

            return InvokeAsync<BatchWriteResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDirectory

        internal virtual CreateDirectoryResponse CreateDirectory(CreateDirectoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDirectoryResponseUnmarshaller.Instance;

            return Invoke<CreateDirectoryResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/CreateDirectory">REST API Reference for CreateDirectory Operation</seealso>
        public virtual Task<CreateDirectoryResponse> CreateDirectoryAsync(CreateDirectoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDirectoryResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDirectoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateFacet

        internal virtual CreateFacetResponse CreateFacet(CreateFacetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFacetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFacetResponseUnmarshaller.Instance;

            return Invoke<CreateFacetResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/CreateFacet">REST API Reference for CreateFacet Operation</seealso>
        public virtual Task<CreateFacetResponse> CreateFacetAsync(CreateFacetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFacetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFacetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFacetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateIndex

        internal virtual CreateIndexResponse CreateIndex(CreateIndexRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the CreateIndex operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/CreateIndex">REST API Reference for CreateIndex Operation</seealso>
        public virtual Task<CreateIndexResponse> CreateIndexAsync(CreateIndexRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIndexResponseUnmarshaller.Instance;

            return InvokeAsync<CreateIndexResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateObject

        internal virtual CreateObjectResponse CreateObject(CreateObjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateObjectResponseUnmarshaller.Instance;

            return Invoke<CreateObjectResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/CreateObject">REST API Reference for CreateObject Operation</seealso>
        public virtual Task<CreateObjectResponse> CreateObjectAsync(CreateObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateObjectResponseUnmarshaller.Instance;

            return InvokeAsync<CreateObjectResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSchema

        internal virtual CreateSchemaResponse CreateSchema(CreateSchemaRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSchemaResponseUnmarshaller.Instance;

            return Invoke<CreateSchemaResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/CreateSchema">REST API Reference for CreateSchema Operation</seealso>
        public virtual Task<CreateSchemaResponse> CreateSchemaAsync(CreateSchemaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSchemaResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSchemaResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateTypedLinkFacet

        internal virtual CreateTypedLinkFacetResponse CreateTypedLinkFacet(CreateTypedLinkFacetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTypedLinkFacetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTypedLinkFacetResponseUnmarshaller.Instance;

            return Invoke<CreateTypedLinkFacetResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/CreateTypedLinkFacet">REST API Reference for CreateTypedLinkFacet Operation</seealso>
        public virtual Task<CreateTypedLinkFacetResponse> CreateTypedLinkFacetAsync(CreateTypedLinkFacetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTypedLinkFacetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTypedLinkFacetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTypedLinkFacetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDirectory

        internal virtual DeleteDirectoryResponse DeleteDirectory(DeleteDirectoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDirectoryResponseUnmarshaller.Instance;

            return Invoke<DeleteDirectoryResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/DeleteDirectory">REST API Reference for DeleteDirectory Operation</seealso>
        public virtual Task<DeleteDirectoryResponse> DeleteDirectoryAsync(DeleteDirectoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDirectoryResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDirectoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteFacet

        internal virtual DeleteFacetResponse DeleteFacet(DeleteFacetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFacetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFacetResponseUnmarshaller.Instance;

            return Invoke<DeleteFacetResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/DeleteFacet">REST API Reference for DeleteFacet Operation</seealso>
        public virtual Task<DeleteFacetResponse> DeleteFacetAsync(DeleteFacetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFacetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFacetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFacetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteObject

        internal virtual DeleteObjectResponse DeleteObject(DeleteObjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteObjectResponseUnmarshaller.Instance;

            return Invoke<DeleteObjectResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/DeleteObject">REST API Reference for DeleteObject Operation</seealso>
        public virtual Task<DeleteObjectResponse> DeleteObjectAsync(DeleteObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteObjectResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteObjectResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSchema

        internal virtual DeleteSchemaResponse DeleteSchema(DeleteSchemaRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSchemaResponseUnmarshaller.Instance;

            return Invoke<DeleteSchemaResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/DeleteSchema">REST API Reference for DeleteSchema Operation</seealso>
        public virtual Task<DeleteSchemaResponse> DeleteSchemaAsync(DeleteSchemaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSchemaResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSchemaResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteTypedLinkFacet

        internal virtual DeleteTypedLinkFacetResponse DeleteTypedLinkFacet(DeleteTypedLinkFacetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTypedLinkFacetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTypedLinkFacetResponseUnmarshaller.Instance;

            return Invoke<DeleteTypedLinkFacetResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/DeleteTypedLinkFacet">REST API Reference for DeleteTypedLinkFacet Operation</seealso>
        public virtual Task<DeleteTypedLinkFacetResponse> DeleteTypedLinkFacetAsync(DeleteTypedLinkFacetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTypedLinkFacetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTypedLinkFacetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTypedLinkFacetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetachFromIndex

        internal virtual DetachFromIndexResponse DetachFromIndex(DetachFromIndexRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachFromIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachFromIndexResponseUnmarshaller.Instance;

            return Invoke<DetachFromIndexResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/DetachFromIndex">REST API Reference for DetachFromIndex Operation</seealso>
        public virtual Task<DetachFromIndexResponse> DetachFromIndexAsync(DetachFromIndexRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachFromIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachFromIndexResponseUnmarshaller.Instance;

            return InvokeAsync<DetachFromIndexResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetachObject

        internal virtual DetachObjectResponse DetachObject(DetachObjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachObjectResponseUnmarshaller.Instance;

            return Invoke<DetachObjectResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/DetachObject">REST API Reference for DetachObject Operation</seealso>
        public virtual Task<DetachObjectResponse> DetachObjectAsync(DetachObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachObjectResponseUnmarshaller.Instance;

            return InvokeAsync<DetachObjectResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetachPolicy

        internal virtual DetachPolicyResponse DetachPolicy(DetachPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachPolicyResponseUnmarshaller.Instance;

            return Invoke<DetachPolicyResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/DetachPolicy">REST API Reference for DetachPolicy Operation</seealso>
        public virtual Task<DetachPolicyResponse> DetachPolicyAsync(DetachPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DetachPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetachTypedLink

        internal virtual DetachTypedLinkResponse DetachTypedLink(DetachTypedLinkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachTypedLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachTypedLinkResponseUnmarshaller.Instance;

            return Invoke<DetachTypedLinkResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/DetachTypedLink">REST API Reference for DetachTypedLink Operation</seealso>
        public virtual Task<DetachTypedLinkResponse> DetachTypedLinkAsync(DetachTypedLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachTypedLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachTypedLinkResponseUnmarshaller.Instance;

            return InvokeAsync<DetachTypedLinkResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisableDirectory

        internal virtual DisableDirectoryResponse DisableDirectory(DisableDirectoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableDirectoryResponseUnmarshaller.Instance;

            return Invoke<DisableDirectoryResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/DisableDirectory">REST API Reference for DisableDirectory Operation</seealso>
        public virtual Task<DisableDirectoryResponse> DisableDirectoryAsync(DisableDirectoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableDirectoryResponseUnmarshaller.Instance;

            return InvokeAsync<DisableDirectoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EnableDirectory

        internal virtual EnableDirectoryResponse EnableDirectory(EnableDirectoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableDirectoryResponseUnmarshaller.Instance;

            return Invoke<EnableDirectoryResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/EnableDirectory">REST API Reference for EnableDirectory Operation</seealso>
        public virtual Task<EnableDirectoryResponse> EnableDirectoryAsync(EnableDirectoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableDirectoryResponseUnmarshaller.Instance;

            return InvokeAsync<EnableDirectoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAppliedSchemaVersion

        internal virtual GetAppliedSchemaVersionResponse GetAppliedSchemaVersion(GetAppliedSchemaVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAppliedSchemaVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAppliedSchemaVersionResponseUnmarshaller.Instance;

            return Invoke<GetAppliedSchemaVersionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetAppliedSchemaVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAppliedSchemaVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/GetAppliedSchemaVersion">REST API Reference for GetAppliedSchemaVersion Operation</seealso>
        public virtual Task<GetAppliedSchemaVersionResponse> GetAppliedSchemaVersionAsync(GetAppliedSchemaVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAppliedSchemaVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAppliedSchemaVersionResponseUnmarshaller.Instance;

            return InvokeAsync<GetAppliedSchemaVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDirectory

        internal virtual GetDirectoryResponse GetDirectory(GetDirectoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDirectoryResponseUnmarshaller.Instance;

            return Invoke<GetDirectoryResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/GetDirectory">REST API Reference for GetDirectory Operation</seealso>
        public virtual Task<GetDirectoryResponse> GetDirectoryAsync(GetDirectoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDirectoryResponseUnmarshaller.Instance;

            return InvokeAsync<GetDirectoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetFacet

        internal virtual GetFacetResponse GetFacet(GetFacetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFacetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFacetResponseUnmarshaller.Instance;

            return Invoke<GetFacetResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/GetFacet">REST API Reference for GetFacet Operation</seealso>
        public virtual Task<GetFacetResponse> GetFacetAsync(GetFacetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFacetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFacetResponseUnmarshaller.Instance;

            return InvokeAsync<GetFacetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetLinkAttributes

        internal virtual GetLinkAttributesResponse GetLinkAttributes(GetLinkAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLinkAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLinkAttributesResponseUnmarshaller.Instance;

            return Invoke<GetLinkAttributesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetLinkAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLinkAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/GetLinkAttributes">REST API Reference for GetLinkAttributes Operation</seealso>
        public virtual Task<GetLinkAttributesResponse> GetLinkAttributesAsync(GetLinkAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLinkAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLinkAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<GetLinkAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetObjectAttributes

        internal virtual GetObjectAttributesResponse GetObjectAttributes(GetObjectAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetObjectAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetObjectAttributesResponseUnmarshaller.Instance;

            return Invoke<GetObjectAttributesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetObjectAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetObjectAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/GetObjectAttributes">REST API Reference for GetObjectAttributes Operation</seealso>
        public virtual Task<GetObjectAttributesResponse> GetObjectAttributesAsync(GetObjectAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetObjectAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetObjectAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<GetObjectAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetObjectInformation

        internal virtual GetObjectInformationResponse GetObjectInformation(GetObjectInformationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetObjectInformationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetObjectInformationResponseUnmarshaller.Instance;

            return Invoke<GetObjectInformationResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/GetObjectInformation">REST API Reference for GetObjectInformation Operation</seealso>
        public virtual Task<GetObjectInformationResponse> GetObjectInformationAsync(GetObjectInformationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetObjectInformationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetObjectInformationResponseUnmarshaller.Instance;

            return InvokeAsync<GetObjectInformationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSchemaAsJson

        internal virtual GetSchemaAsJsonResponse GetSchemaAsJson(GetSchemaAsJsonRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSchemaAsJsonRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSchemaAsJsonResponseUnmarshaller.Instance;

            return Invoke<GetSchemaAsJsonResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/GetSchemaAsJson">REST API Reference for GetSchemaAsJson Operation</seealso>
        public virtual Task<GetSchemaAsJsonResponse> GetSchemaAsJsonAsync(GetSchemaAsJsonRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSchemaAsJsonRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSchemaAsJsonResponseUnmarshaller.Instance;

            return InvokeAsync<GetSchemaAsJsonResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTypedLinkFacetInformation

        internal virtual GetTypedLinkFacetInformationResponse GetTypedLinkFacetInformation(GetTypedLinkFacetInformationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTypedLinkFacetInformationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTypedLinkFacetInformationResponseUnmarshaller.Instance;

            return Invoke<GetTypedLinkFacetInformationResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/GetTypedLinkFacetInformation">REST API Reference for GetTypedLinkFacetInformation Operation</seealso>
        public virtual Task<GetTypedLinkFacetInformationResponse> GetTypedLinkFacetInformationAsync(GetTypedLinkFacetInformationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTypedLinkFacetInformationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTypedLinkFacetInformationResponseUnmarshaller.Instance;

            return InvokeAsync<GetTypedLinkFacetInformationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAppliedSchemaArns

        internal virtual ListAppliedSchemaArnsResponse ListAppliedSchemaArns(ListAppliedSchemaArnsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppliedSchemaArnsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppliedSchemaArnsResponseUnmarshaller.Instance;

            return Invoke<ListAppliedSchemaArnsResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListAppliedSchemaArns">REST API Reference for ListAppliedSchemaArns Operation</seealso>
        public virtual Task<ListAppliedSchemaArnsResponse> ListAppliedSchemaArnsAsync(ListAppliedSchemaArnsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppliedSchemaArnsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppliedSchemaArnsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAppliedSchemaArnsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAttachedIndices

        internal virtual ListAttachedIndicesResponse ListAttachedIndices(ListAttachedIndicesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAttachedIndicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAttachedIndicesResponseUnmarshaller.Instance;

            return Invoke<ListAttachedIndicesResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListAttachedIndices">REST API Reference for ListAttachedIndices Operation</seealso>
        public virtual Task<ListAttachedIndicesResponse> ListAttachedIndicesAsync(ListAttachedIndicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAttachedIndicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAttachedIndicesResponseUnmarshaller.Instance;

            return InvokeAsync<ListAttachedIndicesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDevelopmentSchemaArns

        internal virtual ListDevelopmentSchemaArnsResponse ListDevelopmentSchemaArns(ListDevelopmentSchemaArnsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDevelopmentSchemaArnsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDevelopmentSchemaArnsResponseUnmarshaller.Instance;

            return Invoke<ListDevelopmentSchemaArnsResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListDevelopmentSchemaArns">REST API Reference for ListDevelopmentSchemaArns Operation</seealso>
        public virtual Task<ListDevelopmentSchemaArnsResponse> ListDevelopmentSchemaArnsAsync(ListDevelopmentSchemaArnsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDevelopmentSchemaArnsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDevelopmentSchemaArnsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDevelopmentSchemaArnsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDirectories

        internal virtual ListDirectoriesResponse ListDirectories(ListDirectoriesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDirectoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDirectoriesResponseUnmarshaller.Instance;

            return Invoke<ListDirectoriesResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListDirectories">REST API Reference for ListDirectories Operation</seealso>
        public virtual Task<ListDirectoriesResponse> ListDirectoriesAsync(ListDirectoriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDirectoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDirectoriesResponseUnmarshaller.Instance;

            return InvokeAsync<ListDirectoriesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListFacetAttributes

        internal virtual ListFacetAttributesResponse ListFacetAttributes(ListFacetAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFacetAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFacetAttributesResponseUnmarshaller.Instance;

            return Invoke<ListFacetAttributesResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListFacetAttributes">REST API Reference for ListFacetAttributes Operation</seealso>
        public virtual Task<ListFacetAttributesResponse> ListFacetAttributesAsync(ListFacetAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFacetAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFacetAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<ListFacetAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListFacetNames

        internal virtual ListFacetNamesResponse ListFacetNames(ListFacetNamesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFacetNamesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFacetNamesResponseUnmarshaller.Instance;

            return Invoke<ListFacetNamesResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListFacetNames">REST API Reference for ListFacetNames Operation</seealso>
        public virtual Task<ListFacetNamesResponse> ListFacetNamesAsync(ListFacetNamesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFacetNamesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFacetNamesResponseUnmarshaller.Instance;

            return InvokeAsync<ListFacetNamesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListIncomingTypedLinks

        internal virtual ListIncomingTypedLinksResponse ListIncomingTypedLinks(ListIncomingTypedLinksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIncomingTypedLinksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIncomingTypedLinksResponseUnmarshaller.Instance;

            return Invoke<ListIncomingTypedLinksResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListIncomingTypedLinks">REST API Reference for ListIncomingTypedLinks Operation</seealso>
        public virtual Task<ListIncomingTypedLinksResponse> ListIncomingTypedLinksAsync(ListIncomingTypedLinksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIncomingTypedLinksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIncomingTypedLinksResponseUnmarshaller.Instance;

            return InvokeAsync<ListIncomingTypedLinksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListIndex

        internal virtual ListIndexResponse ListIndex(ListIndexRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIndexResponseUnmarshaller.Instance;

            return Invoke<ListIndexResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListIndex">REST API Reference for ListIndex Operation</seealso>
        public virtual Task<ListIndexResponse> ListIndexAsync(ListIndexRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIndexResponseUnmarshaller.Instance;

            return InvokeAsync<ListIndexResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListManagedSchemaArns

        internal virtual ListManagedSchemaArnsResponse ListManagedSchemaArns(ListManagedSchemaArnsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListManagedSchemaArnsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListManagedSchemaArnsResponseUnmarshaller.Instance;

            return Invoke<ListManagedSchemaArnsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListManagedSchemaArns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListManagedSchemaArns operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListManagedSchemaArns">REST API Reference for ListManagedSchemaArns Operation</seealso>
        public virtual Task<ListManagedSchemaArnsResponse> ListManagedSchemaArnsAsync(ListManagedSchemaArnsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListManagedSchemaArnsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListManagedSchemaArnsResponseUnmarshaller.Instance;

            return InvokeAsync<ListManagedSchemaArnsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListObjectAttributes

        internal virtual ListObjectAttributesResponse ListObjectAttributes(ListObjectAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListObjectAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListObjectAttributesResponseUnmarshaller.Instance;

            return Invoke<ListObjectAttributesResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListObjectAttributes">REST API Reference for ListObjectAttributes Operation</seealso>
        public virtual Task<ListObjectAttributesResponse> ListObjectAttributesAsync(ListObjectAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListObjectAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListObjectAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<ListObjectAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListObjectChildren

        internal virtual ListObjectChildrenResponse ListObjectChildren(ListObjectChildrenRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListObjectChildrenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListObjectChildrenResponseUnmarshaller.Instance;

            return Invoke<ListObjectChildrenResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListObjectChildren">REST API Reference for ListObjectChildren Operation</seealso>
        public virtual Task<ListObjectChildrenResponse> ListObjectChildrenAsync(ListObjectChildrenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListObjectChildrenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListObjectChildrenResponseUnmarshaller.Instance;

            return InvokeAsync<ListObjectChildrenResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListObjectParentPaths

        internal virtual ListObjectParentPathsResponse ListObjectParentPaths(ListObjectParentPathsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListObjectParentPathsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListObjectParentPathsResponseUnmarshaller.Instance;

            return Invoke<ListObjectParentPathsResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListObjectParentPaths">REST API Reference for ListObjectParentPaths Operation</seealso>
        public virtual Task<ListObjectParentPathsResponse> ListObjectParentPathsAsync(ListObjectParentPathsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListObjectParentPathsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListObjectParentPathsResponseUnmarshaller.Instance;

            return InvokeAsync<ListObjectParentPathsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListObjectParents

        internal virtual ListObjectParentsResponse ListObjectParents(ListObjectParentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListObjectParentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListObjectParentsResponseUnmarshaller.Instance;

            return Invoke<ListObjectParentsResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListObjectParents">REST API Reference for ListObjectParents Operation</seealso>
        public virtual Task<ListObjectParentsResponse> ListObjectParentsAsync(ListObjectParentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListObjectParentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListObjectParentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListObjectParentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListObjectPolicies

        internal virtual ListObjectPoliciesResponse ListObjectPolicies(ListObjectPoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListObjectPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListObjectPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListObjectPoliciesResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListObjectPolicies">REST API Reference for ListObjectPolicies Operation</seealso>
        public virtual Task<ListObjectPoliciesResponse> ListObjectPoliciesAsync(ListObjectPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListObjectPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListObjectPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<ListObjectPoliciesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListOutgoingTypedLinks

        internal virtual ListOutgoingTypedLinksResponse ListOutgoingTypedLinks(ListOutgoingTypedLinksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOutgoingTypedLinksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOutgoingTypedLinksResponseUnmarshaller.Instance;

            return Invoke<ListOutgoingTypedLinksResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListOutgoingTypedLinks">REST API Reference for ListOutgoingTypedLinks Operation</seealso>
        public virtual Task<ListOutgoingTypedLinksResponse> ListOutgoingTypedLinksAsync(ListOutgoingTypedLinksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOutgoingTypedLinksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOutgoingTypedLinksResponseUnmarshaller.Instance;

            return InvokeAsync<ListOutgoingTypedLinksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPolicyAttachments

        internal virtual ListPolicyAttachmentsResponse ListPolicyAttachments(ListPolicyAttachmentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPolicyAttachmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPolicyAttachmentsResponseUnmarshaller.Instance;

            return Invoke<ListPolicyAttachmentsResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListPolicyAttachments">REST API Reference for ListPolicyAttachments Operation</seealso>
        public virtual Task<ListPolicyAttachmentsResponse> ListPolicyAttachmentsAsync(ListPolicyAttachmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPolicyAttachmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPolicyAttachmentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPolicyAttachmentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPublishedSchemaArns

        internal virtual ListPublishedSchemaArnsResponse ListPublishedSchemaArns(ListPublishedSchemaArnsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPublishedSchemaArnsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPublishedSchemaArnsResponseUnmarshaller.Instance;

            return Invoke<ListPublishedSchemaArnsResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListPublishedSchemaArns">REST API Reference for ListPublishedSchemaArns Operation</seealso>
        public virtual Task<ListPublishedSchemaArnsResponse> ListPublishedSchemaArnsAsync(ListPublishedSchemaArnsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPublishedSchemaArnsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPublishedSchemaArnsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPublishedSchemaArnsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTypedLinkFacetAttributes

        internal virtual ListTypedLinkFacetAttributesResponse ListTypedLinkFacetAttributes(ListTypedLinkFacetAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTypedLinkFacetAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTypedLinkFacetAttributesResponseUnmarshaller.Instance;

            return Invoke<ListTypedLinkFacetAttributesResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListTypedLinkFacetAttributes">REST API Reference for ListTypedLinkFacetAttributes Operation</seealso>
        public virtual Task<ListTypedLinkFacetAttributesResponse> ListTypedLinkFacetAttributesAsync(ListTypedLinkFacetAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTypedLinkFacetAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTypedLinkFacetAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<ListTypedLinkFacetAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTypedLinkFacetNames

        internal virtual ListTypedLinkFacetNamesResponse ListTypedLinkFacetNames(ListTypedLinkFacetNamesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTypedLinkFacetNamesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTypedLinkFacetNamesResponseUnmarshaller.Instance;

            return Invoke<ListTypedLinkFacetNamesResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListTypedLinkFacetNames">REST API Reference for ListTypedLinkFacetNames Operation</seealso>
        public virtual Task<ListTypedLinkFacetNamesResponse> ListTypedLinkFacetNamesAsync(ListTypedLinkFacetNamesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTypedLinkFacetNamesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTypedLinkFacetNamesResponseUnmarshaller.Instance;

            return InvokeAsync<ListTypedLinkFacetNamesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  LookupPolicy

        internal virtual LookupPolicyResponse LookupPolicy(LookupPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = LookupPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = LookupPolicyResponseUnmarshaller.Instance;

            return Invoke<LookupPolicyResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/LookupPolicy">REST API Reference for LookupPolicy Operation</seealso>
        public virtual Task<LookupPolicyResponse> LookupPolicyAsync(LookupPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = LookupPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = LookupPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<LookupPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PublishSchema

        internal virtual PublishSchemaResponse PublishSchema(PublishSchemaRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PublishSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PublishSchemaResponseUnmarshaller.Instance;

            return Invoke<PublishSchemaResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/PublishSchema">REST API Reference for PublishSchema Operation</seealso>
        public virtual Task<PublishSchemaResponse> PublishSchemaAsync(PublishSchemaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PublishSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PublishSchemaResponseUnmarshaller.Instance;

            return InvokeAsync<PublishSchemaResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutSchemaFromJson

        internal virtual PutSchemaFromJsonResponse PutSchemaFromJson(PutSchemaFromJsonRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutSchemaFromJsonRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSchemaFromJsonResponseUnmarshaller.Instance;

            return Invoke<PutSchemaFromJsonResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/PutSchemaFromJson">REST API Reference for PutSchemaFromJson Operation</seealso>
        public virtual Task<PutSchemaFromJsonResponse> PutSchemaFromJsonAsync(PutSchemaFromJsonRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutSchemaFromJsonRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSchemaFromJsonResponseUnmarshaller.Instance;

            return InvokeAsync<PutSchemaFromJsonResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RemoveFacetFromObject

        internal virtual RemoveFacetFromObjectResponse RemoveFacetFromObject(RemoveFacetFromObjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveFacetFromObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveFacetFromObjectResponseUnmarshaller.Instance;

            return Invoke<RemoveFacetFromObjectResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/RemoveFacetFromObject">REST API Reference for RemoveFacetFromObject Operation</seealso>
        public virtual Task<RemoveFacetFromObjectResponse> RemoveFacetFromObjectAsync(RemoveFacetFromObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveFacetFromObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveFacetFromObjectResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveFacetFromObjectResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateFacet

        internal virtual UpdateFacetResponse UpdateFacet(UpdateFacetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFacetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFacetResponseUnmarshaller.Instance;

            return Invoke<UpdateFacetResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/UpdateFacet">REST API Reference for UpdateFacet Operation</seealso>
        public virtual Task<UpdateFacetResponse> UpdateFacetAsync(UpdateFacetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFacetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFacetResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFacetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateLinkAttributes

        internal virtual UpdateLinkAttributesResponse UpdateLinkAttributes(UpdateLinkAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLinkAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLinkAttributesResponseUnmarshaller.Instance;

            return Invoke<UpdateLinkAttributesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLinkAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLinkAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/UpdateLinkAttributes">REST API Reference for UpdateLinkAttributes Operation</seealso>
        public virtual Task<UpdateLinkAttributesResponse> UpdateLinkAttributesAsync(UpdateLinkAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLinkAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLinkAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateLinkAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateObjectAttributes

        internal virtual UpdateObjectAttributesResponse UpdateObjectAttributes(UpdateObjectAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateObjectAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateObjectAttributesResponseUnmarshaller.Instance;

            return Invoke<UpdateObjectAttributesResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/UpdateObjectAttributes">REST API Reference for UpdateObjectAttributes Operation</seealso>
        public virtual Task<UpdateObjectAttributesResponse> UpdateObjectAttributesAsync(UpdateObjectAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateObjectAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateObjectAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateObjectAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateSchema

        internal virtual UpdateSchemaResponse UpdateSchema(UpdateSchemaRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSchemaResponseUnmarshaller.Instance;

            return Invoke<UpdateSchemaResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/UpdateSchema">REST API Reference for UpdateSchema Operation</seealso>
        public virtual Task<UpdateSchemaResponse> UpdateSchemaAsync(UpdateSchemaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSchemaResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSchemaResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateTypedLinkFacet

        internal virtual UpdateTypedLinkFacetResponse UpdateTypedLinkFacet(UpdateTypedLinkFacetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTypedLinkFacetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTypedLinkFacetResponseUnmarshaller.Instance;

            return Invoke<UpdateTypedLinkFacetResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/UpdateTypedLinkFacet">REST API Reference for UpdateTypedLinkFacet Operation</seealso>
        public virtual Task<UpdateTypedLinkFacetResponse> UpdateTypedLinkFacetAsync(UpdateTypedLinkFacetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTypedLinkFacetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTypedLinkFacetResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTypedLinkFacetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpgradeAppliedSchema

        internal virtual UpgradeAppliedSchemaResponse UpgradeAppliedSchema(UpgradeAppliedSchemaRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpgradeAppliedSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpgradeAppliedSchemaResponseUnmarshaller.Instance;

            return Invoke<UpgradeAppliedSchemaResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpgradeAppliedSchema operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpgradeAppliedSchema operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/UpgradeAppliedSchema">REST API Reference for UpgradeAppliedSchema Operation</seealso>
        public virtual Task<UpgradeAppliedSchemaResponse> UpgradeAppliedSchemaAsync(UpgradeAppliedSchemaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpgradeAppliedSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpgradeAppliedSchemaResponseUnmarshaller.Instance;

            return InvokeAsync<UpgradeAppliedSchemaResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpgradePublishedSchema

        internal virtual UpgradePublishedSchemaResponse UpgradePublishedSchema(UpgradePublishedSchemaRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpgradePublishedSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpgradePublishedSchemaResponseUnmarshaller.Instance;

            return Invoke<UpgradePublishedSchemaResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpgradePublishedSchema operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpgradePublishedSchema operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/UpgradePublishedSchema">REST API Reference for UpgradePublishedSchema Operation</seealso>
        public virtual Task<UpgradePublishedSchemaResponse> UpgradePublishedSchemaAsync(UpgradePublishedSchemaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpgradePublishedSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpgradePublishedSchemaResponseUnmarshaller.Instance;

            return InvokeAsync<UpgradePublishedSchemaResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}