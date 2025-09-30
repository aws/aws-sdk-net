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
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.CloudDirectory
{
    /// <summary>
    /// <para>Implementation for accessing CloudDirectory</para>
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
            : base(new AmazonCloudDirectoryConfig()) { }

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
            : base(new AmazonCloudDirectoryConfig{RegionEndpoint = region}) { }

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
            : base(config) { }


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
#if AWS_ASYNC_ENUMERABLES_API
        private ICloudDirectoryPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ICloudDirectoryPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new CloudDirectoryPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

        #region Overrides

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonCloudDirectoryEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonCloudDirectoryAuthSchemeHandler());
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddFacetToObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddFacetToObjectResponseUnmarshaller.Instance;

            return Invoke<AddFacetToObjectResponse>(request, options);
        }



        /// <summary>
        /// Adds a new <a>Facet</a> to an object. An object can have more than one facet applied
        /// on it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddFacetToObject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddFacetToObject service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied or directory not found. Either you don't have permissions for this directory
        /// or the directory does not exist. Try calling <a>ListDirectories</a> and check your
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// Operations are only permitted on enabled directories.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.FacetValidationException">
        /// The <a>Facet</a> that you provided was not well formed or could not be validated with
        /// the schema.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/AddFacetToObject">REST API Reference for AddFacetToObject Operation</seealso>
        public virtual Task<AddFacetToObjectResponse> AddFacetToObjectAsync(AddFacetToObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddFacetToObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddFacetToObjectResponseUnmarshaller.Instance;

            return InvokeAsync<AddFacetToObjectResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ApplySchema

        internal virtual ApplySchemaResponse ApplySchema(ApplySchemaRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ApplySchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ApplySchemaResponseUnmarshaller.Instance;

            return Invoke<ApplySchemaResponse>(request, options);
        }



        /// <summary>
        /// Copies the input published schema, at the specified version, into the <a>Directory</a>
        /// with the same name and version as that of the published schema.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ApplySchema service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ApplySchema service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied or directory not found. Either you don't have permissions for this directory
        /// or the directory does not exist. Try calling <a>ListDirectories</a> and check your
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidAttachmentException">
        /// Indicates that an attempt to make an attachment was invalid. For example, attaching
        /// two nodes with a link type that is not applicable to the nodes or attempting to apply
        /// a schema to a directory a second time.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.SchemaAlreadyExistsException">
        /// Indicates that a schema could not be created due to a naming conflict. Please select
        /// a different name and then try again.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ApplySchema">REST API Reference for ApplySchema Operation</seealso>
        public virtual Task<ApplySchemaResponse> ApplySchemaAsync(ApplySchemaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ApplySchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ApplySchemaResponseUnmarshaller.Instance;

            return InvokeAsync<ApplySchemaResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AttachObject

        internal virtual AttachObjectResponse AttachObject(AttachObjectRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AttachObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachObjectResponseUnmarshaller.Instance;

            return Invoke<AttachObjectResponse>(request, options);
        }



        /// <summary>
        /// Attaches an existing object to another object. An object can be accessed in two ways:
        /// 
        ///  <ol> <li> 
        /// <para>
        /// Using the path
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Using <c>ObjectIdentifier</c> 
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachObject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AttachObject service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied or directory not found. Either you don't have permissions for this directory
        /// or the directory does not exist. Try calling <a>ListDirectories</a> and check your
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// Operations are only permitted on enabled directories.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.FacetValidationException">
        /// The <a>Facet</a> that you provided was not well formed or could not be validated with
        /// the schema.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidAttachmentException">
        /// Indicates that an attempt to make an attachment was invalid. For example, attaching
        /// two nodes with a link type that is not applicable to the nodes or attempting to apply
        /// a schema to a directory a second time.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LinkNameAlreadyInUseException">
        /// Indicates that a link could not be created due to a naming conflict. Choose a different
        /// name and then try again.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/AttachObject">REST API Reference for AttachObject Operation</seealso>
        public virtual Task<AttachObjectResponse> AttachObjectAsync(AttachObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AttachObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachObjectResponseUnmarshaller.Instance;

            return InvokeAsync<AttachObjectResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AttachPolicy

        internal virtual AttachPolicyResponse AttachPolicy(AttachPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AttachPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachPolicyResponseUnmarshaller.Instance;

            return Invoke<AttachPolicyResponse>(request, options);
        }



        /// <summary>
        /// Attaches a policy object to a regular object. An object can have a limited number
        /// of attached policies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AttachPolicy service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied or directory not found. Either you don't have permissions for this directory
        /// or the directory does not exist. Try calling <a>ListDirectories</a> and check your
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// Operations are only permitted on enabled directories.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.NotPolicyException">
        /// Indicates that the requested operation can only operate on policy objects.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/AttachPolicy">REST API Reference for AttachPolicy Operation</seealso>
        public virtual Task<AttachPolicyResponse> AttachPolicyAsync(AttachPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AttachPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<AttachPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AttachToIndex

        internal virtual AttachToIndexResponse AttachToIndex(AttachToIndexRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AttachToIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachToIndexResponseUnmarshaller.Instance;

            return Invoke<AttachToIndexResponse>(request, options);
        }



        /// <summary>
        /// Attaches the specified object to the specified index.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachToIndex service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AttachToIndex service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied or directory not found. Either you don't have permissions for this directory
        /// or the directory does not exist. Try calling <a>ListDirectories</a> and check your
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// Operations are only permitted on enabled directories.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.IndexedAttributeMissingException">
        /// An object has been attempted to be attached to an object that does not have the appropriate
        /// attribute value.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidAttachmentException">
        /// Indicates that an attempt to make an attachment was invalid. For example, attaching
        /// two nodes with a link type that is not applicable to the nodes or attempting to apply
        /// a schema to a directory a second time.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LinkNameAlreadyInUseException">
        /// Indicates that a link could not be created due to a naming conflict. Choose a different
        /// name and then try again.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.NotIndexException">
        /// Indicates that the requested operation can only operate on index objects.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/AttachToIndex">REST API Reference for AttachToIndex Operation</seealso>
        public virtual Task<AttachToIndexResponse> AttachToIndexAsync(AttachToIndexRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AttachToIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachToIndexResponseUnmarshaller.Instance;

            return InvokeAsync<AttachToIndexResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AttachTypedLink

        internal virtual AttachTypedLinkResponse AttachTypedLink(AttachTypedLinkRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AttachTypedLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachTypedLinkResponseUnmarshaller.Instance;

            return Invoke<AttachTypedLinkResponse>(request, options);
        }



        /// <summary>
        /// Attaches a typed link to a specified source and target object. For more information,
        /// see <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/directory_objects_links.html#directory_objects_links_typedlink">Typed
        /// Links</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachTypedLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AttachTypedLink service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied or directory not found. Either you don't have permissions for this directory
        /// or the directory does not exist. Try calling <a>ListDirectories</a> and check your
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// Operations are only permitted on enabled directories.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.FacetValidationException">
        /// The <a>Facet</a> that you provided was not well formed or could not be validated with
        /// the schema.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidAttachmentException">
        /// Indicates that an attempt to make an attachment was invalid. For example, attaching
        /// two nodes with a link type that is not applicable to the nodes or attempting to apply
        /// a schema to a directory a second time.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/AttachTypedLink">REST API Reference for AttachTypedLink Operation</seealso>
        public virtual Task<AttachTypedLinkResponse> AttachTypedLinkAsync(AttachTypedLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AttachTypedLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachTypedLinkResponseUnmarshaller.Instance;

            return InvokeAsync<AttachTypedLinkResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchRead

        internal virtual BatchReadResponse BatchRead(BatchReadRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchReadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchReadResponseUnmarshaller.Instance;

            return Invoke<BatchReadResponse>(request, options);
        }



        /// <summary>
        /// Performs all the read operations in a batch.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchRead service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchRead service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied or directory not found. Either you don't have permissions for this directory
        /// or the directory does not exist. Try calling <a>ListDirectories</a> and check your
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// Operations are only permitted on enabled directories.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/BatchRead">REST API Reference for BatchRead Operation</seealso>
        public virtual Task<BatchReadResponse> BatchReadAsync(BatchReadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchReadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchReadResponseUnmarshaller.Instance;

            return InvokeAsync<BatchReadResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchWrite

        internal virtual BatchWriteResponse BatchWrite(BatchWriteRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchWriteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchWriteResponseUnmarshaller.Instance;

            return Invoke<BatchWriteResponse>(request, options);
        }



        /// <summary>
        /// Performs all the write operations in a batch. Either all the operations succeed or
        /// none.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchWrite service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchWrite service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied or directory not found. Either you don't have permissions for this directory
        /// or the directory does not exist. Try calling <a>ListDirectories</a> and check your
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.BatchWriteException">
        /// A <c>BatchWrite</c> exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// Operations are only permitted on enabled directories.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/BatchWrite">REST API Reference for BatchWrite Operation</seealso>
        public virtual Task<BatchWriteResponse> BatchWriteAsync(BatchWriteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchWriteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchWriteResponseUnmarshaller.Instance;

            return InvokeAsync<BatchWriteResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateDirectory

        internal virtual CreateDirectoryResponse CreateDirectory(CreateDirectoryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDirectoryResponseUnmarshaller.Instance;

            return Invoke<CreateDirectoryResponse>(request, options);
        }



        /// <summary>
        /// Creates a <a>Directory</a> by copying the published schema into the directory. A directory
        /// cannot be created without a schema.
        /// 
        ///  
        /// <para>
        /// You can also quickly create a directory using a managed schema, called the <c>QuickStartSchema</c>.
        /// For more information, see <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/schemas_managed.html">Managed
        /// Schema</a> in the <i>Amazon Cloud Directory Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDirectory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDirectory service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied or directory not found. Either you don't have permissions for this directory
        /// or the directory does not exist. Try calling <a>ListDirectories</a> and check your
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryAlreadyExistsException">
        /// Indicates that a <a>Directory</a> could not be created due to a naming conflict. Choose
        /// a different name and try again.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/CreateDirectory">REST API Reference for CreateDirectory Operation</seealso>
        public virtual Task<CreateDirectoryResponse> CreateDirectoryAsync(CreateDirectoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDirectoryResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDirectoryResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateFacet

        internal virtual CreateFacetResponse CreateFacet(CreateFacetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFacetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFacetResponseUnmarshaller.Instance;

            return Invoke<CreateFacetResponse>(request, options);
        }



        /// <summary>
        /// Creates a new <a>Facet</a> in a schema. Facet creation is allowed only in development
        /// or applied schemas.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFacet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFacet service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied or directory not found. Either you don't have permissions for this directory
        /// or the directory does not exist. Try calling <a>ListDirectories</a> and check your
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.FacetAlreadyExistsException">
        /// A facet with the same name already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.FacetValidationException">
        /// The <a>Facet</a> that you provided was not well formed or could not be validated with
        /// the schema.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidRuleException">
        /// Occurs when any of the rule parameter keys or values are invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/CreateFacet">REST API Reference for CreateFacet Operation</seealso>
        public virtual Task<CreateFacetResponse> CreateFacetAsync(CreateFacetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFacetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFacetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFacetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateIndex

        internal virtual CreateIndexResponse CreateIndex(CreateIndexRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIndexResponseUnmarshaller.Instance;

            return Invoke<CreateIndexResponse>(request, options);
        }



        /// <summary>
        /// Creates an index object. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/indexing_search.html">Indexing
        /// and search</a> for more information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIndex service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateIndex service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied or directory not found. Either you don't have permissions for this directory
        /// or the directory does not exist. Try calling <a>ListDirectories</a> and check your
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// Operations are only permitted on enabled directories.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.FacetValidationException">
        /// The <a>Facet</a> that you provided was not well formed or could not be validated with
        /// the schema.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LinkNameAlreadyInUseException">
        /// Indicates that a link could not be created due to a naming conflict. Choose a different
        /// name and then try again.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.UnsupportedIndexTypeException">
        /// Indicates that the requested index type is not supported.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/CreateIndex">REST API Reference for CreateIndex Operation</seealso>
        public virtual Task<CreateIndexResponse> CreateIndexAsync(CreateIndexRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIndexResponseUnmarshaller.Instance;

            return InvokeAsync<CreateIndexResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateObject

        internal virtual CreateObjectResponse CreateObject(CreateObjectRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateObjectResponseUnmarshaller.Instance;

            return Invoke<CreateObjectResponse>(request, options);
        }



        /// <summary>
        /// Creates an object in a <a>Directory</a>. Additionally attaches the object to a parent,
        /// if a parent reference and <c>LinkName</c> is specified. An object is simply a collection
        /// of <a>Facet</a> attributes. You can also use this API call to create a policy object,
        /// if the facet from which you create the object is a policy facet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateObject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateObject service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied or directory not found. Either you don't have permissions for this directory
        /// or the directory does not exist. Try calling <a>ListDirectories</a> and check your
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// Operations are only permitted on enabled directories.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.FacetValidationException">
        /// The <a>Facet</a> that you provided was not well formed or could not be validated with
        /// the schema.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LinkNameAlreadyInUseException">
        /// Indicates that a link could not be created due to a naming conflict. Choose a different
        /// name and then try again.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.UnsupportedIndexTypeException">
        /// Indicates that the requested index type is not supported.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/CreateObject">REST API Reference for CreateObject Operation</seealso>
        public virtual Task<CreateObjectResponse> CreateObjectAsync(CreateObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateObjectResponseUnmarshaller.Instance;

            return InvokeAsync<CreateObjectResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateSchema

        internal virtual CreateSchemaResponse CreateSchema(CreateSchemaRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSchemaResponseUnmarshaller.Instance;

            return Invoke<CreateSchemaResponse>(request, options);
        }



        /// <summary>
        /// Creates a new schema in a development state. A schema can exist in three phases:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <i>Development:</i> This is a mutable phase of the schema. All new schemas are in
        /// the development phase. Once the schema is finalized, it can be published.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Published:</i> Published schemas are immutable and have a version associated with
        /// them.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Applied:</i> Applied schemas are mutable in a way that allows you to add new schema
        /// facets. You can also add new, nonrequired attributes to existing schema facets. You
        /// can apply only published schemas to directories. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSchema service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSchema service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied or directory not found. Either you don't have permissions for this directory
        /// or the directory does not exist. Try calling <a>ListDirectories</a> and check your
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.SchemaAlreadyExistsException">
        /// Indicates that a schema could not be created due to a naming conflict. Please select
        /// a different name and then try again.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/CreateSchema">REST API Reference for CreateSchema Operation</seealso>
        public virtual Task<CreateSchemaResponse> CreateSchemaAsync(CreateSchemaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSchemaResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSchemaResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateTypedLinkFacet

        internal virtual CreateTypedLinkFacetResponse CreateTypedLinkFacet(CreateTypedLinkFacetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTypedLinkFacetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTypedLinkFacetResponseUnmarshaller.Instance;

            return Invoke<CreateTypedLinkFacetResponse>(request, options);
        }



        /// <summary>
        /// Creates a <a>TypedLinkFacet</a>. For more information, see <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/directory_objects_links.html#directory_objects_links_typedlink">Typed
        /// Links</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTypedLinkFacet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTypedLinkFacet service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied or directory not found. Either you don't have permissions for this directory
        /// or the directory does not exist. Try calling <a>ListDirectories</a> and check your
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.FacetAlreadyExistsException">
        /// A facet with the same name already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.FacetValidationException">
        /// The <a>Facet</a> that you provided was not well formed or could not be validated with
        /// the schema.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidRuleException">
        /// Occurs when any of the rule parameter keys or values are invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/CreateTypedLinkFacet">REST API Reference for CreateTypedLinkFacet Operation</seealso>
        public virtual Task<CreateTypedLinkFacetResponse> CreateTypedLinkFacetAsync(CreateTypedLinkFacetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTypedLinkFacetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTypedLinkFacetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTypedLinkFacetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteDirectory

        internal virtual DeleteDirectoryResponse DeleteDirectory(DeleteDirectoryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDirectoryResponseUnmarshaller.Instance;

            return Invoke<DeleteDirectoryResponse>(request, options);
        }



        /// <summary>
        /// Deletes a directory. Only disabled directories can be deleted. A deleted directory
        /// cannot be undone. Exercise extreme caution when deleting directories.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDirectory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDirectory service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied or directory not found. Either you don't have permissions for this directory
        /// or the directory does not exist. Try calling <a>ListDirectories</a> and check your
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryDeletedException">
        /// A directory that has been deleted and to which access has been attempted. Note: The
        /// requested resource will eventually cease to exist.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotDisabledException">
        /// An operation can only operate on a disabled directory.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/DeleteDirectory">REST API Reference for DeleteDirectory Operation</seealso>
        public virtual Task<DeleteDirectoryResponse> DeleteDirectoryAsync(DeleteDirectoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDirectoryResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDirectoryResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteFacet

        internal virtual DeleteFacetResponse DeleteFacet(DeleteFacetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFacetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFacetResponseUnmarshaller.Instance;

            return Invoke<DeleteFacetResponse>(request, options);
        }



        /// <summary>
        /// Deletes a given <a>Facet</a>. All attributes and <a>Rule</a>s that are associated
        /// with the facet will be deleted. Only development schema facets are allowed deletion.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFacet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFacet service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied or directory not found. Either you don't have permissions for this directory
        /// or the directory does not exist. Try calling <a>ListDirectories</a> and check your
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.FacetInUseException">
        /// Occurs when deleting a facet that contains an attribute that is a target to an attribute
        /// reference in a different facet.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.FacetNotFoundException">
        /// The specified <a>Facet</a> could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/DeleteFacet">REST API Reference for DeleteFacet Operation</seealso>
        public virtual Task<DeleteFacetResponse> DeleteFacetAsync(DeleteFacetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFacetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFacetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFacetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteObject

        internal virtual DeleteObjectResponse DeleteObject(DeleteObjectRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteObjectResponseUnmarshaller.Instance;

            return Invoke<DeleteObjectResponse>(request, options);
        }



        /// <summary>
        /// Deletes an object and its associated attributes. Only objects with no children and
        /// no parents can be deleted. The maximum number of attributes that can be deleted during
        /// an object deletion is 30. For more information, see <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/limits.html">Amazon
        /// Cloud Directory Limits</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteObject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteObject service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied or directory not found. Either you don't have permissions for this directory
        /// or the directory does not exist. Try calling <a>ListDirectories</a> and check your
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// Operations are only permitted on enabled directories.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ObjectNotDetachedException">
        /// Indicates that the requested operation cannot be completed because the object has
        /// not been detached from the tree.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/DeleteObject">REST API Reference for DeleteObject Operation</seealso>
        public virtual Task<DeleteObjectResponse> DeleteObjectAsync(DeleteObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteObjectResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteObjectResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteSchema

        internal virtual DeleteSchemaResponse DeleteSchema(DeleteSchemaRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSchemaResponseUnmarshaller.Instance;

            return Invoke<DeleteSchemaResponse>(request, options);
        }



        /// <summary>
        /// Deletes a given schema. Schemas in a development and published state can only be deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSchema service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSchema service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied or directory not found. Either you don't have permissions for this directory
        /// or the directory does not exist. Try calling <a>ListDirectories</a> and check your
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.StillContainsLinksException">
        /// The object could not be deleted because links still exist. Remove the links and then
        /// try the operation again.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/DeleteSchema">REST API Reference for DeleteSchema Operation</seealso>
        public virtual Task<DeleteSchemaResponse> DeleteSchemaAsync(DeleteSchemaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSchemaResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSchemaResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteTypedLinkFacet

        internal virtual DeleteTypedLinkFacetResponse DeleteTypedLinkFacet(DeleteTypedLinkFacetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTypedLinkFacetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTypedLinkFacetResponseUnmarshaller.Instance;

            return Invoke<DeleteTypedLinkFacetResponse>(request, options);
        }



        /// <summary>
        /// Deletes a <a>TypedLinkFacet</a>. For more information, see <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/directory_objects_links.html#directory_objects_links_typedlink">Typed
        /// Links</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTypedLinkFacet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTypedLinkFacet service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied or directory not found. Either you don't have permissions for this directory
        /// or the directory does not exist. Try calling <a>ListDirectories</a> and check your
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.FacetNotFoundException">
        /// The specified <a>Facet</a> could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/DeleteTypedLinkFacet">REST API Reference for DeleteTypedLinkFacet Operation</seealso>
        public virtual Task<DeleteTypedLinkFacetResponse> DeleteTypedLinkFacetAsync(DeleteTypedLinkFacetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTypedLinkFacetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTypedLinkFacetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTypedLinkFacetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DetachFromIndex

        internal virtual DetachFromIndexResponse DetachFromIndex(DetachFromIndexRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DetachFromIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachFromIndexResponseUnmarshaller.Instance;

            return Invoke<DetachFromIndexResponse>(request, options);
        }



        /// <summary>
        /// Detaches the specified object from the specified index.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachFromIndex service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DetachFromIndex service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied or directory not found. Either you don't have permissions for this directory
        /// or the directory does not exist. Try calling <a>ListDirectories</a> and check your
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// Operations are only permitted on enabled directories.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.NotIndexException">
        /// Indicates that the requested operation can only operate on index objects.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ObjectAlreadyDetachedException">
        /// Indicates that the object is not attached to the index.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/DetachFromIndex">REST API Reference for DetachFromIndex Operation</seealso>
        public virtual Task<DetachFromIndexResponse> DetachFromIndexAsync(DetachFromIndexRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DetachFromIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachFromIndexResponseUnmarshaller.Instance;

            return InvokeAsync<DetachFromIndexResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DetachObject

        internal virtual DetachObjectResponse DetachObject(DetachObjectRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DetachObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachObjectResponseUnmarshaller.Instance;

            return Invoke<DetachObjectResponse>(request, options);
        }



        /// <summary>
        /// Detaches a given object from the parent object. The object that is to be detached
        /// from the parent is specified by the link name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachObject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DetachObject service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied or directory not found. Either you don't have permissions for this directory
        /// or the directory does not exist. Try calling <a>ListDirectories</a> and check your
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// Operations are only permitted on enabled directories.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.NotNodeException">
        /// Occurs when any invalid operations are performed on an object that is not a node,
        /// such as calling <c>ListObjectChildren</c> for a leaf node object.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/DetachObject">REST API Reference for DetachObject Operation</seealso>
        public virtual Task<DetachObjectResponse> DetachObjectAsync(DetachObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DetachObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachObjectResponseUnmarshaller.Instance;

            return InvokeAsync<DetachObjectResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DetachPolicy

        internal virtual DetachPolicyResponse DetachPolicy(DetachPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DetachPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachPolicyResponseUnmarshaller.Instance;

            return Invoke<DetachPolicyResponse>(request, options);
        }



        /// <summary>
        /// Detaches a policy from an object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DetachPolicy service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied or directory not found. Either you don't have permissions for this directory
        /// or the directory does not exist. Try calling <a>ListDirectories</a> and check your
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// Operations are only permitted on enabled directories.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.NotPolicyException">
        /// Indicates that the requested operation can only operate on policy objects.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/DetachPolicy">REST API Reference for DetachPolicy Operation</seealso>
        public virtual Task<DetachPolicyResponse> DetachPolicyAsync(DetachPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DetachPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DetachPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DetachTypedLink

        internal virtual DetachTypedLinkResponse DetachTypedLink(DetachTypedLinkRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DetachTypedLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachTypedLinkResponseUnmarshaller.Instance;

            return Invoke<DetachTypedLinkResponse>(request, options);
        }



        /// <summary>
        /// Detaches a typed link from a specified source and target object. For more information,
        /// see <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/directory_objects_links.html#directory_objects_links_typedlink">Typed
        /// Links</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachTypedLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DetachTypedLink service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied or directory not found. Either you don't have permissions for this directory
        /// or the directory does not exist. Try calling <a>ListDirectories</a> and check your
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// Operations are only permitted on enabled directories.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.FacetValidationException">
        /// The <a>Facet</a> that you provided was not well formed or could not be validated with
        /// the schema.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/DetachTypedLink">REST API Reference for DetachTypedLink Operation</seealso>
        public virtual Task<DetachTypedLinkResponse> DetachTypedLinkAsync(DetachTypedLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DetachTypedLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachTypedLinkResponseUnmarshaller.Instance;

            return InvokeAsync<DetachTypedLinkResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DisableDirectory

        internal virtual DisableDirectoryResponse DisableDirectory(DisableDirectoryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisableDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableDirectoryResponseUnmarshaller.Instance;

            return Invoke<DisableDirectoryResponse>(request, options);
        }



        /// <summary>
        /// Disables the specified directory. Disabled directories cannot be read or written to.
        /// Only enabled directories can be disabled. Disabled directories may be reenabled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableDirectory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableDirectory service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied or directory not found. Either you don't have permissions for this directory
        /// or the directory does not exist. Try calling <a>ListDirectories</a> and check your
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryDeletedException">
        /// A directory that has been deleted and to which access has been attempted. Note: The
        /// requested resource will eventually cease to exist.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/DisableDirectory">REST API Reference for DisableDirectory Operation</seealso>
        public virtual Task<DisableDirectoryResponse> DisableDirectoryAsync(DisableDirectoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisableDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableDirectoryResponseUnmarshaller.Instance;

            return InvokeAsync<DisableDirectoryResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  EnableDirectory

        internal virtual EnableDirectoryResponse EnableDirectory(EnableDirectoryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EnableDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableDirectoryResponseUnmarshaller.Instance;

            return Invoke<EnableDirectoryResponse>(request, options);
        }



        /// <summary>
        /// Enables the specified directory. Only disabled directories can be enabled. Once enabled,
        /// the directory can then be read and written to.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableDirectory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableDirectory service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied or directory not found. Either you don't have permissions for this directory
        /// or the directory does not exist. Try calling <a>ListDirectories</a> and check your
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryDeletedException">
        /// A directory that has been deleted and to which access has been attempted. Note: The
        /// requested resource will eventually cease to exist.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/EnableDirectory">REST API Reference for EnableDirectory Operation</seealso>
        public virtual Task<EnableDirectoryResponse> EnableDirectoryAsync(EnableDirectoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EnableDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableDirectoryResponseUnmarshaller.Instance;

            return InvokeAsync<EnableDirectoryResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetAppliedSchemaVersion

        internal virtual GetAppliedSchemaVersionResponse GetAppliedSchemaVersion(GetAppliedSchemaVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAppliedSchemaVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAppliedSchemaVersionResponseUnmarshaller.Instance;

            return Invoke<GetAppliedSchemaVersionResponse>(request, options);
        }



        /// <summary>
        /// Returns current applied schema version ARN, including the minor version in use.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAppliedSchemaVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAppliedSchemaVersion service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied or directory not found. Either you don't have permissions for this directory
        /// or the directory does not exist. Try calling <a>ListDirectories</a> and check your
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/GetAppliedSchemaVersion">REST API Reference for GetAppliedSchemaVersion Operation</seealso>
        public virtual Task<GetAppliedSchemaVersionResponse> GetAppliedSchemaVersionAsync(GetAppliedSchemaVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAppliedSchemaVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAppliedSchemaVersionResponseUnmarshaller.Instance;

            return InvokeAsync<GetAppliedSchemaVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetDirectory

        internal virtual GetDirectoryResponse GetDirectory(GetDirectoryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDirectoryResponseUnmarshaller.Instance;

            return Invoke<GetDirectoryResponse>(request, options);
        }



        /// <summary>
        /// Retrieves metadata about a directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDirectory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDirectory service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied or directory not found. Either you don't have permissions for this directory
        /// or the directory does not exist. Try calling <a>ListDirectories</a> and check your
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/GetDirectory">REST API Reference for GetDirectory Operation</seealso>
        public virtual Task<GetDirectoryResponse> GetDirectoryAsync(GetDirectoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDirectoryResponseUnmarshaller.Instance;

            return InvokeAsync<GetDirectoryResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetFacet

        internal virtual GetFacetResponse GetFacet(GetFacetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFacetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFacetResponseUnmarshaller.Instance;

            return Invoke<GetFacetResponse>(request, options);
        }



        /// <summary>
        /// Gets details of the <a>Facet</a>, such as facet name, attributes, <a>Rule</a>s, or
        /// <c>ObjectType</c>. You can call this on all kinds of schema facets -- published, development,
        /// or applied.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFacet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFacet service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied or directory not found. Either you don't have permissions for this directory
        /// or the directory does not exist. Try calling <a>ListDirectories</a> and check your
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.FacetNotFoundException">
        /// The specified <a>Facet</a> could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/GetFacet">REST API Reference for GetFacet Operation</seealso>
        public virtual Task<GetFacetResponse> GetFacetAsync(GetFacetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFacetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFacetResponseUnmarshaller.Instance;

            return InvokeAsync<GetFacetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetLinkAttributes

        internal virtual GetLinkAttributesResponse GetLinkAttributes(GetLinkAttributesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetLinkAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLinkAttributesResponseUnmarshaller.Instance;

            return Invoke<GetLinkAttributesResponse>(request, options);
        }



        /// <summary>
        /// Retrieves attributes that are associated with a typed link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLinkAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLinkAttributes service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied or directory not found. Either you don't have permissions for this directory
        /// or the directory does not exist. Try calling <a>ListDirectories</a> and check your
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// Operations are only permitted on enabled directories.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.FacetValidationException">
        /// The <a>Facet</a> that you provided was not well formed or could not be validated with
        /// the schema.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/GetLinkAttributes">REST API Reference for GetLinkAttributes Operation</seealso>
        public virtual Task<GetLinkAttributesResponse> GetLinkAttributesAsync(GetLinkAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetLinkAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLinkAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<GetLinkAttributesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetObjectAttributes

        internal virtual GetObjectAttributesResponse GetObjectAttributes(GetObjectAttributesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetObjectAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetObjectAttributesResponseUnmarshaller.Instance;

            return Invoke<GetObjectAttributesResponse>(request, options);
        }



        /// <summary>
        /// Retrieves attributes within a facet that are associated with an object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetObjectAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetObjectAttributes service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied or directory not found. Either you don't have permissions for this directory
        /// or the directory does not exist. Try calling <a>ListDirectories</a> and check your
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// Operations are only permitted on enabled directories.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.FacetValidationException">
        /// The <a>Facet</a> that you provided was not well formed or could not be validated with
        /// the schema.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/GetObjectAttributes">REST API Reference for GetObjectAttributes Operation</seealso>
        public virtual Task<GetObjectAttributesResponse> GetObjectAttributesAsync(GetObjectAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetObjectAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetObjectAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<GetObjectAttributesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetObjectInformation

        internal virtual GetObjectInformationResponse GetObjectInformation(GetObjectInformationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetObjectInformationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetObjectInformationResponseUnmarshaller.Instance;

            return Invoke<GetObjectInformationResponse>(request, options);
        }



        /// <summary>
        /// Retrieves metadata about an object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetObjectInformation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetObjectInformation service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied or directory not found. Either you don't have permissions for this directory
        /// or the directory does not exist. Try calling <a>ListDirectories</a> and check your
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// Operations are only permitted on enabled directories.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/GetObjectInformation">REST API Reference for GetObjectInformation Operation</seealso>
        public virtual Task<GetObjectInformationResponse> GetObjectInformationAsync(GetObjectInformationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetObjectInformationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetObjectInformationResponseUnmarshaller.Instance;

            return InvokeAsync<GetObjectInformationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetSchemaAsJson

        internal virtual GetSchemaAsJsonResponse GetSchemaAsJson(GetSchemaAsJsonRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSchemaAsJsonRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSchemaAsJsonResponseUnmarshaller.Instance;

            return Invoke<GetSchemaAsJsonResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a JSON representation of the schema. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/schemas_jsonformat.html#schemas_json">JSON
        /// Schema Format</a> for more information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSchemaAsJson service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSchemaAsJson service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied or directory not found. Either you don't have permissions for this directory
        /// or the directory does not exist. Try calling <a>ListDirectories</a> and check your
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/GetSchemaAsJson">REST API Reference for GetSchemaAsJson Operation</seealso>
        public virtual Task<GetSchemaAsJsonResponse> GetSchemaAsJsonAsync(GetSchemaAsJsonRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSchemaAsJsonRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSchemaAsJsonResponseUnmarshaller.Instance;

            return InvokeAsync<GetSchemaAsJsonResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetTypedLinkFacetInformation

        internal virtual GetTypedLinkFacetInformationResponse GetTypedLinkFacetInformation(GetTypedLinkFacetInformationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTypedLinkFacetInformationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTypedLinkFacetInformationResponseUnmarshaller.Instance;

            return Invoke<GetTypedLinkFacetInformationResponse>(request, options);
        }



        /// <summary>
        /// Returns the identity attribute order for a specific <a>TypedLinkFacet</a>. For more
        /// information, see <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/directory_objects_links.html#directory_objects_links_typedlink">Typed
        /// Links</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTypedLinkFacetInformation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTypedLinkFacetInformation service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied or directory not found. Either you don't have permissions for this directory
        /// or the directory does not exist. Try calling <a>ListDirectories</a> and check your
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.FacetNotFoundException">
        /// The specified <a>Facet</a> could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidNextTokenException">
        /// Indicates that the <c>NextToken</c> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/GetTypedLinkFacetInformation">REST API Reference for GetTypedLinkFacetInformation Operation</seealso>
        public virtual Task<GetTypedLinkFacetInformationResponse> GetTypedLinkFacetInformationAsync(GetTypedLinkFacetInformationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTypedLinkFacetInformationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTypedLinkFacetInformationResponseUnmarshaller.Instance;

            return InvokeAsync<GetTypedLinkFacetInformationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAppliedSchemaArns

        internal virtual ListAppliedSchemaArnsResponse ListAppliedSchemaArns(ListAppliedSchemaArnsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAppliedSchemaArnsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppliedSchemaArnsResponseUnmarshaller.Instance;

            return Invoke<ListAppliedSchemaArnsResponse>(request, options);
        }



        /// <summary>
        /// Lists schema major versions applied to a directory. If <c>SchemaArn</c> is provided,
        /// lists the minor version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppliedSchemaArns service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAppliedSchemaArns service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied or directory not found. Either you don't have permissions for this directory
        /// or the directory does not exist. Try calling <a>ListDirectories</a> and check your
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidNextTokenException">
        /// Indicates that the <c>NextToken</c> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListAppliedSchemaArns">REST API Reference for ListAppliedSchemaArns Operation</seealso>
        public virtual Task<ListAppliedSchemaArnsResponse> ListAppliedSchemaArnsAsync(ListAppliedSchemaArnsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAppliedSchemaArnsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppliedSchemaArnsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAppliedSchemaArnsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAttachedIndices

        internal virtual ListAttachedIndicesResponse ListAttachedIndices(ListAttachedIndicesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAttachedIndicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAttachedIndicesResponseUnmarshaller.Instance;

            return Invoke<ListAttachedIndicesResponse>(request, options);
        }



        /// <summary>
        /// Lists indices attached to the specified object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAttachedIndices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAttachedIndices service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied or directory not found. Either you don't have permissions for this directory
        /// or the directory does not exist. Try calling <a>ListDirectories</a> and check your
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// Operations are only permitted on enabled directories.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListAttachedIndices">REST API Reference for ListAttachedIndices Operation</seealso>
        public virtual Task<ListAttachedIndicesResponse> ListAttachedIndicesAsync(ListAttachedIndicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAttachedIndicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAttachedIndicesResponseUnmarshaller.Instance;

            return InvokeAsync<ListAttachedIndicesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDevelopmentSchemaArns

        internal virtual ListDevelopmentSchemaArnsResponse ListDevelopmentSchemaArns(ListDevelopmentSchemaArnsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDevelopmentSchemaArnsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDevelopmentSchemaArnsResponseUnmarshaller.Instance;

            return Invoke<ListDevelopmentSchemaArnsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves each Amazon Resource Name (ARN) of schemas in the development state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDevelopmentSchemaArns service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDevelopmentSchemaArns service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied or directory not found. Either you don't have permissions for this directory
        /// or the directory does not exist. Try calling <a>ListDirectories</a> and check your
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidNextTokenException">
        /// Indicates that the <c>NextToken</c> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListDevelopmentSchemaArns">REST API Reference for ListDevelopmentSchemaArns Operation</seealso>
        public virtual Task<ListDevelopmentSchemaArnsResponse> ListDevelopmentSchemaArnsAsync(ListDevelopmentSchemaArnsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDevelopmentSchemaArnsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDevelopmentSchemaArnsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDevelopmentSchemaArnsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDirectories

        internal virtual ListDirectoriesResponse ListDirectories(ListDirectoriesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDirectoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDirectoriesResponseUnmarshaller.Instance;

            return Invoke<ListDirectoriesResponse>(request, options);
        }



        /// <summary>
        /// Lists directories created within an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDirectories service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDirectories service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied or directory not found. Either you don't have permissions for this directory
        /// or the directory does not exist. Try calling <a>ListDirectories</a> and check your
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidNextTokenException">
        /// Indicates that the <c>NextToken</c> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListDirectories">REST API Reference for ListDirectories Operation</seealso>
        public virtual Task<ListDirectoriesResponse> ListDirectoriesAsync(ListDirectoriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDirectoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDirectoriesResponseUnmarshaller.Instance;

            return InvokeAsync<ListDirectoriesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListFacetAttributes

        internal virtual ListFacetAttributesResponse ListFacetAttributes(ListFacetAttributesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFacetAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFacetAttributesResponseUnmarshaller.Instance;

            return Invoke<ListFacetAttributesResponse>(request, options);
        }



        /// <summary>
        /// Retrieves attributes attached to the facet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFacetAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFacetAttributes service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied or directory not found. Either you don't have permissions for this directory
        /// or the directory does not exist. Try calling <a>ListDirectories</a> and check your
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.FacetNotFoundException">
        /// The specified <a>Facet</a> could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidNextTokenException">
        /// Indicates that the <c>NextToken</c> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListFacetAttributes">REST API Reference for ListFacetAttributes Operation</seealso>
        public virtual Task<ListFacetAttributesResponse> ListFacetAttributesAsync(ListFacetAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFacetAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFacetAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<ListFacetAttributesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListFacetNames

        internal virtual ListFacetNamesResponse ListFacetNames(ListFacetNamesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFacetNamesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFacetNamesResponseUnmarshaller.Instance;

            return Invoke<ListFacetNamesResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the names of facets that exist in a schema.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFacetNames service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFacetNames service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied or directory not found. Either you don't have permissions for this directory
        /// or the directory does not exist. Try calling <a>ListDirectories</a> and check your
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidNextTokenException">
        /// Indicates that the <c>NextToken</c> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListFacetNames">REST API Reference for ListFacetNames Operation</seealso>
        public virtual Task<ListFacetNamesResponse> ListFacetNamesAsync(ListFacetNamesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFacetNamesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFacetNamesResponseUnmarshaller.Instance;

            return InvokeAsync<ListFacetNamesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListIncomingTypedLinks

        internal virtual ListIncomingTypedLinksResponse ListIncomingTypedLinks(ListIncomingTypedLinksRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIncomingTypedLinksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIncomingTypedLinksResponseUnmarshaller.Instance;

            return Invoke<ListIncomingTypedLinksResponse>(request, options);
        }



        /// <summary>
        /// Returns a paginated list of all the incoming <a>TypedLinkSpecifier</a> information
        /// for an object. It also supports filtering by typed link facet and identity attributes.
        /// For more information, see <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/directory_objects_links.html#directory_objects_links_typedlink">Typed
        /// Links</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIncomingTypedLinks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIncomingTypedLinks service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied or directory not found. Either you don't have permissions for this directory
        /// or the directory does not exist. Try calling <a>ListDirectories</a> and check your
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// Operations are only permitted on enabled directories.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.FacetValidationException">
        /// The <a>Facet</a> that you provided was not well formed or could not be validated with
        /// the schema.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidNextTokenException">
        /// Indicates that the <c>NextToken</c> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListIncomingTypedLinks">REST API Reference for ListIncomingTypedLinks Operation</seealso>
        public virtual Task<ListIncomingTypedLinksResponse> ListIncomingTypedLinksAsync(ListIncomingTypedLinksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIncomingTypedLinksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIncomingTypedLinksResponseUnmarshaller.Instance;

            return InvokeAsync<ListIncomingTypedLinksResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListIndex

        internal virtual ListIndexResponse ListIndex(ListIndexRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIndexResponseUnmarshaller.Instance;

            return Invoke<ListIndexResponse>(request, options);
        }



        /// <summary>
        /// Lists objects attached to the specified index.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIndex service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIndex service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied or directory not found. Either you don't have permissions for this directory
        /// or the directory does not exist. Try calling <a>ListDirectories</a> and check your
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// Operations are only permitted on enabled directories.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.FacetValidationException">
        /// The <a>Facet</a> that you provided was not well formed or could not be validated with
        /// the schema.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidNextTokenException">
        /// Indicates that the <c>NextToken</c> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.NotIndexException">
        /// Indicates that the requested operation can only operate on index objects.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListIndex">REST API Reference for ListIndex Operation</seealso>
        public virtual Task<ListIndexResponse> ListIndexAsync(ListIndexRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIndexResponseUnmarshaller.Instance;

            return InvokeAsync<ListIndexResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListManagedSchemaArns

        internal virtual ListManagedSchemaArnsResponse ListManagedSchemaArns(ListManagedSchemaArnsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListManagedSchemaArnsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListManagedSchemaArnsResponseUnmarshaller.Instance;

            return Invoke<ListManagedSchemaArnsResponse>(request, options);
        }



        /// <summary>
        /// Lists the major version families of each managed schema. If a major version ARN is
        /// provided as SchemaArn, the minor version revisions in that family are listed instead.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListManagedSchemaArns service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListManagedSchemaArns service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied or directory not found. Either you don't have permissions for this directory
        /// or the directory does not exist. Try calling <a>ListDirectories</a> and check your
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidNextTokenException">
        /// Indicates that the <c>NextToken</c> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListManagedSchemaArns">REST API Reference for ListManagedSchemaArns Operation</seealso>
        public virtual Task<ListManagedSchemaArnsResponse> ListManagedSchemaArnsAsync(ListManagedSchemaArnsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListManagedSchemaArnsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListManagedSchemaArnsResponseUnmarshaller.Instance;

            return InvokeAsync<ListManagedSchemaArnsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListObjectAttributes

        internal virtual ListObjectAttributesResponse ListObjectAttributes(ListObjectAttributesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListObjectAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListObjectAttributesResponseUnmarshaller.Instance;

            return Invoke<ListObjectAttributesResponse>(request, options);
        }



        /// <summary>
        /// Lists all attributes that are associated with an object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListObjectAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListObjectAttributes service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied or directory not found. Either you don't have permissions for this directory
        /// or the directory does not exist. Try calling <a>ListDirectories</a> and check your
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// Operations are only permitted on enabled directories.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.FacetValidationException">
        /// The <a>Facet</a> that you provided was not well formed or could not be validated with
        /// the schema.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidNextTokenException">
        /// Indicates that the <c>NextToken</c> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListObjectAttributes">REST API Reference for ListObjectAttributes Operation</seealso>
        public virtual Task<ListObjectAttributesResponse> ListObjectAttributesAsync(ListObjectAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListObjectAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListObjectAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<ListObjectAttributesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListObjectChildren

        internal virtual ListObjectChildrenResponse ListObjectChildren(ListObjectChildrenRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListObjectChildrenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListObjectChildrenResponseUnmarshaller.Instance;

            return Invoke<ListObjectChildrenResponse>(request, options);
        }



        /// <summary>
        /// Returns a paginated list of child objects that are associated with a given object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListObjectChildren service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListObjectChildren service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied or directory not found. Either you don't have permissions for this directory
        /// or the directory does not exist. Try calling <a>ListDirectories</a> and check your
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// Operations are only permitted on enabled directories.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidNextTokenException">
        /// Indicates that the <c>NextToken</c> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.NotNodeException">
        /// Occurs when any invalid operations are performed on an object that is not a node,
        /// such as calling <c>ListObjectChildren</c> for a leaf node object.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListObjectChildren">REST API Reference for ListObjectChildren Operation</seealso>
        public virtual Task<ListObjectChildrenResponse> ListObjectChildrenAsync(ListObjectChildrenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListObjectChildrenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListObjectChildrenResponseUnmarshaller.Instance;

            return InvokeAsync<ListObjectChildrenResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListObjectParentPaths

        internal virtual ListObjectParentPathsResponse ListObjectParentPaths(ListObjectParentPathsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListObjectParentPathsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListObjectParentPathsResponseUnmarshaller.Instance;

            return Invoke<ListObjectParentPathsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves all available parent paths for any object type such as node, leaf node,
        /// policy node, and index node objects. For more information about objects, see <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/key_concepts_directorystructure.html">Directory
        /// Structure</a>.
        /// 
        ///  
        /// <para>
        /// Use this API to evaluate all parents for an object. The call returns all objects from
        /// the root of the directory up to the requested object. The API returns the number of
        /// paths based on user-defined <c>MaxResults</c>, in case there are multiple paths to
        /// the parent. The order of the paths and nodes returned is consistent among multiple
        /// API calls unless the objects are deleted or moved. Paths not leading to the directory
        /// root are ignored from the target object.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListObjectParentPaths service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListObjectParentPaths service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied or directory not found. Either you don't have permissions for this directory
        /// or the directory does not exist. Try calling <a>ListDirectories</a> and check your
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// Operations are only permitted on enabled directories.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidNextTokenException">
        /// Indicates that the <c>NextToken</c> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListObjectParentPaths">REST API Reference for ListObjectParentPaths Operation</seealso>
        public virtual Task<ListObjectParentPathsResponse> ListObjectParentPathsAsync(ListObjectParentPathsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListObjectParentPathsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListObjectParentPathsResponseUnmarshaller.Instance;

            return InvokeAsync<ListObjectParentPathsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListObjectParents

        internal virtual ListObjectParentsResponse ListObjectParents(ListObjectParentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListObjectParentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListObjectParentsResponseUnmarshaller.Instance;

            return Invoke<ListObjectParentsResponse>(request, options);
        }



        /// <summary>
        /// Lists parent objects that are associated with a given object in pagination fashion.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListObjectParents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListObjectParents service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied or directory not found. Either you don't have permissions for this directory
        /// or the directory does not exist. Try calling <a>ListDirectories</a> and check your
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.CannotListParentOfRootException">
        /// Cannot list the parents of a <a>Directory</a> root.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// Operations are only permitted on enabled directories.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidNextTokenException">
        /// Indicates that the <c>NextToken</c> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListObjectParents">REST API Reference for ListObjectParents Operation</seealso>
        public virtual Task<ListObjectParentsResponse> ListObjectParentsAsync(ListObjectParentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListObjectParentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListObjectParentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListObjectParentsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListObjectPolicies

        internal virtual ListObjectPoliciesResponse ListObjectPolicies(ListObjectPoliciesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListObjectPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListObjectPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListObjectPoliciesResponse>(request, options);
        }



        /// <summary>
        /// Returns policies attached to an object in pagination fashion.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListObjectPolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListObjectPolicies service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied or directory not found. Either you don't have permissions for this directory
        /// or the directory does not exist. Try calling <a>ListDirectories</a> and check your
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// Operations are only permitted on enabled directories.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidNextTokenException">
        /// Indicates that the <c>NextToken</c> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListObjectPolicies">REST API Reference for ListObjectPolicies Operation</seealso>
        public virtual Task<ListObjectPoliciesResponse> ListObjectPoliciesAsync(ListObjectPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListObjectPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListObjectPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<ListObjectPoliciesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListOutgoingTypedLinks

        internal virtual ListOutgoingTypedLinksResponse ListOutgoingTypedLinks(ListOutgoingTypedLinksRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOutgoingTypedLinksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOutgoingTypedLinksResponseUnmarshaller.Instance;

            return Invoke<ListOutgoingTypedLinksResponse>(request, options);
        }



        /// <summary>
        /// Returns a paginated list of all the outgoing <a>TypedLinkSpecifier</a> information
        /// for an object. It also supports filtering by typed link facet and identity attributes.
        /// For more information, see <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/directory_objects_links.html#directory_objects_links_typedlink">Typed
        /// Links</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOutgoingTypedLinks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOutgoingTypedLinks service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied or directory not found. Either you don't have permissions for this directory
        /// or the directory does not exist. Try calling <a>ListDirectories</a> and check your
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// Operations are only permitted on enabled directories.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.FacetValidationException">
        /// The <a>Facet</a> that you provided was not well formed or could not be validated with
        /// the schema.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidNextTokenException">
        /// Indicates that the <c>NextToken</c> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListOutgoingTypedLinks">REST API Reference for ListOutgoingTypedLinks Operation</seealso>
        public virtual Task<ListOutgoingTypedLinksResponse> ListOutgoingTypedLinksAsync(ListOutgoingTypedLinksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOutgoingTypedLinksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOutgoingTypedLinksResponseUnmarshaller.Instance;

            return InvokeAsync<ListOutgoingTypedLinksResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListPolicyAttachments

        internal virtual ListPolicyAttachmentsResponse ListPolicyAttachments(ListPolicyAttachmentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPolicyAttachmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPolicyAttachmentsResponseUnmarshaller.Instance;

            return Invoke<ListPolicyAttachmentsResponse>(request, options);
        }



        /// <summary>
        /// Returns all of the <c>ObjectIdentifiers</c> to which a given policy is attached.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPolicyAttachments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPolicyAttachments service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied or directory not found. Either you don't have permissions for this directory
        /// or the directory does not exist. Try calling <a>ListDirectories</a> and check your
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// Operations are only permitted on enabled directories.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidNextTokenException">
        /// Indicates that the <c>NextToken</c> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.NotPolicyException">
        /// Indicates that the requested operation can only operate on policy objects.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListPolicyAttachments">REST API Reference for ListPolicyAttachments Operation</seealso>
        public virtual Task<ListPolicyAttachmentsResponse> ListPolicyAttachmentsAsync(ListPolicyAttachmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPolicyAttachmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPolicyAttachmentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPolicyAttachmentsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListPublishedSchemaArns

        internal virtual ListPublishedSchemaArnsResponse ListPublishedSchemaArns(ListPublishedSchemaArnsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPublishedSchemaArnsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPublishedSchemaArnsResponseUnmarshaller.Instance;

            return Invoke<ListPublishedSchemaArnsResponse>(request, options);
        }



        /// <summary>
        /// Lists the major version families of each published schema. If a major version ARN
        /// is provided as <c>SchemaArn</c>, the minor version revisions in that family are listed
        /// instead.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPublishedSchemaArns service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPublishedSchemaArns service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied or directory not found. Either you don't have permissions for this directory
        /// or the directory does not exist. Try calling <a>ListDirectories</a> and check your
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidNextTokenException">
        /// Indicates that the <c>NextToken</c> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListPublishedSchemaArns">REST API Reference for ListPublishedSchemaArns Operation</seealso>
        public virtual Task<ListPublishedSchemaArnsResponse> ListPublishedSchemaArnsAsync(ListPublishedSchemaArnsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPublishedSchemaArnsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPublishedSchemaArnsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPublishedSchemaArnsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Returns tags for a resource. Tagging is currently supported only for directories with
        /// a limit of 50 tags per directory. All 50 tags are returned for a given directory with
        /// this API call.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied or directory not found. Either you don't have permissions for this directory
        /// or the directory does not exist. Try calling <a>ListDirectories</a> and check your
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidTaggingRequestException">
        /// Can occur for multiple reasons such as when you tag a resource that doesn’t exist
        /// or if you specify a higher number of tags for a resource than the allowed limit. Allowed
        /// limit is 50 tags per resource.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTypedLinkFacetAttributes

        internal virtual ListTypedLinkFacetAttributesResponse ListTypedLinkFacetAttributes(ListTypedLinkFacetAttributesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTypedLinkFacetAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTypedLinkFacetAttributesResponseUnmarshaller.Instance;

            return Invoke<ListTypedLinkFacetAttributesResponse>(request, options);
        }



        /// <summary>
        /// Returns a paginated list of all attribute definitions for a particular <a>TypedLinkFacet</a>.
        /// For more information, see <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/directory_objects_links.html#directory_objects_links_typedlink">Typed
        /// Links</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTypedLinkFacetAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTypedLinkFacetAttributes service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied or directory not found. Either you don't have permissions for this directory
        /// or the directory does not exist. Try calling <a>ListDirectories</a> and check your
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.FacetNotFoundException">
        /// The specified <a>Facet</a> could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidNextTokenException">
        /// Indicates that the <c>NextToken</c> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListTypedLinkFacetAttributes">REST API Reference for ListTypedLinkFacetAttributes Operation</seealso>
        public virtual Task<ListTypedLinkFacetAttributesResponse> ListTypedLinkFacetAttributesAsync(ListTypedLinkFacetAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTypedLinkFacetAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTypedLinkFacetAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<ListTypedLinkFacetAttributesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTypedLinkFacetNames

        internal virtual ListTypedLinkFacetNamesResponse ListTypedLinkFacetNames(ListTypedLinkFacetNamesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTypedLinkFacetNamesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTypedLinkFacetNamesResponseUnmarshaller.Instance;

            return Invoke<ListTypedLinkFacetNamesResponse>(request, options);
        }



        /// <summary>
        /// Returns a paginated list of <c>TypedLink</c> facet names for a particular schema.
        /// For more information, see <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/directory_objects_links.html#directory_objects_links_typedlink">Typed
        /// Links</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTypedLinkFacetNames service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTypedLinkFacetNames service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied or directory not found. Either you don't have permissions for this directory
        /// or the directory does not exist. Try calling <a>ListDirectories</a> and check your
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidNextTokenException">
        /// Indicates that the <c>NextToken</c> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListTypedLinkFacetNames">REST API Reference for ListTypedLinkFacetNames Operation</seealso>
        public virtual Task<ListTypedLinkFacetNamesResponse> ListTypedLinkFacetNamesAsync(ListTypedLinkFacetNamesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTypedLinkFacetNamesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTypedLinkFacetNamesResponseUnmarshaller.Instance;

            return InvokeAsync<ListTypedLinkFacetNamesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  LookupPolicy

        internal virtual LookupPolicyResponse LookupPolicy(LookupPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = LookupPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = LookupPolicyResponseUnmarshaller.Instance;

            return Invoke<LookupPolicyResponse>(request, options);
        }



        /// <summary>
        /// Lists all policies from the root of the <a>Directory</a> to the object specified.
        /// If there are no policies present, an empty list is returned. If policies are present,
        /// and if some objects don't have the policies attached, it returns the <c>ObjectIdentifier</c>
        /// for such objects. If policies are present, it returns <c>ObjectIdentifier</c>, <c>policyId</c>,
        /// and <c>policyType</c>. Paths that don't lead to the root from the target object are
        /// ignored. For more information, see <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/key_concepts_directory.html#key_concepts_policies">Policies</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the LookupPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the LookupPolicy service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied or directory not found. Either you don't have permissions for this directory
        /// or the directory does not exist. Try calling <a>ListDirectories</a> and check your
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// Operations are only permitted on enabled directories.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidNextTokenException">
        /// Indicates that the <c>NextToken</c> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/LookupPolicy">REST API Reference for LookupPolicy Operation</seealso>
        public virtual Task<LookupPolicyResponse> LookupPolicyAsync(LookupPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = LookupPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = LookupPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<LookupPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PublishSchema

        internal virtual PublishSchemaResponse PublishSchema(PublishSchemaRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PublishSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PublishSchemaResponseUnmarshaller.Instance;

            return Invoke<PublishSchemaResponse>(request, options);
        }



        /// <summary>
        /// Publishes a development schema with a major version and a recommended minor version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PublishSchema service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PublishSchema service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied or directory not found. Either you don't have permissions for this directory
        /// or the directory does not exist. Try calling <a>ListDirectories</a> and check your
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.SchemaAlreadyPublishedException">
        /// Indicates that a schema is already published.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/PublishSchema">REST API Reference for PublishSchema Operation</seealso>
        public virtual Task<PublishSchemaResponse> PublishSchemaAsync(PublishSchemaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PublishSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PublishSchemaResponseUnmarshaller.Instance;

            return InvokeAsync<PublishSchemaResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutSchemaFromJson

        internal virtual PutSchemaFromJsonResponse PutSchemaFromJson(PutSchemaFromJsonRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutSchemaFromJsonRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSchemaFromJsonResponseUnmarshaller.Instance;

            return Invoke<PutSchemaFromJsonResponse>(request, options);
        }



        /// <summary>
        /// Allows a schema to be updated using JSON upload. Only available for development schemas.
        /// See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/schemas_jsonformat.html#schemas_json">JSON
        /// Schema Format</a> for more information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutSchemaFromJson service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutSchemaFromJson service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied or directory not found. Either you don't have permissions for this directory
        /// or the directory does not exist. Try calling <a>ListDirectories</a> and check your
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidRuleException">
        /// Occurs when any of the rule parameter keys or values are invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidSchemaDocException">
        /// Indicates that the provided <c>SchemaDoc</c> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/PutSchemaFromJson">REST API Reference for PutSchemaFromJson Operation</seealso>
        public virtual Task<PutSchemaFromJsonResponse> PutSchemaFromJsonAsync(PutSchemaFromJsonRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutSchemaFromJsonRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSchemaFromJsonResponseUnmarshaller.Instance;

            return InvokeAsync<PutSchemaFromJsonResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RemoveFacetFromObject

        internal virtual RemoveFacetFromObjectResponse RemoveFacetFromObject(RemoveFacetFromObjectRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveFacetFromObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveFacetFromObjectResponseUnmarshaller.Instance;

            return Invoke<RemoveFacetFromObjectResponse>(request, options);
        }



        /// <summary>
        /// Removes the specified facet from the specified object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveFacetFromObject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveFacetFromObject service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied or directory not found. Either you don't have permissions for this directory
        /// or the directory does not exist. Try calling <a>ListDirectories</a> and check your
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// Operations are only permitted on enabled directories.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.FacetValidationException">
        /// The <a>Facet</a> that you provided was not well formed or could not be validated with
        /// the schema.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/RemoveFacetFromObject">REST API Reference for RemoveFacetFromObject Operation</seealso>
        public virtual Task<RemoveFacetFromObjectResponse> RemoveFacetFromObjectAsync(RemoveFacetFromObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveFacetFromObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveFacetFromObjectResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveFacetFromObjectResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// An API operation for adding tags to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied or directory not found. Either you don't have permissions for this directory
        /// or the directory does not exist. Try calling <a>ListDirectories</a> and check your
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidTaggingRequestException">
        /// Can occur for multiple reasons such as when you tag a resource that doesn’t exist
        /// or if you specify a higher number of tags for a resource than the allowed limit. Allowed
        /// limit is 50 tags per resource.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// An API operation for removing tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied or directory not found. Either you don't have permissions for this directory
        /// or the directory does not exist. Try calling <a>ListDirectories</a> and check your
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidTaggingRequestException">
        /// Can occur for multiple reasons such as when you tag a resource that doesn’t exist
        /// or if you specify a higher number of tags for a resource than the allowed limit. Allowed
        /// limit is 50 tags per resource.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateFacet

        internal virtual UpdateFacetResponse UpdateFacet(UpdateFacetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFacetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFacetResponseUnmarshaller.Instance;

            return Invoke<UpdateFacetResponse>(request, options);
        }



        /// <summary>
        /// Does the following:
        /// 
        ///  <ol> <li> 
        /// <para>
        /// Adds new <c>Attributes</c>, <c>Rules</c>, or <c>ObjectTypes</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Updates existing <c>Attributes</c>, <c>Rules</c>, or <c>ObjectTypes</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Deletes existing <c>Attributes</c>, <c>Rules</c>, or <c>ObjectTypes</c>.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFacet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFacet service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied or directory not found. Either you don't have permissions for this directory
        /// or the directory does not exist. Try calling <a>ListDirectories</a> and check your
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.FacetNotFoundException">
        /// The specified <a>Facet</a> could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.FacetValidationException">
        /// The <a>Facet</a> that you provided was not well formed or could not be validated with
        /// the schema.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidFacetUpdateException">
        /// An attempt to modify a <a>Facet</a> resulted in an invalid schema exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidRuleException">
        /// Occurs when any of the rule parameter keys or values are invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/UpdateFacet">REST API Reference for UpdateFacet Operation</seealso>
        public virtual Task<UpdateFacetResponse> UpdateFacetAsync(UpdateFacetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFacetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFacetResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFacetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateLinkAttributes

        internal virtual UpdateLinkAttributesResponse UpdateLinkAttributes(UpdateLinkAttributesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLinkAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLinkAttributesResponseUnmarshaller.Instance;

            return Invoke<UpdateLinkAttributesResponse>(request, options);
        }



        /// <summary>
        /// Updates a given typed link’s attributes. Attributes to be updated must not contribute
        /// to the typed link’s identity, as defined by its <c>IdentityAttributeOrder</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLinkAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateLinkAttributes service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied or directory not found. Either you don't have permissions for this directory
        /// or the directory does not exist. Try calling <a>ListDirectories</a> and check your
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// Operations are only permitted on enabled directories.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.FacetValidationException">
        /// The <a>Facet</a> that you provided was not well formed or could not be validated with
        /// the schema.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/UpdateLinkAttributes">REST API Reference for UpdateLinkAttributes Operation</seealso>
        public virtual Task<UpdateLinkAttributesResponse> UpdateLinkAttributesAsync(UpdateLinkAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLinkAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLinkAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateLinkAttributesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateObjectAttributes

        internal virtual UpdateObjectAttributesResponse UpdateObjectAttributes(UpdateObjectAttributesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateObjectAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateObjectAttributesResponseUnmarshaller.Instance;

            return Invoke<UpdateObjectAttributesResponse>(request, options);
        }



        /// <summary>
        /// Updates a given object's attributes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateObjectAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateObjectAttributes service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied or directory not found. Either you don't have permissions for this directory
        /// or the directory does not exist. Try calling <a>ListDirectories</a> and check your
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// Operations are only permitted on enabled directories.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.FacetValidationException">
        /// The <a>Facet</a> that you provided was not well formed or could not be validated with
        /// the schema.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LinkNameAlreadyInUseException">
        /// Indicates that a link could not be created due to a naming conflict. Choose a different
        /// name and then try again.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/UpdateObjectAttributes">REST API Reference for UpdateObjectAttributes Operation</seealso>
        public virtual Task<UpdateObjectAttributesResponse> UpdateObjectAttributesAsync(UpdateObjectAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateObjectAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateObjectAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateObjectAttributesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateSchema

        internal virtual UpdateSchemaResponse UpdateSchema(UpdateSchemaRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSchemaResponseUnmarshaller.Instance;

            return Invoke<UpdateSchemaResponse>(request, options);
        }



        /// <summary>
        /// Updates the schema name with a new name. Only development schema names can be updated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSchema service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSchema service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied or directory not found. Either you don't have permissions for this directory
        /// or the directory does not exist. Try calling <a>ListDirectories</a> and check your
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/UpdateSchema">REST API Reference for UpdateSchema Operation</seealso>
        public virtual Task<UpdateSchemaResponse> UpdateSchemaAsync(UpdateSchemaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSchemaResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSchemaResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateTypedLinkFacet

        internal virtual UpdateTypedLinkFacetResponse UpdateTypedLinkFacet(UpdateTypedLinkFacetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTypedLinkFacetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTypedLinkFacetResponseUnmarshaller.Instance;

            return Invoke<UpdateTypedLinkFacetResponse>(request, options);
        }



        /// <summary>
        /// Updates a <a>TypedLinkFacet</a>. For more information, see <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/directory_objects_links.html#directory_objects_links_typedlink">Typed
        /// Links</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTypedLinkFacet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTypedLinkFacet service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied or directory not found. Either you don't have permissions for this directory
        /// or the directory does not exist. Try calling <a>ListDirectories</a> and check your
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.FacetNotFoundException">
        /// The specified <a>Facet</a> could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.FacetValidationException">
        /// The <a>Facet</a> that you provided was not well formed or could not be validated with
        /// the schema.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidFacetUpdateException">
        /// An attempt to modify a <a>Facet</a> resulted in an invalid schema exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidRuleException">
        /// Occurs when any of the rule parameter keys or values are invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/UpdateTypedLinkFacet">REST API Reference for UpdateTypedLinkFacet Operation</seealso>
        public virtual Task<UpdateTypedLinkFacetResponse> UpdateTypedLinkFacetAsync(UpdateTypedLinkFacetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTypedLinkFacetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTypedLinkFacetResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTypedLinkFacetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpgradeAppliedSchema

        internal virtual UpgradeAppliedSchemaResponse UpgradeAppliedSchema(UpgradeAppliedSchemaRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpgradeAppliedSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpgradeAppliedSchemaResponseUnmarshaller.Instance;

            return Invoke<UpgradeAppliedSchemaResponse>(request, options);
        }



        /// <summary>
        /// Upgrades a single directory in-place using the <c>PublishedSchemaArn</c> with schema
        /// updates found in <c>MinorVersion</c>. Backwards-compatible minor version upgrades
        /// are instantaneously available for readers on all objects in the directory. Note: This
        /// is a synchronous API call and upgrades only one schema on a given directory per call.
        /// To upgrade multiple directories from one schema, you would need to call this API on
        /// each directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpgradeAppliedSchema service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpgradeAppliedSchema service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied or directory not found. Either you don't have permissions for this directory
        /// or the directory does not exist. Try calling <a>ListDirectories</a> and check your
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.IncompatibleSchemaException">
        /// Indicates a failure occurred while performing a check for backward compatibility between
        /// the specified schema and the schema that is currently applied to the directory.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidAttachmentException">
        /// Indicates that an attempt to make an attachment was invalid. For example, attaching
        /// two nodes with a link type that is not applicable to the nodes or attempting to apply
        /// a schema to a directory a second time.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.SchemaAlreadyExistsException">
        /// Indicates that a schema could not be created due to a naming conflict. Please select
        /// a different name and then try again.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/UpgradeAppliedSchema">REST API Reference for UpgradeAppliedSchema Operation</seealso>
        public virtual Task<UpgradeAppliedSchemaResponse> UpgradeAppliedSchemaAsync(UpgradeAppliedSchemaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpgradeAppliedSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpgradeAppliedSchemaResponseUnmarshaller.Instance;

            return InvokeAsync<UpgradeAppliedSchemaResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpgradePublishedSchema

        internal virtual UpgradePublishedSchemaResponse UpgradePublishedSchema(UpgradePublishedSchemaRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpgradePublishedSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpgradePublishedSchemaResponseUnmarshaller.Instance;

            return Invoke<UpgradePublishedSchemaResponse>(request, options);
        }



        /// <summary>
        /// Upgrades a published schema under a new minor version revision using the current contents
        /// of <c>DevelopmentSchemaArn</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpgradePublishedSchema service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpgradePublishedSchema service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied or directory not found. Either you don't have permissions for this directory
        /// or the directory does not exist. Try calling <a>ListDirectories</a> and check your
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.IncompatibleSchemaException">
        /// Indicates a failure occurred while performing a check for backward compatibility between
        /// the specified schema and the schema that is currently applied to the directory.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidAttachmentException">
        /// Indicates that an attempt to make an attachment was invalid. For example, attaching
        /// two nodes with a link type that is not applicable to the nodes or attempting to apply
        /// a schema to a directory a second time.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/UpgradePublishedSchema">REST API Reference for UpgradePublishedSchema Operation</seealso>
        public virtual Task<UpgradePublishedSchemaResponse> UpgradePublishedSchemaAsync(UpgradePublishedSchemaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpgradePublishedSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpgradePublishedSchemaResponseUnmarshaller.Instance;

            return InvokeAsync<UpgradePublishedSchemaResponse>(request, options, cancellationToken);
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
            var parameters = new ServiceOperationEndpointParameters(request);
            return Config.DetermineServiceOperationEndpoint(parameters);
        }

        #endregion

    }
}