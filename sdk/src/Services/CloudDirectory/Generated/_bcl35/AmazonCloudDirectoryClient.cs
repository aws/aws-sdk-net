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
        /// Adds a new <a>Facet</a> to an object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddFacetToObject service method.</param>
        /// 
        /// <returns>The response from the AddFacetToObject service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// An operation can only operate on a directory that is not enabled.
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
        public AddFacetToObjectResponse AddFacetToObject(AddFacetToObjectRequest request)
        {
            var marshaller = new AddFacetToObjectRequestMarshaller();
            var unmarshaller = AddFacetToObjectResponseUnmarshaller.Instance;

            return Invoke<AddFacetToObjectRequest,AddFacetToObjectResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/AddFacetToObject">REST API Reference for AddFacetToObject Operation</seealso>
        public IAsyncResult BeginAddFacetToObject(AddFacetToObjectRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AddFacetToObjectRequestMarshaller();
            var unmarshaller = AddFacetToObjectResponseUnmarshaller.Instance;

            return BeginInvoke<AddFacetToObjectRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AddFacetToObject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddFacetToObject.</param>
        /// 
        /// <returns>Returns a  AddFacetToObjectResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/AddFacetToObject">REST API Reference for AddFacetToObject Operation</seealso>
        public  AddFacetToObjectResponse EndAddFacetToObject(IAsyncResult asyncResult)
        {
            return EndInvoke<AddFacetToObjectResponse>(asyncResult);
        }

        #endregion
        
        #region  ApplySchema

        /// <summary>
        /// Copies the input published schema into the <a>Directory</a> with the same name and
        /// version as that of the published schema .
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
        public ApplySchemaResponse ApplySchema(ApplySchemaRequest request)
        {
            var marshaller = new ApplySchemaRequestMarshaller();
            var unmarshaller = ApplySchemaResponseUnmarshaller.Instance;

            return Invoke<ApplySchemaRequest,ApplySchemaResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ApplySchema">REST API Reference for ApplySchema Operation</seealso>
        public IAsyncResult BeginApplySchema(ApplySchemaRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ApplySchemaRequestMarshaller();
            var unmarshaller = ApplySchemaResponseUnmarshaller.Instance;

            return BeginInvoke<ApplySchemaRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ApplySchema operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginApplySchema.</param>
        /// 
        /// <returns>Returns a  ApplySchemaResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ApplySchema">REST API Reference for ApplySchema Operation</seealso>
        public  ApplySchemaResponse EndApplySchema(IAsyncResult asyncResult)
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
        /// An operation can only operate on a directory that is not enabled.
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
        public AttachObjectResponse AttachObject(AttachObjectRequest request)
        {
            var marshaller = new AttachObjectRequestMarshaller();
            var unmarshaller = AttachObjectResponseUnmarshaller.Instance;

            return Invoke<AttachObjectRequest,AttachObjectResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/AttachObject">REST API Reference for AttachObject Operation</seealso>
        public IAsyncResult BeginAttachObject(AttachObjectRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AttachObjectRequestMarshaller();
            var unmarshaller = AttachObjectResponseUnmarshaller.Instance;

            return BeginInvoke<AttachObjectRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AttachObject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachObject.</param>
        /// 
        /// <returns>Returns a  AttachObjectResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/AttachObject">REST API Reference for AttachObject Operation</seealso>
        public  AttachObjectResponse EndAttachObject(IAsyncResult asyncResult)
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
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// An operation can only operate on a directory that is not enabled.
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
        public AttachPolicyResponse AttachPolicy(AttachPolicyRequest request)
        {
            var marshaller = new AttachPolicyRequestMarshaller();
            var unmarshaller = AttachPolicyResponseUnmarshaller.Instance;

            return Invoke<AttachPolicyRequest,AttachPolicyResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/AttachPolicy">REST API Reference for AttachPolicy Operation</seealso>
        public IAsyncResult BeginAttachPolicy(AttachPolicyRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AttachPolicyRequestMarshaller();
            var unmarshaller = AttachPolicyResponseUnmarshaller.Instance;

            return BeginInvoke<AttachPolicyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AttachPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachPolicy.</param>
        /// 
        /// <returns>Returns a  AttachPolicyResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/AttachPolicy">REST API Reference for AttachPolicy Operation</seealso>
        public  AttachPolicyResponse EndAttachPolicy(IAsyncResult asyncResult)
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
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// An operation can only operate on a directory that is not enabled.
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
        public AttachToIndexResponse AttachToIndex(AttachToIndexRequest request)
        {
            var marshaller = new AttachToIndexRequestMarshaller();
            var unmarshaller = AttachToIndexResponseUnmarshaller.Instance;

            return Invoke<AttachToIndexRequest,AttachToIndexResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/AttachToIndex">REST API Reference for AttachToIndex Operation</seealso>
        public IAsyncResult BeginAttachToIndex(AttachToIndexRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AttachToIndexRequestMarshaller();
            var unmarshaller = AttachToIndexResponseUnmarshaller.Instance;

            return BeginInvoke<AttachToIndexRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AttachToIndex operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachToIndex.</param>
        /// 
        /// <returns>Returns a  AttachToIndexResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/AttachToIndex">REST API Reference for AttachToIndex Operation</seealso>
        public  AttachToIndexResponse EndAttachToIndex(IAsyncResult asyncResult)
        {
            return EndInvoke<AttachToIndexResponse>(asyncResult);
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
        public AttachTypedLinkResponse AttachTypedLink(AttachTypedLinkRequest request)
        {
            var marshaller = new AttachTypedLinkRequestMarshaller();
            var unmarshaller = AttachTypedLinkResponseUnmarshaller.Instance;

            return Invoke<AttachTypedLinkRequest,AttachTypedLinkResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/AttachTypedLink">REST API Reference for AttachTypedLink Operation</seealso>
        public IAsyncResult BeginAttachTypedLink(AttachTypedLinkRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AttachTypedLinkRequestMarshaller();
            var unmarshaller = AttachTypedLinkResponseUnmarshaller.Instance;

            return BeginInvoke<AttachTypedLinkRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AttachTypedLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachTypedLink.</param>
        /// 
        /// <returns>Returns a  AttachTypedLinkResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/AttachTypedLink">REST API Reference for AttachTypedLink Operation</seealso>
        public  AttachTypedLinkResponse EndAttachTypedLink(IAsyncResult asyncResult)
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
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// An operation can only operate on a directory that is not enabled.
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
        public BatchReadResponse BatchRead(BatchReadRequest request)
        {
            var marshaller = new BatchReadRequestMarshaller();
            var unmarshaller = BatchReadResponseUnmarshaller.Instance;

            return Invoke<BatchReadRequest,BatchReadResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/BatchRead">REST API Reference for BatchRead Operation</seealso>
        public IAsyncResult BeginBatchRead(BatchReadRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new BatchReadRequestMarshaller();
            var unmarshaller = BatchReadResponseUnmarshaller.Instance;

            return BeginInvoke<BatchReadRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchRead operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchRead.</param>
        /// 
        /// <returns>Returns a  BatchReadResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/BatchRead">REST API Reference for BatchRead Operation</seealso>
        public  BatchReadResponse EndBatchRead(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchReadResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchWrite

        /// <summary>
        /// Performs all the write operations in a batch. Either all the operations succeed or
        /// none. Batch writes supports only object-related operations.
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
        /// An operation can only operate on a directory that is not enabled.
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
        public BatchWriteResponse BatchWrite(BatchWriteRequest request)
        {
            var marshaller = new BatchWriteRequestMarshaller();
            var unmarshaller = BatchWriteResponseUnmarshaller.Instance;

            return Invoke<BatchWriteRequest,BatchWriteResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/BatchWrite">REST API Reference for BatchWrite Operation</seealso>
        public IAsyncResult BeginBatchWrite(BatchWriteRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new BatchWriteRequestMarshaller();
            var unmarshaller = BatchWriteResponseUnmarshaller.Instance;

            return BeginInvoke<BatchWriteRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchWrite operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchWrite.</param>
        /// 
        /// <returns>Returns a  BatchWriteResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/BatchWrite">REST API Reference for BatchWrite Operation</seealso>
        public  BatchWriteResponse EndBatchWrite(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchWriteResponse>(asyncResult);
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
        public CreateDirectoryResponse CreateDirectory(CreateDirectoryRequest request)
        {
            var marshaller = new CreateDirectoryRequestMarshaller();
            var unmarshaller = CreateDirectoryResponseUnmarshaller.Instance;

            return Invoke<CreateDirectoryRequest,CreateDirectoryResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/CreateDirectory">REST API Reference for CreateDirectory Operation</seealso>
        public IAsyncResult BeginCreateDirectory(CreateDirectoryRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateDirectoryRequestMarshaller();
            var unmarshaller = CreateDirectoryResponseUnmarshaller.Instance;

            return BeginInvoke<CreateDirectoryRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDirectory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDirectory.</param>
        /// 
        /// <returns>Returns a  CreateDirectoryResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/CreateDirectory">REST API Reference for CreateDirectory Operation</seealso>
        public  CreateDirectoryResponse EndCreateDirectory(IAsyncResult asyncResult)
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
        public CreateFacetResponse CreateFacet(CreateFacetRequest request)
        {
            var marshaller = new CreateFacetRequestMarshaller();
            var unmarshaller = CreateFacetResponseUnmarshaller.Instance;

            return Invoke<CreateFacetRequest,CreateFacetResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/CreateFacet">REST API Reference for CreateFacet Operation</seealso>
        public IAsyncResult BeginCreateFacet(CreateFacetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateFacetRequestMarshaller();
            var unmarshaller = CreateFacetResponseUnmarshaller.Instance;

            return BeginInvoke<CreateFacetRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFacet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFacet.</param>
        /// 
        /// <returns>Returns a  CreateFacetResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/CreateFacet">REST API Reference for CreateFacet Operation</seealso>
        public  CreateFacetResponse EndCreateFacet(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateFacetResponse>(asyncResult);
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
        /// An operation can only operate on a directory that is not enabled.
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
        public CreateIndexResponse CreateIndex(CreateIndexRequest request)
        {
            var marshaller = new CreateIndexRequestMarshaller();
            var unmarshaller = CreateIndexResponseUnmarshaller.Instance;

            return Invoke<CreateIndexRequest,CreateIndexResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/CreateIndex">REST API Reference for CreateIndex Operation</seealso>
        public IAsyncResult BeginCreateIndex(CreateIndexRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateIndexRequestMarshaller();
            var unmarshaller = CreateIndexResponseUnmarshaller.Instance;

            return BeginInvoke<CreateIndexRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateIndex operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateIndex.</param>
        /// 
        /// <returns>Returns a  CreateIndexResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/CreateIndex">REST API Reference for CreateIndex Operation</seealso>
        public  CreateIndexResponse EndCreateIndex(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateIndexResponse>(asyncResult);
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
        /// An operation can only operate on a directory that is not enabled.
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
        public CreateObjectResponse CreateObject(CreateObjectRequest request)
        {
            var marshaller = new CreateObjectRequestMarshaller();
            var unmarshaller = CreateObjectResponseUnmarshaller.Instance;

            return Invoke<CreateObjectRequest,CreateObjectResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/CreateObject">REST API Reference for CreateObject Operation</seealso>
        public IAsyncResult BeginCreateObject(CreateObjectRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateObjectRequestMarshaller();
            var unmarshaller = CreateObjectResponseUnmarshaller.Instance;

            return BeginInvoke<CreateObjectRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateObject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateObject.</param>
        /// 
        /// <returns>Returns a  CreateObjectResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/CreateObject">REST API Reference for CreateObject Operation</seealso>
        public  CreateObjectResponse EndCreateObject(IAsyncResult asyncResult)
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
        public CreateSchemaResponse CreateSchema(CreateSchemaRequest request)
        {
            var marshaller = new CreateSchemaRequestMarshaller();
            var unmarshaller = CreateSchemaResponseUnmarshaller.Instance;

            return Invoke<CreateSchemaRequest,CreateSchemaResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/CreateSchema">REST API Reference for CreateSchema Operation</seealso>
        public IAsyncResult BeginCreateSchema(CreateSchemaRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateSchemaRequestMarshaller();
            var unmarshaller = CreateSchemaResponseUnmarshaller.Instance;

            return BeginInvoke<CreateSchemaRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSchema operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSchema.</param>
        /// 
        /// <returns>Returns a  CreateSchemaResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/CreateSchema">REST API Reference for CreateSchema Operation</seealso>
        public  CreateSchemaResponse EndCreateSchema(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSchemaResponse>(asyncResult);
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
        public CreateTypedLinkFacetResponse CreateTypedLinkFacet(CreateTypedLinkFacetRequest request)
        {
            var marshaller = new CreateTypedLinkFacetRequestMarshaller();
            var unmarshaller = CreateTypedLinkFacetResponseUnmarshaller.Instance;

            return Invoke<CreateTypedLinkFacetRequest,CreateTypedLinkFacetResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/CreateTypedLinkFacet">REST API Reference for CreateTypedLinkFacet Operation</seealso>
        public IAsyncResult BeginCreateTypedLinkFacet(CreateTypedLinkFacetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateTypedLinkFacetRequestMarshaller();
            var unmarshaller = CreateTypedLinkFacetResponseUnmarshaller.Instance;

            return BeginInvoke<CreateTypedLinkFacetRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTypedLinkFacet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTypedLinkFacet.</param>
        /// 
        /// <returns>Returns a  CreateTypedLinkFacetResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/CreateTypedLinkFacet">REST API Reference for CreateTypedLinkFacet Operation</seealso>
        public  CreateTypedLinkFacetResponse EndCreateTypedLinkFacet(IAsyncResult asyncResult)
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
        public DeleteDirectoryResponse DeleteDirectory(DeleteDirectoryRequest request)
        {
            var marshaller = new DeleteDirectoryRequestMarshaller();
            var unmarshaller = DeleteDirectoryResponseUnmarshaller.Instance;

            return Invoke<DeleteDirectoryRequest,DeleteDirectoryResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DeleteDirectory">REST API Reference for DeleteDirectory Operation</seealso>
        public IAsyncResult BeginDeleteDirectory(DeleteDirectoryRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteDirectoryRequestMarshaller();
            var unmarshaller = DeleteDirectoryResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteDirectoryRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDirectory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDirectory.</param>
        /// 
        /// <returns>Returns a  DeleteDirectoryResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DeleteDirectory">REST API Reference for DeleteDirectory Operation</seealso>
        public  DeleteDirectoryResponse EndDeleteDirectory(IAsyncResult asyncResult)
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
        public DeleteFacetResponse DeleteFacet(DeleteFacetRequest request)
        {
            var marshaller = new DeleteFacetRequestMarshaller();
            var unmarshaller = DeleteFacetResponseUnmarshaller.Instance;

            return Invoke<DeleteFacetRequest,DeleteFacetResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DeleteFacet">REST API Reference for DeleteFacet Operation</seealso>
        public IAsyncResult BeginDeleteFacet(DeleteFacetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteFacetRequestMarshaller();
            var unmarshaller = DeleteFacetResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteFacetRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFacet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFacet.</param>
        /// 
        /// <returns>Returns a  DeleteFacetResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DeleteFacet">REST API Reference for DeleteFacet Operation</seealso>
        public  DeleteFacetResponse EndDeleteFacet(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteFacetResponse>(asyncResult);
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
        /// An operation can only operate on a directory that is not enabled.
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
        public DeleteObjectResponse DeleteObject(DeleteObjectRequest request)
        {
            var marshaller = new DeleteObjectRequestMarshaller();
            var unmarshaller = DeleteObjectResponseUnmarshaller.Instance;

            return Invoke<DeleteObjectRequest,DeleteObjectResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DeleteObject">REST API Reference for DeleteObject Operation</seealso>
        public IAsyncResult BeginDeleteObject(DeleteObjectRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteObjectRequestMarshaller();
            var unmarshaller = DeleteObjectResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteObjectRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteObject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteObject.</param>
        /// 
        /// <returns>Returns a  DeleteObjectResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DeleteObject">REST API Reference for DeleteObject Operation</seealso>
        public  DeleteObjectResponse EndDeleteObject(IAsyncResult asyncResult)
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
        public DeleteSchemaResponse DeleteSchema(DeleteSchemaRequest request)
        {
            var marshaller = new DeleteSchemaRequestMarshaller();
            var unmarshaller = DeleteSchemaResponseUnmarshaller.Instance;

            return Invoke<DeleteSchemaRequest,DeleteSchemaResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DeleteSchema">REST API Reference for DeleteSchema Operation</seealso>
        public IAsyncResult BeginDeleteSchema(DeleteSchemaRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteSchemaRequestMarshaller();
            var unmarshaller = DeleteSchemaResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteSchemaRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSchema operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSchema.</param>
        /// 
        /// <returns>Returns a  DeleteSchemaResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DeleteSchema">REST API Reference for DeleteSchema Operation</seealso>
        public  DeleteSchemaResponse EndDeleteSchema(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSchemaResponse>(asyncResult);
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
        public DeleteTypedLinkFacetResponse DeleteTypedLinkFacet(DeleteTypedLinkFacetRequest request)
        {
            var marshaller = new DeleteTypedLinkFacetRequestMarshaller();
            var unmarshaller = DeleteTypedLinkFacetResponseUnmarshaller.Instance;

            return Invoke<DeleteTypedLinkFacetRequest,DeleteTypedLinkFacetResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DeleteTypedLinkFacet">REST API Reference for DeleteTypedLinkFacet Operation</seealso>
        public IAsyncResult BeginDeleteTypedLinkFacet(DeleteTypedLinkFacetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteTypedLinkFacetRequestMarshaller();
            var unmarshaller = DeleteTypedLinkFacetResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteTypedLinkFacetRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTypedLinkFacet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTypedLinkFacet.</param>
        /// 
        /// <returns>Returns a  DeleteTypedLinkFacetResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DeleteTypedLinkFacet">REST API Reference for DeleteTypedLinkFacet Operation</seealso>
        public  DeleteTypedLinkFacetResponse EndDeleteTypedLinkFacet(IAsyncResult asyncResult)
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
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// An operation can only operate on a directory that is not enabled.
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
        public DetachFromIndexResponse DetachFromIndex(DetachFromIndexRequest request)
        {
            var marshaller = new DetachFromIndexRequestMarshaller();
            var unmarshaller = DetachFromIndexResponseUnmarshaller.Instance;

            return Invoke<DetachFromIndexRequest,DetachFromIndexResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DetachFromIndex">REST API Reference for DetachFromIndex Operation</seealso>
        public IAsyncResult BeginDetachFromIndex(DetachFromIndexRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DetachFromIndexRequestMarshaller();
            var unmarshaller = DetachFromIndexResponseUnmarshaller.Instance;

            return BeginInvoke<DetachFromIndexRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DetachFromIndex operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachFromIndex.</param>
        /// 
        /// <returns>Returns a  DetachFromIndexResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DetachFromIndex">REST API Reference for DetachFromIndex Operation</seealso>
        public  DetachFromIndexResponse EndDetachFromIndex(IAsyncResult asyncResult)
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
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// An operation can only operate on a directory that is not enabled.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DetachObject">REST API Reference for DetachObject Operation</seealso>
        public DetachObjectResponse DetachObject(DetachObjectRequest request)
        {
            var marshaller = new DetachObjectRequestMarshaller();
            var unmarshaller = DetachObjectResponseUnmarshaller.Instance;

            return Invoke<DetachObjectRequest,DetachObjectResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DetachObject">REST API Reference for DetachObject Operation</seealso>
        public IAsyncResult BeginDetachObject(DetachObjectRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DetachObjectRequestMarshaller();
            var unmarshaller = DetachObjectResponseUnmarshaller.Instance;

            return BeginInvoke<DetachObjectRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DetachObject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachObject.</param>
        /// 
        /// <returns>Returns a  DetachObjectResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DetachObject">REST API Reference for DetachObject Operation</seealso>
        public  DetachObjectResponse EndDetachObject(IAsyncResult asyncResult)
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
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// An operation can only operate on a directory that is not enabled.
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
        public DetachPolicyResponse DetachPolicy(DetachPolicyRequest request)
        {
            var marshaller = new DetachPolicyRequestMarshaller();
            var unmarshaller = DetachPolicyResponseUnmarshaller.Instance;

            return Invoke<DetachPolicyRequest,DetachPolicyResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DetachPolicy">REST API Reference for DetachPolicy Operation</seealso>
        public IAsyncResult BeginDetachPolicy(DetachPolicyRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DetachPolicyRequestMarshaller();
            var unmarshaller = DetachPolicyResponseUnmarshaller.Instance;

            return BeginInvoke<DetachPolicyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DetachPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachPolicy.</param>
        /// 
        /// <returns>Returns a  DetachPolicyResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DetachPolicy">REST API Reference for DetachPolicy Operation</seealso>
        public  DetachPolicyResponse EndDetachPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DetachPolicyResponse>(asyncResult);
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
        public DetachTypedLinkResponse DetachTypedLink(DetachTypedLinkRequest request)
        {
            var marshaller = new DetachTypedLinkRequestMarshaller();
            var unmarshaller = DetachTypedLinkResponseUnmarshaller.Instance;

            return Invoke<DetachTypedLinkRequest,DetachTypedLinkResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DetachTypedLink">REST API Reference for DetachTypedLink Operation</seealso>
        public IAsyncResult BeginDetachTypedLink(DetachTypedLinkRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DetachTypedLinkRequestMarshaller();
            var unmarshaller = DetachTypedLinkResponseUnmarshaller.Instance;

            return BeginInvoke<DetachTypedLinkRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DetachTypedLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachTypedLink.</param>
        /// 
        /// <returns>Returns a  DetachTypedLinkResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DetachTypedLink">REST API Reference for DetachTypedLink Operation</seealso>
        public  DetachTypedLinkResponse EndDetachTypedLink(IAsyncResult asyncResult)
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
        public DisableDirectoryResponse DisableDirectory(DisableDirectoryRequest request)
        {
            var marshaller = new DisableDirectoryRequestMarshaller();
            var unmarshaller = DisableDirectoryResponseUnmarshaller.Instance;

            return Invoke<DisableDirectoryRequest,DisableDirectoryResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DisableDirectory">REST API Reference for DisableDirectory Operation</seealso>
        public IAsyncResult BeginDisableDirectory(DisableDirectoryRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DisableDirectoryRequestMarshaller();
            var unmarshaller = DisableDirectoryResponseUnmarshaller.Instance;

            return BeginInvoke<DisableDirectoryRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisableDirectory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableDirectory.</param>
        /// 
        /// <returns>Returns a  DisableDirectoryResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DisableDirectory">REST API Reference for DisableDirectory Operation</seealso>
        public  DisableDirectoryResponse EndDisableDirectory(IAsyncResult asyncResult)
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
        public EnableDirectoryResponse EnableDirectory(EnableDirectoryRequest request)
        {
            var marshaller = new EnableDirectoryRequestMarshaller();
            var unmarshaller = EnableDirectoryResponseUnmarshaller.Instance;

            return Invoke<EnableDirectoryRequest,EnableDirectoryResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/EnableDirectory">REST API Reference for EnableDirectory Operation</seealso>
        public IAsyncResult BeginEnableDirectory(EnableDirectoryRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new EnableDirectoryRequestMarshaller();
            var unmarshaller = EnableDirectoryResponseUnmarshaller.Instance;

            return BeginInvoke<EnableDirectoryRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  EnableDirectory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableDirectory.</param>
        /// 
        /// <returns>Returns a  EnableDirectoryResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/EnableDirectory">REST API Reference for EnableDirectory Operation</seealso>
        public  EnableDirectoryResponse EndEnableDirectory(IAsyncResult asyncResult)
        {
            return EndInvoke<EnableDirectoryResponse>(asyncResult);
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
        public GetDirectoryResponse GetDirectory(GetDirectoryRequest request)
        {
            var marshaller = new GetDirectoryRequestMarshaller();
            var unmarshaller = GetDirectoryResponseUnmarshaller.Instance;

            return Invoke<GetDirectoryRequest,GetDirectoryResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/GetDirectory">REST API Reference for GetDirectory Operation</seealso>
        public IAsyncResult BeginGetDirectory(GetDirectoryRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetDirectoryRequestMarshaller();
            var unmarshaller = GetDirectoryResponseUnmarshaller.Instance;

            return BeginInvoke<GetDirectoryRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDirectory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDirectory.</param>
        /// 
        /// <returns>Returns a  GetDirectoryResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/GetDirectory">REST API Reference for GetDirectory Operation</seealso>
        public  GetDirectoryResponse EndGetDirectory(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDirectoryResponse>(asyncResult);
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
        public GetFacetResponse GetFacet(GetFacetRequest request)
        {
            var marshaller = new GetFacetRequestMarshaller();
            var unmarshaller = GetFacetResponseUnmarshaller.Instance;

            return Invoke<GetFacetRequest,GetFacetResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/GetFacet">REST API Reference for GetFacet Operation</seealso>
        public IAsyncResult BeginGetFacet(GetFacetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetFacetRequestMarshaller();
            var unmarshaller = GetFacetResponseUnmarshaller.Instance;

            return BeginInvoke<GetFacetRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetFacet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFacet.</param>
        /// 
        /// <returns>Returns a  GetFacetResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/GetFacet">REST API Reference for GetFacet Operation</seealso>
        public  GetFacetResponse EndGetFacet(IAsyncResult asyncResult)
        {
            return EndInvoke<GetFacetResponse>(asyncResult);
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
        /// An operation can only operate on a directory that is not enabled.
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
        public GetObjectInformationResponse GetObjectInformation(GetObjectInformationRequest request)
        {
            var marshaller = new GetObjectInformationRequestMarshaller();
            var unmarshaller = GetObjectInformationResponseUnmarshaller.Instance;

            return Invoke<GetObjectInformationRequest,GetObjectInformationResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/GetObjectInformation">REST API Reference for GetObjectInformation Operation</seealso>
        public IAsyncResult BeginGetObjectInformation(GetObjectInformationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetObjectInformationRequestMarshaller();
            var unmarshaller = GetObjectInformationResponseUnmarshaller.Instance;

            return BeginInvoke<GetObjectInformationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetObjectInformation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetObjectInformation.</param>
        /// 
        /// <returns>Returns a  GetObjectInformationResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/GetObjectInformation">REST API Reference for GetObjectInformation Operation</seealso>
        public  GetObjectInformationResponse EndGetObjectInformation(IAsyncResult asyncResult)
        {
            return EndInvoke<GetObjectInformationResponse>(asyncResult);
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
        public GetSchemaAsJsonResponse GetSchemaAsJson(GetSchemaAsJsonRequest request)
        {
            var marshaller = new GetSchemaAsJsonRequestMarshaller();
            var unmarshaller = GetSchemaAsJsonResponseUnmarshaller.Instance;

            return Invoke<GetSchemaAsJsonRequest,GetSchemaAsJsonResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/GetSchemaAsJson">REST API Reference for GetSchemaAsJson Operation</seealso>
        public IAsyncResult BeginGetSchemaAsJson(GetSchemaAsJsonRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetSchemaAsJsonRequestMarshaller();
            var unmarshaller = GetSchemaAsJsonResponseUnmarshaller.Instance;

            return BeginInvoke<GetSchemaAsJsonRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSchemaAsJson operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSchemaAsJson.</param>
        /// 
        /// <returns>Returns a  GetSchemaAsJsonResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/GetSchemaAsJson">REST API Reference for GetSchemaAsJson Operation</seealso>
        public  GetSchemaAsJsonResponse EndGetSchemaAsJson(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSchemaAsJsonResponse>(asyncResult);
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
        public GetTypedLinkFacetInformationResponse GetTypedLinkFacetInformation(GetTypedLinkFacetInformationRequest request)
        {
            var marshaller = new GetTypedLinkFacetInformationRequestMarshaller();
            var unmarshaller = GetTypedLinkFacetInformationResponseUnmarshaller.Instance;

            return Invoke<GetTypedLinkFacetInformationRequest,GetTypedLinkFacetInformationResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/GetTypedLinkFacetInformation">REST API Reference for GetTypedLinkFacetInformation Operation</seealso>
        public IAsyncResult BeginGetTypedLinkFacetInformation(GetTypedLinkFacetInformationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetTypedLinkFacetInformationRequestMarshaller();
            var unmarshaller = GetTypedLinkFacetInformationResponseUnmarshaller.Instance;

            return BeginInvoke<GetTypedLinkFacetInformationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTypedLinkFacetInformation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTypedLinkFacetInformation.</param>
        /// 
        /// <returns>Returns a  GetTypedLinkFacetInformationResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/GetTypedLinkFacetInformation">REST API Reference for GetTypedLinkFacetInformation Operation</seealso>
        public  GetTypedLinkFacetInformationResponse EndGetTypedLinkFacetInformation(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTypedLinkFacetInformationResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAppliedSchemaArns

        /// <summary>
        /// Lists schemas applied to a directory.
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
        public ListAppliedSchemaArnsResponse ListAppliedSchemaArns(ListAppliedSchemaArnsRequest request)
        {
            var marshaller = new ListAppliedSchemaArnsRequestMarshaller();
            var unmarshaller = ListAppliedSchemaArnsResponseUnmarshaller.Instance;

            return Invoke<ListAppliedSchemaArnsRequest,ListAppliedSchemaArnsResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListAppliedSchemaArns">REST API Reference for ListAppliedSchemaArns Operation</seealso>
        public IAsyncResult BeginListAppliedSchemaArns(ListAppliedSchemaArnsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListAppliedSchemaArnsRequestMarshaller();
            var unmarshaller = ListAppliedSchemaArnsResponseUnmarshaller.Instance;

            return BeginInvoke<ListAppliedSchemaArnsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAppliedSchemaArns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAppliedSchemaArns.</param>
        /// 
        /// <returns>Returns a  ListAppliedSchemaArnsResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListAppliedSchemaArns">REST API Reference for ListAppliedSchemaArns Operation</seealso>
        public  ListAppliedSchemaArnsResponse EndListAppliedSchemaArns(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAppliedSchemaArnsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAttachedIndices

        /// <summary>
        /// Lists indices attached to an object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAttachedIndices service method.</param>
        /// 
        /// <returns>The response from the ListAttachedIndices service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// An operation can only operate on a directory that is not enabled.
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
        public ListAttachedIndicesResponse ListAttachedIndices(ListAttachedIndicesRequest request)
        {
            var marshaller = new ListAttachedIndicesRequestMarshaller();
            var unmarshaller = ListAttachedIndicesResponseUnmarshaller.Instance;

            return Invoke<ListAttachedIndicesRequest,ListAttachedIndicesResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListAttachedIndices">REST API Reference for ListAttachedIndices Operation</seealso>
        public IAsyncResult BeginListAttachedIndices(ListAttachedIndicesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListAttachedIndicesRequestMarshaller();
            var unmarshaller = ListAttachedIndicesResponseUnmarshaller.Instance;

            return BeginInvoke<ListAttachedIndicesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAttachedIndices operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAttachedIndices.</param>
        /// 
        /// <returns>Returns a  ListAttachedIndicesResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListAttachedIndices">REST API Reference for ListAttachedIndices Operation</seealso>
        public  ListAttachedIndicesResponse EndListAttachedIndices(IAsyncResult asyncResult)
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
        public ListDevelopmentSchemaArnsResponse ListDevelopmentSchemaArns(ListDevelopmentSchemaArnsRequest request)
        {
            var marshaller = new ListDevelopmentSchemaArnsRequestMarshaller();
            var unmarshaller = ListDevelopmentSchemaArnsResponseUnmarshaller.Instance;

            return Invoke<ListDevelopmentSchemaArnsRequest,ListDevelopmentSchemaArnsResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListDevelopmentSchemaArns">REST API Reference for ListDevelopmentSchemaArns Operation</seealso>
        public IAsyncResult BeginListDevelopmentSchemaArns(ListDevelopmentSchemaArnsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListDevelopmentSchemaArnsRequestMarshaller();
            var unmarshaller = ListDevelopmentSchemaArnsResponseUnmarshaller.Instance;

            return BeginInvoke<ListDevelopmentSchemaArnsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDevelopmentSchemaArns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDevelopmentSchemaArns.</param>
        /// 
        /// <returns>Returns a  ListDevelopmentSchemaArnsResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListDevelopmentSchemaArns">REST API Reference for ListDevelopmentSchemaArns Operation</seealso>
        public  ListDevelopmentSchemaArnsResponse EndListDevelopmentSchemaArns(IAsyncResult asyncResult)
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
        public ListDirectoriesResponse ListDirectories(ListDirectoriesRequest request)
        {
            var marshaller = new ListDirectoriesRequestMarshaller();
            var unmarshaller = ListDirectoriesResponseUnmarshaller.Instance;

            return Invoke<ListDirectoriesRequest,ListDirectoriesResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListDirectories">REST API Reference for ListDirectories Operation</seealso>
        public IAsyncResult BeginListDirectories(ListDirectoriesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListDirectoriesRequestMarshaller();
            var unmarshaller = ListDirectoriesResponseUnmarshaller.Instance;

            return BeginInvoke<ListDirectoriesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDirectories operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDirectories.</param>
        /// 
        /// <returns>Returns a  ListDirectoriesResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListDirectories">REST API Reference for ListDirectories Operation</seealso>
        public  ListDirectoriesResponse EndListDirectories(IAsyncResult asyncResult)
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
        public ListFacetAttributesResponse ListFacetAttributes(ListFacetAttributesRequest request)
        {
            var marshaller = new ListFacetAttributesRequestMarshaller();
            var unmarshaller = ListFacetAttributesResponseUnmarshaller.Instance;

            return Invoke<ListFacetAttributesRequest,ListFacetAttributesResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListFacetAttributes">REST API Reference for ListFacetAttributes Operation</seealso>
        public IAsyncResult BeginListFacetAttributes(ListFacetAttributesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListFacetAttributesRequestMarshaller();
            var unmarshaller = ListFacetAttributesResponseUnmarshaller.Instance;

            return BeginInvoke<ListFacetAttributesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListFacetAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFacetAttributes.</param>
        /// 
        /// <returns>Returns a  ListFacetAttributesResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListFacetAttributes">REST API Reference for ListFacetAttributes Operation</seealso>
        public  ListFacetAttributesResponse EndListFacetAttributes(IAsyncResult asyncResult)
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
        public ListFacetNamesResponse ListFacetNames(ListFacetNamesRequest request)
        {
            var marshaller = new ListFacetNamesRequestMarshaller();
            var unmarshaller = ListFacetNamesResponseUnmarshaller.Instance;

            return Invoke<ListFacetNamesRequest,ListFacetNamesResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListFacetNames">REST API Reference for ListFacetNames Operation</seealso>
        public IAsyncResult BeginListFacetNames(ListFacetNamesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListFacetNamesRequestMarshaller();
            var unmarshaller = ListFacetNamesResponseUnmarshaller.Instance;

            return BeginInvoke<ListFacetNamesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListFacetNames operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFacetNames.</param>
        /// 
        /// <returns>Returns a  ListFacetNamesResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListFacetNames">REST API Reference for ListFacetNames Operation</seealso>
        public  ListFacetNamesResponse EndListFacetNames(IAsyncResult asyncResult)
        {
            return EndInvoke<ListFacetNamesResponse>(asyncResult);
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
        public ListIncomingTypedLinksResponse ListIncomingTypedLinks(ListIncomingTypedLinksRequest request)
        {
            var marshaller = new ListIncomingTypedLinksRequestMarshaller();
            var unmarshaller = ListIncomingTypedLinksResponseUnmarshaller.Instance;

            return Invoke<ListIncomingTypedLinksRequest,ListIncomingTypedLinksResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListIncomingTypedLinks">REST API Reference for ListIncomingTypedLinks Operation</seealso>
        public IAsyncResult BeginListIncomingTypedLinks(ListIncomingTypedLinksRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListIncomingTypedLinksRequestMarshaller();
            var unmarshaller = ListIncomingTypedLinksResponseUnmarshaller.Instance;

            return BeginInvoke<ListIncomingTypedLinksRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListIncomingTypedLinks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIncomingTypedLinks.</param>
        /// 
        /// <returns>Returns a  ListIncomingTypedLinksResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListIncomingTypedLinks">REST API Reference for ListIncomingTypedLinks Operation</seealso>
        public  ListIncomingTypedLinksResponse EndListIncomingTypedLinks(IAsyncResult asyncResult)
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
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// An operation can only operate on a directory that is not enabled.
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
        public ListIndexResponse ListIndex(ListIndexRequest request)
        {
            var marshaller = new ListIndexRequestMarshaller();
            var unmarshaller = ListIndexResponseUnmarshaller.Instance;

            return Invoke<ListIndexRequest,ListIndexResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListIndex">REST API Reference for ListIndex Operation</seealso>
        public IAsyncResult BeginListIndex(ListIndexRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListIndexRequestMarshaller();
            var unmarshaller = ListIndexResponseUnmarshaller.Instance;

            return BeginInvoke<ListIndexRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListIndex operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIndex.</param>
        /// 
        /// <returns>Returns a  ListIndexResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListIndex">REST API Reference for ListIndex Operation</seealso>
        public  ListIndexResponse EndListIndex(IAsyncResult asyncResult)
        {
            return EndInvoke<ListIndexResponse>(asyncResult);
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
        /// An operation can only operate on a directory that is not enabled.
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
        public ListObjectAttributesResponse ListObjectAttributes(ListObjectAttributesRequest request)
        {
            var marshaller = new ListObjectAttributesRequestMarshaller();
            var unmarshaller = ListObjectAttributesResponseUnmarshaller.Instance;

            return Invoke<ListObjectAttributesRequest,ListObjectAttributesResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListObjectAttributes">REST API Reference for ListObjectAttributes Operation</seealso>
        public IAsyncResult BeginListObjectAttributes(ListObjectAttributesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListObjectAttributesRequestMarshaller();
            var unmarshaller = ListObjectAttributesResponseUnmarshaller.Instance;

            return BeginInvoke<ListObjectAttributesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListObjectAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListObjectAttributes.</param>
        /// 
        /// <returns>Returns a  ListObjectAttributesResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListObjectAttributes">REST API Reference for ListObjectAttributes Operation</seealso>
        public  ListObjectAttributesResponse EndListObjectAttributes(IAsyncResult asyncResult)
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
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// An operation can only operate on a directory that is not enabled.
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
        public ListObjectChildrenResponse ListObjectChildren(ListObjectChildrenRequest request)
        {
            var marshaller = new ListObjectChildrenRequestMarshaller();
            var unmarshaller = ListObjectChildrenResponseUnmarshaller.Instance;

            return Invoke<ListObjectChildrenRequest,ListObjectChildrenResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListObjectChildren">REST API Reference for ListObjectChildren Operation</seealso>
        public IAsyncResult BeginListObjectChildren(ListObjectChildrenRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListObjectChildrenRequestMarshaller();
            var unmarshaller = ListObjectChildrenResponseUnmarshaller.Instance;

            return BeginInvoke<ListObjectChildrenRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListObjectChildren operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListObjectChildren.</param>
        /// 
        /// <returns>Returns a  ListObjectChildrenResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListObjectChildren">REST API Reference for ListObjectChildren Operation</seealso>
        public  ListObjectChildrenResponse EndListObjectChildren(IAsyncResult asyncResult)
        {
            return EndInvoke<ListObjectChildrenResponse>(asyncResult);
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
        /// An operation can only operate on a directory that is not enabled.
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
        public ListObjectParentPathsResponse ListObjectParentPaths(ListObjectParentPathsRequest request)
        {
            var marshaller = new ListObjectParentPathsRequestMarshaller();
            var unmarshaller = ListObjectParentPathsResponseUnmarshaller.Instance;

            return Invoke<ListObjectParentPathsRequest,ListObjectParentPathsResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListObjectParentPaths">REST API Reference for ListObjectParentPaths Operation</seealso>
        public IAsyncResult BeginListObjectParentPaths(ListObjectParentPathsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListObjectParentPathsRequestMarshaller();
            var unmarshaller = ListObjectParentPathsResponseUnmarshaller.Instance;

            return BeginInvoke<ListObjectParentPathsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListObjectParentPaths operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListObjectParentPaths.</param>
        /// 
        /// <returns>Returns a  ListObjectParentPathsResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListObjectParentPaths">REST API Reference for ListObjectParentPaths Operation</seealso>
        public  ListObjectParentPathsResponse EndListObjectParentPaths(IAsyncResult asyncResult)
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
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.CannotListParentOfRootException">
        /// Cannot list the parents of a <a>Directory</a> root.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// An operation can only operate on a directory that is not enabled.
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
        public ListObjectParentsResponse ListObjectParents(ListObjectParentsRequest request)
        {
            var marshaller = new ListObjectParentsRequestMarshaller();
            var unmarshaller = ListObjectParentsResponseUnmarshaller.Instance;

            return Invoke<ListObjectParentsRequest,ListObjectParentsResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListObjectParents">REST API Reference for ListObjectParents Operation</seealso>
        public IAsyncResult BeginListObjectParents(ListObjectParentsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListObjectParentsRequestMarshaller();
            var unmarshaller = ListObjectParentsResponseUnmarshaller.Instance;

            return BeginInvoke<ListObjectParentsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListObjectParents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListObjectParents.</param>
        /// 
        /// <returns>Returns a  ListObjectParentsResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListObjectParents">REST API Reference for ListObjectParents Operation</seealso>
        public  ListObjectParentsResponse EndListObjectParents(IAsyncResult asyncResult)
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
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// An operation can only operate on a directory that is not enabled.
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
        public ListObjectPoliciesResponse ListObjectPolicies(ListObjectPoliciesRequest request)
        {
            var marshaller = new ListObjectPoliciesRequestMarshaller();
            var unmarshaller = ListObjectPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListObjectPoliciesRequest,ListObjectPoliciesResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListObjectPolicies">REST API Reference for ListObjectPolicies Operation</seealso>
        public IAsyncResult BeginListObjectPolicies(ListObjectPoliciesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListObjectPoliciesRequestMarshaller();
            var unmarshaller = ListObjectPoliciesResponseUnmarshaller.Instance;

            return BeginInvoke<ListObjectPoliciesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListObjectPolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListObjectPolicies.</param>
        /// 
        /// <returns>Returns a  ListObjectPoliciesResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListObjectPolicies">REST API Reference for ListObjectPolicies Operation</seealso>
        public  ListObjectPoliciesResponse EndListObjectPolicies(IAsyncResult asyncResult)
        {
            return EndInvoke<ListObjectPoliciesResponse>(asyncResult);
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
        public ListOutgoingTypedLinksResponse ListOutgoingTypedLinks(ListOutgoingTypedLinksRequest request)
        {
            var marshaller = new ListOutgoingTypedLinksRequestMarshaller();
            var unmarshaller = ListOutgoingTypedLinksResponseUnmarshaller.Instance;

            return Invoke<ListOutgoingTypedLinksRequest,ListOutgoingTypedLinksResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListOutgoingTypedLinks">REST API Reference for ListOutgoingTypedLinks Operation</seealso>
        public IAsyncResult BeginListOutgoingTypedLinks(ListOutgoingTypedLinksRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListOutgoingTypedLinksRequestMarshaller();
            var unmarshaller = ListOutgoingTypedLinksResponseUnmarshaller.Instance;

            return BeginInvoke<ListOutgoingTypedLinksRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListOutgoingTypedLinks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOutgoingTypedLinks.</param>
        /// 
        /// <returns>Returns a  ListOutgoingTypedLinksResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListOutgoingTypedLinks">REST API Reference for ListOutgoingTypedLinks Operation</seealso>
        public  ListOutgoingTypedLinksResponse EndListOutgoingTypedLinks(IAsyncResult asyncResult)
        {
            return EndInvoke<ListOutgoingTypedLinksResponse>(asyncResult);
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
        /// An operation can only operate on a directory that is not enabled.
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
        public ListPolicyAttachmentsResponse ListPolicyAttachments(ListPolicyAttachmentsRequest request)
        {
            var marshaller = new ListPolicyAttachmentsRequestMarshaller();
            var unmarshaller = ListPolicyAttachmentsResponseUnmarshaller.Instance;

            return Invoke<ListPolicyAttachmentsRequest,ListPolicyAttachmentsResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListPolicyAttachments">REST API Reference for ListPolicyAttachments Operation</seealso>
        public IAsyncResult BeginListPolicyAttachments(ListPolicyAttachmentsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListPolicyAttachmentsRequestMarshaller();
            var unmarshaller = ListPolicyAttachmentsResponseUnmarshaller.Instance;

            return BeginInvoke<ListPolicyAttachmentsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPolicyAttachments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPolicyAttachments.</param>
        /// 
        /// <returns>Returns a  ListPolicyAttachmentsResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListPolicyAttachments">REST API Reference for ListPolicyAttachments Operation</seealso>
        public  ListPolicyAttachmentsResponse EndListPolicyAttachments(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPolicyAttachmentsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPublishedSchemaArns

        /// <summary>
        /// Retrieves each published schema Amazon Resource Name (ARN).
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
        public ListPublishedSchemaArnsResponse ListPublishedSchemaArns(ListPublishedSchemaArnsRequest request)
        {
            var marshaller = new ListPublishedSchemaArnsRequestMarshaller();
            var unmarshaller = ListPublishedSchemaArnsResponseUnmarshaller.Instance;

            return Invoke<ListPublishedSchemaArnsRequest,ListPublishedSchemaArnsResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListPublishedSchemaArns">REST API Reference for ListPublishedSchemaArns Operation</seealso>
        public IAsyncResult BeginListPublishedSchemaArns(ListPublishedSchemaArnsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListPublishedSchemaArnsRequestMarshaller();
            var unmarshaller = ListPublishedSchemaArnsResponseUnmarshaller.Instance;

            return BeginInvoke<ListPublishedSchemaArnsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPublishedSchemaArns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPublishedSchemaArns.</param>
        /// 
        /// <returns>Returns a  ListPublishedSchemaArnsResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListPublishedSchemaArns">REST API Reference for ListPublishedSchemaArns Operation</seealso>
        public  ListPublishedSchemaArnsResponse EndListPublishedSchemaArns(IAsyncResult asyncResult)
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
        public ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var marshaller = new ListTagsForResourceRequestMarshaller();
            var unmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceRequest,ListTagsForResourceResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListTagsForResourceRequestMarshaller();
            var unmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke<ListTagsForResourceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public  ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
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
        public ListTypedLinkFacetAttributesResponse ListTypedLinkFacetAttributes(ListTypedLinkFacetAttributesRequest request)
        {
            var marshaller = new ListTypedLinkFacetAttributesRequestMarshaller();
            var unmarshaller = ListTypedLinkFacetAttributesResponseUnmarshaller.Instance;

            return Invoke<ListTypedLinkFacetAttributesRequest,ListTypedLinkFacetAttributesResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListTypedLinkFacetAttributes">REST API Reference for ListTypedLinkFacetAttributes Operation</seealso>
        public IAsyncResult BeginListTypedLinkFacetAttributes(ListTypedLinkFacetAttributesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListTypedLinkFacetAttributesRequestMarshaller();
            var unmarshaller = ListTypedLinkFacetAttributesResponseUnmarshaller.Instance;

            return BeginInvoke<ListTypedLinkFacetAttributesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTypedLinkFacetAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTypedLinkFacetAttributes.</param>
        /// 
        /// <returns>Returns a  ListTypedLinkFacetAttributesResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListTypedLinkFacetAttributes">REST API Reference for ListTypedLinkFacetAttributes Operation</seealso>
        public  ListTypedLinkFacetAttributesResponse EndListTypedLinkFacetAttributes(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTypedLinkFacetAttributesResponse>(asyncResult);
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
        public ListTypedLinkFacetNamesResponse ListTypedLinkFacetNames(ListTypedLinkFacetNamesRequest request)
        {
            var marshaller = new ListTypedLinkFacetNamesRequestMarshaller();
            var unmarshaller = ListTypedLinkFacetNamesResponseUnmarshaller.Instance;

            return Invoke<ListTypedLinkFacetNamesRequest,ListTypedLinkFacetNamesResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListTypedLinkFacetNames">REST API Reference for ListTypedLinkFacetNames Operation</seealso>
        public IAsyncResult BeginListTypedLinkFacetNames(ListTypedLinkFacetNamesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListTypedLinkFacetNamesRequestMarshaller();
            var unmarshaller = ListTypedLinkFacetNamesResponseUnmarshaller.Instance;

            return BeginInvoke<ListTypedLinkFacetNamesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTypedLinkFacetNames operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTypedLinkFacetNames.</param>
        /// 
        /// <returns>Returns a  ListTypedLinkFacetNamesResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListTypedLinkFacetNames">REST API Reference for ListTypedLinkFacetNames Operation</seealso>
        public  ListTypedLinkFacetNamesResponse EndListTypedLinkFacetNames(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTypedLinkFacetNamesResponse>(asyncResult);
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
        /// An operation can only operate on a directory that is not enabled.
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
        public LookupPolicyResponse LookupPolicy(LookupPolicyRequest request)
        {
            var marshaller = new LookupPolicyRequestMarshaller();
            var unmarshaller = LookupPolicyResponseUnmarshaller.Instance;

            return Invoke<LookupPolicyRequest,LookupPolicyResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/LookupPolicy">REST API Reference for LookupPolicy Operation</seealso>
        public IAsyncResult BeginLookupPolicy(LookupPolicyRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new LookupPolicyRequestMarshaller();
            var unmarshaller = LookupPolicyResponseUnmarshaller.Instance;

            return BeginInvoke<LookupPolicyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  LookupPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginLookupPolicy.</param>
        /// 
        /// <returns>Returns a  LookupPolicyResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/LookupPolicy">REST API Reference for LookupPolicy Operation</seealso>
        public  LookupPolicyResponse EndLookupPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<LookupPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  PublishSchema

        /// <summary>
        /// Publishes a development schema with a version. If description and attributes are specified,
        /// <code>PublishSchema</code> overrides the development schema description and attributes.
        /// If not, the development schema description and attributes are used.
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
        public PublishSchemaResponse PublishSchema(PublishSchemaRequest request)
        {
            var marshaller = new PublishSchemaRequestMarshaller();
            var unmarshaller = PublishSchemaResponseUnmarshaller.Instance;

            return Invoke<PublishSchemaRequest,PublishSchemaResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/PublishSchema">REST API Reference for PublishSchema Operation</seealso>
        public IAsyncResult BeginPublishSchema(PublishSchemaRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new PublishSchemaRequestMarshaller();
            var unmarshaller = PublishSchemaResponseUnmarshaller.Instance;

            return BeginInvoke<PublishSchemaRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PublishSchema operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPublishSchema.</param>
        /// 
        /// <returns>Returns a  PublishSchemaResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/PublishSchema">REST API Reference for PublishSchema Operation</seealso>
        public  PublishSchemaResponse EndPublishSchema(IAsyncResult asyncResult)
        {
            return EndInvoke<PublishSchemaResponse>(asyncResult);
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
        public PutSchemaFromJsonResponse PutSchemaFromJson(PutSchemaFromJsonRequest request)
        {
            var marshaller = new PutSchemaFromJsonRequestMarshaller();
            var unmarshaller = PutSchemaFromJsonResponseUnmarshaller.Instance;

            return Invoke<PutSchemaFromJsonRequest,PutSchemaFromJsonResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/PutSchemaFromJson">REST API Reference for PutSchemaFromJson Operation</seealso>
        public IAsyncResult BeginPutSchemaFromJson(PutSchemaFromJsonRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new PutSchemaFromJsonRequestMarshaller();
            var unmarshaller = PutSchemaFromJsonResponseUnmarshaller.Instance;

            return BeginInvoke<PutSchemaFromJsonRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutSchemaFromJson operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutSchemaFromJson.</param>
        /// 
        /// <returns>Returns a  PutSchemaFromJsonResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/PutSchemaFromJson">REST API Reference for PutSchemaFromJson Operation</seealso>
        public  PutSchemaFromJsonResponse EndPutSchemaFromJson(IAsyncResult asyncResult)
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
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// An operation can only operate on a directory that is not enabled.
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
        public RemoveFacetFromObjectResponse RemoveFacetFromObject(RemoveFacetFromObjectRequest request)
        {
            var marshaller = new RemoveFacetFromObjectRequestMarshaller();
            var unmarshaller = RemoveFacetFromObjectResponseUnmarshaller.Instance;

            return Invoke<RemoveFacetFromObjectRequest,RemoveFacetFromObjectResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/RemoveFacetFromObject">REST API Reference for RemoveFacetFromObject Operation</seealso>
        public IAsyncResult BeginRemoveFacetFromObject(RemoveFacetFromObjectRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new RemoveFacetFromObjectRequestMarshaller();
            var unmarshaller = RemoveFacetFromObjectResponseUnmarshaller.Instance;

            return BeginInvoke<RemoveFacetFromObjectRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveFacetFromObject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveFacetFromObject.</param>
        /// 
        /// <returns>Returns a  RemoveFacetFromObjectResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/RemoveFacetFromObject">REST API Reference for RemoveFacetFromObject Operation</seealso>
        public  RemoveFacetFromObjectResponse EndRemoveFacetFromObject(IAsyncResult asyncResult)
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
        public TagResourceResponse TagResource(TagResourceRequest request)
        {
            var marshaller = new TagResourceRequestMarshaller();
            var unmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceRequest,TagResourceResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        public IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new TagResourceRequestMarshaller();
            var unmarshaller = TagResourceResponseUnmarshaller.Instance;

            return BeginInvoke<TagResourceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        public  TagResourceResponse EndTagResource(IAsyncResult asyncResult)
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
        public UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var marshaller = new UntagResourceRequestMarshaller();
            var unmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceRequest,UntagResourceResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UntagResourceRequestMarshaller();
            var unmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return BeginInvoke<UntagResourceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public  UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
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
        public UpdateFacetResponse UpdateFacet(UpdateFacetRequest request)
        {
            var marshaller = new UpdateFacetRequestMarshaller();
            var unmarshaller = UpdateFacetResponseUnmarshaller.Instance;

            return Invoke<UpdateFacetRequest,UpdateFacetResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/UpdateFacet">REST API Reference for UpdateFacet Operation</seealso>
        public IAsyncResult BeginUpdateFacet(UpdateFacetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateFacetRequestMarshaller();
            var unmarshaller = UpdateFacetResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateFacetRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFacet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFacet.</param>
        /// 
        /// <returns>Returns a  UpdateFacetResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/UpdateFacet">REST API Reference for UpdateFacet Operation</seealso>
        public  UpdateFacetResponse EndUpdateFacet(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateFacetResponse>(asyncResult);
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
        /// An operation can only operate on a directory that is not enabled.
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
        public UpdateObjectAttributesResponse UpdateObjectAttributes(UpdateObjectAttributesRequest request)
        {
            var marshaller = new UpdateObjectAttributesRequestMarshaller();
            var unmarshaller = UpdateObjectAttributesResponseUnmarshaller.Instance;

            return Invoke<UpdateObjectAttributesRequest,UpdateObjectAttributesResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/UpdateObjectAttributes">REST API Reference for UpdateObjectAttributes Operation</seealso>
        public IAsyncResult BeginUpdateObjectAttributes(UpdateObjectAttributesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateObjectAttributesRequestMarshaller();
            var unmarshaller = UpdateObjectAttributesResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateObjectAttributesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateObjectAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateObjectAttributes.</param>
        /// 
        /// <returns>Returns a  UpdateObjectAttributesResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/UpdateObjectAttributes">REST API Reference for UpdateObjectAttributes Operation</seealso>
        public  UpdateObjectAttributesResponse EndUpdateObjectAttributes(IAsyncResult asyncResult)
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
        public UpdateSchemaResponse UpdateSchema(UpdateSchemaRequest request)
        {
            var marshaller = new UpdateSchemaRequestMarshaller();
            var unmarshaller = UpdateSchemaResponseUnmarshaller.Instance;

            return Invoke<UpdateSchemaRequest,UpdateSchemaResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/UpdateSchema">REST API Reference for UpdateSchema Operation</seealso>
        public IAsyncResult BeginUpdateSchema(UpdateSchemaRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateSchemaRequestMarshaller();
            var unmarshaller = UpdateSchemaResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateSchemaRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSchema operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSchema.</param>
        /// 
        /// <returns>Returns a  UpdateSchemaResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/UpdateSchema">REST API Reference for UpdateSchema Operation</seealso>
        public  UpdateSchemaResponse EndUpdateSchema(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSchemaResponse>(asyncResult);
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
        public UpdateTypedLinkFacetResponse UpdateTypedLinkFacet(UpdateTypedLinkFacetRequest request)
        {
            var marshaller = new UpdateTypedLinkFacetRequestMarshaller();
            var unmarshaller = UpdateTypedLinkFacetResponseUnmarshaller.Instance;

            return Invoke<UpdateTypedLinkFacetRequest,UpdateTypedLinkFacetResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/UpdateTypedLinkFacet">REST API Reference for UpdateTypedLinkFacet Operation</seealso>
        public IAsyncResult BeginUpdateTypedLinkFacet(UpdateTypedLinkFacetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateTypedLinkFacetRequestMarshaller();
            var unmarshaller = UpdateTypedLinkFacetResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateTypedLinkFacetRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTypedLinkFacet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTypedLinkFacet.</param>
        /// 
        /// <returns>Returns a  UpdateTypedLinkFacetResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/UpdateTypedLinkFacet">REST API Reference for UpdateTypedLinkFacet Operation</seealso>
        public  UpdateTypedLinkFacetResponse EndUpdateTypedLinkFacet(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateTypedLinkFacetResponse>(asyncResult);
        }

        #endregion
        
    }
}