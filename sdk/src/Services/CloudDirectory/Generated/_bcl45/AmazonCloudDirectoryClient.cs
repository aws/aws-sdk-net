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


        /// <summary>
        /// Adds a new <a>Facet</a> to an object. An object can have more than one facet applied
        /// on it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddFacetToObject service method.</param>
        /// 
        /// <returns>The response from the AddFacetToObject service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
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
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/AddFacetToObject">REST API Reference for AddFacetToObject Operation</seealso>
        public virtual AddFacetToObjectResponse AddFacetToObject(AddFacetToObjectRequest request)
        {
            var marshaller = AddFacetToObjectRequestMarshaller.Instance;
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
        public virtual Task<AddFacetToObjectResponse> AddFacetToObjectAsync(AddFacetToObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AddFacetToObjectRequestMarshaller.Instance;
            var unmarshaller = AddFacetToObjectResponseUnmarshaller.Instance;

            return InvokeAsync<AddFacetToObjectRequest,AddFacetToObjectResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ApplySchema


        /// <summary>
        /// Copies the input published schema, at the specified version, into the <a>Directory</a>
        /// with the same name and version as that of the published schema.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ApplySchema service method.</param>
        /// 
        /// <returns>The response from the ApplySchema service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
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
        /// Indicates that an attempt to attach an object with the same link name or to apply
        /// a schema with the same name has occurred. Rename the link or the schema and then try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ApplySchema">REST API Reference for ApplySchema Operation</seealso>
        public virtual ApplySchemaResponse ApplySchema(ApplySchemaRequest request)
        {
            var marshaller = ApplySchemaRequestMarshaller.Instance;
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
        public virtual Task<ApplySchemaResponse> ApplySchemaAsync(ApplySchemaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ApplySchemaRequestMarshaller.Instance;
            var unmarshaller = ApplySchemaResponseUnmarshaller.Instance;

            return InvokeAsync<ApplySchemaRequest,ApplySchemaResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AttachObject


        /// <summary>
        /// Attaches an existing object to another object. An object can be accessed in two ways:
        /// 
        ///  <ol> <li> 
        /// <para>
        /// Using the path
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Using <code>ObjectIdentifier</code> 
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachObject service method.</param>
        /// 
        /// <returns>The response from the AttachObject service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
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
        /// Indicates that an attempt to attach an object with the same link name or to apply
        /// a schema with the same name has occurred. Rename the link or the schema and then try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
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
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/AttachObject">REST API Reference for AttachObject Operation</seealso>
        public virtual AttachObjectResponse AttachObject(AttachObjectRequest request)
        {
            var marshaller = AttachObjectRequestMarshaller.Instance;
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
        public virtual Task<AttachObjectResponse> AttachObjectAsync(AttachObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AttachObjectRequestMarshaller.Instance;
            var unmarshaller = AttachObjectResponseUnmarshaller.Instance;

            return InvokeAsync<AttachObjectRequest,AttachObjectResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AttachPolicy


        /// <summary>
        /// Attaches a policy object to a regular object. An object can have a limited number
        /// of attached policies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachPolicy service method.</param>
        /// 
        /// <returns>The response from the AttachPolicy service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
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
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/AttachPolicy">REST API Reference for AttachPolicy Operation</seealso>
        public virtual AttachPolicyResponse AttachPolicy(AttachPolicyRequest request)
        {
            var marshaller = AttachPolicyRequestMarshaller.Instance;
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
        public virtual Task<AttachPolicyResponse> AttachPolicyAsync(AttachPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AttachPolicyRequestMarshaller.Instance;
            var unmarshaller = AttachPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<AttachPolicyRequest,AttachPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AttachToIndex


        /// <summary>
        /// Attaches the specified object to the specified index.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachToIndex service method.</param>
        /// 
        /// <returns>The response from the AttachToIndex service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
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
        /// Indicates that an attempt to attach an object with the same link name or to apply
        /// a schema with the same name has occurred. Rename the link or the schema and then try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/AttachToIndex">REST API Reference for AttachToIndex Operation</seealso>
        public virtual AttachToIndexResponse AttachToIndex(AttachToIndexRequest request)
        {
            var marshaller = AttachToIndexRequestMarshaller.Instance;
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
        public virtual Task<AttachToIndexResponse> AttachToIndexAsync(AttachToIndexRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AttachToIndexRequestMarshaller.Instance;
            var unmarshaller = AttachToIndexResponseUnmarshaller.Instance;

            return InvokeAsync<AttachToIndexRequest,AttachToIndexResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AttachTypedLink


        /// <summary>
        /// Attaches a typed link to a specified source and target object. For more information,
        /// see <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/objectsandlinks.html#typedlink">Typed
        /// link</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachTypedLink service method.</param>
        /// 
        /// <returns>The response from the AttachTypedLink service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
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
        /// Indicates that an attempt to attach an object with the same link name or to apply
        /// a schema with the same name has occurred. Rename the link or the schema and then try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
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
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/AttachTypedLink">REST API Reference for AttachTypedLink Operation</seealso>
        public virtual AttachTypedLinkResponse AttachTypedLink(AttachTypedLinkRequest request)
        {
            var marshaller = AttachTypedLinkRequestMarshaller.Instance;
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
        public virtual Task<AttachTypedLinkResponse> AttachTypedLinkAsync(AttachTypedLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AttachTypedLinkRequestMarshaller.Instance;
            var unmarshaller = AttachTypedLinkResponseUnmarshaller.Instance;

            return InvokeAsync<AttachTypedLinkRequest,AttachTypedLinkResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  BatchRead


        /// <summary>
        /// Performs all the read operations in a batch.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchRead service method.</param>
        /// 
        /// <returns>The response from the BatchRead service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
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
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/BatchRead">REST API Reference for BatchRead Operation</seealso>
        public virtual BatchReadResponse BatchRead(BatchReadRequest request)
        {
            var marshaller = BatchReadRequestMarshaller.Instance;
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
        public virtual Task<BatchReadResponse> BatchReadAsync(BatchReadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = BatchReadRequestMarshaller.Instance;
            var unmarshaller = BatchReadResponseUnmarshaller.Instance;

            return InvokeAsync<BatchReadRequest,BatchReadResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  BatchWrite


        /// <summary>
        /// Performs all the write operations in a batch. Either all the operations succeed or
        /// none.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchWrite service method.</param>
        /// 
        /// <returns>The response from the BatchWrite service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.BatchWriteException">
        /// A <code>BatchWrite</code> exception has occurred.
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
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/BatchWrite">REST API Reference for BatchWrite Operation</seealso>
        public virtual BatchWriteResponse BatchWrite(BatchWriteRequest request)
        {
            var marshaller = BatchWriteRequestMarshaller.Instance;
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
        public virtual Task<BatchWriteResponse> BatchWriteAsync(BatchWriteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = BatchWriteRequestMarshaller.Instance;
            var unmarshaller = BatchWriteResponseUnmarshaller.Instance;

            return InvokeAsync<BatchWriteRequest,BatchWriteResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDirectory


        /// <summary>
        /// Creates a <a>Directory</a> by copying the published schema into the directory. A directory
        /// cannot be created without a schema.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDirectory service method.</param>
        /// 
        /// <returns>The response from the CreateDirectory service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
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
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/CreateDirectory">REST API Reference for CreateDirectory Operation</seealso>
        public virtual CreateDirectoryResponse CreateDirectory(CreateDirectoryRequest request)
        {
            var marshaller = CreateDirectoryRequestMarshaller.Instance;
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
        public virtual Task<CreateDirectoryResponse> CreateDirectoryAsync(CreateDirectoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateDirectoryRequestMarshaller.Instance;
            var unmarshaller = CreateDirectoryResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDirectoryRequest,CreateDirectoryResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateFacet


        /// <summary>
        /// Creates a new <a>Facet</a> in a schema. Facet creation is allowed only in development
        /// or applied schemas.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFacet service method.</param>
        /// 
        /// <returns>The response from the CreateFacet service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
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
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/CreateFacet">REST API Reference for CreateFacet Operation</seealso>
        public virtual CreateFacetResponse CreateFacet(CreateFacetRequest request)
        {
            var marshaller = CreateFacetRequestMarshaller.Instance;
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
        public virtual Task<CreateFacetResponse> CreateFacetAsync(CreateFacetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateFacetRequestMarshaller.Instance;
            var unmarshaller = CreateFacetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFacetRequest,CreateFacetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateIndex


        /// <summary>
        /// Creates an index object. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/cd_indexing.html">Indexing</a>
        /// for more information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIndex service method.</param>
        /// 
        /// <returns>The response from the CreateIndex service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
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
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/CreateIndex">REST API Reference for CreateIndex Operation</seealso>
        public virtual CreateIndexResponse CreateIndex(CreateIndexRequest request)
        {
            var marshaller = CreateIndexRequestMarshaller.Instance;
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
        public virtual Task<CreateIndexResponse> CreateIndexAsync(CreateIndexRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateIndexRequestMarshaller.Instance;
            var unmarshaller = CreateIndexResponseUnmarshaller.Instance;

            return InvokeAsync<CreateIndexRequest,CreateIndexResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateObject


        /// <summary>
        /// Creates an object in a <a>Directory</a>. Additionally attaches the object to a parent,
        /// if a parent reference and <code>LinkName</code> is specified. An object is simply
        /// a collection of <a>Facet</a> attributes. You can also use this API call to create
        /// a policy object, if the facet from which you create the object is a policy facet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateObject service method.</param>
        /// 
        /// <returns>The response from the CreateObject service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
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
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/CreateObject">REST API Reference for CreateObject Operation</seealso>
        public virtual CreateObjectResponse CreateObject(CreateObjectRequest request)
        {
            var marshaller = CreateObjectRequestMarshaller.Instance;
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
        public virtual Task<CreateObjectResponse> CreateObjectAsync(CreateObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateObjectRequestMarshaller.Instance;
            var unmarshaller = CreateObjectResponseUnmarshaller.Instance;

            return InvokeAsync<CreateObjectRequest,CreateObjectResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateSchema


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
        /// 
        /// <returns>The response from the CreateSchema service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
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
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/CreateSchema">REST API Reference for CreateSchema Operation</seealso>
        public virtual CreateSchemaResponse CreateSchema(CreateSchemaRequest request)
        {
            var marshaller = CreateSchemaRequestMarshaller.Instance;
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
        public virtual Task<CreateSchemaResponse> CreateSchemaAsync(CreateSchemaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateSchemaRequestMarshaller.Instance;
            var unmarshaller = CreateSchemaResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSchemaRequest,CreateSchemaResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateTypedLinkFacet


        /// <summary>
        /// Creates a <a>TypedLinkFacet</a>. For more information, see <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/objectsandlinks.html#typedlink">Typed
        /// link</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTypedLinkFacet service method.</param>
        /// 
        /// <returns>The response from the CreateTypedLinkFacet service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
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
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/CreateTypedLinkFacet">REST API Reference for CreateTypedLinkFacet Operation</seealso>
        public virtual CreateTypedLinkFacetResponse CreateTypedLinkFacet(CreateTypedLinkFacetRequest request)
        {
            var marshaller = CreateTypedLinkFacetRequestMarshaller.Instance;
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
        public virtual Task<CreateTypedLinkFacetResponse> CreateTypedLinkFacetAsync(CreateTypedLinkFacetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateTypedLinkFacetRequestMarshaller.Instance;
            var unmarshaller = CreateTypedLinkFacetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTypedLinkFacetRequest,CreateTypedLinkFacetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteDirectory


        /// <summary>
        /// Deletes a directory. Only disabled directories can be deleted. A deleted directory
        /// cannot be undone. Exercise extreme caution when deleting directories.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDirectory service method.</param>
        /// 
        /// <returns>The response from the DeleteDirectory service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
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
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DeleteDirectory">REST API Reference for DeleteDirectory Operation</seealso>
        public virtual DeleteDirectoryResponse DeleteDirectory(DeleteDirectoryRequest request)
        {
            var marshaller = DeleteDirectoryRequestMarshaller.Instance;
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
        public virtual Task<DeleteDirectoryResponse> DeleteDirectoryAsync(DeleteDirectoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteDirectoryRequestMarshaller.Instance;
            var unmarshaller = DeleteDirectoryResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDirectoryRequest,DeleteDirectoryResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteFacet


        /// <summary>
        /// Deletes a given <a>Facet</a>. All attributes and <a>Rule</a>s that are associated
        /// with the facet will be deleted. Only development schema facets are allowed deletion.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFacet service method.</param>
        /// 
        /// <returns>The response from the DeleteFacet service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
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
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DeleteFacet">REST API Reference for DeleteFacet Operation</seealso>
        public virtual DeleteFacetResponse DeleteFacet(DeleteFacetRequest request)
        {
            var marshaller = DeleteFacetRequestMarshaller.Instance;
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
        public virtual Task<DeleteFacetResponse> DeleteFacetAsync(DeleteFacetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteFacetRequestMarshaller.Instance;
            var unmarshaller = DeleteFacetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFacetRequest,DeleteFacetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteObject


        /// <summary>
        /// Deletes an object and its associated attributes. Only objects with no children and
        /// no parents can be deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteObject service method.</param>
        /// 
        /// <returns>The response from the DeleteObject service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
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
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DeleteObject">REST API Reference for DeleteObject Operation</seealso>
        public virtual DeleteObjectResponse DeleteObject(DeleteObjectRequest request)
        {
            var marshaller = DeleteObjectRequestMarshaller.Instance;
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
        public virtual Task<DeleteObjectResponse> DeleteObjectAsync(DeleteObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteObjectRequestMarshaller.Instance;
            var unmarshaller = DeleteObjectResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteObjectRequest,DeleteObjectResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteSchema


        /// <summary>
        /// Deletes a given schema. Schemas in a development and published state can only be deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSchema service method.</param>
        /// 
        /// <returns>The response from the DeleteSchema service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
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
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DeleteSchema">REST API Reference for DeleteSchema Operation</seealso>
        public virtual DeleteSchemaResponse DeleteSchema(DeleteSchemaRequest request)
        {
            var marshaller = DeleteSchemaRequestMarshaller.Instance;
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
        public virtual Task<DeleteSchemaResponse> DeleteSchemaAsync(DeleteSchemaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteSchemaRequestMarshaller.Instance;
            var unmarshaller = DeleteSchemaResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSchemaRequest,DeleteSchemaResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteTypedLinkFacet


        /// <summary>
        /// Deletes a <a>TypedLinkFacet</a>. For more information, see <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/objectsandlinks.html#typedlink">Typed
        /// link</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTypedLinkFacet service method.</param>
        /// 
        /// <returns>The response from the DeleteTypedLinkFacet service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
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
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DeleteTypedLinkFacet">REST API Reference for DeleteTypedLinkFacet Operation</seealso>
        public virtual DeleteTypedLinkFacetResponse DeleteTypedLinkFacet(DeleteTypedLinkFacetRequest request)
        {
            var marshaller = DeleteTypedLinkFacetRequestMarshaller.Instance;
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
        public virtual Task<DeleteTypedLinkFacetResponse> DeleteTypedLinkFacetAsync(DeleteTypedLinkFacetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteTypedLinkFacetRequestMarshaller.Instance;
            var unmarshaller = DeleteTypedLinkFacetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTypedLinkFacetRequest,DeleteTypedLinkFacetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DetachFromIndex


        /// <summary>
        /// Detaches the specified object from the specified index.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachFromIndex service method.</param>
        /// 
        /// <returns>The response from the DetachFromIndex service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
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
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DetachFromIndex">REST API Reference for DetachFromIndex Operation</seealso>
        public virtual DetachFromIndexResponse DetachFromIndex(DetachFromIndexRequest request)
        {
            var marshaller = DetachFromIndexRequestMarshaller.Instance;
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
        public virtual Task<DetachFromIndexResponse> DetachFromIndexAsync(DetachFromIndexRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DetachFromIndexRequestMarshaller.Instance;
            var unmarshaller = DetachFromIndexResponseUnmarshaller.Instance;

            return InvokeAsync<DetachFromIndexRequest,DetachFromIndexResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DetachObject


        /// <summary>
        /// Detaches a given object from the parent object. The object that is to be detached
        /// from the parent is specified by the link name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachObject service method.</param>
        /// 
        /// <returns>The response from the DetachObject service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
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
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.NotNodeException">
        /// Occurs when any invalid operations are performed on an object that is not a node,
        /// such as calling <code>ListObjectChildren</code> for a leaf node object.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DetachObject">REST API Reference for DetachObject Operation</seealso>
        public virtual DetachObjectResponse DetachObject(DetachObjectRequest request)
        {
            var marshaller = DetachObjectRequestMarshaller.Instance;
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
        public virtual Task<DetachObjectResponse> DetachObjectAsync(DetachObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DetachObjectRequestMarshaller.Instance;
            var unmarshaller = DetachObjectResponseUnmarshaller.Instance;

            return InvokeAsync<DetachObjectRequest,DetachObjectResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DetachPolicy


        /// <summary>
        /// Detaches a policy from an object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachPolicy service method.</param>
        /// 
        /// <returns>The response from the DetachPolicy service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
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
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DetachPolicy">REST API Reference for DetachPolicy Operation</seealso>
        public virtual DetachPolicyResponse DetachPolicy(DetachPolicyRequest request)
        {
            var marshaller = DetachPolicyRequestMarshaller.Instance;
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
        public virtual Task<DetachPolicyResponse> DetachPolicyAsync(DetachPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DetachPolicyRequestMarshaller.Instance;
            var unmarshaller = DetachPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DetachPolicyRequest,DetachPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DetachTypedLink


        /// <summary>
        /// Detaches a typed link from a specified source and target object. For more information,
        /// see <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/objectsandlinks.html#typedlink">Typed
        /// link</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachTypedLink service method.</param>
        /// 
        /// <returns>The response from the DetachTypedLink service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
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
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DetachTypedLink">REST API Reference for DetachTypedLink Operation</seealso>
        public virtual DetachTypedLinkResponse DetachTypedLink(DetachTypedLinkRequest request)
        {
            var marshaller = DetachTypedLinkRequestMarshaller.Instance;
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
        public virtual Task<DetachTypedLinkResponse> DetachTypedLinkAsync(DetachTypedLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DetachTypedLinkRequestMarshaller.Instance;
            var unmarshaller = DetachTypedLinkResponseUnmarshaller.Instance;

            return InvokeAsync<DetachTypedLinkRequest,DetachTypedLinkResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisableDirectory


        /// <summary>
        /// Disables the specified directory. Disabled directories cannot be read or written to.
        /// Only enabled directories can be disabled. Disabled directories may be reenabled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableDirectory service method.</param>
        /// 
        /// <returns>The response from the DisableDirectory service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
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
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DisableDirectory">REST API Reference for DisableDirectory Operation</seealso>
        public virtual DisableDirectoryResponse DisableDirectory(DisableDirectoryRequest request)
        {
            var marshaller = DisableDirectoryRequestMarshaller.Instance;
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
        public virtual Task<DisableDirectoryResponse> DisableDirectoryAsync(DisableDirectoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DisableDirectoryRequestMarshaller.Instance;
            var unmarshaller = DisableDirectoryResponseUnmarshaller.Instance;

            return InvokeAsync<DisableDirectoryRequest,DisableDirectoryResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  EnableDirectory


        /// <summary>
        /// Enables the specified directory. Only disabled directories can be enabled. Once enabled,
        /// the directory can then be read and written to.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableDirectory service method.</param>
        /// 
        /// <returns>The response from the EnableDirectory service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
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
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/EnableDirectory">REST API Reference for EnableDirectory Operation</seealso>
        public virtual EnableDirectoryResponse EnableDirectory(EnableDirectoryRequest request)
        {
            var marshaller = EnableDirectoryRequestMarshaller.Instance;
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
        public virtual Task<EnableDirectoryResponse> EnableDirectoryAsync(EnableDirectoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = EnableDirectoryRequestMarshaller.Instance;
            var unmarshaller = EnableDirectoryResponseUnmarshaller.Instance;

            return InvokeAsync<EnableDirectoryRequest,EnableDirectoryResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetAppliedSchemaVersion


        /// <summary>
        /// Returns current applied schema version ARN, including the minor version in use.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAppliedSchemaVersion service method.</param>
        /// 
        /// <returns>The response from the GetAppliedSchemaVersion service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
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
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/GetAppliedSchemaVersion">REST API Reference for GetAppliedSchemaVersion Operation</seealso>
        public virtual GetAppliedSchemaVersionResponse GetAppliedSchemaVersion(GetAppliedSchemaVersionRequest request)
        {
            var marshaller = GetAppliedSchemaVersionRequestMarshaller.Instance;
            var unmarshaller = GetAppliedSchemaVersionResponseUnmarshaller.Instance;

            return Invoke<GetAppliedSchemaVersionRequest,GetAppliedSchemaVersionResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/GetAppliedSchemaVersion">REST API Reference for GetAppliedSchemaVersion Operation</seealso>
        public virtual Task<GetAppliedSchemaVersionResponse> GetAppliedSchemaVersionAsync(GetAppliedSchemaVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetAppliedSchemaVersionRequestMarshaller.Instance;
            var unmarshaller = GetAppliedSchemaVersionResponseUnmarshaller.Instance;

            return InvokeAsync<GetAppliedSchemaVersionRequest,GetAppliedSchemaVersionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDirectory


        /// <summary>
        /// Retrieves metadata about a directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDirectory service method.</param>
        /// 
        /// <returns>The response from the GetDirectory service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
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
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/GetDirectory">REST API Reference for GetDirectory Operation</seealso>
        public virtual GetDirectoryResponse GetDirectory(GetDirectoryRequest request)
        {
            var marshaller = GetDirectoryRequestMarshaller.Instance;
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
        public virtual Task<GetDirectoryResponse> GetDirectoryAsync(GetDirectoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetDirectoryRequestMarshaller.Instance;
            var unmarshaller = GetDirectoryResponseUnmarshaller.Instance;

            return InvokeAsync<GetDirectoryRequest,GetDirectoryResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetFacet


        /// <summary>
        /// Gets details of the <a>Facet</a>, such as facet name, attributes, <a>Rule</a>s, or
        /// <code>ObjectType</code>. You can call this on all kinds of schema facets -- published,
        /// development, or applied.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFacet service method.</param>
        /// 
        /// <returns>The response from the GetFacet service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
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
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/GetFacet">REST API Reference for GetFacet Operation</seealso>
        public virtual GetFacetResponse GetFacet(GetFacetRequest request)
        {
            var marshaller = GetFacetRequestMarshaller.Instance;
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
        public virtual Task<GetFacetResponse> GetFacetAsync(GetFacetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetFacetRequestMarshaller.Instance;
            var unmarshaller = GetFacetResponseUnmarshaller.Instance;

            return InvokeAsync<GetFacetRequest,GetFacetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetObjectAttributes


        /// <summary>
        /// Retrieves attributes within a facet that are associated with an object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetObjectAttributes service method.</param>
        /// 
        /// <returns>The response from the GetObjectAttributes service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
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
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/GetObjectAttributes">REST API Reference for GetObjectAttributes Operation</seealso>
        public virtual GetObjectAttributesResponse GetObjectAttributes(GetObjectAttributesRequest request)
        {
            var marshaller = GetObjectAttributesRequestMarshaller.Instance;
            var unmarshaller = GetObjectAttributesResponseUnmarshaller.Instance;

            return Invoke<GetObjectAttributesRequest,GetObjectAttributesResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/GetObjectAttributes">REST API Reference for GetObjectAttributes Operation</seealso>
        public virtual Task<GetObjectAttributesResponse> GetObjectAttributesAsync(GetObjectAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetObjectAttributesRequestMarshaller.Instance;
            var unmarshaller = GetObjectAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<GetObjectAttributesRequest,GetObjectAttributesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetObjectInformation


        /// <summary>
        /// Retrieves metadata about an object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetObjectInformation service method.</param>
        /// 
        /// <returns>The response from the GetObjectInformation service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
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
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/GetObjectInformation">REST API Reference for GetObjectInformation Operation</seealso>
        public virtual GetObjectInformationResponse GetObjectInformation(GetObjectInformationRequest request)
        {
            var marshaller = GetObjectInformationRequestMarshaller.Instance;
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
        public virtual Task<GetObjectInformationResponse> GetObjectInformationAsync(GetObjectInformationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetObjectInformationRequestMarshaller.Instance;
            var unmarshaller = GetObjectInformationResponseUnmarshaller.Instance;

            return InvokeAsync<GetObjectInformationRequest,GetObjectInformationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetSchemaAsJson


        /// <summary>
        /// Retrieves a JSON representation of the schema. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/cd_schemas.html#jsonformat">JSON
        /// Schema Format</a> for more information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSchemaAsJson service method.</param>
        /// 
        /// <returns>The response from the GetSchemaAsJson service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
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
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
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
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/GetSchemaAsJson">REST API Reference for GetSchemaAsJson Operation</seealso>
        public virtual GetSchemaAsJsonResponse GetSchemaAsJson(GetSchemaAsJsonRequest request)
        {
            var marshaller = GetSchemaAsJsonRequestMarshaller.Instance;
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
        public virtual Task<GetSchemaAsJsonResponse> GetSchemaAsJsonAsync(GetSchemaAsJsonRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetSchemaAsJsonRequestMarshaller.Instance;
            var unmarshaller = GetSchemaAsJsonResponseUnmarshaller.Instance;

            return InvokeAsync<GetSchemaAsJsonRequest,GetSchemaAsJsonResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetTypedLinkFacetInformation


        /// <summary>
        /// Returns the identity attribute order for a specific <a>TypedLinkFacet</a>. For more
        /// information, see <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/objectsandlinks.html#typedlink">Typed
        /// link</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTypedLinkFacetInformation service method.</param>
        /// 
        /// <returns>The response from the GetTypedLinkFacetInformation service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
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
        /// Indicates that the <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/GetTypedLinkFacetInformation">REST API Reference for GetTypedLinkFacetInformation Operation</seealso>
        public virtual GetTypedLinkFacetInformationResponse GetTypedLinkFacetInformation(GetTypedLinkFacetInformationRequest request)
        {
            var marshaller = GetTypedLinkFacetInformationRequestMarshaller.Instance;
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
        public virtual Task<GetTypedLinkFacetInformationResponse> GetTypedLinkFacetInformationAsync(GetTypedLinkFacetInformationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetTypedLinkFacetInformationRequestMarshaller.Instance;
            var unmarshaller = GetTypedLinkFacetInformationResponseUnmarshaller.Instance;

            return InvokeAsync<GetTypedLinkFacetInformationRequest,GetTypedLinkFacetInformationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListAppliedSchemaArns


        /// <summary>
        /// Lists schema major versions applied to a directory. If <code>SchemaArn</code> is provided,
        /// lists the minor version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppliedSchemaArns service method.</param>
        /// 
        /// <returns>The response from the ListAppliedSchemaArns service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
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
        /// Indicates that the <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListAppliedSchemaArns">REST API Reference for ListAppliedSchemaArns Operation</seealso>
        public virtual ListAppliedSchemaArnsResponse ListAppliedSchemaArns(ListAppliedSchemaArnsRequest request)
        {
            var marshaller = ListAppliedSchemaArnsRequestMarshaller.Instance;
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
        public virtual Task<ListAppliedSchemaArnsResponse> ListAppliedSchemaArnsAsync(ListAppliedSchemaArnsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListAppliedSchemaArnsRequestMarshaller.Instance;
            var unmarshaller = ListAppliedSchemaArnsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAppliedSchemaArnsRequest,ListAppliedSchemaArnsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListAttachedIndices


        /// <summary>
        /// Lists indices attached to the specified object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAttachedIndices service method.</param>
        /// 
        /// <returns>The response from the ListAttachedIndices service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
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
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListAttachedIndices">REST API Reference for ListAttachedIndices Operation</seealso>
        public virtual ListAttachedIndicesResponse ListAttachedIndices(ListAttachedIndicesRequest request)
        {
            var marshaller = ListAttachedIndicesRequestMarshaller.Instance;
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
        public virtual Task<ListAttachedIndicesResponse> ListAttachedIndicesAsync(ListAttachedIndicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListAttachedIndicesRequestMarshaller.Instance;
            var unmarshaller = ListAttachedIndicesResponseUnmarshaller.Instance;

            return InvokeAsync<ListAttachedIndicesRequest,ListAttachedIndicesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListDevelopmentSchemaArns


        /// <summary>
        /// Retrieves each Amazon Resource Name (ARN) of schemas in the development state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDevelopmentSchemaArns service method.</param>
        /// 
        /// <returns>The response from the ListDevelopmentSchemaArns service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
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
        /// Indicates that the <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListDevelopmentSchemaArns">REST API Reference for ListDevelopmentSchemaArns Operation</seealso>
        public virtual ListDevelopmentSchemaArnsResponse ListDevelopmentSchemaArns(ListDevelopmentSchemaArnsRequest request)
        {
            var marshaller = ListDevelopmentSchemaArnsRequestMarshaller.Instance;
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
        public virtual Task<ListDevelopmentSchemaArnsResponse> ListDevelopmentSchemaArnsAsync(ListDevelopmentSchemaArnsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListDevelopmentSchemaArnsRequestMarshaller.Instance;
            var unmarshaller = ListDevelopmentSchemaArnsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDevelopmentSchemaArnsRequest,ListDevelopmentSchemaArnsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListDirectories


        /// <summary>
        /// Lists directories created within an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDirectories service method.</param>
        /// 
        /// <returns>The response from the ListDirectories service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
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
        /// Indicates that the <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListDirectories">REST API Reference for ListDirectories Operation</seealso>
        public virtual ListDirectoriesResponse ListDirectories(ListDirectoriesRequest request)
        {
            var marshaller = ListDirectoriesRequestMarshaller.Instance;
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
        public virtual Task<ListDirectoriesResponse> ListDirectoriesAsync(ListDirectoriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListDirectoriesRequestMarshaller.Instance;
            var unmarshaller = ListDirectoriesResponseUnmarshaller.Instance;

            return InvokeAsync<ListDirectoriesRequest,ListDirectoriesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListFacetAttributes


        /// <summary>
        /// Retrieves attributes attached to the facet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFacetAttributes service method.</param>
        /// 
        /// <returns>The response from the ListFacetAttributes service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
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
        /// Indicates that the <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListFacetAttributes">REST API Reference for ListFacetAttributes Operation</seealso>
        public virtual ListFacetAttributesResponse ListFacetAttributes(ListFacetAttributesRequest request)
        {
            var marshaller = ListFacetAttributesRequestMarshaller.Instance;
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
        public virtual Task<ListFacetAttributesResponse> ListFacetAttributesAsync(ListFacetAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListFacetAttributesRequestMarshaller.Instance;
            var unmarshaller = ListFacetAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<ListFacetAttributesRequest,ListFacetAttributesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListFacetNames


        /// <summary>
        /// Retrieves the names of facets that exist in a schema.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFacetNames service method.</param>
        /// 
        /// <returns>The response from the ListFacetNames service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
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
        /// Indicates that the <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListFacetNames">REST API Reference for ListFacetNames Operation</seealso>
        public virtual ListFacetNamesResponse ListFacetNames(ListFacetNamesRequest request)
        {
            var marshaller = ListFacetNamesRequestMarshaller.Instance;
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
        public virtual Task<ListFacetNamesResponse> ListFacetNamesAsync(ListFacetNamesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListFacetNamesRequestMarshaller.Instance;
            var unmarshaller = ListFacetNamesResponseUnmarshaller.Instance;

            return InvokeAsync<ListFacetNamesRequest,ListFacetNamesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListIncomingTypedLinks


        /// <summary>
        /// Returns a paginated list of all the incoming <a>TypedLinkSpecifier</a> information
        /// for an object. It also supports filtering by typed link facet and identity attributes.
        /// For more information, see <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/objectsandlinks.html#typedlink">Typed
        /// link</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIncomingTypedLinks service method.</param>
        /// 
        /// <returns>The response from the ListIncomingTypedLinks service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
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
        /// Indicates that the <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListIncomingTypedLinks">REST API Reference for ListIncomingTypedLinks Operation</seealso>
        public virtual ListIncomingTypedLinksResponse ListIncomingTypedLinks(ListIncomingTypedLinksRequest request)
        {
            var marshaller = ListIncomingTypedLinksRequestMarshaller.Instance;
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
        public virtual Task<ListIncomingTypedLinksResponse> ListIncomingTypedLinksAsync(ListIncomingTypedLinksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListIncomingTypedLinksRequestMarshaller.Instance;
            var unmarshaller = ListIncomingTypedLinksResponseUnmarshaller.Instance;

            return InvokeAsync<ListIncomingTypedLinksRequest,ListIncomingTypedLinksResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListIndex


        /// <summary>
        /// Lists objects attached to the specified index.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIndex service method.</param>
        /// 
        /// <returns>The response from the ListIndex service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
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
        /// Indicates that the <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListIndex">REST API Reference for ListIndex Operation</seealso>
        public virtual ListIndexResponse ListIndex(ListIndexRequest request)
        {
            var marshaller = ListIndexRequestMarshaller.Instance;
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
        public virtual Task<ListIndexResponse> ListIndexAsync(ListIndexRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListIndexRequestMarshaller.Instance;
            var unmarshaller = ListIndexResponseUnmarshaller.Instance;

            return InvokeAsync<ListIndexRequest,ListIndexResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListObjectAttributes


        /// <summary>
        /// Lists all attributes that are associated with an object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListObjectAttributes service method.</param>
        /// 
        /// <returns>The response from the ListObjectAttributes service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
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
        /// Indicates that the <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListObjectAttributes">REST API Reference for ListObjectAttributes Operation</seealso>
        public virtual ListObjectAttributesResponse ListObjectAttributes(ListObjectAttributesRequest request)
        {
            var marshaller = ListObjectAttributesRequestMarshaller.Instance;
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
        public virtual Task<ListObjectAttributesResponse> ListObjectAttributesAsync(ListObjectAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListObjectAttributesRequestMarshaller.Instance;
            var unmarshaller = ListObjectAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<ListObjectAttributesRequest,ListObjectAttributesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListObjectChildren


        /// <summary>
        /// Returns a paginated list of child objects that are associated with a given object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListObjectChildren service method.</param>
        /// 
        /// <returns>The response from the ListObjectChildren service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
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
        /// Indicates that the <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.NotNodeException">
        /// Occurs when any invalid operations are performed on an object that is not a node,
        /// such as calling <code>ListObjectChildren</code> for a leaf node object.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListObjectChildren">REST API Reference for ListObjectChildren Operation</seealso>
        public virtual ListObjectChildrenResponse ListObjectChildren(ListObjectChildrenRequest request)
        {
            var marshaller = ListObjectChildrenRequestMarshaller.Instance;
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
        public virtual Task<ListObjectChildrenResponse> ListObjectChildrenAsync(ListObjectChildrenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListObjectChildrenRequestMarshaller.Instance;
            var unmarshaller = ListObjectChildrenResponseUnmarshaller.Instance;

            return InvokeAsync<ListObjectChildrenRequest,ListObjectChildrenResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListObjectParentPaths


        /// <summary>
        /// Retrieves all available parent paths for any object type such as node, leaf node,
        /// policy node, and index node objects. For more information about objects, see <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/cd_key_concepts.html#dirstructure">Directory
        /// Structure</a>.
        /// 
        ///  
        /// <para>
        /// Use this API to evaluate all parents for an object. The call returns all objects from
        /// the root of the directory up to the requested object. The API returns the number of
        /// paths based on user-defined <code>MaxResults</code>, in case there are multiple paths
        /// to the parent. The order of the paths and nodes returned is consistent among multiple
        /// API calls unless the objects are deleted or moved. Paths not leading to the directory
        /// root are ignored from the target object.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListObjectParentPaths service method.</param>
        /// 
        /// <returns>The response from the ListObjectParentPaths service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
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
        /// Indicates that the <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListObjectParentPaths">REST API Reference for ListObjectParentPaths Operation</seealso>
        public virtual ListObjectParentPathsResponse ListObjectParentPaths(ListObjectParentPathsRequest request)
        {
            var marshaller = ListObjectParentPathsRequestMarshaller.Instance;
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
        public virtual Task<ListObjectParentPathsResponse> ListObjectParentPathsAsync(ListObjectParentPathsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListObjectParentPathsRequestMarshaller.Instance;
            var unmarshaller = ListObjectParentPathsResponseUnmarshaller.Instance;

            return InvokeAsync<ListObjectParentPathsRequest,ListObjectParentPathsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListObjectParents


        /// <summary>
        /// Lists parent objects that are associated with a given object in pagination fashion.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListObjectParents service method.</param>
        /// 
        /// <returns>The response from the ListObjectParents service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
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
        /// Indicates that the <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListObjectParents">REST API Reference for ListObjectParents Operation</seealso>
        public virtual ListObjectParentsResponse ListObjectParents(ListObjectParentsRequest request)
        {
            var marshaller = ListObjectParentsRequestMarshaller.Instance;
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
        public virtual Task<ListObjectParentsResponse> ListObjectParentsAsync(ListObjectParentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListObjectParentsRequestMarshaller.Instance;
            var unmarshaller = ListObjectParentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListObjectParentsRequest,ListObjectParentsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListObjectPolicies


        /// <summary>
        /// Returns policies attached to an object in pagination fashion.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListObjectPolicies service method.</param>
        /// 
        /// <returns>The response from the ListObjectPolicies service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
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
        /// Indicates that the <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListObjectPolicies">REST API Reference for ListObjectPolicies Operation</seealso>
        public virtual ListObjectPoliciesResponse ListObjectPolicies(ListObjectPoliciesRequest request)
        {
            var marshaller = ListObjectPoliciesRequestMarshaller.Instance;
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
        public virtual Task<ListObjectPoliciesResponse> ListObjectPoliciesAsync(ListObjectPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListObjectPoliciesRequestMarshaller.Instance;
            var unmarshaller = ListObjectPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<ListObjectPoliciesRequest,ListObjectPoliciesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListOutgoingTypedLinks


        /// <summary>
        /// Returns a paginated list of all the outgoing <a>TypedLinkSpecifier</a> information
        /// for an object. It also supports filtering by typed link facet and identity attributes.
        /// For more information, see <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/objectsandlinks.html#typedlink">Typed
        /// link</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOutgoingTypedLinks service method.</param>
        /// 
        /// <returns>The response from the ListOutgoingTypedLinks service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
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
        /// Indicates that the <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListOutgoingTypedLinks">REST API Reference for ListOutgoingTypedLinks Operation</seealso>
        public virtual ListOutgoingTypedLinksResponse ListOutgoingTypedLinks(ListOutgoingTypedLinksRequest request)
        {
            var marshaller = ListOutgoingTypedLinksRequestMarshaller.Instance;
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
        public virtual Task<ListOutgoingTypedLinksResponse> ListOutgoingTypedLinksAsync(ListOutgoingTypedLinksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListOutgoingTypedLinksRequestMarshaller.Instance;
            var unmarshaller = ListOutgoingTypedLinksResponseUnmarshaller.Instance;

            return InvokeAsync<ListOutgoingTypedLinksRequest,ListOutgoingTypedLinksResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListPolicyAttachments


        /// <summary>
        /// Returns all of the <code>ObjectIdentifiers</code> to which a given policy is attached.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPolicyAttachments service method.</param>
        /// 
        /// <returns>The response from the ListPolicyAttachments service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
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
        /// Indicates that the <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListPolicyAttachments">REST API Reference for ListPolicyAttachments Operation</seealso>
        public virtual ListPolicyAttachmentsResponse ListPolicyAttachments(ListPolicyAttachmentsRequest request)
        {
            var marshaller = ListPolicyAttachmentsRequestMarshaller.Instance;
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
        public virtual Task<ListPolicyAttachmentsResponse> ListPolicyAttachmentsAsync(ListPolicyAttachmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListPolicyAttachmentsRequestMarshaller.Instance;
            var unmarshaller = ListPolicyAttachmentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPolicyAttachmentsRequest,ListPolicyAttachmentsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListPublishedSchemaArns


        /// <summary>
        /// Lists the major version families of each published schema. If a major version ARN
        /// is provided as <code>SchemaArn</code>, the minor version revisions in that family
        /// are listed instead.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPublishedSchemaArns service method.</param>
        /// 
        /// <returns>The response from the ListPublishedSchemaArns service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
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
        /// Indicates that the <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListPublishedSchemaArns">REST API Reference for ListPublishedSchemaArns Operation</seealso>
        public virtual ListPublishedSchemaArnsResponse ListPublishedSchemaArns(ListPublishedSchemaArnsRequest request)
        {
            var marshaller = ListPublishedSchemaArnsRequestMarshaller.Instance;
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
        public virtual Task<ListPublishedSchemaArnsResponse> ListPublishedSchemaArnsAsync(ListPublishedSchemaArnsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListPublishedSchemaArnsRequestMarshaller.Instance;
            var unmarshaller = ListPublishedSchemaArnsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPublishedSchemaArnsRequest,ListPublishedSchemaArnsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Returns tags for a resource. Tagging is currently supported only for directories with
        /// a limit of 50 tags per directory. All 50 tags are returned for a given directory with
        /// this API call.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
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
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var marshaller = ListTagsForResourceRequestMarshaller.Instance;
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
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListTagsForResourceRequestMarshaller.Instance;
            var unmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceRequest,ListTagsForResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListTypedLinkFacetAttributes


        /// <summary>
        /// Returns a paginated list of all attribute definitions for a particular <a>TypedLinkFacet</a>.
        /// For more information, see <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/objectsandlinks.html#typedlink">Typed
        /// link</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTypedLinkFacetAttributes service method.</param>
        /// 
        /// <returns>The response from the ListTypedLinkFacetAttributes service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
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
        /// Indicates that the <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListTypedLinkFacetAttributes">REST API Reference for ListTypedLinkFacetAttributes Operation</seealso>
        public virtual ListTypedLinkFacetAttributesResponse ListTypedLinkFacetAttributes(ListTypedLinkFacetAttributesRequest request)
        {
            var marshaller = ListTypedLinkFacetAttributesRequestMarshaller.Instance;
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
        public virtual Task<ListTypedLinkFacetAttributesResponse> ListTypedLinkFacetAttributesAsync(ListTypedLinkFacetAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListTypedLinkFacetAttributesRequestMarshaller.Instance;
            var unmarshaller = ListTypedLinkFacetAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<ListTypedLinkFacetAttributesRequest,ListTypedLinkFacetAttributesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListTypedLinkFacetNames


        /// <summary>
        /// Returns a paginated list of <code>TypedLink</code> facet names for a particular schema.
        /// For more information, see <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/objectsandlinks.html#typedlink">Typed
        /// link</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTypedLinkFacetNames service method.</param>
        /// 
        /// <returns>The response from the ListTypedLinkFacetNames service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
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
        /// Indicates that the <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListTypedLinkFacetNames">REST API Reference for ListTypedLinkFacetNames Operation</seealso>
        public virtual ListTypedLinkFacetNamesResponse ListTypedLinkFacetNames(ListTypedLinkFacetNamesRequest request)
        {
            var marshaller = ListTypedLinkFacetNamesRequestMarshaller.Instance;
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
        public virtual Task<ListTypedLinkFacetNamesResponse> ListTypedLinkFacetNamesAsync(ListTypedLinkFacetNamesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListTypedLinkFacetNamesRequestMarshaller.Instance;
            var unmarshaller = ListTypedLinkFacetNamesResponseUnmarshaller.Instance;

            return InvokeAsync<ListTypedLinkFacetNamesRequest,ListTypedLinkFacetNamesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  LookupPolicy


        /// <summary>
        /// Lists all policies from the root of the <a>Directory</a> to the object specified.
        /// If there are no policies present, an empty list is returned. If policies are present,
        /// and if some objects don't have the policies attached, it returns the <code>ObjectIdentifier</code>
        /// for such objects. If policies are present, it returns <code>ObjectIdentifier</code>,
        /// <code>policyId</code>, and <code>policyType</code>. Paths that don't lead to the root
        /// from the target object are ignored. For more information, see <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/cd_key_concepts.html#policies">Policies</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the LookupPolicy service method.</param>
        /// 
        /// <returns>The response from the LookupPolicy service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
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
        /// Indicates that the <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/LookupPolicy">REST API Reference for LookupPolicy Operation</seealso>
        public virtual LookupPolicyResponse LookupPolicy(LookupPolicyRequest request)
        {
            var marshaller = LookupPolicyRequestMarshaller.Instance;
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
        public virtual Task<LookupPolicyResponse> LookupPolicyAsync(LookupPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = LookupPolicyRequestMarshaller.Instance;
            var unmarshaller = LookupPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<LookupPolicyRequest,LookupPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PublishSchema


        /// <summary>
        /// Publishes a development schema with a major version and a recommended minor version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PublishSchema service method.</param>
        /// 
        /// <returns>The response from the PublishSchema service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
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
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/PublishSchema">REST API Reference for PublishSchema Operation</seealso>
        public virtual PublishSchemaResponse PublishSchema(PublishSchemaRequest request)
        {
            var marshaller = PublishSchemaRequestMarshaller.Instance;
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
        public virtual Task<PublishSchemaResponse> PublishSchemaAsync(PublishSchemaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = PublishSchemaRequestMarshaller.Instance;
            var unmarshaller = PublishSchemaResponseUnmarshaller.Instance;

            return InvokeAsync<PublishSchemaRequest,PublishSchemaResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutSchemaFromJson


        /// <summary>
        /// Allows a schema to be updated using JSON upload. Only available for development schemas.
        /// See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/cd_schemas.html#jsonformat">JSON
        /// Schema Format</a> for more information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutSchemaFromJson service method.</param>
        /// 
        /// <returns>The response from the PutSchemaFromJson service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
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
        /// Indicates that the provided <code>SchemaDoc</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/PutSchemaFromJson">REST API Reference for PutSchemaFromJson Operation</seealso>
        public virtual PutSchemaFromJsonResponse PutSchemaFromJson(PutSchemaFromJsonRequest request)
        {
            var marshaller = PutSchemaFromJsonRequestMarshaller.Instance;
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
        public virtual Task<PutSchemaFromJsonResponse> PutSchemaFromJsonAsync(PutSchemaFromJsonRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = PutSchemaFromJsonRequestMarshaller.Instance;
            var unmarshaller = PutSchemaFromJsonResponseUnmarshaller.Instance;

            return InvokeAsync<PutSchemaFromJsonRequest,PutSchemaFromJsonResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RemoveFacetFromObject


        /// <summary>
        /// Removes the specified facet from the specified object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveFacetFromObject service method.</param>
        /// 
        /// <returns>The response from the RemoveFacetFromObject service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
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
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/RemoveFacetFromObject">REST API Reference for RemoveFacetFromObject Operation</seealso>
        public virtual RemoveFacetFromObjectResponse RemoveFacetFromObject(RemoveFacetFromObjectRequest request)
        {
            var marshaller = RemoveFacetFromObjectRequestMarshaller.Instance;
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
        public virtual Task<RemoveFacetFromObjectResponse> RemoveFacetFromObjectAsync(RemoveFacetFromObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RemoveFacetFromObjectRequestMarshaller.Instance;
            var unmarshaller = RemoveFacetFromObjectResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveFacetFromObjectRequest,RemoveFacetFromObjectResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// An API operation for adding tags to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
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
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var marshaller = TagResourceRequestMarshaller.Instance;
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
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = TagResourceRequestMarshaller.Instance;
            var unmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceRequest,TagResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// An API operation for removing tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
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
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var marshaller = UntagResourceRequestMarshaller.Instance;
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
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UntagResourceRequestMarshaller.Instance;
            var unmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceRequest,UntagResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateFacet


        /// <summary>
        /// Does the following:
        /// 
        ///  <ol> <li> 
        /// <para>
        /// Adds new <code>Attributes</code>, <code>Rules</code>, or <code>ObjectTypes</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Updates existing <code>Attributes</code>, <code>Rules</code>, or <code>ObjectTypes</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Deletes existing <code>Attributes</code>, <code>Rules</code>, or <code>ObjectTypes</code>.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFacet service method.</param>
        /// 
        /// <returns>The response from the UpdateFacet service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
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
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidFacetUpdateException">
        /// An attempt to modify a <a>Facet</a> resulted in an invalid schema exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidRuleException">
        /// Occurs when any of the rule parameter keys or values are invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/UpdateFacet">REST API Reference for UpdateFacet Operation</seealso>
        public virtual UpdateFacetResponse UpdateFacet(UpdateFacetRequest request)
        {
            var marshaller = UpdateFacetRequestMarshaller.Instance;
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
        public virtual Task<UpdateFacetResponse> UpdateFacetAsync(UpdateFacetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateFacetRequestMarshaller.Instance;
            var unmarshaller = UpdateFacetResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFacetRequest,UpdateFacetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateObjectAttributes


        /// <summary>
        /// Updates a given object's attributes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateObjectAttributes service method.</param>
        /// 
        /// <returns>The response from the UpdateObjectAttributes service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
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
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/UpdateObjectAttributes">REST API Reference for UpdateObjectAttributes Operation</seealso>
        public virtual UpdateObjectAttributesResponse UpdateObjectAttributes(UpdateObjectAttributesRequest request)
        {
            var marshaller = UpdateObjectAttributesRequestMarshaller.Instance;
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
        public virtual Task<UpdateObjectAttributesResponse> UpdateObjectAttributesAsync(UpdateObjectAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateObjectAttributesRequestMarshaller.Instance;
            var unmarshaller = UpdateObjectAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateObjectAttributesRequest,UpdateObjectAttributesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateSchema


        /// <summary>
        /// Updates the schema name with a new name. Only development schema names can be updated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSchema service method.</param>
        /// 
        /// <returns>The response from the UpdateSchema service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
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
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/UpdateSchema">REST API Reference for UpdateSchema Operation</seealso>
        public virtual UpdateSchemaResponse UpdateSchema(UpdateSchemaRequest request)
        {
            var marshaller = UpdateSchemaRequestMarshaller.Instance;
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
        public virtual Task<UpdateSchemaResponse> UpdateSchemaAsync(UpdateSchemaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateSchemaRequestMarshaller.Instance;
            var unmarshaller = UpdateSchemaResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSchemaRequest,UpdateSchemaResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateTypedLinkFacet


        /// <summary>
        /// Updates a <a>TypedLinkFacet</a>. For more information, see <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/objectsandlinks.html#typedlink">Typed
        /// link</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTypedLinkFacet service method.</param>
        /// 
        /// <returns>The response from the UpdateTypedLinkFacet service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
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
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/UpdateTypedLinkFacet">REST API Reference for UpdateTypedLinkFacet Operation</seealso>
        public virtual UpdateTypedLinkFacetResponse UpdateTypedLinkFacet(UpdateTypedLinkFacetRequest request)
        {
            var marshaller = UpdateTypedLinkFacetRequestMarshaller.Instance;
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
        public virtual Task<UpdateTypedLinkFacetResponse> UpdateTypedLinkFacetAsync(UpdateTypedLinkFacetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateTypedLinkFacetRequestMarshaller.Instance;
            var unmarshaller = UpdateTypedLinkFacetResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTypedLinkFacetRequest,UpdateTypedLinkFacetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpgradeAppliedSchema


        /// <summary>
        /// Upgrades a single directory in-place using the <code>PublishedSchemaArn</code> with
        /// schema updates found in <code>MinorVersion</code>. Backwards-compatible minor version
        /// upgrades are instantaneously available for readers on all objects in the directory.
        /// Note: This is a synchronous API call and upgrades only one schema on a given directory
        /// per call. To upgrade multiple directories from one schema, you would need to call
        /// this API on each directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpgradeAppliedSchema service method.</param>
        /// 
        /// <returns>The response from the UpgradeAppliedSchema service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
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
        /// Indicates that an attempt to attach an object with the same link name or to apply
        /// a schema with the same name has occurred. Rename the link or the schema and then try
        /// again.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/UpgradeAppliedSchema">REST API Reference for UpgradeAppliedSchema Operation</seealso>
        public virtual UpgradeAppliedSchemaResponse UpgradeAppliedSchema(UpgradeAppliedSchemaRequest request)
        {
            var marshaller = UpgradeAppliedSchemaRequestMarshaller.Instance;
            var unmarshaller = UpgradeAppliedSchemaResponseUnmarshaller.Instance;

            return Invoke<UpgradeAppliedSchemaRequest,UpgradeAppliedSchemaResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/UpgradeAppliedSchema">REST API Reference for UpgradeAppliedSchema Operation</seealso>
        public virtual Task<UpgradeAppliedSchemaResponse> UpgradeAppliedSchemaAsync(UpgradeAppliedSchemaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpgradeAppliedSchemaRequestMarshaller.Instance;
            var unmarshaller = UpgradeAppliedSchemaResponseUnmarshaller.Instance;

            return InvokeAsync<UpgradeAppliedSchemaRequest,UpgradeAppliedSchemaResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpgradePublishedSchema


        /// <summary>
        /// Upgrades a published schema under a new minor version revision using the current contents
        /// of <code>DevelopmentSchemaArn</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpgradePublishedSchema service method.</param>
        /// 
        /// <returns>The response from the UpgradePublishedSchema service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
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
        /// Indicates that an attempt to attach an object with the same link name or to apply
        /// a schema with the same name has occurred. Rename the link or the schema and then try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/UpgradePublishedSchema">REST API Reference for UpgradePublishedSchema Operation</seealso>
        public virtual UpgradePublishedSchemaResponse UpgradePublishedSchema(UpgradePublishedSchemaRequest request)
        {
            var marshaller = UpgradePublishedSchemaRequestMarshaller.Instance;
            var unmarshaller = UpgradePublishedSchemaResponseUnmarshaller.Instance;

            return Invoke<UpgradePublishedSchemaRequest,UpgradePublishedSchemaResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/UpgradePublishedSchema">REST API Reference for UpgradePublishedSchema Operation</seealso>
        public virtual Task<UpgradePublishedSchemaResponse> UpgradePublishedSchemaAsync(UpgradePublishedSchemaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpgradePublishedSchemaRequestMarshaller.Instance;
            var unmarshaller = UpgradePublishedSchemaResponseUnmarshaller.Instance;

            return InvokeAsync<UpgradePublishedSchemaRequest,UpgradePublishedSchemaResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}