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

#pragma warning disable CS1570
namespace Amazon.LakeFormation
{
    /// <summary>
    /// <para>Implementation for accessing LakeFormation</para>
    ///
    /// Lake Formation 
    /// <para>
    /// Defines the public endpoint for the Lake Formation service.
    /// </para>
    /// </summary>
    public partial class AmazonLakeFormationClient : AmazonServiceClient, IAmazonLakeFormation
    {
        private static IServiceMetadata serviceMetadata = new AmazonLakeFormationMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private ILakeFormationPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ILakeFormationPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new LakeFormationPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
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
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
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
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonLakeFormationEndpointResolver());
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
        /// Attaches one or more LF-tags to an existing resource.
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
        /// A specified entity does not exist.
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
        
        #region  AssumeDecoratedRoleWithSAML

        /// <summary>
        /// Allows a caller to assume an IAM role decorated as the SAML user specified in the
        /// SAML assertion included in the request. This decoration allows Lake Formation to enforce
        /// access policies against the SAML users and groups. This API operation requires SAML
        /// federation setup in the caller’s account as it can only be called with valid SAML
        /// assertions. Lake Formation does not scope down the permission of the assumed role.
        /// All permissions attached to the role via the SAML federation setup will be included
        /// in the role session. 
        /// 
        ///  
        /// <para>
        ///  This decorated role is expected to access data in Amazon S3 by getting temporary
        /// access from Lake Formation which is authorized via the virtual API <c>GetDataAccess</c>.
        /// Therefore, all SAML roles that can be assumed via <c>AssumeDecoratedRoleWithSAML</c>
        /// must at a minimum include <c>lakeformation:GetDataAccess</c> in their role policies.
        /// A typical IAM policy attached to such a role would look as follows: 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssumeDecoratedRoleWithSAML service method.</param>
        /// 
        /// <returns>The response from the AssumeDecoratedRoleWithSAML service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/AssumeDecoratedRoleWithSAML">REST API Reference for AssumeDecoratedRoleWithSAML Operation</seealso>
        public virtual AssumeDecoratedRoleWithSAMLResponse AssumeDecoratedRoleWithSAML(AssumeDecoratedRoleWithSAMLRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssumeDecoratedRoleWithSAMLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssumeDecoratedRoleWithSAMLResponseUnmarshaller.Instance;

            return Invoke<AssumeDecoratedRoleWithSAMLResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssumeDecoratedRoleWithSAML operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssumeDecoratedRoleWithSAML operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssumeDecoratedRoleWithSAML
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/AssumeDecoratedRoleWithSAML">REST API Reference for AssumeDecoratedRoleWithSAML Operation</seealso>
        public virtual IAsyncResult BeginAssumeDecoratedRoleWithSAML(AssumeDecoratedRoleWithSAMLRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssumeDecoratedRoleWithSAMLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssumeDecoratedRoleWithSAMLResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssumeDecoratedRoleWithSAML operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssumeDecoratedRoleWithSAML.</param>
        /// 
        /// <returns>Returns a  AssumeDecoratedRoleWithSAMLResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/AssumeDecoratedRoleWithSAML">REST API Reference for AssumeDecoratedRoleWithSAML Operation</seealso>
        public virtual AssumeDecoratedRoleWithSAMLResponse EndAssumeDecoratedRoleWithSAML(IAsyncResult asyncResult)
        {
            return EndInvoke<AssumeDecoratedRoleWithSAMLResponse>(asyncResult);
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
        
        #region  CancelTransaction

        /// <summary>
        /// Attempts to cancel the specified transaction. Returns an exception if the transaction
        /// was previously committed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelTransaction service method.</param>
        /// 
        /// <returns>The response from the CancelTransaction service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
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
        /// <exception cref="Amazon.LakeFormation.Model.TransactionCommitInProgressException">
        /// Contains details about an error related to a transaction commit that was in progress.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.TransactionCommittedException">
        /// Contains details about an error where the specified transaction has already been committed
        /// and cannot be used for <c>UpdateTableObjects</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/CancelTransaction">REST API Reference for CancelTransaction Operation</seealso>
        public virtual CancelTransactionResponse CancelTransaction(CancelTransactionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelTransactionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelTransactionResponseUnmarshaller.Instance;

            return Invoke<CancelTransactionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelTransaction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelTransaction operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelTransaction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/CancelTransaction">REST API Reference for CancelTransaction Operation</seealso>
        public virtual IAsyncResult BeginCancelTransaction(CancelTransactionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelTransactionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelTransactionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelTransaction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelTransaction.</param>
        /// 
        /// <returns>Returns a  CancelTransactionResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/CancelTransaction">REST API Reference for CancelTransaction Operation</seealso>
        public virtual CancelTransactionResponse EndCancelTransaction(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelTransactionResponse>(asyncResult);
        }

        #endregion
        
        #region  CommitTransaction

        /// <summary>
        /// Attempts to commit the specified transaction. Returns an exception if the transaction
        /// was previously aborted. This API action is idempotent if called multiple times for
        /// the same transaction.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CommitTransaction service method.</param>
        /// 
        /// <returns>The response from the CommitTransaction service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
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
        /// <exception cref="Amazon.LakeFormation.Model.TransactionCanceledException">
        /// Contains details about an error related to a transaction that was cancelled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/CommitTransaction">REST API Reference for CommitTransaction Operation</seealso>
        public virtual CommitTransactionResponse CommitTransaction(CommitTransactionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CommitTransactionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CommitTransactionResponseUnmarshaller.Instance;

            return Invoke<CommitTransactionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CommitTransaction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CommitTransaction operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCommitTransaction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/CommitTransaction">REST API Reference for CommitTransaction Operation</seealso>
        public virtual IAsyncResult BeginCommitTransaction(CommitTransactionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CommitTransactionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CommitTransactionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CommitTransaction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCommitTransaction.</param>
        /// 
        /// <returns>Returns a  CommitTransactionResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/CommitTransaction">REST API Reference for CommitTransaction Operation</seealso>
        public virtual CommitTransactionResponse EndCommitTransaction(IAsyncResult asyncResult)
        {
            return EndInvoke<CommitTransactionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDataCellsFilter

        /// <summary>
        /// Creates a data cell filter to allow one to grant access to certain columns on certain
        /// rows.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataCellsFilter service method.</param>
        /// 
        /// <returns>The response from the CreateDataCellsFilter service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/CreateDataCellsFilter">REST API Reference for CreateDataCellsFilter Operation</seealso>
        public virtual CreateDataCellsFilterResponse CreateDataCellsFilter(CreateDataCellsFilterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataCellsFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataCellsFilterResponseUnmarshaller.Instance;

            return Invoke<CreateDataCellsFilterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataCellsFilter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataCellsFilter operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDataCellsFilter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/CreateDataCellsFilter">REST API Reference for CreateDataCellsFilter Operation</seealso>
        public virtual IAsyncResult BeginCreateDataCellsFilter(CreateDataCellsFilterRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataCellsFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataCellsFilterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataCellsFilter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataCellsFilter.</param>
        /// 
        /// <returns>Returns a  CreateDataCellsFilterResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/CreateDataCellsFilter">REST API Reference for CreateDataCellsFilter Operation</seealso>
        public virtual CreateDataCellsFilterResponse EndCreateDataCellsFilter(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDataCellsFilterResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateLakeFormationIdentityCenterConfiguration

        /// <summary>
        /// Creates an IAM Identity Center connection with Lake Formation to allow IAM Identity
        /// Center users and groups to access Data Catalog resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLakeFormationIdentityCenterConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateLakeFormationIdentityCenterConfiguration service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/CreateLakeFormationIdentityCenterConfiguration">REST API Reference for CreateLakeFormationIdentityCenterConfiguration Operation</seealso>
        public virtual CreateLakeFormationIdentityCenterConfigurationResponse CreateLakeFormationIdentityCenterConfiguration(CreateLakeFormationIdentityCenterConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLakeFormationIdentityCenterConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLakeFormationIdentityCenterConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateLakeFormationIdentityCenterConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLakeFormationIdentityCenterConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLakeFormationIdentityCenterConfiguration operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLakeFormationIdentityCenterConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/CreateLakeFormationIdentityCenterConfiguration">REST API Reference for CreateLakeFormationIdentityCenterConfiguration Operation</seealso>
        public virtual IAsyncResult BeginCreateLakeFormationIdentityCenterConfiguration(CreateLakeFormationIdentityCenterConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLakeFormationIdentityCenterConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLakeFormationIdentityCenterConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLakeFormationIdentityCenterConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLakeFormationIdentityCenterConfiguration.</param>
        /// 
        /// <returns>Returns a  CreateLakeFormationIdentityCenterConfigurationResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/CreateLakeFormationIdentityCenterConfiguration">REST API Reference for CreateLakeFormationIdentityCenterConfiguration Operation</seealso>
        public virtual CreateLakeFormationIdentityCenterConfigurationResponse EndCreateLakeFormationIdentityCenterConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateLakeFormationIdentityCenterConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateLakeFormationOptIn

        /// <summary>
        /// Enforce Lake Formation permissions for the given databases, tables, and principals.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLakeFormationOptIn service method.</param>
        /// 
        /// <returns>The response from the CreateLakeFormationOptIn service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/CreateLakeFormationOptIn">REST API Reference for CreateLakeFormationOptIn Operation</seealso>
        public virtual CreateLakeFormationOptInResponse CreateLakeFormationOptIn(CreateLakeFormationOptInRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLakeFormationOptInRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLakeFormationOptInResponseUnmarshaller.Instance;

            return Invoke<CreateLakeFormationOptInResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLakeFormationOptIn operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLakeFormationOptIn operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLakeFormationOptIn
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/CreateLakeFormationOptIn">REST API Reference for CreateLakeFormationOptIn Operation</seealso>
        public virtual IAsyncResult BeginCreateLakeFormationOptIn(CreateLakeFormationOptInRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLakeFormationOptInRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLakeFormationOptInResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLakeFormationOptIn operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLakeFormationOptIn.</param>
        /// 
        /// <returns>Returns a  CreateLakeFormationOptInResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/CreateLakeFormationOptIn">REST API Reference for CreateLakeFormationOptIn Operation</seealso>
        public virtual CreateLakeFormationOptInResponse EndCreateLakeFormationOptIn(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateLakeFormationOptInResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateLFTag

        /// <summary>
        /// Creates an LF-tag with the specified name and values.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLFTag service method.</param>
        /// 
        /// <returns>The response from the CreateLFTag service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
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
        
        #region  CreateLFTagExpression

        /// <summary>
        /// Creates a new LF-Tag expression with the provided name, description, catalog ID, and
        /// expression body. This call fails if a LF-Tag expression with the same name already
        /// exists in the caller’s account or if the underlying LF-Tags don't exist. To call this
        /// API operation, caller needs the following Lake Formation permissions:
        /// 
        ///  
        /// <para>
        ///  <c>CREATE_LF_TAG_EXPRESSION</c> on the root catalog resource.
        /// </para>
        ///  
        /// <para>
        ///  <c>GRANT_WITH_LF_TAG_EXPRESSION</c> on all underlying LF-Tag key:value pairs included
        /// in the expression. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLFTagExpression service method.</param>
        /// 
        /// <returns>The response from the CreateLFTagExpression service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/CreateLFTagExpression">REST API Reference for CreateLFTagExpression Operation</seealso>
        public virtual CreateLFTagExpressionResponse CreateLFTagExpression(CreateLFTagExpressionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLFTagExpressionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLFTagExpressionResponseUnmarshaller.Instance;

            return Invoke<CreateLFTagExpressionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLFTagExpression operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLFTagExpression operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLFTagExpression
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/CreateLFTagExpression">REST API Reference for CreateLFTagExpression Operation</seealso>
        public virtual IAsyncResult BeginCreateLFTagExpression(CreateLFTagExpressionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLFTagExpressionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLFTagExpressionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLFTagExpression operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLFTagExpression.</param>
        /// 
        /// <returns>Returns a  CreateLFTagExpressionResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/CreateLFTagExpression">REST API Reference for CreateLFTagExpression Operation</seealso>
        public virtual CreateLFTagExpressionResponse EndCreateLFTagExpression(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateLFTagExpressionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDataCellsFilter

        /// <summary>
        /// Deletes a data cell filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataCellsFilter service method.</param>
        /// 
        /// <returns>The response from the DeleteDataCellsFilter service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/DeleteDataCellsFilter">REST API Reference for DeleteDataCellsFilter Operation</seealso>
        public virtual DeleteDataCellsFilterResponse DeleteDataCellsFilter(DeleteDataCellsFilterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDataCellsFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataCellsFilterResponseUnmarshaller.Instance;

            return Invoke<DeleteDataCellsFilterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDataCellsFilter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataCellsFilter operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDataCellsFilter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/DeleteDataCellsFilter">REST API Reference for DeleteDataCellsFilter Operation</seealso>
        public virtual IAsyncResult BeginDeleteDataCellsFilter(DeleteDataCellsFilterRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDataCellsFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataCellsFilterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDataCellsFilter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDataCellsFilter.</param>
        /// 
        /// <returns>Returns a  DeleteDataCellsFilterResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/DeleteDataCellsFilter">REST API Reference for DeleteDataCellsFilter Operation</seealso>
        public virtual DeleteDataCellsFilterResponse EndDeleteDataCellsFilter(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDataCellsFilterResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteLakeFormationIdentityCenterConfiguration

        /// <summary>
        /// Deletes an IAM Identity Center connection with Lake Formation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLakeFormationIdentityCenterConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteLakeFormationIdentityCenterConfiguration service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/DeleteLakeFormationIdentityCenterConfiguration">REST API Reference for DeleteLakeFormationIdentityCenterConfiguration Operation</seealso>
        public virtual DeleteLakeFormationIdentityCenterConfigurationResponse DeleteLakeFormationIdentityCenterConfiguration(DeleteLakeFormationIdentityCenterConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLakeFormationIdentityCenterConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLakeFormationIdentityCenterConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteLakeFormationIdentityCenterConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLakeFormationIdentityCenterConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLakeFormationIdentityCenterConfiguration operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLakeFormationIdentityCenterConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/DeleteLakeFormationIdentityCenterConfiguration">REST API Reference for DeleteLakeFormationIdentityCenterConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDeleteLakeFormationIdentityCenterConfiguration(DeleteLakeFormationIdentityCenterConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLakeFormationIdentityCenterConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLakeFormationIdentityCenterConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLakeFormationIdentityCenterConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLakeFormationIdentityCenterConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteLakeFormationIdentityCenterConfigurationResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/DeleteLakeFormationIdentityCenterConfiguration">REST API Reference for DeleteLakeFormationIdentityCenterConfiguration Operation</seealso>
        public virtual DeleteLakeFormationIdentityCenterConfigurationResponse EndDeleteLakeFormationIdentityCenterConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteLakeFormationIdentityCenterConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteLakeFormationOptIn

        /// <summary>
        /// Remove the Lake Formation permissions enforcement of the given databases, tables,
        /// and principals.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLakeFormationOptIn service method.</param>
        /// 
        /// <returns>The response from the DeleteLakeFormationOptIn service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/DeleteLakeFormationOptIn">REST API Reference for DeleteLakeFormationOptIn Operation</seealso>
        public virtual DeleteLakeFormationOptInResponse DeleteLakeFormationOptIn(DeleteLakeFormationOptInRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLakeFormationOptInRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLakeFormationOptInResponseUnmarshaller.Instance;

            return Invoke<DeleteLakeFormationOptInResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLakeFormationOptIn operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLakeFormationOptIn operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLakeFormationOptIn
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/DeleteLakeFormationOptIn">REST API Reference for DeleteLakeFormationOptIn Operation</seealso>
        public virtual IAsyncResult BeginDeleteLakeFormationOptIn(DeleteLakeFormationOptInRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLakeFormationOptInRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLakeFormationOptInResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLakeFormationOptIn operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLakeFormationOptIn.</param>
        /// 
        /// <returns>Returns a  DeleteLakeFormationOptInResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/DeleteLakeFormationOptIn">REST API Reference for DeleteLakeFormationOptIn Operation</seealso>
        public virtual DeleteLakeFormationOptInResponse EndDeleteLakeFormationOptIn(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteLakeFormationOptInResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteLFTag

        /// <summary>
        /// Deletes the specified LF-tag given a key name. If the input parameter tag key was
        /// not found, then the operation will throw an exception. When you delete an LF-tag,
        /// the <c>LFTagPolicy</c> attached to the LF-tag becomes invalid. If the deleted LF-tag
        /// was still assigned to any resource, the tag policy attach to the deleted LF-tag will
        /// no longer be applied to the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLFTag service method.</param>
        /// 
        /// <returns>The response from the DeleteLFTag service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
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
        
        #region  DeleteLFTagExpression

        /// <summary>
        /// Deletes the LF-Tag expression. The caller must be a data lake admin or have <c>DROP</c>
        /// permissions on the LF-Tag expression. Deleting a LF-Tag expression will also delete
        /// all <c>LFTagPolicy</c> permissions referencing the LF-Tag expression.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLFTagExpression service method.</param>
        /// 
        /// <returns>The response from the DeleteLFTagExpression service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/DeleteLFTagExpression">REST API Reference for DeleteLFTagExpression Operation</seealso>
        public virtual DeleteLFTagExpressionResponse DeleteLFTagExpression(DeleteLFTagExpressionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLFTagExpressionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLFTagExpressionResponseUnmarshaller.Instance;

            return Invoke<DeleteLFTagExpressionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLFTagExpression operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLFTagExpression operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLFTagExpression
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/DeleteLFTagExpression">REST API Reference for DeleteLFTagExpression Operation</seealso>
        public virtual IAsyncResult BeginDeleteLFTagExpression(DeleteLFTagExpressionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLFTagExpressionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLFTagExpressionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLFTagExpression operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLFTagExpression.</param>
        /// 
        /// <returns>Returns a  DeleteLFTagExpressionResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/DeleteLFTagExpression">REST API Reference for DeleteLFTagExpression Operation</seealso>
        public virtual DeleteLFTagExpressionResponse EndDeleteLFTagExpression(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteLFTagExpressionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteObjectsOnCancel

        /// <summary>
        /// For a specific governed table, provides a list of Amazon S3 objects that will be written
        /// during the current transaction and that can be automatically deleted if the transaction
        /// is canceled. Without this call, no Amazon S3 objects are automatically deleted when
        /// a transaction cancels. 
        /// 
        ///  
        /// <para>
        ///  The Glue ETL library function <c>write_dynamic_frame.from_catalog()</c> includes
        /// an option to automatically call <c>DeleteObjectsOnCancel</c> before writes. For more
        /// information, see <a href="https://docs.aws.amazon.com/lake-formation/latest/dg/transactions-data-operations.html#rolling-back-writes">Rolling
        /// Back Amazon S3 Writes</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteObjectsOnCancel service method.</param>
        /// 
        /// <returns>The response from the DeleteObjectsOnCancel service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
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
        /// <exception cref="Amazon.LakeFormation.Model.ResourceNotReadyException">
        /// Contains details about an error related to a resource which is not ready for a transaction.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.TransactionCanceledException">
        /// Contains details about an error related to a transaction that was cancelled.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.TransactionCommittedException">
        /// Contains details about an error where the specified transaction has already been committed
        /// and cannot be used for <c>UpdateTableObjects</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/DeleteObjectsOnCancel">REST API Reference for DeleteObjectsOnCancel Operation</seealso>
        public virtual DeleteObjectsOnCancelResponse DeleteObjectsOnCancel(DeleteObjectsOnCancelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteObjectsOnCancelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteObjectsOnCancelResponseUnmarshaller.Instance;

            return Invoke<DeleteObjectsOnCancelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteObjectsOnCancel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteObjectsOnCancel operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteObjectsOnCancel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/DeleteObjectsOnCancel">REST API Reference for DeleteObjectsOnCancel Operation</seealso>
        public virtual IAsyncResult BeginDeleteObjectsOnCancel(DeleteObjectsOnCancelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteObjectsOnCancelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteObjectsOnCancelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteObjectsOnCancel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteObjectsOnCancel.</param>
        /// 
        /// <returns>Returns a  DeleteObjectsOnCancelResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/DeleteObjectsOnCancel">REST API Reference for DeleteObjectsOnCancel Operation</seealso>
        public virtual DeleteObjectsOnCancelResponse EndDeleteObjectsOnCancel(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteObjectsOnCancelResponse>(asyncResult);
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
        /// A specified entity does not exist.
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
        
        #region  DescribeLakeFormationIdentityCenterConfiguration

        /// <summary>
        /// Retrieves the instance ARN and application ARN for the connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLakeFormationIdentityCenterConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeLakeFormationIdentityCenterConfiguration service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/DescribeLakeFormationIdentityCenterConfiguration">REST API Reference for DescribeLakeFormationIdentityCenterConfiguration Operation</seealso>
        public virtual DescribeLakeFormationIdentityCenterConfigurationResponse DescribeLakeFormationIdentityCenterConfiguration(DescribeLakeFormationIdentityCenterConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLakeFormationIdentityCenterConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLakeFormationIdentityCenterConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeLakeFormationIdentityCenterConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLakeFormationIdentityCenterConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLakeFormationIdentityCenterConfiguration operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLakeFormationIdentityCenterConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/DescribeLakeFormationIdentityCenterConfiguration">REST API Reference for DescribeLakeFormationIdentityCenterConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDescribeLakeFormationIdentityCenterConfiguration(DescribeLakeFormationIdentityCenterConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLakeFormationIdentityCenterConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLakeFormationIdentityCenterConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLakeFormationIdentityCenterConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLakeFormationIdentityCenterConfiguration.</param>
        /// 
        /// <returns>Returns a  DescribeLakeFormationIdentityCenterConfigurationResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/DescribeLakeFormationIdentityCenterConfiguration">REST API Reference for DescribeLakeFormationIdentityCenterConfiguration Operation</seealso>
        public virtual DescribeLakeFormationIdentityCenterConfigurationResponse EndDescribeLakeFormationIdentityCenterConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeLakeFormationIdentityCenterConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeResource

        /// <summary>
        /// Retrieves the current data access role for the given resource registered in Lake Formation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeResource service method.</param>
        /// 
        /// <returns>The response from the DescribeResource service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
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
        
        #region  DescribeTransaction

        /// <summary>
        /// Returns the details of a single transaction.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTransaction service method.</param>
        /// 
        /// <returns>The response from the DescribeTransaction service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/DescribeTransaction">REST API Reference for DescribeTransaction Operation</seealso>
        public virtual DescribeTransactionResponse DescribeTransaction(DescribeTransactionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTransactionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTransactionResponseUnmarshaller.Instance;

            return Invoke<DescribeTransactionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTransaction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTransaction operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTransaction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/DescribeTransaction">REST API Reference for DescribeTransaction Operation</seealso>
        public virtual IAsyncResult BeginDescribeTransaction(DescribeTransactionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTransactionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTransactionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTransaction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTransaction.</param>
        /// 
        /// <returns>Returns a  DescribeTransactionResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/DescribeTransaction">REST API Reference for DescribeTransaction Operation</seealso>
        public virtual DescribeTransactionResponse EndDescribeTransaction(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeTransactionResponse>(asyncResult);
        }

        #endregion
        
        #region  ExtendTransaction

        /// <summary>
        /// Indicates to the service that the specified transaction is still active and should
        /// not be treated as idle and aborted.
        /// 
        ///  
        /// <para>
        /// Write transactions that remain idle for a long period are automatically aborted unless
        /// explicitly extended.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExtendTransaction service method.</param>
        /// 
        /// <returns>The response from the ExtendTransaction service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
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
        /// <exception cref="Amazon.LakeFormation.Model.TransactionCanceledException">
        /// Contains details about an error related to a transaction that was cancelled.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.TransactionCommitInProgressException">
        /// Contains details about an error related to a transaction commit that was in progress.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.TransactionCommittedException">
        /// Contains details about an error where the specified transaction has already been committed
        /// and cannot be used for <c>UpdateTableObjects</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/ExtendTransaction">REST API Reference for ExtendTransaction Operation</seealso>
        public virtual ExtendTransactionResponse ExtendTransaction(ExtendTransactionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExtendTransactionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExtendTransactionResponseUnmarshaller.Instance;

            return Invoke<ExtendTransactionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ExtendTransaction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExtendTransaction operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExtendTransaction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/ExtendTransaction">REST API Reference for ExtendTransaction Operation</seealso>
        public virtual IAsyncResult BeginExtendTransaction(ExtendTransactionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExtendTransactionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExtendTransactionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ExtendTransaction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExtendTransaction.</param>
        /// 
        /// <returns>Returns a  ExtendTransactionResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/ExtendTransaction">REST API Reference for ExtendTransaction Operation</seealso>
        public virtual ExtendTransactionResponse EndExtendTransaction(IAsyncResult asyncResult)
        {
            return EndInvoke<ExtendTransactionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDataCellsFilter

        /// <summary>
        /// Returns a data cells filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataCellsFilter service method.</param>
        /// 
        /// <returns>The response from the GetDataCellsFilter service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetDataCellsFilter">REST API Reference for GetDataCellsFilter Operation</seealso>
        public virtual GetDataCellsFilterResponse GetDataCellsFilter(GetDataCellsFilterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataCellsFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataCellsFilterResponseUnmarshaller.Instance;

            return Invoke<GetDataCellsFilterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDataCellsFilter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataCellsFilter operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDataCellsFilter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetDataCellsFilter">REST API Reference for GetDataCellsFilter Operation</seealso>
        public virtual IAsyncResult BeginGetDataCellsFilter(GetDataCellsFilterRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataCellsFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataCellsFilterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDataCellsFilter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDataCellsFilter.</param>
        /// 
        /// <returns>Returns a  GetDataCellsFilterResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetDataCellsFilter">REST API Reference for GetDataCellsFilter Operation</seealso>
        public virtual GetDataCellsFilterResponse EndGetDataCellsFilter(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDataCellsFilterResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDataLakePrincipal

        /// <summary>
        /// Returns the identity of the invoking principal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataLakePrincipal service method.</param>
        /// 
        /// <returns>The response from the GetDataLakePrincipal service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetDataLakePrincipal">REST API Reference for GetDataLakePrincipal Operation</seealso>
        public virtual GetDataLakePrincipalResponse GetDataLakePrincipal(GetDataLakePrincipalRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataLakePrincipalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataLakePrincipalResponseUnmarshaller.Instance;

            return Invoke<GetDataLakePrincipalResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDataLakePrincipal operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataLakePrincipal operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDataLakePrincipal
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetDataLakePrincipal">REST API Reference for GetDataLakePrincipal Operation</seealso>
        public virtual IAsyncResult BeginGetDataLakePrincipal(GetDataLakePrincipalRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataLakePrincipalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataLakePrincipalResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDataLakePrincipal operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDataLakePrincipal.</param>
        /// 
        /// <returns>Returns a  GetDataLakePrincipalResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetDataLakePrincipal">REST API Reference for GetDataLakePrincipal Operation</seealso>
        public virtual GetDataLakePrincipalResponse EndGetDataLakePrincipal(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDataLakePrincipalResponse>(asyncResult);
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
        /// A specified entity does not exist.
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
        /// located at a path in Amazon S3. <c>GetEffectivePermissionsForPath</c> will not return
        /// databases and tables if the catalog is encrypted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEffectivePermissionsForPath service method.</param>
        /// 
        /// <returns>The response from the GetEffectivePermissionsForPath service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
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
        /// Returns an LF-tag definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLFTag service method.</param>
        /// 
        /// <returns>The response from the GetLFTag service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
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
        
        #region  GetLFTagExpression

        /// <summary>
        /// Returns the details about the LF-Tag expression. The caller must be a data lake admin
        /// or must have <c>DESCRIBE</c> permission on the LF-Tag expression resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLFTagExpression service method.</param>
        /// 
        /// <returns>The response from the GetLFTagExpression service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetLFTagExpression">REST API Reference for GetLFTagExpression Operation</seealso>
        public virtual GetLFTagExpressionResponse GetLFTagExpression(GetLFTagExpressionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLFTagExpressionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLFTagExpressionResponseUnmarshaller.Instance;

            return Invoke<GetLFTagExpressionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetLFTagExpression operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLFTagExpression operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLFTagExpression
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetLFTagExpression">REST API Reference for GetLFTagExpression Operation</seealso>
        public virtual IAsyncResult BeginGetLFTagExpression(GetLFTagExpressionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLFTagExpressionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLFTagExpressionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetLFTagExpression operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLFTagExpression.</param>
        /// 
        /// <returns>Returns a  GetLFTagExpressionResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetLFTagExpression">REST API Reference for GetLFTagExpression Operation</seealso>
        public virtual GetLFTagExpressionResponse EndGetLFTagExpression(IAsyncResult asyncResult)
        {
            return EndInvoke<GetLFTagExpressionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetQueryState

        /// <summary>
        /// Returns the state of a query previously submitted. Clients are expected to poll <c>GetQueryState</c>
        /// to monitor the current state of the planning before retrieving the work units. A query
        /// state is only visible to the principal that made the initial call to <c>StartQueryPlanning</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueryState service method.</param>
        /// 
        /// <returns>The response from the GetQueryState service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetQueryState">REST API Reference for GetQueryState Operation</seealso>
        public virtual GetQueryStateResponse GetQueryState(GetQueryStateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetQueryStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueryStateResponseUnmarshaller.Instance;

            return Invoke<GetQueryStateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetQueryState operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetQueryState operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetQueryState
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetQueryState">REST API Reference for GetQueryState Operation</seealso>
        public virtual IAsyncResult BeginGetQueryState(GetQueryStateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetQueryStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueryStateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetQueryState operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetQueryState.</param>
        /// 
        /// <returns>Returns a  GetQueryStateResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetQueryState">REST API Reference for GetQueryState Operation</seealso>
        public virtual GetQueryStateResponse EndGetQueryState(IAsyncResult asyncResult)
        {
            return EndInvoke<GetQueryStateResponse>(asyncResult);
        }

        #endregion
        
        #region  GetQueryStatistics

        /// <summary>
        /// Retrieves statistics on the planning and execution of a query.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueryStatistics service method.</param>
        /// 
        /// <returns>The response from the GetQueryStatistics service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.ExpiredException">
        /// Contains details about an error where the query request expired.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.StatisticsNotReadyYetException">
        /// Contains details about an error related to statistics not being ready.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.ThrottledException">
        /// Contains details about an error where the query request was throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetQueryStatistics">REST API Reference for GetQueryStatistics Operation</seealso>
        public virtual GetQueryStatisticsResponse GetQueryStatistics(GetQueryStatisticsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetQueryStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueryStatisticsResponseUnmarshaller.Instance;

            return Invoke<GetQueryStatisticsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetQueryStatistics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetQueryStatistics operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetQueryStatistics
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetQueryStatistics">REST API Reference for GetQueryStatistics Operation</seealso>
        public virtual IAsyncResult BeginGetQueryStatistics(GetQueryStatisticsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetQueryStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueryStatisticsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetQueryStatistics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetQueryStatistics.</param>
        /// 
        /// <returns>Returns a  GetQueryStatisticsResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetQueryStatistics">REST API Reference for GetQueryStatistics Operation</seealso>
        public virtual GetQueryStatisticsResponse EndGetQueryStatistics(IAsyncResult asyncResult)
        {
            return EndInvoke<GetQueryStatisticsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetResourceLFTags

        /// <summary>
        /// Returns the LF-tags applied to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceLFTags service method.</param>
        /// 
        /// <returns>The response from the GetResourceLFTags service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
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
        
        #region  GetTableObjects

        /// <summary>
        /// Returns the set of Amazon S3 objects that make up the specified governed table. A
        /// transaction ID or timestamp can be specified for time-travel queries.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTableObjects service method.</param>
        /// 
        /// <returns>The response from the GetTableObjects service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
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
        /// <exception cref="Amazon.LakeFormation.Model.ResourceNotReadyException">
        /// Contains details about an error related to a resource which is not ready for a transaction.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.TransactionCanceledException">
        /// Contains details about an error related to a transaction that was cancelled.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.TransactionCommittedException">
        /// Contains details about an error where the specified transaction has already been committed
        /// and cannot be used for <c>UpdateTableObjects</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetTableObjects">REST API Reference for GetTableObjects Operation</seealso>
        public virtual GetTableObjectsResponse GetTableObjects(GetTableObjectsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTableObjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTableObjectsResponseUnmarshaller.Instance;

            return Invoke<GetTableObjectsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTableObjects operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTableObjects operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTableObjects
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetTableObjects">REST API Reference for GetTableObjects Operation</seealso>
        public virtual IAsyncResult BeginGetTableObjects(GetTableObjectsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTableObjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTableObjectsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTableObjects operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTableObjects.</param>
        /// 
        /// <returns>Returns a  GetTableObjectsResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetTableObjects">REST API Reference for GetTableObjects Operation</seealso>
        public virtual GetTableObjectsResponse EndGetTableObjects(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTableObjectsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTemporaryGluePartitionCredentials

        /// <summary>
        /// This API is identical to <c>GetTemporaryTableCredentials</c> except that this is used
        /// when the target Data Catalog resource is of type Partition. Lake Formation restricts
        /// the permission of the vended credentials with the same scope down policy which restricts
        /// access to a single Amazon S3 prefix.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTemporaryGluePartitionCredentials service method.</param>
        /// 
        /// <returns>The response from the GetTemporaryGluePartitionCredentials service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
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
        /// <exception cref="Amazon.LakeFormation.Model.PermissionTypeMismatchException">
        /// The engine does not support filtering data based on the enforced permissions. For
        /// example, if you call the <c>GetTemporaryGlueTableCredentials</c> operation with <c>SupportedPermissionType</c>
        /// equal to <c>ColumnPermission</c>, but cell-level permissions exist on the table, this
        /// exception is thrown.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetTemporaryGluePartitionCredentials">REST API Reference for GetTemporaryGluePartitionCredentials Operation</seealso>
        public virtual GetTemporaryGluePartitionCredentialsResponse GetTemporaryGluePartitionCredentials(GetTemporaryGluePartitionCredentialsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTemporaryGluePartitionCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTemporaryGluePartitionCredentialsResponseUnmarshaller.Instance;

            return Invoke<GetTemporaryGluePartitionCredentialsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTemporaryGluePartitionCredentials operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTemporaryGluePartitionCredentials operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTemporaryGluePartitionCredentials
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetTemporaryGluePartitionCredentials">REST API Reference for GetTemporaryGluePartitionCredentials Operation</seealso>
        public virtual IAsyncResult BeginGetTemporaryGluePartitionCredentials(GetTemporaryGluePartitionCredentialsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTemporaryGluePartitionCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTemporaryGluePartitionCredentialsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTemporaryGluePartitionCredentials operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTemporaryGluePartitionCredentials.</param>
        /// 
        /// <returns>Returns a  GetTemporaryGluePartitionCredentialsResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetTemporaryGluePartitionCredentials">REST API Reference for GetTemporaryGluePartitionCredentials Operation</seealso>
        public virtual GetTemporaryGluePartitionCredentialsResponse EndGetTemporaryGluePartitionCredentials(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTemporaryGluePartitionCredentialsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTemporaryGlueTableCredentials

        /// <summary>
        /// Allows a caller in a secure environment to assume a role with permission to access
        /// Amazon S3. In order to vend such credentials, Lake Formation assumes the role associated
        /// with a registered location, for example an Amazon S3 bucket, with a scope down policy
        /// which restricts the access to a single prefix.
        /// 
        ///  
        /// <para>
        /// To call this API, the role that the service assumes must have <c>lakeformation:GetDataAccess</c>
        /// permission on the resource.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTemporaryGlueTableCredentials service method.</param>
        /// 
        /// <returns>The response from the GetTemporaryGlueTableCredentials service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
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
        /// <exception cref="Amazon.LakeFormation.Model.PermissionTypeMismatchException">
        /// The engine does not support filtering data based on the enforced permissions. For
        /// example, if you call the <c>GetTemporaryGlueTableCredentials</c> operation with <c>SupportedPermissionType</c>
        /// equal to <c>ColumnPermission</c>, but cell-level permissions exist on the table, this
        /// exception is thrown.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetTemporaryGlueTableCredentials">REST API Reference for GetTemporaryGlueTableCredentials Operation</seealso>
        public virtual GetTemporaryGlueTableCredentialsResponse GetTemporaryGlueTableCredentials(GetTemporaryGlueTableCredentialsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTemporaryGlueTableCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTemporaryGlueTableCredentialsResponseUnmarshaller.Instance;

            return Invoke<GetTemporaryGlueTableCredentialsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTemporaryGlueTableCredentials operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTemporaryGlueTableCredentials operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTemporaryGlueTableCredentials
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetTemporaryGlueTableCredentials">REST API Reference for GetTemporaryGlueTableCredentials Operation</seealso>
        public virtual IAsyncResult BeginGetTemporaryGlueTableCredentials(GetTemporaryGlueTableCredentialsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTemporaryGlueTableCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTemporaryGlueTableCredentialsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTemporaryGlueTableCredentials operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTemporaryGlueTableCredentials.</param>
        /// 
        /// <returns>Returns a  GetTemporaryGlueTableCredentialsResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetTemporaryGlueTableCredentials">REST API Reference for GetTemporaryGlueTableCredentials Operation</seealso>
        public virtual GetTemporaryGlueTableCredentialsResponse EndGetTemporaryGlueTableCredentials(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTemporaryGlueTableCredentialsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetWorkUnitResults

        /// <summary>
        /// Returns the work units resulting from the query. Work units can be executed in any
        /// order and in parallel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkUnitResults service method.</param>
        /// 
        /// <returns>The response from the GetWorkUnitResults service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.ExpiredException">
        /// Contains details about an error where the query request expired.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.ThrottledException">
        /// Contains details about an error where the query request was throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetWorkUnitResults">REST API Reference for GetWorkUnitResults Operation</seealso>
        public virtual GetWorkUnitResultsResponse GetWorkUnitResults(GetWorkUnitResultsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWorkUnitResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkUnitResultsResponseUnmarshaller.Instance;

            return Invoke<GetWorkUnitResultsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetWorkUnitResults operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWorkUnitResults operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWorkUnitResults
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetWorkUnitResults">REST API Reference for GetWorkUnitResults Operation</seealso>
        public virtual IAsyncResult BeginGetWorkUnitResults(GetWorkUnitResultsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWorkUnitResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkUnitResultsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetWorkUnitResults operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWorkUnitResults.</param>
        /// 
        /// <returns>Returns a  GetWorkUnitResultsResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetWorkUnitResults">REST API Reference for GetWorkUnitResults Operation</seealso>
        public virtual GetWorkUnitResultsResponse EndGetWorkUnitResults(IAsyncResult asyncResult)
        {
            return EndInvoke<GetWorkUnitResultsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetWorkUnits

        /// <summary>
        /// Retrieves the work units generated by the <c>StartQueryPlanning</c> operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkUnits service method.</param>
        /// 
        /// <returns>The response from the GetWorkUnits service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.ExpiredException">
        /// Contains details about an error where the query request expired.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.WorkUnitsNotReadyYetException">
        /// Contains details about an error related to work units not being ready.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetWorkUnits">REST API Reference for GetWorkUnits Operation</seealso>
        public virtual GetWorkUnitsResponse GetWorkUnits(GetWorkUnitsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWorkUnitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkUnitsResponseUnmarshaller.Instance;

            return Invoke<GetWorkUnitsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetWorkUnits operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWorkUnits operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWorkUnits
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetWorkUnits">REST API Reference for GetWorkUnits Operation</seealso>
        public virtual IAsyncResult BeginGetWorkUnits(GetWorkUnitsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWorkUnitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkUnitsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetWorkUnits operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWorkUnits.</param>
        /// 
        /// <returns>Returns a  GetWorkUnitsResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetWorkUnits">REST API Reference for GetWorkUnits Operation</seealso>
        public virtual GetWorkUnitsResponse EndGetWorkUnits(IAsyncResult asyncResult)
        {
            return EndInvoke<GetWorkUnitsResponse>(asyncResult);
        }

        #endregion
        
        #region  GrantPermissions

        /// <summary>
        /// Grants permissions to the principal to access metadata in the Data Catalog and data
        /// organized in underlying data storage such as Amazon S3.
        /// 
        ///  
        /// <para>
        /// For information about permissions, see <a href="https://docs.aws.amazon.com/lake-formation/latest/dg/security-data-access.html">Security
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
        /// A specified entity does not exist.
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
        
        #region  ListDataCellsFilter

        /// <summary>
        /// Lists all the data cell filters on a table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataCellsFilter service method.</param>
        /// 
        /// <returns>The response from the ListDataCellsFilter service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/ListDataCellsFilter">REST API Reference for ListDataCellsFilter Operation</seealso>
        public virtual ListDataCellsFilterResponse ListDataCellsFilter(ListDataCellsFilterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataCellsFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataCellsFilterResponseUnmarshaller.Instance;

            return Invoke<ListDataCellsFilterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDataCellsFilter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDataCellsFilter operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDataCellsFilter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/ListDataCellsFilter">REST API Reference for ListDataCellsFilter Operation</seealso>
        public virtual IAsyncResult BeginListDataCellsFilter(ListDataCellsFilterRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataCellsFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataCellsFilterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDataCellsFilter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDataCellsFilter.</param>
        /// 
        /// <returns>Returns a  ListDataCellsFilterResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/ListDataCellsFilter">REST API Reference for ListDataCellsFilter Operation</seealso>
        public virtual ListDataCellsFilterResponse EndListDataCellsFilter(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDataCellsFilterResponse>(asyncResult);
        }

        #endregion
        
        #region  ListLakeFormationOptIns

        /// <summary>
        /// Retrieve the current list of resources and principals that are opt in to enforce Lake
        /// Formation permissions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLakeFormationOptIns service method.</param>
        /// 
        /// <returns>The response from the ListLakeFormationOptIns service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/ListLakeFormationOptIns">REST API Reference for ListLakeFormationOptIns Operation</seealso>
        public virtual ListLakeFormationOptInsResponse ListLakeFormationOptIns(ListLakeFormationOptInsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLakeFormationOptInsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLakeFormationOptInsResponseUnmarshaller.Instance;

            return Invoke<ListLakeFormationOptInsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListLakeFormationOptIns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLakeFormationOptIns operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLakeFormationOptIns
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/ListLakeFormationOptIns">REST API Reference for ListLakeFormationOptIns Operation</seealso>
        public virtual IAsyncResult BeginListLakeFormationOptIns(ListLakeFormationOptInsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLakeFormationOptInsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLakeFormationOptInsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListLakeFormationOptIns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLakeFormationOptIns.</param>
        /// 
        /// <returns>Returns a  ListLakeFormationOptInsResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/ListLakeFormationOptIns">REST API Reference for ListLakeFormationOptIns Operation</seealso>
        public virtual ListLakeFormationOptInsResponse EndListLakeFormationOptIns(IAsyncResult asyncResult)
        {
            return EndInvoke<ListLakeFormationOptInsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListLFTagExpressions

        /// <summary>
        /// Returns the LF-Tag expressions in caller’s account filtered based on caller's permissions.
        /// Data Lake and read only admins implicitly can see all tag expressions in their account,
        /// else caller needs DESCRIBE permissions on tag expression.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLFTagExpressions service method.</param>
        /// 
        /// <returns>The response from the ListLFTagExpressions service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/ListLFTagExpressions">REST API Reference for ListLFTagExpressions Operation</seealso>
        public virtual ListLFTagExpressionsResponse ListLFTagExpressions(ListLFTagExpressionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLFTagExpressionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLFTagExpressionsResponseUnmarshaller.Instance;

            return Invoke<ListLFTagExpressionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListLFTagExpressions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLFTagExpressions operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLFTagExpressions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/ListLFTagExpressions">REST API Reference for ListLFTagExpressions Operation</seealso>
        public virtual IAsyncResult BeginListLFTagExpressions(ListLFTagExpressionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLFTagExpressionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLFTagExpressionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListLFTagExpressions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLFTagExpressions.</param>
        /// 
        /// <returns>Returns a  ListLFTagExpressionsResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/ListLFTagExpressions">REST API Reference for ListLFTagExpressions Operation</seealso>
        public virtual ListLFTagExpressionsResponse EndListLFTagExpressions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListLFTagExpressionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListLFTags

        /// <summary>
        /// Lists LF-tags that the requester has permission to view.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLFTags service method.</param>
        /// 
        /// <returns>The response from the ListLFTags service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
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
        /// For information about permissions, see <a href="https://docs.aws.amazon.com/lake-formation/latest/dg/security-data-access.html">Security
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
        
        #region  ListTableStorageOptimizers

        /// <summary>
        /// Returns the configuration of all storage optimizers associated with a specified table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTableStorageOptimizers service method.</param>
        /// 
        /// <returns>The response from the ListTableStorageOptimizers service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/ListTableStorageOptimizers">REST API Reference for ListTableStorageOptimizers Operation</seealso>
        public virtual ListTableStorageOptimizersResponse ListTableStorageOptimizers(ListTableStorageOptimizersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTableStorageOptimizersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTableStorageOptimizersResponseUnmarshaller.Instance;

            return Invoke<ListTableStorageOptimizersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTableStorageOptimizers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTableStorageOptimizers operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTableStorageOptimizers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/ListTableStorageOptimizers">REST API Reference for ListTableStorageOptimizers Operation</seealso>
        public virtual IAsyncResult BeginListTableStorageOptimizers(ListTableStorageOptimizersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTableStorageOptimizersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTableStorageOptimizersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTableStorageOptimizers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTableStorageOptimizers.</param>
        /// 
        /// <returns>Returns a  ListTableStorageOptimizersResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/ListTableStorageOptimizers">REST API Reference for ListTableStorageOptimizers Operation</seealso>
        public virtual ListTableStorageOptimizersResponse EndListTableStorageOptimizers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTableStorageOptimizersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTransactions

        /// <summary>
        /// Returns metadata about transactions and their status. To prevent the response from
        /// growing indefinitely, only uncommitted transactions and those available for time-travel
        /// queries are returned.
        /// 
        ///  
        /// <para>
        /// This operation can help you identify uncommitted transactions or to get information
        /// about transactions.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTransactions service method.</param>
        /// 
        /// <returns>The response from the ListTransactions service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/ListTransactions">REST API Reference for ListTransactions Operation</seealso>
        public virtual ListTransactionsResponse ListTransactions(ListTransactionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTransactionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTransactionsResponseUnmarshaller.Instance;

            return Invoke<ListTransactionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTransactions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTransactions operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTransactions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/ListTransactions">REST API Reference for ListTransactions Operation</seealso>
        public virtual IAsyncResult BeginListTransactions(ListTransactionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTransactionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTransactionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTransactions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTransactions.</param>
        /// 
        /// <returns>Returns a  ListTransactionsResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/ListTransactions">REST API Reference for ListTransactions Operation</seealso>
        public virtual ListTransactionsResponse EndListTransactions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTransactionsResponse>(asyncResult);
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
        /// The following request registers a new location and gives Lake Formation permission
        /// to use the service-linked role to access that location.
        /// </para>
        ///  
        /// <para>
        ///  <c>ResourceArn = arn:aws:s3:::my-bucket/ UseServiceLinkedRole = true</c> 
        /// </para>
        ///  
        /// <para>
        /// If <c>UseServiceLinkedRole</c> is not set to true, you must provide or set the <c>RoleArn</c>:
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:aws:iam::12345:role/my-data-access-role</c> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterResource service method.</param>
        /// 
        /// <returns>The response from the RegisterResource service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
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
        /// Removes an LF-tag from the resource. Only database, table, or tableWithColumns resource
        /// are allowed. To tag columns, use the column inclusion list in <c>tableWithColumns</c>
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
        /// A specified entity does not exist.
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
        /// A specified entity does not exist.
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
        /// This operation allows a search on <c>DATABASE</c> resources by <c>TagCondition</c>.
        /// This operation is used by admins who want to grant user permissions on certain <c>TagConditions</c>.
        /// Before making a grant, the admin can use <c>SearchDatabasesByTags</c> to find all
        /// resources where the given <c>TagConditions</c> are valid to verify whether the returned
        /// resources can be shared.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchDatabasesByLFTags service method.</param>
        /// 
        /// <returns>The response from the SearchDatabasesByLFTags service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
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
        /// This operation allows a search on <c>TABLE</c> resources by <c>LFTag</c>s. This will
        /// be used by admins who want to grant user permissions on certain LF-tags. Before making
        /// a grant, the admin can use <c>SearchTablesByLFTags</c> to find all resources where
        /// the given <c>LFTag</c>s are valid to verify whether the returned resources can be
        /// shared.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchTablesByLFTags service method.</param>
        /// 
        /// <returns>The response from the SearchTablesByLFTags service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
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
        
        #region  StartQueryPlanning

        /// <summary>
        /// Submits a request to process a query statement.
        /// 
        ///  
        /// <para>
        /// This operation generates work units that can be retrieved with the <c>GetWorkUnits</c>
        /// operation as soon as the query state is WORKUNITS_AVAILABLE or FINISHED.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartQueryPlanning service method.</param>
        /// 
        /// <returns>The response from the StartQueryPlanning service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.ThrottledException">
        /// Contains details about an error where the query request was throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/StartQueryPlanning">REST API Reference for StartQueryPlanning Operation</seealso>
        public virtual StartQueryPlanningResponse StartQueryPlanning(StartQueryPlanningRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartQueryPlanningRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartQueryPlanningResponseUnmarshaller.Instance;

            return Invoke<StartQueryPlanningResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartQueryPlanning operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartQueryPlanning operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartQueryPlanning
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/StartQueryPlanning">REST API Reference for StartQueryPlanning Operation</seealso>
        public virtual IAsyncResult BeginStartQueryPlanning(StartQueryPlanningRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartQueryPlanningRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartQueryPlanningResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartQueryPlanning operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartQueryPlanning.</param>
        /// 
        /// <returns>Returns a  StartQueryPlanningResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/StartQueryPlanning">REST API Reference for StartQueryPlanning Operation</seealso>
        public virtual StartQueryPlanningResponse EndStartQueryPlanning(IAsyncResult asyncResult)
        {
            return EndInvoke<StartQueryPlanningResponse>(asyncResult);
        }

        #endregion
        
        #region  StartTransaction

        /// <summary>
        /// Starts a new transaction and returns its transaction ID. Transaction IDs are opaque
        /// objects that you can use to identify a transaction.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTransaction service method.</param>
        /// 
        /// <returns>The response from the StartTransaction service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/StartTransaction">REST API Reference for StartTransaction Operation</seealso>
        public virtual StartTransactionResponse StartTransaction(StartTransactionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartTransactionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTransactionResponseUnmarshaller.Instance;

            return Invoke<StartTransactionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartTransaction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartTransaction operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartTransaction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/StartTransaction">REST API Reference for StartTransaction Operation</seealso>
        public virtual IAsyncResult BeginStartTransaction(StartTransactionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartTransactionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTransactionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartTransaction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartTransaction.</param>
        /// 
        /// <returns>Returns a  StartTransactionResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/StartTransaction">REST API Reference for StartTransaction Operation</seealso>
        public virtual StartTransactionResponse EndStartTransaction(IAsyncResult asyncResult)
        {
            return EndInvoke<StartTransactionResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDataCellsFilter

        /// <summary>
        /// Updates a data cell filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataCellsFilter service method.</param>
        /// 
        /// <returns>The response from the UpdateDataCellsFilter service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/UpdateDataCellsFilter">REST API Reference for UpdateDataCellsFilter Operation</seealso>
        public virtual UpdateDataCellsFilterResponse UpdateDataCellsFilter(UpdateDataCellsFilterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDataCellsFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataCellsFilterResponseUnmarshaller.Instance;

            return Invoke<UpdateDataCellsFilterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDataCellsFilter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataCellsFilter operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDataCellsFilter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/UpdateDataCellsFilter">REST API Reference for UpdateDataCellsFilter Operation</seealso>
        public virtual IAsyncResult BeginUpdateDataCellsFilter(UpdateDataCellsFilterRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDataCellsFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataCellsFilterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDataCellsFilter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDataCellsFilter.</param>
        /// 
        /// <returns>Returns a  UpdateDataCellsFilterResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/UpdateDataCellsFilter">REST API Reference for UpdateDataCellsFilter Operation</seealso>
        public virtual UpdateDataCellsFilterResponse EndUpdateDataCellsFilter(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDataCellsFilterResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateLakeFormationIdentityCenterConfiguration

        /// <summary>
        /// Updates the IAM Identity Center connection parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLakeFormationIdentityCenterConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateLakeFormationIdentityCenterConfiguration service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/UpdateLakeFormationIdentityCenterConfiguration">REST API Reference for UpdateLakeFormationIdentityCenterConfiguration Operation</seealso>
        public virtual UpdateLakeFormationIdentityCenterConfigurationResponse UpdateLakeFormationIdentityCenterConfiguration(UpdateLakeFormationIdentityCenterConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLakeFormationIdentityCenterConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLakeFormationIdentityCenterConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateLakeFormationIdentityCenterConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLakeFormationIdentityCenterConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLakeFormationIdentityCenterConfiguration operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLakeFormationIdentityCenterConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/UpdateLakeFormationIdentityCenterConfiguration">REST API Reference for UpdateLakeFormationIdentityCenterConfiguration Operation</seealso>
        public virtual IAsyncResult BeginUpdateLakeFormationIdentityCenterConfiguration(UpdateLakeFormationIdentityCenterConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLakeFormationIdentityCenterConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLakeFormationIdentityCenterConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLakeFormationIdentityCenterConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLakeFormationIdentityCenterConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateLakeFormationIdentityCenterConfigurationResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/UpdateLakeFormationIdentityCenterConfiguration">REST API Reference for UpdateLakeFormationIdentityCenterConfiguration Operation</seealso>
        public virtual UpdateLakeFormationIdentityCenterConfigurationResponse EndUpdateLakeFormationIdentityCenterConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateLakeFormationIdentityCenterConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateLFTag

        /// <summary>
        /// Updates the list of possible values for the specified LF-tag key. If the LF-tag does
        /// not exist, the operation throws an EntityNotFoundException. The values in the delete
        /// key values will be deleted from list of possible values. If any value in the delete
        /// key values is attached to a resource, then API errors out with a 400 Exception - "Update
        /// not allowed". Untag the attribute before deleting the LF-tag key's value.
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
        /// A specified entity does not exist.
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
        
        #region  UpdateLFTagExpression

        /// <summary>
        /// Updates the name of the LF-Tag expression to the new description and expression body
        /// provided. Updating a LF-Tag expression immediately changes the permission boundaries
        /// of all existing <c>LFTagPolicy</c> permission grants that reference the given LF-Tag
        /// expression.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLFTagExpression service method.</param>
        /// 
        /// <returns>The response from the UpdateLFTagExpression service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/UpdateLFTagExpression">REST API Reference for UpdateLFTagExpression Operation</seealso>
        public virtual UpdateLFTagExpressionResponse UpdateLFTagExpression(UpdateLFTagExpressionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLFTagExpressionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLFTagExpressionResponseUnmarshaller.Instance;

            return Invoke<UpdateLFTagExpressionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLFTagExpression operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLFTagExpression operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLFTagExpression
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/UpdateLFTagExpression">REST API Reference for UpdateLFTagExpression Operation</seealso>
        public virtual IAsyncResult BeginUpdateLFTagExpression(UpdateLFTagExpressionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLFTagExpressionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLFTagExpressionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLFTagExpression operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLFTagExpression.</param>
        /// 
        /// <returns>Returns a  UpdateLFTagExpressionResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/UpdateLFTagExpression">REST API Reference for UpdateLFTagExpression Operation</seealso>
        public virtual UpdateLFTagExpressionResponse EndUpdateLFTagExpression(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateLFTagExpressionResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateResource

        /// <summary>
        /// Updates the data access role used for vending access to the given (registered) resource
        /// in Lake Formation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResource service method.</param>
        /// 
        /// <returns>The response from the UpdateResource service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
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
        
        #region  UpdateTableObjects

        /// <summary>
        /// Updates the manifest of Amazon S3 objects that make up the specified governed table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTableObjects service method.</param>
        /// 
        /// <returns>The response from the UpdateTableObjects service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
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
        /// <exception cref="Amazon.LakeFormation.Model.ResourceNotReadyException">
        /// Contains details about an error related to a resource which is not ready for a transaction.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.TransactionCanceledException">
        /// Contains details about an error related to a transaction that was cancelled.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.TransactionCommitInProgressException">
        /// Contains details about an error related to a transaction commit that was in progress.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.TransactionCommittedException">
        /// Contains details about an error where the specified transaction has already been committed
        /// and cannot be used for <c>UpdateTableObjects</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/UpdateTableObjects">REST API Reference for UpdateTableObjects Operation</seealso>
        public virtual UpdateTableObjectsResponse UpdateTableObjects(UpdateTableObjectsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTableObjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTableObjectsResponseUnmarshaller.Instance;

            return Invoke<UpdateTableObjectsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTableObjects operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTableObjects operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTableObjects
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/UpdateTableObjects">REST API Reference for UpdateTableObjects Operation</seealso>
        public virtual IAsyncResult BeginUpdateTableObjects(UpdateTableObjectsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTableObjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTableObjectsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTableObjects operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTableObjects.</param>
        /// 
        /// <returns>Returns a  UpdateTableObjectsResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/UpdateTableObjects">REST API Reference for UpdateTableObjects Operation</seealso>
        public virtual UpdateTableObjectsResponse EndUpdateTableObjects(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateTableObjectsResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateTableStorageOptimizer

        /// <summary>
        /// Updates the configuration of the storage optimizers for a table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTableStorageOptimizer service method.</param>
        /// 
        /// <returns>The response from the UpdateTableStorageOptimizer service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/UpdateTableStorageOptimizer">REST API Reference for UpdateTableStorageOptimizer Operation</seealso>
        public virtual UpdateTableStorageOptimizerResponse UpdateTableStorageOptimizer(UpdateTableStorageOptimizerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTableStorageOptimizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTableStorageOptimizerResponseUnmarshaller.Instance;

            return Invoke<UpdateTableStorageOptimizerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTableStorageOptimizer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTableStorageOptimizer operation on AmazonLakeFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTableStorageOptimizer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/UpdateTableStorageOptimizer">REST API Reference for UpdateTableStorageOptimizer Operation</seealso>
        public virtual IAsyncResult BeginUpdateTableStorageOptimizer(UpdateTableStorageOptimizerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTableStorageOptimizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTableStorageOptimizerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTableStorageOptimizer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTableStorageOptimizer.</param>
        /// 
        /// <returns>Returns a  UpdateTableStorageOptimizerResult from LakeFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/UpdateTableStorageOptimizer">REST API Reference for UpdateTableStorageOptimizer Operation</seealso>
        public virtual UpdateTableStorageOptimizerResponse EndUpdateTableStorageOptimizer(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateTableStorageOptimizerResponse>(asyncResult);
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
            var resolver = new AmazonLakeFormationEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}