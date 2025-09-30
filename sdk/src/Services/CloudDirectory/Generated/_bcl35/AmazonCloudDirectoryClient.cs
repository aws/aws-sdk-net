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
using System.Collections.Generic;
using System.Net;

using Amazon.CloudDirectory.Model;
using Amazon.CloudDirectory.Model.Internal.MarshallTransformations;
using Amazon.CloudDirectory.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

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

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
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
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonCloudDirectoryEndpointResolver());
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

        /// <summary>
        /// Adds a new <a>Facet</a> to an object. An object can have more than one facet applied
        /// on it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddFacetToObject service method.</param>
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
        public virtual AddFacetToObjectResponse AddFacetToObject(AddFacetToObjectRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddFacetToObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddFacetToObjectResponseUnmarshaller.Instance;

            return Invoke<AddFacetToObjectResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddFacetToObject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddFacetToObject operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddFacetToObject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/AddFacetToObject">REST API Reference for AddFacetToObject Operation</seealso>
        public virtual IAsyncResult BeginAddFacetToObject(AddFacetToObjectRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddFacetToObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddFacetToObjectResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AddFacetToObject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddFacetToObject.</param>
        /// 
        /// <returns>Returns a  AddFacetToObjectResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/AddFacetToObject">REST API Reference for AddFacetToObject Operation</seealso>
        public virtual AddFacetToObjectResponse EndAddFacetToObject(IAsyncResult asyncResult)
        {
            return EndInvoke<AddFacetToObjectResponse>(asyncResult);
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
        public virtual ApplySchemaResponse ApplySchema(ApplySchemaRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ApplySchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ApplySchemaResponseUnmarshaller.Instance;

            return Invoke<ApplySchemaResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ApplySchema operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ApplySchema operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndApplySchema
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ApplySchema">REST API Reference for ApplySchema Operation</seealso>
        public virtual IAsyncResult BeginApplySchema(ApplySchemaRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ApplySchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ApplySchemaResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ApplySchema operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginApplySchema.</param>
        /// 
        /// <returns>Returns a  ApplySchemaResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ApplySchema">REST API Reference for ApplySchema Operation</seealso>
        public virtual ApplySchemaResponse EndApplySchema(IAsyncResult asyncResult)
        {
            return EndInvoke<ApplySchemaResponse>(asyncResult);
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
        /// Using <c>ObjectIdentifier</c> 
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachObject service method.</param>
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
        public virtual AttachObjectResponse AttachObject(AttachObjectRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AttachObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachObjectResponseUnmarshaller.Instance;

            return Invoke<AttachObjectResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AttachObject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachObject operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAttachObject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/AttachObject">REST API Reference for AttachObject Operation</seealso>
        public virtual IAsyncResult BeginAttachObject(AttachObjectRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AttachObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachObjectResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AttachObject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachObject.</param>
        /// 
        /// <returns>Returns a  AttachObjectResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/AttachObject">REST API Reference for AttachObject Operation</seealso>
        public virtual AttachObjectResponse EndAttachObject(IAsyncResult asyncResult)
        {
            return EndInvoke<AttachObjectResponse>(asyncResult);
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
        public virtual AttachPolicyResponse AttachPolicy(AttachPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AttachPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachPolicyResponseUnmarshaller.Instance;

            return Invoke<AttachPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AttachPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachPolicy operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAttachPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/AttachPolicy">REST API Reference for AttachPolicy Operation</seealso>
        public virtual IAsyncResult BeginAttachPolicy(AttachPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AttachPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AttachPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachPolicy.</param>
        /// 
        /// <returns>Returns a  AttachPolicyResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/AttachPolicy">REST API Reference for AttachPolicy Operation</seealso>
        public virtual AttachPolicyResponse EndAttachPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<AttachPolicyResponse>(asyncResult);
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
        public virtual AttachToIndexResponse AttachToIndex(AttachToIndexRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AttachToIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachToIndexResponseUnmarshaller.Instance;

            return Invoke<AttachToIndexResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AttachToIndex operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachToIndex operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAttachToIndex
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/AttachToIndex">REST API Reference for AttachToIndex Operation</seealso>
        public virtual IAsyncResult BeginAttachToIndex(AttachToIndexRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AttachToIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachToIndexResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AttachToIndex operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachToIndex.</param>
        /// 
        /// <returns>Returns a  AttachToIndexResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/AttachToIndex">REST API Reference for AttachToIndex Operation</seealso>
        public virtual AttachToIndexResponse EndAttachToIndex(IAsyncResult asyncResult)
        {
            return EndInvoke<AttachToIndexResponse>(asyncResult);
        }

        #endregion
        
        #region  AttachTypedLink

        /// <summary>
        /// Attaches a typed link to a specified source and target object. For more information,
        /// see <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/directory_objects_links.html#directory_objects_links_typedlink">Typed
        /// Links</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachTypedLink service method.</param>
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
        public virtual AttachTypedLinkResponse AttachTypedLink(AttachTypedLinkRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AttachTypedLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachTypedLinkResponseUnmarshaller.Instance;

            return Invoke<AttachTypedLinkResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AttachTypedLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachTypedLink operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAttachTypedLink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/AttachTypedLink">REST API Reference for AttachTypedLink Operation</seealso>
        public virtual IAsyncResult BeginAttachTypedLink(AttachTypedLinkRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AttachTypedLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachTypedLinkResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AttachTypedLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachTypedLink.</param>
        /// 
        /// <returns>Returns a  AttachTypedLinkResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/AttachTypedLink">REST API Reference for AttachTypedLink Operation</seealso>
        public virtual AttachTypedLinkResponse EndAttachTypedLink(IAsyncResult asyncResult)
        {
            return EndInvoke<AttachTypedLinkResponse>(asyncResult);
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
        public virtual BatchReadResponse BatchRead(BatchReadRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchReadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchReadResponseUnmarshaller.Instance;

            return Invoke<BatchReadResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchRead operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchRead operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchRead
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/BatchRead">REST API Reference for BatchRead Operation</seealso>
        public virtual IAsyncResult BeginBatchRead(BatchReadRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchReadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchReadResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchRead operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchRead.</param>
        /// 
        /// <returns>Returns a  BatchReadResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/BatchRead">REST API Reference for BatchRead Operation</seealso>
        public virtual BatchReadResponse EndBatchRead(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchReadResponse>(asyncResult);
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
        public virtual BatchWriteResponse BatchWrite(BatchWriteRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchWriteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchWriteResponseUnmarshaller.Instance;

            return Invoke<BatchWriteResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchWrite operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchWrite operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchWrite
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/BatchWrite">REST API Reference for BatchWrite Operation</seealso>
        public virtual IAsyncResult BeginBatchWrite(BatchWriteRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchWriteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchWriteResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchWrite operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchWrite.</param>
        /// 
        /// <returns>Returns a  BatchWriteResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/BatchWrite">REST API Reference for BatchWrite Operation</seealso>
        public virtual BatchWriteResponse EndBatchWrite(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchWriteResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDirectory

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
        public virtual CreateDirectoryResponse CreateDirectory(CreateDirectoryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDirectoryResponseUnmarshaller.Instance;

            return Invoke<CreateDirectoryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDirectory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDirectory operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDirectory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/CreateDirectory">REST API Reference for CreateDirectory Operation</seealso>
        public virtual IAsyncResult BeginCreateDirectory(CreateDirectoryRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDirectoryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDirectory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDirectory.</param>
        /// 
        /// <returns>Returns a  CreateDirectoryResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/CreateDirectory">REST API Reference for CreateDirectory Operation</seealso>
        public virtual CreateDirectoryResponse EndCreateDirectory(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDirectoryResponse>(asyncResult);
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
        public virtual CreateFacetResponse CreateFacet(CreateFacetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFacetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFacetResponseUnmarshaller.Instance;

            return Invoke<CreateFacetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFacet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFacet operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFacet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/CreateFacet">REST API Reference for CreateFacet Operation</seealso>
        public virtual IAsyncResult BeginCreateFacet(CreateFacetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFacetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFacetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFacet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFacet.</param>
        /// 
        /// <returns>Returns a  CreateFacetResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/CreateFacet">REST API Reference for CreateFacet Operation</seealso>
        public virtual CreateFacetResponse EndCreateFacet(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateFacetResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateIndex

        /// <summary>
        /// Creates an index object. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/indexing_search.html">Indexing
        /// and search</a> for more information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIndex service method.</param>
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
        public virtual CreateIndexResponse CreateIndex(CreateIndexRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIndexResponseUnmarshaller.Instance;

            return Invoke<CreateIndexResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateIndex operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateIndex operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateIndex
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/CreateIndex">REST API Reference for CreateIndex Operation</seealso>
        public virtual IAsyncResult BeginCreateIndex(CreateIndexRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  CreateIndexResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/CreateIndex">REST API Reference for CreateIndex Operation</seealso>
        public virtual CreateIndexResponse EndCreateIndex(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateIndexResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateObject

        /// <summary>
        /// Creates an object in a <a>Directory</a>. Additionally attaches the object to a parent,
        /// if a parent reference and <c>LinkName</c> is specified. An object is simply a collection
        /// of <a>Facet</a> attributes. You can also use this API call to create a policy object,
        /// if the facet from which you create the object is a policy facet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateObject service method.</param>
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
        public virtual CreateObjectResponse CreateObject(CreateObjectRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateObjectResponseUnmarshaller.Instance;

            return Invoke<CreateObjectResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateObject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateObject operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateObject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/CreateObject">REST API Reference for CreateObject Operation</seealso>
        public virtual IAsyncResult BeginCreateObject(CreateObjectRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateObjectResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateObject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateObject.</param>
        /// 
        /// <returns>Returns a  CreateObjectResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/CreateObject">REST API Reference for CreateObject Operation</seealso>
        public virtual CreateObjectResponse EndCreateObject(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateObjectResponse>(asyncResult);
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
        public virtual CreateSchemaResponse CreateSchema(CreateSchemaRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSchemaResponseUnmarshaller.Instance;

            return Invoke<CreateSchemaResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSchema operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSchema operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSchema
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/CreateSchema">REST API Reference for CreateSchema Operation</seealso>
        public virtual IAsyncResult BeginCreateSchema(CreateSchemaRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSchemaResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSchema operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSchema.</param>
        /// 
        /// <returns>Returns a  CreateSchemaResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/CreateSchema">REST API Reference for CreateSchema Operation</seealso>
        public virtual CreateSchemaResponse EndCreateSchema(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSchemaResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateTypedLinkFacet

        /// <summary>
        /// Creates a <a>TypedLinkFacet</a>. For more information, see <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/directory_objects_links.html#directory_objects_links_typedlink">Typed
        /// Links</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTypedLinkFacet service method.</param>
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
        public virtual CreateTypedLinkFacetResponse CreateTypedLinkFacet(CreateTypedLinkFacetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTypedLinkFacetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTypedLinkFacetResponseUnmarshaller.Instance;

            return Invoke<CreateTypedLinkFacetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTypedLinkFacet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTypedLinkFacet operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTypedLinkFacet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/CreateTypedLinkFacet">REST API Reference for CreateTypedLinkFacet Operation</seealso>
        public virtual IAsyncResult BeginCreateTypedLinkFacet(CreateTypedLinkFacetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTypedLinkFacetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTypedLinkFacetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTypedLinkFacet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTypedLinkFacet.</param>
        /// 
        /// <returns>Returns a  CreateTypedLinkFacetResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/CreateTypedLinkFacet">REST API Reference for CreateTypedLinkFacet Operation</seealso>
        public virtual CreateTypedLinkFacetResponse EndCreateTypedLinkFacet(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateTypedLinkFacetResponse>(asyncResult);
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
        public virtual DeleteDirectoryResponse DeleteDirectory(DeleteDirectoryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDirectoryResponseUnmarshaller.Instance;

            return Invoke<DeleteDirectoryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDirectory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDirectory operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDirectory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/DeleteDirectory">REST API Reference for DeleteDirectory Operation</seealso>
        public virtual IAsyncResult BeginDeleteDirectory(DeleteDirectoryRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDirectoryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDirectory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDirectory.</param>
        /// 
        /// <returns>Returns a  DeleteDirectoryResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/DeleteDirectory">REST API Reference for DeleteDirectory Operation</seealso>
        public virtual DeleteDirectoryResponse EndDeleteDirectory(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDirectoryResponse>(asyncResult);
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
        public virtual DeleteFacetResponse DeleteFacet(DeleteFacetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFacetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFacetResponseUnmarshaller.Instance;

            return Invoke<DeleteFacetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFacet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFacet operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFacet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/DeleteFacet">REST API Reference for DeleteFacet Operation</seealso>
        public virtual IAsyncResult BeginDeleteFacet(DeleteFacetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFacetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFacetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFacet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFacet.</param>
        /// 
        /// <returns>Returns a  DeleteFacetResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/DeleteFacet">REST API Reference for DeleteFacet Operation</seealso>
        public virtual DeleteFacetResponse EndDeleteFacet(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteFacetResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteObject

        /// <summary>
        /// Deletes an object and its associated attributes. Only objects with no children and
        /// no parents can be deleted. The maximum number of attributes that can be deleted during
        /// an object deletion is 30. For more information, see <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/limits.html">Amazon
        /// Cloud Directory Limits</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteObject service method.</param>
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
        public virtual DeleteObjectResponse DeleteObject(DeleteObjectRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteObjectResponseUnmarshaller.Instance;

            return Invoke<DeleteObjectResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteObject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteObject operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteObject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/DeleteObject">REST API Reference for DeleteObject Operation</seealso>
        public virtual IAsyncResult BeginDeleteObject(DeleteObjectRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteObjectResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteObject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteObject.</param>
        /// 
        /// <returns>Returns a  DeleteObjectResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/DeleteObject">REST API Reference for DeleteObject Operation</seealso>
        public virtual DeleteObjectResponse EndDeleteObject(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteObjectResponse>(asyncResult);
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
        public virtual DeleteSchemaResponse DeleteSchema(DeleteSchemaRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSchemaResponseUnmarshaller.Instance;

            return Invoke<DeleteSchemaResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSchema operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSchema operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSchema
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/DeleteSchema">REST API Reference for DeleteSchema Operation</seealso>
        public virtual IAsyncResult BeginDeleteSchema(DeleteSchemaRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSchemaResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSchema operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSchema.</param>
        /// 
        /// <returns>Returns a  DeleteSchemaResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/DeleteSchema">REST API Reference for DeleteSchema Operation</seealso>
        public virtual DeleteSchemaResponse EndDeleteSchema(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSchemaResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteTypedLinkFacet

        /// <summary>
        /// Deletes a <a>TypedLinkFacet</a>. For more information, see <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/directory_objects_links.html#directory_objects_links_typedlink">Typed
        /// Links</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTypedLinkFacet service method.</param>
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
        public virtual DeleteTypedLinkFacetResponse DeleteTypedLinkFacet(DeleteTypedLinkFacetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTypedLinkFacetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTypedLinkFacetResponseUnmarshaller.Instance;

            return Invoke<DeleteTypedLinkFacetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTypedLinkFacet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTypedLinkFacet operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTypedLinkFacet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/DeleteTypedLinkFacet">REST API Reference for DeleteTypedLinkFacet Operation</seealso>
        public virtual IAsyncResult BeginDeleteTypedLinkFacet(DeleteTypedLinkFacetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTypedLinkFacetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTypedLinkFacetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTypedLinkFacet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTypedLinkFacet.</param>
        /// 
        /// <returns>Returns a  DeleteTypedLinkFacetResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/DeleteTypedLinkFacet">REST API Reference for DeleteTypedLinkFacet Operation</seealso>
        public virtual DeleteTypedLinkFacetResponse EndDeleteTypedLinkFacet(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteTypedLinkFacetResponse>(asyncResult);
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
        public virtual DetachFromIndexResponse DetachFromIndex(DetachFromIndexRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DetachFromIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachFromIndexResponseUnmarshaller.Instance;

            return Invoke<DetachFromIndexResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DetachFromIndex operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachFromIndex operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetachFromIndex
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/DetachFromIndex">REST API Reference for DetachFromIndex Operation</seealso>
        public virtual IAsyncResult BeginDetachFromIndex(DetachFromIndexRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DetachFromIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachFromIndexResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DetachFromIndex operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachFromIndex.</param>
        /// 
        /// <returns>Returns a  DetachFromIndexResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/DetachFromIndex">REST API Reference for DetachFromIndex Operation</seealso>
        public virtual DetachFromIndexResponse EndDetachFromIndex(IAsyncResult asyncResult)
        {
            return EndInvoke<DetachFromIndexResponse>(asyncResult);
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
        public virtual DetachObjectResponse DetachObject(DetachObjectRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DetachObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachObjectResponseUnmarshaller.Instance;

            return Invoke<DetachObjectResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DetachObject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachObject operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetachObject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/DetachObject">REST API Reference for DetachObject Operation</seealso>
        public virtual IAsyncResult BeginDetachObject(DetachObjectRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DetachObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachObjectResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DetachObject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachObject.</param>
        /// 
        /// <returns>Returns a  DetachObjectResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/DetachObject">REST API Reference for DetachObject Operation</seealso>
        public virtual DetachObjectResponse EndDetachObject(IAsyncResult asyncResult)
        {
            return EndInvoke<DetachObjectResponse>(asyncResult);
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
        public virtual DetachPolicyResponse DetachPolicy(DetachPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DetachPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachPolicyResponseUnmarshaller.Instance;

            return Invoke<DetachPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DetachPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachPolicy operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetachPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/DetachPolicy">REST API Reference for DetachPolicy Operation</seealso>
        public virtual IAsyncResult BeginDetachPolicy(DetachPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DetachPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DetachPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachPolicy.</param>
        /// 
        /// <returns>Returns a  DetachPolicyResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/DetachPolicy">REST API Reference for DetachPolicy Operation</seealso>
        public virtual DetachPolicyResponse EndDetachPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DetachPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  DetachTypedLink

        /// <summary>
        /// Detaches a typed link from a specified source and target object. For more information,
        /// see <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/directory_objects_links.html#directory_objects_links_typedlink">Typed
        /// Links</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachTypedLink service method.</param>
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
        public virtual DetachTypedLinkResponse DetachTypedLink(DetachTypedLinkRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DetachTypedLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachTypedLinkResponseUnmarshaller.Instance;

            return Invoke<DetachTypedLinkResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DetachTypedLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachTypedLink operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetachTypedLink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/DetachTypedLink">REST API Reference for DetachTypedLink Operation</seealso>
        public virtual IAsyncResult BeginDetachTypedLink(DetachTypedLinkRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DetachTypedLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachTypedLinkResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DetachTypedLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachTypedLink.</param>
        /// 
        /// <returns>Returns a  DetachTypedLinkResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/DetachTypedLink">REST API Reference for DetachTypedLink Operation</seealso>
        public virtual DetachTypedLinkResponse EndDetachTypedLink(IAsyncResult asyncResult)
        {
            return EndInvoke<DetachTypedLinkResponse>(asyncResult);
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
        public virtual DisableDirectoryResponse DisableDirectory(DisableDirectoryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisableDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableDirectoryResponseUnmarshaller.Instance;

            return Invoke<DisableDirectoryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisableDirectory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableDirectory operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableDirectory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/DisableDirectory">REST API Reference for DisableDirectory Operation</seealso>
        public virtual IAsyncResult BeginDisableDirectory(DisableDirectoryRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisableDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableDirectoryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisableDirectory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableDirectory.</param>
        /// 
        /// <returns>Returns a  DisableDirectoryResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/DisableDirectory">REST API Reference for DisableDirectory Operation</seealso>
        public virtual DisableDirectoryResponse EndDisableDirectory(IAsyncResult asyncResult)
        {
            return EndInvoke<DisableDirectoryResponse>(asyncResult);
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
        public virtual EnableDirectoryResponse EnableDirectory(EnableDirectoryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EnableDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableDirectoryResponseUnmarshaller.Instance;

            return Invoke<EnableDirectoryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EnableDirectory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableDirectory operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableDirectory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/EnableDirectory">REST API Reference for EnableDirectory Operation</seealso>
        public virtual IAsyncResult BeginEnableDirectory(EnableDirectoryRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EnableDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableDirectoryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  EnableDirectory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableDirectory.</param>
        /// 
        /// <returns>Returns a  EnableDirectoryResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/EnableDirectory">REST API Reference for EnableDirectory Operation</seealso>
        public virtual EnableDirectoryResponse EndEnableDirectory(IAsyncResult asyncResult)
        {
            return EndInvoke<EnableDirectoryResponse>(asyncResult);
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
        public virtual GetAppliedSchemaVersionResponse GetAppliedSchemaVersion(GetAppliedSchemaVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAppliedSchemaVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAppliedSchemaVersionResponseUnmarshaller.Instance;

            return Invoke<GetAppliedSchemaVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAppliedSchemaVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAppliedSchemaVersion operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAppliedSchemaVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/GetAppliedSchemaVersion">REST API Reference for GetAppliedSchemaVersion Operation</seealso>
        public virtual IAsyncResult BeginGetAppliedSchemaVersion(GetAppliedSchemaVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAppliedSchemaVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAppliedSchemaVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAppliedSchemaVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAppliedSchemaVersion.</param>
        /// 
        /// <returns>Returns a  GetAppliedSchemaVersionResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/GetAppliedSchemaVersion">REST API Reference for GetAppliedSchemaVersion Operation</seealso>
        public virtual GetAppliedSchemaVersionResponse EndGetAppliedSchemaVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAppliedSchemaVersionResponse>(asyncResult);
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
        public virtual GetDirectoryResponse GetDirectory(GetDirectoryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDirectoryResponseUnmarshaller.Instance;

            return Invoke<GetDirectoryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDirectory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDirectory operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDirectory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/GetDirectory">REST API Reference for GetDirectory Operation</seealso>
        public virtual IAsyncResult BeginGetDirectory(GetDirectoryRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDirectoryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDirectory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDirectory.</param>
        /// 
        /// <returns>Returns a  GetDirectoryResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/GetDirectory">REST API Reference for GetDirectory Operation</seealso>
        public virtual GetDirectoryResponse EndGetDirectory(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDirectoryResponse>(asyncResult);
        }

        #endregion
        
        #region  GetFacet

        /// <summary>
        /// Gets details of the <a>Facet</a>, such as facet name, attributes, <a>Rule</a>s, or
        /// <c>ObjectType</c>. You can call this on all kinds of schema facets -- published, development,
        /// or applied.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFacet service method.</param>
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
        public virtual GetFacetResponse GetFacet(GetFacetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFacetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFacetResponseUnmarshaller.Instance;

            return Invoke<GetFacetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetFacet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFacet operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFacet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/GetFacet">REST API Reference for GetFacet Operation</seealso>
        public virtual IAsyncResult BeginGetFacet(GetFacetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFacetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFacetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetFacet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFacet.</param>
        /// 
        /// <returns>Returns a  GetFacetResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/GetFacet">REST API Reference for GetFacet Operation</seealso>
        public virtual GetFacetResponse EndGetFacet(IAsyncResult asyncResult)
        {
            return EndInvoke<GetFacetResponse>(asyncResult);
        }

        #endregion
        
        #region  GetLinkAttributes

        /// <summary>
        /// Retrieves attributes that are associated with a typed link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLinkAttributes service method.</param>
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
        public virtual GetLinkAttributesResponse GetLinkAttributes(GetLinkAttributesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetLinkAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLinkAttributesResponseUnmarshaller.Instance;

            return Invoke<GetLinkAttributesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetLinkAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLinkAttributes operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLinkAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/GetLinkAttributes">REST API Reference for GetLinkAttributes Operation</seealso>
        public virtual IAsyncResult BeginGetLinkAttributes(GetLinkAttributesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetLinkAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLinkAttributesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetLinkAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLinkAttributes.</param>
        /// 
        /// <returns>Returns a  GetLinkAttributesResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/GetLinkAttributes">REST API Reference for GetLinkAttributes Operation</seealso>
        public virtual GetLinkAttributesResponse EndGetLinkAttributes(IAsyncResult asyncResult)
        {
            return EndInvoke<GetLinkAttributesResponse>(asyncResult);
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
        public virtual GetObjectAttributesResponse GetObjectAttributes(GetObjectAttributesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetObjectAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetObjectAttributesResponseUnmarshaller.Instance;

            return Invoke<GetObjectAttributesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetObjectAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetObjectAttributes operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetObjectAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/GetObjectAttributes">REST API Reference for GetObjectAttributes Operation</seealso>
        public virtual IAsyncResult BeginGetObjectAttributes(GetObjectAttributesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetObjectAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetObjectAttributesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetObjectAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetObjectAttributes.</param>
        /// 
        /// <returns>Returns a  GetObjectAttributesResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/GetObjectAttributes">REST API Reference for GetObjectAttributes Operation</seealso>
        public virtual GetObjectAttributesResponse EndGetObjectAttributes(IAsyncResult asyncResult)
        {
            return EndInvoke<GetObjectAttributesResponse>(asyncResult);
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
        public virtual GetObjectInformationResponse GetObjectInformation(GetObjectInformationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetObjectInformationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetObjectInformationResponseUnmarshaller.Instance;

            return Invoke<GetObjectInformationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetObjectInformation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetObjectInformation operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetObjectInformation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/GetObjectInformation">REST API Reference for GetObjectInformation Operation</seealso>
        public virtual IAsyncResult BeginGetObjectInformation(GetObjectInformationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetObjectInformationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetObjectInformationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetObjectInformation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetObjectInformation.</param>
        /// 
        /// <returns>Returns a  GetObjectInformationResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/GetObjectInformation">REST API Reference for GetObjectInformation Operation</seealso>
        public virtual GetObjectInformationResponse EndGetObjectInformation(IAsyncResult asyncResult)
        {
            return EndInvoke<GetObjectInformationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSchemaAsJson

        /// <summary>
        /// Retrieves a JSON representation of the schema. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/schemas_jsonformat.html#schemas_json">JSON
        /// Schema Format</a> for more information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSchemaAsJson service method.</param>
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
        public virtual GetSchemaAsJsonResponse GetSchemaAsJson(GetSchemaAsJsonRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSchemaAsJsonRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSchemaAsJsonResponseUnmarshaller.Instance;

            return Invoke<GetSchemaAsJsonResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSchemaAsJson operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSchemaAsJson operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSchemaAsJson
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/GetSchemaAsJson">REST API Reference for GetSchemaAsJson Operation</seealso>
        public virtual IAsyncResult BeginGetSchemaAsJson(GetSchemaAsJsonRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSchemaAsJsonRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSchemaAsJsonResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSchemaAsJson operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSchemaAsJson.</param>
        /// 
        /// <returns>Returns a  GetSchemaAsJsonResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/GetSchemaAsJson">REST API Reference for GetSchemaAsJson Operation</seealso>
        public virtual GetSchemaAsJsonResponse EndGetSchemaAsJson(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSchemaAsJsonResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTypedLinkFacetInformation

        /// <summary>
        /// Returns the identity attribute order for a specific <a>TypedLinkFacet</a>. For more
        /// information, see <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/directory_objects_links.html#directory_objects_links_typedlink">Typed
        /// Links</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTypedLinkFacetInformation service method.</param>
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
        public virtual GetTypedLinkFacetInformationResponse GetTypedLinkFacetInformation(GetTypedLinkFacetInformationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTypedLinkFacetInformationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTypedLinkFacetInformationResponseUnmarshaller.Instance;

            return Invoke<GetTypedLinkFacetInformationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTypedLinkFacetInformation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTypedLinkFacetInformation operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTypedLinkFacetInformation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/GetTypedLinkFacetInformation">REST API Reference for GetTypedLinkFacetInformation Operation</seealso>
        public virtual IAsyncResult BeginGetTypedLinkFacetInformation(GetTypedLinkFacetInformationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTypedLinkFacetInformationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTypedLinkFacetInformationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTypedLinkFacetInformation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTypedLinkFacetInformation.</param>
        /// 
        /// <returns>Returns a  GetTypedLinkFacetInformationResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/GetTypedLinkFacetInformation">REST API Reference for GetTypedLinkFacetInformation Operation</seealso>
        public virtual GetTypedLinkFacetInformationResponse EndGetTypedLinkFacetInformation(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTypedLinkFacetInformationResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAppliedSchemaArns

        /// <summary>
        /// Lists schema major versions applied to a directory. If <c>SchemaArn</c> is provided,
        /// lists the minor version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppliedSchemaArns service method.</param>
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
        public virtual ListAppliedSchemaArnsResponse ListAppliedSchemaArns(ListAppliedSchemaArnsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAppliedSchemaArnsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppliedSchemaArnsResponseUnmarshaller.Instance;

            return Invoke<ListAppliedSchemaArnsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAppliedSchemaArns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAppliedSchemaArns operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAppliedSchemaArns
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListAppliedSchemaArns">REST API Reference for ListAppliedSchemaArns Operation</seealso>
        public virtual IAsyncResult BeginListAppliedSchemaArns(ListAppliedSchemaArnsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAppliedSchemaArnsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppliedSchemaArnsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAppliedSchemaArns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAppliedSchemaArns.</param>
        /// 
        /// <returns>Returns a  ListAppliedSchemaArnsResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListAppliedSchemaArns">REST API Reference for ListAppliedSchemaArns Operation</seealso>
        public virtual ListAppliedSchemaArnsResponse EndListAppliedSchemaArns(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAppliedSchemaArnsResponse>(asyncResult);
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
        public virtual ListAttachedIndicesResponse ListAttachedIndices(ListAttachedIndicesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAttachedIndicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAttachedIndicesResponseUnmarshaller.Instance;

            return Invoke<ListAttachedIndicesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAttachedIndices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAttachedIndices operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAttachedIndices
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListAttachedIndices">REST API Reference for ListAttachedIndices Operation</seealso>
        public virtual IAsyncResult BeginListAttachedIndices(ListAttachedIndicesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAttachedIndicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAttachedIndicesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAttachedIndices operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAttachedIndices.</param>
        /// 
        /// <returns>Returns a  ListAttachedIndicesResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListAttachedIndices">REST API Reference for ListAttachedIndices Operation</seealso>
        public virtual ListAttachedIndicesResponse EndListAttachedIndices(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAttachedIndicesResponse>(asyncResult);
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
        public virtual ListDevelopmentSchemaArnsResponse ListDevelopmentSchemaArns(ListDevelopmentSchemaArnsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDevelopmentSchemaArnsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDevelopmentSchemaArnsResponseUnmarshaller.Instance;

            return Invoke<ListDevelopmentSchemaArnsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDevelopmentSchemaArns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDevelopmentSchemaArns operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDevelopmentSchemaArns
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListDevelopmentSchemaArns">REST API Reference for ListDevelopmentSchemaArns Operation</seealso>
        public virtual IAsyncResult BeginListDevelopmentSchemaArns(ListDevelopmentSchemaArnsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDevelopmentSchemaArnsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDevelopmentSchemaArnsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDevelopmentSchemaArns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDevelopmentSchemaArns.</param>
        /// 
        /// <returns>Returns a  ListDevelopmentSchemaArnsResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListDevelopmentSchemaArns">REST API Reference for ListDevelopmentSchemaArns Operation</seealso>
        public virtual ListDevelopmentSchemaArnsResponse EndListDevelopmentSchemaArns(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDevelopmentSchemaArnsResponse>(asyncResult);
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
        public virtual ListDirectoriesResponse ListDirectories(ListDirectoriesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDirectoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDirectoriesResponseUnmarshaller.Instance;

            return Invoke<ListDirectoriesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDirectories operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDirectories operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDirectories
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListDirectories">REST API Reference for ListDirectories Operation</seealso>
        public virtual IAsyncResult BeginListDirectories(ListDirectoriesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDirectoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDirectoriesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDirectories operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDirectories.</param>
        /// 
        /// <returns>Returns a  ListDirectoriesResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListDirectories">REST API Reference for ListDirectories Operation</seealso>
        public virtual ListDirectoriesResponse EndListDirectories(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDirectoriesResponse>(asyncResult);
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
        public virtual ListFacetAttributesResponse ListFacetAttributes(ListFacetAttributesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFacetAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFacetAttributesResponseUnmarshaller.Instance;

            return Invoke<ListFacetAttributesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListFacetAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFacetAttributes operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFacetAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListFacetAttributes">REST API Reference for ListFacetAttributes Operation</seealso>
        public virtual IAsyncResult BeginListFacetAttributes(ListFacetAttributesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFacetAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFacetAttributesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListFacetAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFacetAttributes.</param>
        /// 
        /// <returns>Returns a  ListFacetAttributesResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListFacetAttributes">REST API Reference for ListFacetAttributes Operation</seealso>
        public virtual ListFacetAttributesResponse EndListFacetAttributes(IAsyncResult asyncResult)
        {
            return EndInvoke<ListFacetAttributesResponse>(asyncResult);
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
        public virtual ListFacetNamesResponse ListFacetNames(ListFacetNamesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFacetNamesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFacetNamesResponseUnmarshaller.Instance;

            return Invoke<ListFacetNamesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListFacetNames operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFacetNames operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFacetNames
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListFacetNames">REST API Reference for ListFacetNames Operation</seealso>
        public virtual IAsyncResult BeginListFacetNames(ListFacetNamesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFacetNamesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFacetNamesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListFacetNames operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFacetNames.</param>
        /// 
        /// <returns>Returns a  ListFacetNamesResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListFacetNames">REST API Reference for ListFacetNames Operation</seealso>
        public virtual ListFacetNamesResponse EndListFacetNames(IAsyncResult asyncResult)
        {
            return EndInvoke<ListFacetNamesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListIncomingTypedLinks

        /// <summary>
        /// Returns a paginated list of all the incoming <a>TypedLinkSpecifier</a> information
        /// for an object. It also supports filtering by typed link facet and identity attributes.
        /// For more information, see <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/directory_objects_links.html#directory_objects_links_typedlink">Typed
        /// Links</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIncomingTypedLinks service method.</param>
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
        public virtual ListIncomingTypedLinksResponse ListIncomingTypedLinks(ListIncomingTypedLinksRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIncomingTypedLinksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIncomingTypedLinksResponseUnmarshaller.Instance;

            return Invoke<ListIncomingTypedLinksResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListIncomingTypedLinks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIncomingTypedLinks operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListIncomingTypedLinks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListIncomingTypedLinks">REST API Reference for ListIncomingTypedLinks Operation</seealso>
        public virtual IAsyncResult BeginListIncomingTypedLinks(ListIncomingTypedLinksRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIncomingTypedLinksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIncomingTypedLinksResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListIncomingTypedLinks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIncomingTypedLinks.</param>
        /// 
        /// <returns>Returns a  ListIncomingTypedLinksResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListIncomingTypedLinks">REST API Reference for ListIncomingTypedLinks Operation</seealso>
        public virtual ListIncomingTypedLinksResponse EndListIncomingTypedLinks(IAsyncResult asyncResult)
        {
            return EndInvoke<ListIncomingTypedLinksResponse>(asyncResult);
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
        public virtual ListIndexResponse ListIndex(ListIndexRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIndexResponseUnmarshaller.Instance;

            return Invoke<ListIndexResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListIndex operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIndex operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListIndex
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListIndex">REST API Reference for ListIndex Operation</seealso>
        public virtual IAsyncResult BeginListIndex(ListIndexRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIndexResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListIndex operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIndex.</param>
        /// 
        /// <returns>Returns a  ListIndexResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListIndex">REST API Reference for ListIndex Operation</seealso>
        public virtual ListIndexResponse EndListIndex(IAsyncResult asyncResult)
        {
            return EndInvoke<ListIndexResponse>(asyncResult);
        }

        #endregion
        
        #region  ListManagedSchemaArns

        /// <summary>
        /// Lists the major version families of each managed schema. If a major version ARN is
        /// provided as SchemaArn, the minor version revisions in that family are listed instead.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListManagedSchemaArns service method.</param>
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
        public virtual ListManagedSchemaArnsResponse ListManagedSchemaArns(ListManagedSchemaArnsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListManagedSchemaArnsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListManagedSchemaArnsResponseUnmarshaller.Instance;

            return Invoke<ListManagedSchemaArnsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListManagedSchemaArns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListManagedSchemaArns operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListManagedSchemaArns
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListManagedSchemaArns">REST API Reference for ListManagedSchemaArns Operation</seealso>
        public virtual IAsyncResult BeginListManagedSchemaArns(ListManagedSchemaArnsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListManagedSchemaArnsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListManagedSchemaArnsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListManagedSchemaArns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListManagedSchemaArns.</param>
        /// 
        /// <returns>Returns a  ListManagedSchemaArnsResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListManagedSchemaArns">REST API Reference for ListManagedSchemaArns Operation</seealso>
        public virtual ListManagedSchemaArnsResponse EndListManagedSchemaArns(IAsyncResult asyncResult)
        {
            return EndInvoke<ListManagedSchemaArnsResponse>(asyncResult);
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
        public virtual ListObjectAttributesResponse ListObjectAttributes(ListObjectAttributesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListObjectAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListObjectAttributesResponseUnmarshaller.Instance;

            return Invoke<ListObjectAttributesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListObjectAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListObjectAttributes operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListObjectAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListObjectAttributes">REST API Reference for ListObjectAttributes Operation</seealso>
        public virtual IAsyncResult BeginListObjectAttributes(ListObjectAttributesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListObjectAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListObjectAttributesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListObjectAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListObjectAttributes.</param>
        /// 
        /// <returns>Returns a  ListObjectAttributesResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListObjectAttributes">REST API Reference for ListObjectAttributes Operation</seealso>
        public virtual ListObjectAttributesResponse EndListObjectAttributes(IAsyncResult asyncResult)
        {
            return EndInvoke<ListObjectAttributesResponse>(asyncResult);
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
        public virtual ListObjectChildrenResponse ListObjectChildren(ListObjectChildrenRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListObjectChildrenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListObjectChildrenResponseUnmarshaller.Instance;

            return Invoke<ListObjectChildrenResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListObjectChildren operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListObjectChildren operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListObjectChildren
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListObjectChildren">REST API Reference for ListObjectChildren Operation</seealso>
        public virtual IAsyncResult BeginListObjectChildren(ListObjectChildrenRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListObjectChildrenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListObjectChildrenResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListObjectChildren operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListObjectChildren.</param>
        /// 
        /// <returns>Returns a  ListObjectChildrenResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListObjectChildren">REST API Reference for ListObjectChildren Operation</seealso>
        public virtual ListObjectChildrenResponse EndListObjectChildren(IAsyncResult asyncResult)
        {
            return EndInvoke<ListObjectChildrenResponse>(asyncResult);
        }

        #endregion
        
        #region  ListObjectParentPaths

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
        public virtual ListObjectParentPathsResponse ListObjectParentPaths(ListObjectParentPathsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListObjectParentPathsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListObjectParentPathsResponseUnmarshaller.Instance;

            return Invoke<ListObjectParentPathsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListObjectParentPaths operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListObjectParentPaths operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListObjectParentPaths
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListObjectParentPaths">REST API Reference for ListObjectParentPaths Operation</seealso>
        public virtual IAsyncResult BeginListObjectParentPaths(ListObjectParentPathsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListObjectParentPathsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListObjectParentPathsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListObjectParentPaths operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListObjectParentPaths.</param>
        /// 
        /// <returns>Returns a  ListObjectParentPathsResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListObjectParentPaths">REST API Reference for ListObjectParentPaths Operation</seealso>
        public virtual ListObjectParentPathsResponse EndListObjectParentPaths(IAsyncResult asyncResult)
        {
            return EndInvoke<ListObjectParentPathsResponse>(asyncResult);
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
        public virtual ListObjectParentsResponse ListObjectParents(ListObjectParentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListObjectParentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListObjectParentsResponseUnmarshaller.Instance;

            return Invoke<ListObjectParentsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListObjectParents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListObjectParents operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListObjectParents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListObjectParents">REST API Reference for ListObjectParents Operation</seealso>
        public virtual IAsyncResult BeginListObjectParents(ListObjectParentsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListObjectParentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListObjectParentsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListObjectParents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListObjectParents.</param>
        /// 
        /// <returns>Returns a  ListObjectParentsResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListObjectParents">REST API Reference for ListObjectParents Operation</seealso>
        public virtual ListObjectParentsResponse EndListObjectParents(IAsyncResult asyncResult)
        {
            return EndInvoke<ListObjectParentsResponse>(asyncResult);
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
        public virtual ListObjectPoliciesResponse ListObjectPolicies(ListObjectPoliciesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListObjectPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListObjectPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListObjectPoliciesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListObjectPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListObjectPolicies operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListObjectPolicies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListObjectPolicies">REST API Reference for ListObjectPolicies Operation</seealso>
        public virtual IAsyncResult BeginListObjectPolicies(ListObjectPoliciesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListObjectPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListObjectPoliciesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListObjectPolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListObjectPolicies.</param>
        /// 
        /// <returns>Returns a  ListObjectPoliciesResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListObjectPolicies">REST API Reference for ListObjectPolicies Operation</seealso>
        public virtual ListObjectPoliciesResponse EndListObjectPolicies(IAsyncResult asyncResult)
        {
            return EndInvoke<ListObjectPoliciesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListOutgoingTypedLinks

        /// <summary>
        /// Returns a paginated list of all the outgoing <a>TypedLinkSpecifier</a> information
        /// for an object. It also supports filtering by typed link facet and identity attributes.
        /// For more information, see <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/directory_objects_links.html#directory_objects_links_typedlink">Typed
        /// Links</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOutgoingTypedLinks service method.</param>
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
        public virtual ListOutgoingTypedLinksResponse ListOutgoingTypedLinks(ListOutgoingTypedLinksRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOutgoingTypedLinksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOutgoingTypedLinksResponseUnmarshaller.Instance;

            return Invoke<ListOutgoingTypedLinksResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListOutgoingTypedLinks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOutgoingTypedLinks operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOutgoingTypedLinks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListOutgoingTypedLinks">REST API Reference for ListOutgoingTypedLinks Operation</seealso>
        public virtual IAsyncResult BeginListOutgoingTypedLinks(ListOutgoingTypedLinksRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOutgoingTypedLinksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOutgoingTypedLinksResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListOutgoingTypedLinks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOutgoingTypedLinks.</param>
        /// 
        /// <returns>Returns a  ListOutgoingTypedLinksResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListOutgoingTypedLinks">REST API Reference for ListOutgoingTypedLinks Operation</seealso>
        public virtual ListOutgoingTypedLinksResponse EndListOutgoingTypedLinks(IAsyncResult asyncResult)
        {
            return EndInvoke<ListOutgoingTypedLinksResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPolicyAttachments

        /// <summary>
        /// Returns all of the <c>ObjectIdentifiers</c> to which a given policy is attached.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPolicyAttachments service method.</param>
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
        public virtual ListPolicyAttachmentsResponse ListPolicyAttachments(ListPolicyAttachmentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPolicyAttachmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPolicyAttachmentsResponseUnmarshaller.Instance;

            return Invoke<ListPolicyAttachmentsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPolicyAttachments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPolicyAttachments operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPolicyAttachments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListPolicyAttachments">REST API Reference for ListPolicyAttachments Operation</seealso>
        public virtual IAsyncResult BeginListPolicyAttachments(ListPolicyAttachmentsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPolicyAttachmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPolicyAttachmentsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPolicyAttachments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPolicyAttachments.</param>
        /// 
        /// <returns>Returns a  ListPolicyAttachmentsResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListPolicyAttachments">REST API Reference for ListPolicyAttachments Operation</seealso>
        public virtual ListPolicyAttachmentsResponse EndListPolicyAttachments(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPolicyAttachmentsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPublishedSchemaArns

        /// <summary>
        /// Lists the major version families of each published schema. If a major version ARN
        /// is provided as <c>SchemaArn</c>, the minor version revisions in that family are listed
        /// instead.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPublishedSchemaArns service method.</param>
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
        public virtual ListPublishedSchemaArnsResponse ListPublishedSchemaArns(ListPublishedSchemaArnsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPublishedSchemaArnsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPublishedSchemaArnsResponseUnmarshaller.Instance;

            return Invoke<ListPublishedSchemaArnsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPublishedSchemaArns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPublishedSchemaArns operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPublishedSchemaArns
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListPublishedSchemaArns">REST API Reference for ListPublishedSchemaArns Operation</seealso>
        public virtual IAsyncResult BeginListPublishedSchemaArns(ListPublishedSchemaArnsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPublishedSchemaArnsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPublishedSchemaArnsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPublishedSchemaArns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPublishedSchemaArns.</param>
        /// 
        /// <returns>Returns a  ListPublishedSchemaArnsResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListPublishedSchemaArns">REST API Reference for ListPublishedSchemaArns Operation</seealso>
        public virtual ListPublishedSchemaArnsResponse EndListPublishedSchemaArns(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPublishedSchemaArnsResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTypedLinkFacetAttributes

        /// <summary>
        /// Returns a paginated list of all attribute definitions for a particular <a>TypedLinkFacet</a>.
        /// For more information, see <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/directory_objects_links.html#directory_objects_links_typedlink">Typed
        /// Links</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTypedLinkFacetAttributes service method.</param>
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
        public virtual ListTypedLinkFacetAttributesResponse ListTypedLinkFacetAttributes(ListTypedLinkFacetAttributesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTypedLinkFacetAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTypedLinkFacetAttributesResponseUnmarshaller.Instance;

            return Invoke<ListTypedLinkFacetAttributesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTypedLinkFacetAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTypedLinkFacetAttributes operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTypedLinkFacetAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListTypedLinkFacetAttributes">REST API Reference for ListTypedLinkFacetAttributes Operation</seealso>
        public virtual IAsyncResult BeginListTypedLinkFacetAttributes(ListTypedLinkFacetAttributesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTypedLinkFacetAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTypedLinkFacetAttributesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTypedLinkFacetAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTypedLinkFacetAttributes.</param>
        /// 
        /// <returns>Returns a  ListTypedLinkFacetAttributesResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListTypedLinkFacetAttributes">REST API Reference for ListTypedLinkFacetAttributes Operation</seealso>
        public virtual ListTypedLinkFacetAttributesResponse EndListTypedLinkFacetAttributes(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTypedLinkFacetAttributesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTypedLinkFacetNames

        /// <summary>
        /// Returns a paginated list of <c>TypedLink</c> facet names for a particular schema.
        /// For more information, see <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/directory_objects_links.html#directory_objects_links_typedlink">Typed
        /// Links</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTypedLinkFacetNames service method.</param>
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
        public virtual ListTypedLinkFacetNamesResponse ListTypedLinkFacetNames(ListTypedLinkFacetNamesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTypedLinkFacetNamesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTypedLinkFacetNamesResponseUnmarshaller.Instance;

            return Invoke<ListTypedLinkFacetNamesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTypedLinkFacetNames operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTypedLinkFacetNames operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTypedLinkFacetNames
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListTypedLinkFacetNames">REST API Reference for ListTypedLinkFacetNames Operation</seealso>
        public virtual IAsyncResult BeginListTypedLinkFacetNames(ListTypedLinkFacetNamesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTypedLinkFacetNamesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTypedLinkFacetNamesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTypedLinkFacetNames operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTypedLinkFacetNames.</param>
        /// 
        /// <returns>Returns a  ListTypedLinkFacetNamesResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/ListTypedLinkFacetNames">REST API Reference for ListTypedLinkFacetNames Operation</seealso>
        public virtual ListTypedLinkFacetNamesResponse EndListTypedLinkFacetNames(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTypedLinkFacetNamesResponse>(asyncResult);
        }

        #endregion
        
        #region  LookupPolicy

        /// <summary>
        /// Lists all policies from the root of the <a>Directory</a> to the object specified.
        /// If there are no policies present, an empty list is returned. If policies are present,
        /// and if some objects don't have the policies attached, it returns the <c>ObjectIdentifier</c>
        /// for such objects. If policies are present, it returns <c>ObjectIdentifier</c>, <c>policyId</c>,
        /// and <c>policyType</c>. Paths that don't lead to the root from the target object are
        /// ignored. For more information, see <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/key_concepts_directory.html#key_concepts_policies">Policies</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the LookupPolicy service method.</param>
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
        public virtual LookupPolicyResponse LookupPolicy(LookupPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = LookupPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = LookupPolicyResponseUnmarshaller.Instance;

            return Invoke<LookupPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the LookupPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the LookupPolicy operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndLookupPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/LookupPolicy">REST API Reference for LookupPolicy Operation</seealso>
        public virtual IAsyncResult BeginLookupPolicy(LookupPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = LookupPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = LookupPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  LookupPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginLookupPolicy.</param>
        /// 
        /// <returns>Returns a  LookupPolicyResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/LookupPolicy">REST API Reference for LookupPolicy Operation</seealso>
        public virtual LookupPolicyResponse EndLookupPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<LookupPolicyResponse>(asyncResult);
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
        public virtual PublishSchemaResponse PublishSchema(PublishSchemaRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PublishSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PublishSchemaResponseUnmarshaller.Instance;

            return Invoke<PublishSchemaResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PublishSchema operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PublishSchema operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPublishSchema
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/PublishSchema">REST API Reference for PublishSchema Operation</seealso>
        public virtual IAsyncResult BeginPublishSchema(PublishSchemaRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PublishSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PublishSchemaResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PublishSchema operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPublishSchema.</param>
        /// 
        /// <returns>Returns a  PublishSchemaResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/PublishSchema">REST API Reference for PublishSchema Operation</seealso>
        public virtual PublishSchemaResponse EndPublishSchema(IAsyncResult asyncResult)
        {
            return EndInvoke<PublishSchemaResponse>(asyncResult);
        }

        #endregion
        
        #region  PutSchemaFromJson

        /// <summary>
        /// Allows a schema to be updated using JSON upload. Only available for development schemas.
        /// See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/schemas_jsonformat.html#schemas_json">JSON
        /// Schema Format</a> for more information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutSchemaFromJson service method.</param>
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
        public virtual PutSchemaFromJsonResponse PutSchemaFromJson(PutSchemaFromJsonRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutSchemaFromJsonRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSchemaFromJsonResponseUnmarshaller.Instance;

            return Invoke<PutSchemaFromJsonResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutSchemaFromJson operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutSchemaFromJson operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutSchemaFromJson
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/PutSchemaFromJson">REST API Reference for PutSchemaFromJson Operation</seealso>
        public virtual IAsyncResult BeginPutSchemaFromJson(PutSchemaFromJsonRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutSchemaFromJsonRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSchemaFromJsonResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutSchemaFromJson operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutSchemaFromJson.</param>
        /// 
        /// <returns>Returns a  PutSchemaFromJsonResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/PutSchemaFromJson">REST API Reference for PutSchemaFromJson Operation</seealso>
        public virtual PutSchemaFromJsonResponse EndPutSchemaFromJson(IAsyncResult asyncResult)
        {
            return EndInvoke<PutSchemaFromJsonResponse>(asyncResult);
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
        public virtual RemoveFacetFromObjectResponse RemoveFacetFromObject(RemoveFacetFromObjectRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveFacetFromObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveFacetFromObjectResponseUnmarshaller.Instance;

            return Invoke<RemoveFacetFromObjectResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveFacetFromObject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveFacetFromObject operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveFacetFromObject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/RemoveFacetFromObject">REST API Reference for RemoveFacetFromObject Operation</seealso>
        public virtual IAsyncResult BeginRemoveFacetFromObject(RemoveFacetFromObjectRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveFacetFromObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveFacetFromObjectResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveFacetFromObject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveFacetFromObject.</param>
        /// 
        /// <returns>Returns a  RemoveFacetFromObjectResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/RemoveFacetFromObject">REST API Reference for RemoveFacetFromObject Operation</seealso>
        public virtual RemoveFacetFromObjectResponse EndRemoveFacetFromObject(IAsyncResult asyncResult)
        {
            return EndInvoke<RemoveFacetFromObjectResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateFacet

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
        public virtual UpdateFacetResponse UpdateFacet(UpdateFacetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFacetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFacetResponseUnmarshaller.Instance;

            return Invoke<UpdateFacetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFacet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFacet operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFacet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/UpdateFacet">REST API Reference for UpdateFacet Operation</seealso>
        public virtual IAsyncResult BeginUpdateFacet(UpdateFacetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFacetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFacetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFacet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFacet.</param>
        /// 
        /// <returns>Returns a  UpdateFacetResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/UpdateFacet">REST API Reference for UpdateFacet Operation</seealso>
        public virtual UpdateFacetResponse EndUpdateFacet(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateFacetResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateLinkAttributes

        /// <summary>
        /// Updates a given typed link’s attributes. Attributes to be updated must not contribute
        /// to the typed link’s identity, as defined by its <c>IdentityAttributeOrder</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLinkAttributes service method.</param>
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
        public virtual UpdateLinkAttributesResponse UpdateLinkAttributes(UpdateLinkAttributesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLinkAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLinkAttributesResponseUnmarshaller.Instance;

            return Invoke<UpdateLinkAttributesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLinkAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLinkAttributes operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLinkAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/UpdateLinkAttributes">REST API Reference for UpdateLinkAttributes Operation</seealso>
        public virtual IAsyncResult BeginUpdateLinkAttributes(UpdateLinkAttributesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLinkAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLinkAttributesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLinkAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLinkAttributes.</param>
        /// 
        /// <returns>Returns a  UpdateLinkAttributesResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/UpdateLinkAttributes">REST API Reference for UpdateLinkAttributes Operation</seealso>
        public virtual UpdateLinkAttributesResponse EndUpdateLinkAttributes(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateLinkAttributesResponse>(asyncResult);
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
        public virtual UpdateObjectAttributesResponse UpdateObjectAttributes(UpdateObjectAttributesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateObjectAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateObjectAttributesResponseUnmarshaller.Instance;

            return Invoke<UpdateObjectAttributesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateObjectAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateObjectAttributes operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateObjectAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/UpdateObjectAttributes">REST API Reference for UpdateObjectAttributes Operation</seealso>
        public virtual IAsyncResult BeginUpdateObjectAttributes(UpdateObjectAttributesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateObjectAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateObjectAttributesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateObjectAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateObjectAttributes.</param>
        /// 
        /// <returns>Returns a  UpdateObjectAttributesResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/UpdateObjectAttributes">REST API Reference for UpdateObjectAttributes Operation</seealso>
        public virtual UpdateObjectAttributesResponse EndUpdateObjectAttributes(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateObjectAttributesResponse>(asyncResult);
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
        public virtual UpdateSchemaResponse UpdateSchema(UpdateSchemaRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSchemaResponseUnmarshaller.Instance;

            return Invoke<UpdateSchemaResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSchema operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSchema operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSchema
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/UpdateSchema">REST API Reference for UpdateSchema Operation</seealso>
        public virtual IAsyncResult BeginUpdateSchema(UpdateSchemaRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSchemaResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSchema operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSchema.</param>
        /// 
        /// <returns>Returns a  UpdateSchemaResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/UpdateSchema">REST API Reference for UpdateSchema Operation</seealso>
        public virtual UpdateSchemaResponse EndUpdateSchema(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSchemaResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateTypedLinkFacet

        /// <summary>
        /// Updates a <a>TypedLinkFacet</a>. For more information, see <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/directory_objects_links.html#directory_objects_links_typedlink">Typed
        /// Links</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTypedLinkFacet service method.</param>
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
        public virtual UpdateTypedLinkFacetResponse UpdateTypedLinkFacet(UpdateTypedLinkFacetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTypedLinkFacetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTypedLinkFacetResponseUnmarshaller.Instance;

            return Invoke<UpdateTypedLinkFacetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTypedLinkFacet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTypedLinkFacet operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTypedLinkFacet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/UpdateTypedLinkFacet">REST API Reference for UpdateTypedLinkFacet Operation</seealso>
        public virtual IAsyncResult BeginUpdateTypedLinkFacet(UpdateTypedLinkFacetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTypedLinkFacetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTypedLinkFacetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTypedLinkFacet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTypedLinkFacet.</param>
        /// 
        /// <returns>Returns a  UpdateTypedLinkFacetResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/UpdateTypedLinkFacet">REST API Reference for UpdateTypedLinkFacet Operation</seealso>
        public virtual UpdateTypedLinkFacetResponse EndUpdateTypedLinkFacet(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateTypedLinkFacetResponse>(asyncResult);
        }

        #endregion
        
        #region  UpgradeAppliedSchema

        /// <summary>
        /// Upgrades a single directory in-place using the <c>PublishedSchemaArn</c> with schema
        /// updates found in <c>MinorVersion</c>. Backwards-compatible minor version upgrades
        /// are instantaneously available for readers on all objects in the directory. Note: This
        /// is a synchronous API call and upgrades only one schema on a given directory per call.
        /// To upgrade multiple directories from one schema, you would need to call this API on
        /// each directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpgradeAppliedSchema service method.</param>
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
        public virtual UpgradeAppliedSchemaResponse UpgradeAppliedSchema(UpgradeAppliedSchemaRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpgradeAppliedSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpgradeAppliedSchemaResponseUnmarshaller.Instance;

            return Invoke<UpgradeAppliedSchemaResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpgradeAppliedSchema operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpgradeAppliedSchema operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpgradeAppliedSchema
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/UpgradeAppliedSchema">REST API Reference for UpgradeAppliedSchema Operation</seealso>
        public virtual IAsyncResult BeginUpgradeAppliedSchema(UpgradeAppliedSchemaRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpgradeAppliedSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpgradeAppliedSchemaResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpgradeAppliedSchema operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpgradeAppliedSchema.</param>
        /// 
        /// <returns>Returns a  UpgradeAppliedSchemaResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/UpgradeAppliedSchema">REST API Reference for UpgradeAppliedSchema Operation</seealso>
        public virtual UpgradeAppliedSchemaResponse EndUpgradeAppliedSchema(IAsyncResult asyncResult)
        {
            return EndInvoke<UpgradeAppliedSchemaResponse>(asyncResult);
        }

        #endregion
        
        #region  UpgradePublishedSchema

        /// <summary>
        /// Upgrades a published schema under a new minor version revision using the current contents
        /// of <c>DevelopmentSchemaArn</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpgradePublishedSchema service method.</param>
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
        public virtual UpgradePublishedSchemaResponse UpgradePublishedSchema(UpgradePublishedSchemaRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpgradePublishedSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpgradePublishedSchemaResponseUnmarshaller.Instance;

            return Invoke<UpgradePublishedSchemaResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpgradePublishedSchema operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpgradePublishedSchema operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpgradePublishedSchema
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/UpgradePublishedSchema">REST API Reference for UpgradePublishedSchema Operation</seealso>
        public virtual IAsyncResult BeginUpgradePublishedSchema(UpgradePublishedSchemaRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpgradePublishedSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpgradePublishedSchemaResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpgradePublishedSchema operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpgradePublishedSchema.</param>
        /// 
        /// <returns>Returns a  UpgradePublishedSchemaResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2017-01-11/UpgradePublishedSchema">REST API Reference for UpgradePublishedSchema Operation</seealso>
        public virtual UpgradePublishedSchemaResponse EndUpgradePublishedSchema(IAsyncResult asyncResult)
        {
            return EndInvoke<UpgradePublishedSchemaResponse>(asyncResult);
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
            var resolver = new AmazonCloudDirectoryEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}