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
 * Do not modify this file. This file is generated from the lakeformation-2017-03-31.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.LakeFormation.Model;
using Amazon.LakeFormation.Model.Internal.MarshallTransformations;
using Amazon.LakeFormation.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.LakeFormation
{
    /// <summary>
    /// Implementation for accessing LakeFormation
    ///
    /// AWS Lake Formation 
    /// <para>
    /// Defines the public endpoint for the AWS Lake Formation service.
    /// </para>
    /// </summary>
    public partial class AmazonLakeFormationClient : AmazonServiceClient, IAmazonLakeFormation
    {
        private static IServiceMetadata serviceMetadata = new AmazonLakeFormationMetadata();

        #region Constructors

        /// <summary>
        /// Constructs AmazonLakeFormationClient with the credentials loaded from the application's
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
        public AmazonLakeFormationClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonLakeFormationConfig()) { }

        /// <summary>
        /// Constructs AmazonLakeFormationClient with the credentials loaded from the application's
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
        public AmazonLakeFormationClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonLakeFormationConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonLakeFormationClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonLakeFormationClient Configuration Object</param>
        public AmazonLakeFormationClient(AmazonLakeFormationConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonLakeFormationClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonLakeFormationClient(AWSCredentials credentials)
            : this(credentials, new AmazonLakeFormationConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLakeFormationClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLakeFormationClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonLakeFormationConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonLakeFormationClient with AWS Credentials and an
        /// AmazonLakeFormationClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonLakeFormationClient Configuration Object</param>
        public AmazonLakeFormationClient(AWSCredentials credentials, AmazonLakeFormationConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonLakeFormationClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonLakeFormationClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonLakeFormationConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLakeFormationClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLakeFormationClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonLakeFormationConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonLakeFormationClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonLakeFormationClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonLakeFormationClient Configuration Object</param>
        public AmazonLakeFormationClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonLakeFormationConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonLakeFormationClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonLakeFormationClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonLakeFormationConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLakeFormationClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLakeFormationClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonLakeFormationConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonLakeFormationClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonLakeFormationClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonLakeFormationClient Configuration Object</param>
        public AmazonLakeFormationClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonLakeFormationConfig clientConfig)
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


        #region  AddLFTagsToResource

        /// <summary>
        /// Attaches one or more tags to an existing resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddLFTagsToResource service method.</param>
        /// 
        /// <returns>The response from the AddLFTagsToResource service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/AddLFTagsToResource">REST API Reference for AddLFTagsToResource Operation</seealso>
        public virtual AddLFTagsToResourceResponse AddLFTagsToResource(AddLFTagsToResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddLFTagsToResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddLFTagsToResourceResponseUnmarshaller.Instance;

            return Invoke<AddLFTagsToResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddLFTagsToResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddLFTagsToResource operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddLFTagsToResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/AddLFTagsToResource">REST API Reference for AddLFTagsToResource Operation</seealso>
        public virtual IAsyncResult BeginAddLFTagsToResource(AddLFTagsToResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddLFTagsToResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddLFTagsToResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AddLFTagsToResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddLFTagsToResource.</param>
        /// 
        /// <returns>Returns a  AddLFTagsToResourceResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/AddLFTagsToResource">REST API Reference for AddLFTagsToResource Operation</seealso>
        public virtual AddLFTagsToResourceResponse EndAddLFTagsToResource(IAsyncResult asyncResult)
        {
            return EndInvoke<AddLFTagsToResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchGrantPermissions

        /// <summary>
        /// Batch operation to grant permissions to the principal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGrantPermissions service method.</param>
        /// 
        /// <returns>The response from the BatchGrantPermissions service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/BatchGrantPermissions">REST API Reference for BatchGrantPermissions Operation</seealso>
        public virtual BatchGrantPermissionsResponse BatchGrantPermissions(BatchGrantPermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGrantPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGrantPermissionsResponseUnmarshaller.Instance;

            return Invoke<BatchGrantPermissionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGrantPermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGrantPermissions operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGrantPermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/BatchGrantPermissions">REST API Reference for BatchGrantPermissions Operation</seealso>
        public virtual IAsyncResult BeginBatchGrantPermissions(BatchGrantPermissionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGrantPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGrantPermissionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGrantPermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGrantPermissions.</param>
        /// 
        /// <returns>Returns a  BatchGrantPermissionsResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/BatchGrantPermissions">REST API Reference for BatchGrantPermissions Operation</seealso>
        public virtual BatchGrantPermissionsResponse EndBatchGrantPermissions(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchGrantPermissionsResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchRevokePermissions

        /// <summary>
        /// Batch operation to revoke permissions from the principal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchRevokePermissions service method.</param>
        /// 
        /// <returns>The response from the BatchRevokePermissions service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/BatchRevokePermissions">REST API Reference for BatchRevokePermissions Operation</seealso>
        public virtual BatchRevokePermissionsResponse BatchRevokePermissions(BatchRevokePermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchRevokePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchRevokePermissionsResponseUnmarshaller.Instance;

            return Invoke<BatchRevokePermissionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchRevokePermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchRevokePermissions operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchRevokePermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/BatchRevokePermissions">REST API Reference for BatchRevokePermissions Operation</seealso>
        public virtual IAsyncResult BeginBatchRevokePermissions(BatchRevokePermissionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchRevokePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchRevokePermissionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchRevokePermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchRevokePermissions.</param>
        /// 
        /// <returns>Returns a  BatchRevokePermissionsResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/BatchRevokePermissions">REST API Reference for BatchRevokePermissions Operation</seealso>
        public virtual BatchRevokePermissionsResponse EndBatchRevokePermissions(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchRevokePermissionsResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateLFTag

        /// <summary>
        /// Creates a tag with the specified name and values.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLFTag service method.</param>
        /// 
        /// <returns>The response from the CreateLFTag service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/CreateLFTag">REST API Reference for CreateLFTag Operation</seealso>
        public virtual CreateLFTagResponse CreateLFTag(CreateLFTagRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLFTagRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLFTagResponseUnmarshaller.Instance;

            return Invoke<CreateLFTagResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLFTag operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLFTag operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLFTag
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/CreateLFTag">REST API Reference for CreateLFTag Operation</seealso>
        public virtual IAsyncResult BeginCreateLFTag(CreateLFTagRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLFTagRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLFTagResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLFTag operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLFTag.</param>
        /// 
        /// <returns>Returns a  CreateLFTagResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/CreateLFTag">REST API Reference for CreateLFTag Operation</seealso>
        public virtual CreateLFTagResponse EndCreateLFTag(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateLFTagResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteLFTag

        /// <summary>
        /// Deletes the specified tag key name. If the attribute key does not exist or the tag
        /// does not exist, then the operation will not do anything. If the attribute key exists,
        /// then the operation checks if any resources are tagged with this attribute key, if
        /// yes, the API throws a 400 Exception with the message "Delete not allowed" as the tag
        /// key is still attached with resources. You can consider untagging resources with this
        /// tag key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLFTag service method.</param>
        /// 
        /// <returns>The response from the DeleteLFTag service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/DeleteLFTag">REST API Reference for DeleteLFTag Operation</seealso>
        public virtual DeleteLFTagResponse DeleteLFTag(DeleteLFTagRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLFTagRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLFTagResponseUnmarshaller.Instance;

            return Invoke<DeleteLFTagResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLFTag operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLFTag operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLFTag
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/DeleteLFTag">REST API Reference for DeleteLFTag Operation</seealso>
        public virtual IAsyncResult BeginDeleteLFTag(DeleteLFTagRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLFTagRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLFTagResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLFTag operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLFTag.</param>
        /// 
        /// <returns>Returns a  DeleteLFTagResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/DeleteLFTag">REST API Reference for DeleteLFTag Operation</seealso>
        public virtual DeleteLFTagResponse EndDeleteLFTag(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteLFTagResponse>(asyncResult);
        }

        #endregion
        
        #region  DeregisterResource

        /// <summary>
        /// Deregisters the resource as managed by the Data Catalog.
        /// 
        ///  
        /// <para>
        /// When you deregister a path, Lake Formation removes the path from the inline policy
        /// attached to your service-linked role.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterResource service method.</param>
        /// 
        /// <returns>The response from the DeregisterResource service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/DeregisterResource">REST API Reference for DeregisterResource Operation</seealso>
        public virtual DeregisterResourceResponse DeregisterResource(DeregisterResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterResourceResponseUnmarshaller.Instance;

            return Invoke<DeregisterResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterResource operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/DeregisterResource">REST API Reference for DeregisterResource Operation</seealso>
        public virtual IAsyncResult BeginDeregisterResource(DeregisterResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterResource.</param>
        /// 
        /// <returns>Returns a  DeregisterResourceResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/DeregisterResource">REST API Reference for DeregisterResource Operation</seealso>
        public virtual DeregisterResourceResponse EndDeregisterResource(IAsyncResult asyncResult)
        {
            return EndInvoke<DeregisterResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeResource

        /// <summary>
        /// Retrieves the current data access role for the given resource registered in AWS Lake
        /// Formation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeResource service method.</param>
        /// 
        /// <returns>The response from the DescribeResource service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/DescribeResource">REST API Reference for DescribeResource Operation</seealso>
        public virtual DescribeResourceResponse DescribeResource(DescribeResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeResourceResponseUnmarshaller.Instance;

            return Invoke<DescribeResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeResource operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/DescribeResource">REST API Reference for DescribeResource Operation</seealso>
        public virtual IAsyncResult BeginDescribeResource(DescribeResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeResource.</param>
        /// 
        /// <returns>Returns a  DescribeResourceResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/DescribeResource">REST API Reference for DescribeResource Operation</seealso>
        public virtual DescribeResourceResponse EndDescribeResource(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDataLakeSettings

        /// <summary>
        /// Retrieves the list of the data lake administrators of a Lake Formation-managed data
        /// lake.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataLakeSettings service method.</param>
        /// 
        /// <returns>The response from the GetDataLakeSettings service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetDataLakeSettings">REST API Reference for GetDataLakeSettings Operation</seealso>
        public virtual GetDataLakeSettingsResponse GetDataLakeSettings(GetDataLakeSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataLakeSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataLakeSettingsResponseUnmarshaller.Instance;

            return Invoke<GetDataLakeSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDataLakeSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataLakeSettings operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDataLakeSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetDataLakeSettings">REST API Reference for GetDataLakeSettings Operation</seealso>
        public virtual IAsyncResult BeginGetDataLakeSettings(GetDataLakeSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataLakeSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataLakeSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDataLakeSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDataLakeSettings.</param>
        /// 
        /// <returns>Returns a  GetDataLakeSettingsResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetDataLakeSettings">REST API Reference for GetDataLakeSettings Operation</seealso>
        public virtual GetDataLakeSettingsResponse EndGetDataLakeSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDataLakeSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetEffectivePermissionsForPath

        /// <summary>
        /// Returns the Lake Formation permissions for a specified table or database resource
        /// located at a path in Amazon S3. <code>GetEffectivePermissionsForPath</code> will not
        /// return databases and tables if the catalog is encrypted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEffectivePermissionsForPath service method.</param>
        /// 
        /// <returns>The response from the GetEffectivePermissionsForPath service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetEffectivePermissionsForPath">REST API Reference for GetEffectivePermissionsForPath Operation</seealso>
        public virtual GetEffectivePermissionsForPathResponse GetEffectivePermissionsForPath(GetEffectivePermissionsForPathRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEffectivePermissionsForPathRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEffectivePermissionsForPathResponseUnmarshaller.Instance;

            return Invoke<GetEffectivePermissionsForPathResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetEffectivePermissionsForPath operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEffectivePermissionsForPath operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEffectivePermissionsForPath
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetEffectivePermissionsForPath">REST API Reference for GetEffectivePermissionsForPath Operation</seealso>
        public virtual IAsyncResult BeginGetEffectivePermissionsForPath(GetEffectivePermissionsForPathRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEffectivePermissionsForPathRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEffectivePermissionsForPathResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetEffectivePermissionsForPath operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEffectivePermissionsForPath.</param>
        /// 
        /// <returns>Returns a  GetEffectivePermissionsForPathResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetEffectivePermissionsForPath">REST API Reference for GetEffectivePermissionsForPath Operation</seealso>
        public virtual GetEffectivePermissionsForPathResponse EndGetEffectivePermissionsForPath(IAsyncResult asyncResult)
        {
            return EndInvoke<GetEffectivePermissionsForPathResponse>(asyncResult);
        }

        #endregion
        
        #region  GetLFTag

        /// <summary>
        /// Returns a tag definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLFTag service method.</param>
        /// 
        /// <returns>The response from the GetLFTag service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetLFTag">REST API Reference for GetLFTag Operation</seealso>
        public virtual GetLFTagResponse GetLFTag(GetLFTagRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLFTagRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLFTagResponseUnmarshaller.Instance;

            return Invoke<GetLFTagResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetLFTag operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLFTag operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLFTag
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetLFTag">REST API Reference for GetLFTag Operation</seealso>
        public virtual IAsyncResult BeginGetLFTag(GetLFTagRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLFTagRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLFTagResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetLFTag operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLFTag.</param>
        /// 
        /// <returns>Returns a  GetLFTagResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetLFTag">REST API Reference for GetLFTag Operation</seealso>
        public virtual GetLFTagResponse EndGetLFTag(IAsyncResult asyncResult)
        {
            return EndInvoke<GetLFTagResponse>(asyncResult);
        }

        #endregion
        
        #region  GetResourceLFTags

        /// <summary>
        /// Returns the tags applied to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceLFTags service method.</param>
        /// 
        /// <returns>The response from the GetResourceLFTags service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.GlueEncryptionException">
        /// An encryption operation failed.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetResourceLFTags">REST API Reference for GetResourceLFTags Operation</seealso>
        public virtual GetResourceLFTagsResponse GetResourceLFTags(GetResourceLFTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourceLFTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceLFTagsResponseUnmarshaller.Instance;

            return Invoke<GetResourceLFTagsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetResourceLFTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourceLFTags operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResourceLFTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetResourceLFTags">REST API Reference for GetResourceLFTags Operation</seealso>
        public virtual IAsyncResult BeginGetResourceLFTags(GetResourceLFTagsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourceLFTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceLFTagsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetResourceLFTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResourceLFTags.</param>
        /// 
        /// <returns>Returns a  GetResourceLFTagsResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetResourceLFTags">REST API Reference for GetResourceLFTags Operation</seealso>
        public virtual GetResourceLFTagsResponse EndGetResourceLFTags(IAsyncResult asyncResult)
        {
            return EndInvoke<GetResourceLFTagsResponse>(asyncResult);
        }

        #endregion
        
        #region  GrantPermissions

        /// <summary>
        /// Grants permissions to the principal to access metadata in the Data Catalog and data
        /// organized in underlying data storage such as Amazon S3.
        /// 
        ///  
        /// <para>
        /// For information about permissions, see <a href="https://docs-aws.amazon.com/lake-formation/latest/dg/security-data-access.html">Security
        /// and Access Control to Metadata and Data</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GrantPermissions service method.</param>
        /// 
        /// <returns>The response from the GrantPermissions service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GrantPermissions">REST API Reference for GrantPermissions Operation</seealso>
        public virtual GrantPermissionsResponse GrantPermissions(GrantPermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GrantPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GrantPermissionsResponseUnmarshaller.Instance;

            return Invoke<GrantPermissionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GrantPermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GrantPermissions operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGrantPermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GrantPermissions">REST API Reference for GrantPermissions Operation</seealso>
        public virtual IAsyncResult BeginGrantPermissions(GrantPermissionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GrantPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GrantPermissionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GrantPermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGrantPermissions.</param>
        /// 
        /// <returns>Returns a  GrantPermissionsResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GrantPermissions">REST API Reference for GrantPermissions Operation</seealso>
        public virtual GrantPermissionsResponse EndGrantPermissions(IAsyncResult asyncResult)
        {
            return EndInvoke<GrantPermissionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListLFTags

        /// <summary>
        /// Lists tags that the requester has permission to view.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLFTags service method.</param>
        /// 
        /// <returns>The response from the ListLFTags service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/ListLFTags">REST API Reference for ListLFTags Operation</seealso>
        public virtual ListLFTagsResponse ListLFTags(ListLFTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLFTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLFTagsResponseUnmarshaller.Instance;

            return Invoke<ListLFTagsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListLFTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLFTags operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLFTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/ListLFTags">REST API Reference for ListLFTags Operation</seealso>
        public virtual IAsyncResult BeginListLFTags(ListLFTagsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLFTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLFTagsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListLFTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLFTags.</param>
        /// 
        /// <returns>Returns a  ListLFTagsResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/ListLFTags">REST API Reference for ListLFTags Operation</seealso>
        public virtual ListLFTagsResponse EndListLFTags(IAsyncResult asyncResult)
        {
            return EndInvoke<ListLFTagsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPermissions

        /// <summary>
        /// Returns a list of the principal permissions on the resource, filtered by the permissions
        /// of the caller. For example, if you are granted an ALTER permission, you are able to
        /// see only the principal permissions for ALTER.
        /// 
        ///  
        /// <para>
        /// This operation returns only those permissions that have been explicitly granted.
        /// </para>
        ///  
        /// <para>
        /// For information about permissions, see <a href="https://docs-aws.amazon.com/lake-formation/latest/dg/security-data-access.html">Security
        /// and Access Control to Metadata and Data</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPermissions service method.</param>
        /// 
        /// <returns>The response from the ListPermissions service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/ListPermissions">REST API Reference for ListPermissions Operation</seealso>
        public virtual ListPermissionsResponse ListPermissions(ListPermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPermissionsResponseUnmarshaller.Instance;

            return Invoke<ListPermissionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPermissions operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/ListPermissions">REST API Reference for ListPermissions Operation</seealso>
        public virtual IAsyncResult BeginListPermissions(ListPermissionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPermissionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPermissions.</param>
        /// 
        /// <returns>Returns a  ListPermissionsResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/ListPermissions">REST API Reference for ListPermissions Operation</seealso>
        public virtual ListPermissionsResponse EndListPermissions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPermissionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListResources

        /// <summary>
        /// Lists the resources registered to be managed by the Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResources service method.</param>
        /// 
        /// <returns>The response from the ListResources service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/ListResources">REST API Reference for ListResources Operation</seealso>
        public virtual ListResourcesResponse ListResources(ListResourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourcesResponseUnmarshaller.Instance;

            return Invoke<ListResourcesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResources operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/ListResources">REST API Reference for ListResources Operation</seealso>
        public virtual IAsyncResult BeginListResources(ListResourcesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourcesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResources.</param>
        /// 
        /// <returns>Returns a  ListResourcesResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/ListResources">REST API Reference for ListResources Operation</seealso>
        public virtual ListResourcesResponse EndListResources(IAsyncResult asyncResult)
        {
            return EndInvoke<ListResourcesResponse>(asyncResult);
        }

        #endregion
        
        #region  PutDataLakeSettings

        /// <summary>
        /// Sets the list of data lake administrators who have admin privileges on all resources
        /// managed by Lake Formation. For more information on admin privileges, see <a href="https://docs.aws.amazon.com/lake-formation/latest/dg/lake-formation-permissions.html">Granting
        /// Lake Formation Permissions</a>.
        /// 
        ///  
        /// <para>
        /// This API replaces the current list of data lake admins with the new list being passed.
        /// To add an admin, fetch the current list and add the new admin to that list and pass
        /// that list in this API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDataLakeSettings service method.</param>
        /// 
        /// <returns>The response from the PutDataLakeSettings service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/PutDataLakeSettings">REST API Reference for PutDataLakeSettings Operation</seealso>
        public virtual PutDataLakeSettingsResponse PutDataLakeSettings(PutDataLakeSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutDataLakeSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDataLakeSettingsResponseUnmarshaller.Instance;

            return Invoke<PutDataLakeSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutDataLakeSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutDataLakeSettings operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutDataLakeSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/PutDataLakeSettings">REST API Reference for PutDataLakeSettings Operation</seealso>
        public virtual IAsyncResult BeginPutDataLakeSettings(PutDataLakeSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutDataLakeSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDataLakeSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutDataLakeSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutDataLakeSettings.</param>
        /// 
        /// <returns>Returns a  PutDataLakeSettingsResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/PutDataLakeSettings">REST API Reference for PutDataLakeSettings Operation</seealso>
        public virtual PutDataLakeSettingsResponse EndPutDataLakeSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<PutDataLakeSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  RegisterResource

        /// <summary>
        /// Registers the resource as managed by the Data Catalog.
        /// 
        ///  
        /// <para>
        /// To add or update data, Lake Formation needs read/write access to the chosen Amazon
        /// S3 path. Choose a role that you know has permission to do this, or choose the AWSServiceRoleForLakeFormationDataAccess
        /// service-linked role. When you register the first Amazon S3 path, the service-linked
        /// role and a new inline policy are created on your behalf. Lake Formation adds the first
        /// path to the inline policy and attaches it to the service-linked role. When you register
        /// subsequent paths, Lake Formation adds the path to the existing policy.
        /// </para>
        ///  
        /// <para>
        /// The following request registers a new location and gives AWS Lake Formation permission
        /// to use the service-linked role to access that location.
        /// </para>
        ///  
        /// <para>
        ///  <code>ResourceArn = arn:aws:s3:::my-bucket UseServiceLinkedRole = true</code> 
        /// </para>
        ///  
        /// <para>
        /// If <code>UseServiceLinkedRole</code> is not set to true, you must provide or set the
        /// <code>RoleArn</code>:
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:iam::12345:role/my-data-access-role</code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterResource service method.</param>
        /// 
        /// <returns>The response from the RegisterResource service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/RegisterResource">REST API Reference for RegisterResource Operation</seealso>
        public virtual RegisterResourceResponse RegisterResource(RegisterResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterResourceResponseUnmarshaller.Instance;

            return Invoke<RegisterResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterResource operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/RegisterResource">REST API Reference for RegisterResource Operation</seealso>
        public virtual IAsyncResult BeginRegisterResource(RegisterResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterResource.</param>
        /// 
        /// <returns>Returns a  RegisterResourceResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/RegisterResource">REST API Reference for RegisterResource Operation</seealso>
        public virtual RegisterResourceResponse EndRegisterResource(IAsyncResult asyncResult)
        {
            return EndInvoke<RegisterResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  RemoveLFTagsFromResource

        /// <summary>
        /// Removes a tag from the resource. Only database, table, or tableWithColumns resource
        /// are allowed. To tag columns, use the column inclusion list in <code>tableWithColumns</code>
        /// to specify column input.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveLFTagsFromResource service method.</param>
        /// 
        /// <returns>The response from the RemoveLFTagsFromResource service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.GlueEncryptionException">
        /// An encryption operation failed.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/RemoveLFTagsFromResource">REST API Reference for RemoveLFTagsFromResource Operation</seealso>
        public virtual RemoveLFTagsFromResourceResponse RemoveLFTagsFromResource(RemoveLFTagsFromResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveLFTagsFromResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveLFTagsFromResourceResponseUnmarshaller.Instance;

            return Invoke<RemoveLFTagsFromResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveLFTagsFromResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveLFTagsFromResource operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveLFTagsFromResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/RemoveLFTagsFromResource">REST API Reference for RemoveLFTagsFromResource Operation</seealso>
        public virtual IAsyncResult BeginRemoveLFTagsFromResource(RemoveLFTagsFromResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveLFTagsFromResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveLFTagsFromResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveLFTagsFromResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveLFTagsFromResource.</param>
        /// 
        /// <returns>Returns a  RemoveLFTagsFromResourceResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/RemoveLFTagsFromResource">REST API Reference for RemoveLFTagsFromResource Operation</seealso>
        public virtual RemoveLFTagsFromResourceResponse EndRemoveLFTagsFromResource(IAsyncResult asyncResult)
        {
            return EndInvoke<RemoveLFTagsFromResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  RevokePermissions

        /// <summary>
        /// Revokes permissions to the principal to access metadata in the Data Catalog and data
        /// organized in underlying data storage such as Amazon S3.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokePermissions service method.</param>
        /// 
        /// <returns>The response from the RevokePermissions service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/RevokePermissions">REST API Reference for RevokePermissions Operation</seealso>
        public virtual RevokePermissionsResponse RevokePermissions(RevokePermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RevokePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokePermissionsResponseUnmarshaller.Instance;

            return Invoke<RevokePermissionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RevokePermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokePermissions operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRevokePermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/RevokePermissions">REST API Reference for RevokePermissions Operation</seealso>
        public virtual IAsyncResult BeginRevokePermissions(RevokePermissionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RevokePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokePermissionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RevokePermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRevokePermissions.</param>
        /// 
        /// <returns>Returns a  RevokePermissionsResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/RevokePermissions">REST API Reference for RevokePermissions Operation</seealso>
        public virtual RevokePermissionsResponse EndRevokePermissions(IAsyncResult asyncResult)
        {
            return EndInvoke<RevokePermissionsResponse>(asyncResult);
        }

        #endregion
        
        #region  SearchDatabasesByLFTags

        /// <summary>
        /// This operation allows a search on <code>DATABASE</code> resources by <code>TagCondition</code>.
        /// This operation is used by admins who want to grant user permissions on certain <code>TagConditions</code>.
        /// Before making a grant, the admin can use <code>SearchDatabasesByTags</code> to find
        /// all resources where the given <code>TagConditions</code> are valid to verify whether
        /// the returned resources can be shared.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchDatabasesByLFTags service method.</param>
        /// 
        /// <returns>The response from the SearchDatabasesByLFTags service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.GlueEncryptionException">
        /// An encryption operation failed.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/SearchDatabasesByLFTags">REST API Reference for SearchDatabasesByLFTags Operation</seealso>
        public virtual SearchDatabasesByLFTagsResponse SearchDatabasesByLFTags(SearchDatabasesByLFTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchDatabasesByLFTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchDatabasesByLFTagsResponseUnmarshaller.Instance;

            return Invoke<SearchDatabasesByLFTagsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SearchDatabasesByLFTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchDatabasesByLFTags operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchDatabasesByLFTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/SearchDatabasesByLFTags">REST API Reference for SearchDatabasesByLFTags Operation</seealso>
        public virtual IAsyncResult BeginSearchDatabasesByLFTags(SearchDatabasesByLFTagsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchDatabasesByLFTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchDatabasesByLFTagsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SearchDatabasesByLFTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchDatabasesByLFTags.</param>
        /// 
        /// <returns>Returns a  SearchDatabasesByLFTagsResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/SearchDatabasesByLFTags">REST API Reference for SearchDatabasesByLFTags Operation</seealso>
        public virtual SearchDatabasesByLFTagsResponse EndSearchDatabasesByLFTags(IAsyncResult asyncResult)
        {
            return EndInvoke<SearchDatabasesByLFTagsResponse>(asyncResult);
        }

        #endregion
        
        #region  SearchTablesByLFTags

        /// <summary>
        /// This operation allows a search on <code>TABLE</code> resources by <code>LFTag</code>s.
        /// This will be used by admins who want to grant user permissions on certain LFTags.
        /// Before making a grant, the admin can use <code>SearchTablesByLFTags</code> to find
        /// all resources where the given <code>LFTag</code>s are valid to verify whether the
        /// returned resources can be shared.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchTablesByLFTags service method.</param>
        /// 
        /// <returns>The response from the SearchTablesByLFTags service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.GlueEncryptionException">
        /// An encryption operation failed.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/SearchTablesByLFTags">REST API Reference for SearchTablesByLFTags Operation</seealso>
        public virtual SearchTablesByLFTagsResponse SearchTablesByLFTags(SearchTablesByLFTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchTablesByLFTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchTablesByLFTagsResponseUnmarshaller.Instance;

            return Invoke<SearchTablesByLFTagsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SearchTablesByLFTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchTablesByLFTags operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchTablesByLFTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/SearchTablesByLFTags">REST API Reference for SearchTablesByLFTags Operation</seealso>
        public virtual IAsyncResult BeginSearchTablesByLFTags(SearchTablesByLFTagsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchTablesByLFTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchTablesByLFTagsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SearchTablesByLFTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchTablesByLFTags.</param>
        /// 
        /// <returns>Returns a  SearchTablesByLFTagsResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/SearchTablesByLFTags">REST API Reference for SearchTablesByLFTags Operation</seealso>
        public virtual SearchTablesByLFTagsResponse EndSearchTablesByLFTags(IAsyncResult asyncResult)
        {
            return EndInvoke<SearchTablesByLFTagsResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateLFTag

        /// <summary>
        /// Updates the list of possible values for the specified tag key. If the tag does not
        /// exist, the operation throws an EntityNotFoundException. The values in the delete key
        /// values will be deleted from list of possible values. If any value in the delete key
        /// values is attached to a resource, then API errors out with a 400 Exception - "Update
        /// not allowed". Untag the attribute before deleting the tag key's value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLFTag service method.</param>
        /// 
        /// <returns>The response from the UpdateLFTag service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/UpdateLFTag">REST API Reference for UpdateLFTag Operation</seealso>
        public virtual UpdateLFTagResponse UpdateLFTag(UpdateLFTagRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLFTagRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLFTagResponseUnmarshaller.Instance;

            return Invoke<UpdateLFTagResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLFTag operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLFTag operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLFTag
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/UpdateLFTag">REST API Reference for UpdateLFTag Operation</seealso>
        public virtual IAsyncResult BeginUpdateLFTag(UpdateLFTagRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLFTagRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLFTagResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLFTag operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLFTag.</param>
        /// 
        /// <returns>Returns a  UpdateLFTagResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/UpdateLFTag">REST API Reference for UpdateLFTag Operation</seealso>
        public virtual UpdateLFTagResponse EndUpdateLFTag(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateLFTagResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateResource

        /// <summary>
        /// Updates the data access role used for vending access to the given (registered) resource
        /// in AWS Lake Formation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResource service method.</param>
        /// 
        /// <returns>The response from the UpdateResource service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/UpdateResource">REST API Reference for UpdateResource Operation</seealso>
        public virtual UpdateResourceResponse UpdateResource(UpdateResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResourceResponseUnmarshaller.Instance;

            return Invoke<UpdateResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateResource operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/UpdateResource">REST API Reference for UpdateResource Operation</seealso>
        public virtual IAsyncResult BeginUpdateResource(UpdateResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateResource.</param>
        /// 
        /// <returns>Returns a  UpdateResourceResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/UpdateResource">REST API Reference for UpdateResource Operation</seealso>
        public virtual UpdateResourceResponse EndUpdateResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateResourceResponse>(asyncResult);
        }

        #endregion
        
    }
}