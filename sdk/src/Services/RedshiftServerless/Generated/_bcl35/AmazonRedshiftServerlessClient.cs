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
 * Do not modify this file. This file is generated from the redshift-serverless-2021-04-21.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.RedshiftServerless.Model;
using Amazon.RedshiftServerless.Model.Internal.MarshallTransformations;
using Amazon.RedshiftServerless.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.RedshiftServerless
{
    /// <summary>
    /// <para>Implementation for accessing RedshiftServerless</para>
    ///
    /// This is an interface reference for Amazon Redshift Serverless. It contains documentation
    /// for one of the programming or command line interfaces you can use to manage Amazon
    /// Redshift Serverless. 
    /// 
    ///  
    /// <para>
    /// Amazon Redshift Serverless automatically provisions data warehouse capacity and intelligently
    /// scales the underlying resources based on workload demands. Amazon Redshift Serverless
    /// adjusts capacity in seconds to deliver consistently high performance and simplified
    /// operations for even the most demanding and volatile workloads. Amazon Redshift Serverless
    /// lets you focus on using your data to acquire new insights for your business and customers.
    /// 
    /// </para>
    ///  
    /// <para>
    ///  To learn more about Amazon Redshift Serverless, see <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/serverless-whatis.html">What
    /// is Amazon Redshift Serverless?</a>.
    /// </para>
    /// </summary>
    public partial class AmazonRedshiftServerlessClient : AmazonServiceClient, IAmazonRedshiftServerless
    {
        private static IServiceMetadata serviceMetadata = new AmazonRedshiftServerlessMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IRedshiftServerlessPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IRedshiftServerlessPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new RedshiftServerlessPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonRedshiftServerlessClient with the credentials loaded from the application's
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
        public AmazonRedshiftServerlessClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRedshiftServerlessConfig()) { }

        /// <summary>
        /// Constructs AmazonRedshiftServerlessClient with the credentials loaded from the application's
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
        public AmazonRedshiftServerlessClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRedshiftServerlessConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonRedshiftServerlessClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonRedshiftServerlessClient Configuration Object</param>
        public AmazonRedshiftServerlessClient(AmazonRedshiftServerlessConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonRedshiftServerlessClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonRedshiftServerlessClient(AWSCredentials credentials)
            : this(credentials, new AmazonRedshiftServerlessConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftServerlessClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRedshiftServerlessClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonRedshiftServerlessConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftServerlessClient with AWS Credentials and an
        /// AmazonRedshiftServerlessClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonRedshiftServerlessClient Configuration Object</param>
        public AmazonRedshiftServerlessClient(AWSCredentials credentials, AmazonRedshiftServerlessConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftServerlessClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonRedshiftServerlessClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRedshiftServerlessConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftServerlessClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRedshiftServerlessClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRedshiftServerlessConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftServerlessClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRedshiftServerlessClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonRedshiftServerlessClient Configuration Object</param>
        public AmazonRedshiftServerlessClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonRedshiftServerlessConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftServerlessClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonRedshiftServerlessClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRedshiftServerlessConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftServerlessClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRedshiftServerlessClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRedshiftServerlessConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftServerlessClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRedshiftServerlessClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonRedshiftServerlessClient Configuration Object</param>
        public AmazonRedshiftServerlessClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonRedshiftServerlessConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonRedshiftServerlessEndpointResolver());
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


        #region  ConvertRecoveryPointToSnapshot

        /// <summary>
        /// Converts a recovery point to a snapshot. For more information about recovery points
        /// and snapshots, see <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/serverless-snapshots-recovery.html">Working
        /// with snapshots and recovery points</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConvertRecoveryPointToSnapshot service method.</param>
        /// 
        /// <returns>The response from the ConvertRecoveryPointToSnapshot service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ServiceQuotaExceededException">
        /// The service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.TooManyTagsException">
        /// The request exceeded the number of tags allowed for a resource.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ConvertRecoveryPointToSnapshot">REST API Reference for ConvertRecoveryPointToSnapshot Operation</seealso>
        public virtual ConvertRecoveryPointToSnapshotResponse ConvertRecoveryPointToSnapshot(ConvertRecoveryPointToSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConvertRecoveryPointToSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConvertRecoveryPointToSnapshotResponseUnmarshaller.Instance;

            return Invoke<ConvertRecoveryPointToSnapshotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ConvertRecoveryPointToSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConvertRecoveryPointToSnapshot operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndConvertRecoveryPointToSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ConvertRecoveryPointToSnapshot">REST API Reference for ConvertRecoveryPointToSnapshot Operation</seealso>
        public virtual IAsyncResult BeginConvertRecoveryPointToSnapshot(ConvertRecoveryPointToSnapshotRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConvertRecoveryPointToSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConvertRecoveryPointToSnapshotResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ConvertRecoveryPointToSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginConvertRecoveryPointToSnapshot.</param>
        /// 
        /// <returns>Returns a  ConvertRecoveryPointToSnapshotResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ConvertRecoveryPointToSnapshot">REST API Reference for ConvertRecoveryPointToSnapshot Operation</seealso>
        public virtual ConvertRecoveryPointToSnapshotResponse EndConvertRecoveryPointToSnapshot(IAsyncResult asyncResult)
        {
            return EndInvoke<ConvertRecoveryPointToSnapshotResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateCustomDomainAssociation

        /// <summary>
        /// Creates a custom domain association for Amazon Redshift Serverless.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomDomainAssociation service method.</param>
        /// 
        /// <returns>The response from the CreateCustomDomainAssociation service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/CreateCustomDomainAssociation">REST API Reference for CreateCustomDomainAssociation Operation</seealso>
        public virtual CreateCustomDomainAssociationResponse CreateCustomDomainAssociation(CreateCustomDomainAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCustomDomainAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCustomDomainAssociationResponseUnmarshaller.Instance;

            return Invoke<CreateCustomDomainAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCustomDomainAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomDomainAssociation operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCustomDomainAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/CreateCustomDomainAssociation">REST API Reference for CreateCustomDomainAssociation Operation</seealso>
        public virtual IAsyncResult BeginCreateCustomDomainAssociation(CreateCustomDomainAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCustomDomainAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCustomDomainAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCustomDomainAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCustomDomainAssociation.</param>
        /// 
        /// <returns>Returns a  CreateCustomDomainAssociationResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/CreateCustomDomainAssociation">REST API Reference for CreateCustomDomainAssociation Operation</seealso>
        public virtual CreateCustomDomainAssociationResponse EndCreateCustomDomainAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateCustomDomainAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateEndpointAccess

        /// <summary>
        /// Creates an Amazon Redshift Serverless managed VPC endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEndpointAccess service method.</param>
        /// 
        /// <returns>The response from the CreateEndpointAccess service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ServiceQuotaExceededException">
        /// The service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/CreateEndpointAccess">REST API Reference for CreateEndpointAccess Operation</seealso>
        public virtual CreateEndpointAccessResponse CreateEndpointAccess(CreateEndpointAccessRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEndpointAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEndpointAccessResponseUnmarshaller.Instance;

            return Invoke<CreateEndpointAccessResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEndpointAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEndpointAccess operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEndpointAccess
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/CreateEndpointAccess">REST API Reference for CreateEndpointAccess Operation</seealso>
        public virtual IAsyncResult BeginCreateEndpointAccess(CreateEndpointAccessRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEndpointAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEndpointAccessResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEndpointAccess operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEndpointAccess.</param>
        /// 
        /// <returns>Returns a  CreateEndpointAccessResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/CreateEndpointAccess">REST API Reference for CreateEndpointAccess Operation</seealso>
        public virtual CreateEndpointAccessResponse EndCreateEndpointAccess(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateEndpointAccessResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateNamespace

        /// <summary>
        /// Creates a namespace in Amazon Redshift Serverless.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNamespace service method.</param>
        /// 
        /// <returns>The response from the CreateNamespace service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.TooManyTagsException">
        /// The request exceeded the number of tags allowed for a resource.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/CreateNamespace">REST API Reference for CreateNamespace Operation</seealso>
        public virtual CreateNamespaceResponse CreateNamespace(CreateNamespaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNamespaceResponseUnmarshaller.Instance;

            return Invoke<CreateNamespaceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNamespace operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateNamespace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/CreateNamespace">REST API Reference for CreateNamespace Operation</seealso>
        public virtual IAsyncResult BeginCreateNamespace(CreateNamespaceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNamespaceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateNamespace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateNamespace.</param>
        /// 
        /// <returns>Returns a  CreateNamespaceResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/CreateNamespace">REST API Reference for CreateNamespace Operation</seealso>
        public virtual CreateNamespaceResponse EndCreateNamespace(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateNamespaceResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateScheduledAction

        /// <summary>
        /// Creates a scheduled action. A scheduled action contains a schedule and an Amazon Redshift
        /// API action. For example, you can create a schedule of when to run the <c>CreateSnapshot</c>
        /// API operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateScheduledAction service method.</param>
        /// 
        /// <returns>The response from the CreateScheduledAction service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/CreateScheduledAction">REST API Reference for CreateScheduledAction Operation</seealso>
        public virtual CreateScheduledActionResponse CreateScheduledAction(CreateScheduledActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateScheduledActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateScheduledActionResponseUnmarshaller.Instance;

            return Invoke<CreateScheduledActionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateScheduledAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateScheduledAction operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateScheduledAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/CreateScheduledAction">REST API Reference for CreateScheduledAction Operation</seealso>
        public virtual IAsyncResult BeginCreateScheduledAction(CreateScheduledActionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateScheduledActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateScheduledActionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateScheduledAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateScheduledAction.</param>
        /// 
        /// <returns>Returns a  CreateScheduledActionResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/CreateScheduledAction">REST API Reference for CreateScheduledAction Operation</seealso>
        public virtual CreateScheduledActionResponse EndCreateScheduledAction(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateScheduledActionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateSnapshot

        /// <summary>
        /// Creates a snapshot of all databases in a namespace. For more information about snapshots,
        /// see <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/serverless-snapshots-recovery.html">
        /// Working with snapshots and recovery points</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshot service method.</param>
        /// 
        /// <returns>The response from the CreateSnapshot service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ServiceQuotaExceededException">
        /// The service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.TooManyTagsException">
        /// The request exceeded the number of tags allowed for a resource.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/CreateSnapshot">REST API Reference for CreateSnapshot Operation</seealso>
        public virtual CreateSnapshotResponse CreateSnapshot(CreateSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateSnapshotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshot operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/CreateSnapshot">REST API Reference for CreateSnapshot Operation</seealso>
        public virtual IAsyncResult BeginCreateSnapshot(CreateSnapshotRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSnapshotResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSnapshot.</param>
        /// 
        /// <returns>Returns a  CreateSnapshotResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/CreateSnapshot">REST API Reference for CreateSnapshot Operation</seealso>
        public virtual CreateSnapshotResponse EndCreateSnapshot(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSnapshotResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateSnapshotCopyConfiguration

        /// <summary>
        /// Creates a snapshot copy configuration that lets you copy snapshots to another Amazon
        /// Web Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshotCopyConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateSnapshotCopyConfiguration service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ServiceQuotaExceededException">
        /// The service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/CreateSnapshotCopyConfiguration">REST API Reference for CreateSnapshotCopyConfiguration Operation</seealso>
        public virtual CreateSnapshotCopyConfigurationResponse CreateSnapshotCopyConfiguration(CreateSnapshotCopyConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSnapshotCopyConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSnapshotCopyConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateSnapshotCopyConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSnapshotCopyConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshotCopyConfiguration operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSnapshotCopyConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/CreateSnapshotCopyConfiguration">REST API Reference for CreateSnapshotCopyConfiguration Operation</seealso>
        public virtual IAsyncResult BeginCreateSnapshotCopyConfiguration(CreateSnapshotCopyConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSnapshotCopyConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSnapshotCopyConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSnapshotCopyConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSnapshotCopyConfiguration.</param>
        /// 
        /// <returns>Returns a  CreateSnapshotCopyConfigurationResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/CreateSnapshotCopyConfiguration">REST API Reference for CreateSnapshotCopyConfiguration Operation</seealso>
        public virtual CreateSnapshotCopyConfigurationResponse EndCreateSnapshotCopyConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSnapshotCopyConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateUsageLimit

        /// <summary>
        /// Creates a usage limit for a specified Amazon Redshift Serverless usage type. The usage
        /// limit is identified by the returned usage limit identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUsageLimit service method.</param>
        /// 
        /// <returns>The response from the CreateUsageLimit service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ServiceQuotaExceededException">
        /// The service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/CreateUsageLimit">REST API Reference for CreateUsageLimit Operation</seealso>
        public virtual CreateUsageLimitResponse CreateUsageLimit(CreateUsageLimitRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUsageLimitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUsageLimitResponseUnmarshaller.Instance;

            return Invoke<CreateUsageLimitResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUsageLimit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUsageLimit operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateUsageLimit
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/CreateUsageLimit">REST API Reference for CreateUsageLimit Operation</seealso>
        public virtual IAsyncResult BeginCreateUsageLimit(CreateUsageLimitRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUsageLimitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUsageLimitResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateUsageLimit operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUsageLimit.</param>
        /// 
        /// <returns>Returns a  CreateUsageLimitResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/CreateUsageLimit">REST API Reference for CreateUsageLimit Operation</seealso>
        public virtual CreateUsageLimitResponse EndCreateUsageLimit(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateUsageLimitResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateWorkgroup

        /// <summary>
        /// Creates an workgroup in Amazon Redshift Serverless.
        /// 
        ///  
        /// <para>
        /// VPC Block Public Access (BPA) enables you to block resources in VPCs and subnets that
        /// you own in a Region from reaching or being reached from the internet through internet
        /// gateways and egress-only internet gateways. If a workgroup is in an account with VPC
        /// BPA turned on, the following capabilities are blocked: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Creating a public access workgroup
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Modifying a private workgroup to public
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Adding a subnet with VPC BPA turned on to the workgroup when the workgroup is public
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about VPC BPA, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/security-vpc-bpa.html">Block
        /// public access to VPCs and subnets</a> in the <i>Amazon VPC User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkgroup service method.</param>
        /// 
        /// <returns>The response from the CreateWorkgroup service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InsufficientCapacityException">
        /// There is an insufficient capacity to perform the action.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.Ipv6CidrBlockNotFoundException">
        /// There are no subnets in your VPC with associated IPv6 CIDR blocks. To use dual-stack
        /// mode, associate an IPv6 CIDR block with each subnet in your VPC.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.TooManyTagsException">
        /// The request exceeded the number of tags allowed for a resource.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/CreateWorkgroup">REST API Reference for CreateWorkgroup Operation</seealso>
        public virtual CreateWorkgroupResponse CreateWorkgroup(CreateWorkgroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWorkgroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkgroupResponseUnmarshaller.Instance;

            return Invoke<CreateWorkgroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWorkgroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkgroup operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWorkgroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/CreateWorkgroup">REST API Reference for CreateWorkgroup Operation</seealso>
        public virtual IAsyncResult BeginCreateWorkgroup(CreateWorkgroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWorkgroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkgroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWorkgroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWorkgroup.</param>
        /// 
        /// <returns>Returns a  CreateWorkgroupResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/CreateWorkgroup">REST API Reference for CreateWorkgroup Operation</seealso>
        public virtual CreateWorkgroupResponse EndCreateWorkgroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateWorkgroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteCustomDomainAssociation

        /// <summary>
        /// Deletes a custom domain association for Amazon Redshift Serverless.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomDomainAssociation service method.</param>
        /// 
        /// <returns>The response from the DeleteCustomDomainAssociation service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/DeleteCustomDomainAssociation">REST API Reference for DeleteCustomDomainAssociation Operation</seealso>
        public virtual DeleteCustomDomainAssociationResponse DeleteCustomDomainAssociation(DeleteCustomDomainAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCustomDomainAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCustomDomainAssociationResponseUnmarshaller.Instance;

            return Invoke<DeleteCustomDomainAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCustomDomainAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomDomainAssociation operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCustomDomainAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/DeleteCustomDomainAssociation">REST API Reference for DeleteCustomDomainAssociation Operation</seealso>
        public virtual IAsyncResult BeginDeleteCustomDomainAssociation(DeleteCustomDomainAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCustomDomainAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCustomDomainAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCustomDomainAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCustomDomainAssociation.</param>
        /// 
        /// <returns>Returns a  DeleteCustomDomainAssociationResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/DeleteCustomDomainAssociation">REST API Reference for DeleteCustomDomainAssociation Operation</seealso>
        public virtual DeleteCustomDomainAssociationResponse EndDeleteCustomDomainAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteCustomDomainAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteEndpointAccess

        /// <summary>
        /// Deletes an Amazon Redshift Serverless managed VPC endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpointAccess service method.</param>
        /// 
        /// <returns>The response from the DeleteEndpointAccess service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/DeleteEndpointAccess">REST API Reference for DeleteEndpointAccess Operation</seealso>
        public virtual DeleteEndpointAccessResponse DeleteEndpointAccess(DeleteEndpointAccessRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEndpointAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEndpointAccessResponseUnmarshaller.Instance;

            return Invoke<DeleteEndpointAccessResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEndpointAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpointAccess operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEndpointAccess
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/DeleteEndpointAccess">REST API Reference for DeleteEndpointAccess Operation</seealso>
        public virtual IAsyncResult BeginDeleteEndpointAccess(DeleteEndpointAccessRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEndpointAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEndpointAccessResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEndpointAccess operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEndpointAccess.</param>
        /// 
        /// <returns>Returns a  DeleteEndpointAccessResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/DeleteEndpointAccess">REST API Reference for DeleteEndpointAccess Operation</seealso>
        public virtual DeleteEndpointAccessResponse EndDeleteEndpointAccess(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteEndpointAccessResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteNamespace

        /// <summary>
        /// Deletes a namespace from Amazon Redshift Serverless. Before you delete the namespace,
        /// you can create a final snapshot that has all of the data within the namespace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNamespace service method.</param>
        /// 
        /// <returns>The response from the DeleteNamespace service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/DeleteNamespace">REST API Reference for DeleteNamespace Operation</seealso>
        public virtual DeleteNamespaceResponse DeleteNamespace(DeleteNamespaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNamespaceResponseUnmarshaller.Instance;

            return Invoke<DeleteNamespaceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNamespace operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteNamespace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/DeleteNamespace">REST API Reference for DeleteNamespace Operation</seealso>
        public virtual IAsyncResult BeginDeleteNamespace(DeleteNamespaceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNamespaceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteNamespace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteNamespace.</param>
        /// 
        /// <returns>Returns a  DeleteNamespaceResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/DeleteNamespace">REST API Reference for DeleteNamespace Operation</seealso>
        public virtual DeleteNamespaceResponse EndDeleteNamespace(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteNamespaceResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteResourcePolicy

        /// <summary>
        /// Deletes the specified resource policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteResourcePolicy service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        public virtual DeleteResourcePolicyResponse DeleteResourcePolicy(DeleteResourcePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteResourcePolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        public virtual IAsyncResult BeginDeleteResourcePolicy(DeleteResourcePolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteResourcePolicy.</param>
        /// 
        /// <returns>Returns a  DeleteResourcePolicyResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        public virtual DeleteResourcePolicyResponse EndDeleteResourcePolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteResourcePolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteScheduledAction

        /// <summary>
        /// Deletes a scheduled action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteScheduledAction service method.</param>
        /// 
        /// <returns>The response from the DeleteScheduledAction service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/DeleteScheduledAction">REST API Reference for DeleteScheduledAction Operation</seealso>
        public virtual DeleteScheduledActionResponse DeleteScheduledAction(DeleteScheduledActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteScheduledActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteScheduledActionResponseUnmarshaller.Instance;

            return Invoke<DeleteScheduledActionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteScheduledAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteScheduledAction operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteScheduledAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/DeleteScheduledAction">REST API Reference for DeleteScheduledAction Operation</seealso>
        public virtual IAsyncResult BeginDeleteScheduledAction(DeleteScheduledActionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteScheduledActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteScheduledActionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteScheduledAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteScheduledAction.</param>
        /// 
        /// <returns>Returns a  DeleteScheduledActionResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/DeleteScheduledAction">REST API Reference for DeleteScheduledAction Operation</seealso>
        public virtual DeleteScheduledActionResponse EndDeleteScheduledAction(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteScheduledActionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteSnapshot

        /// <summary>
        /// Deletes a snapshot from Amazon Redshift Serverless.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshot service method.</param>
        /// 
        /// <returns>The response from the DeleteSnapshot service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/DeleteSnapshot">REST API Reference for DeleteSnapshot Operation</seealso>
        public virtual DeleteSnapshotResponse DeleteSnapshot(DeleteSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSnapshotResponseUnmarshaller.Instance;

            return Invoke<DeleteSnapshotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshot operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/DeleteSnapshot">REST API Reference for DeleteSnapshot Operation</seealso>
        public virtual IAsyncResult BeginDeleteSnapshot(DeleteSnapshotRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSnapshotResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSnapshot.</param>
        /// 
        /// <returns>Returns a  DeleteSnapshotResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/DeleteSnapshot">REST API Reference for DeleteSnapshot Operation</seealso>
        public virtual DeleteSnapshotResponse EndDeleteSnapshot(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSnapshotResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteSnapshotCopyConfiguration

        /// <summary>
        /// Deletes a snapshot copy configuration
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshotCopyConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteSnapshotCopyConfiguration service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/DeleteSnapshotCopyConfiguration">REST API Reference for DeleteSnapshotCopyConfiguration Operation</seealso>
        public virtual DeleteSnapshotCopyConfigurationResponse DeleteSnapshotCopyConfiguration(DeleteSnapshotCopyConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSnapshotCopyConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSnapshotCopyConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteSnapshotCopyConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSnapshotCopyConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshotCopyConfiguration operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSnapshotCopyConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/DeleteSnapshotCopyConfiguration">REST API Reference for DeleteSnapshotCopyConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDeleteSnapshotCopyConfiguration(DeleteSnapshotCopyConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSnapshotCopyConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSnapshotCopyConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSnapshotCopyConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSnapshotCopyConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteSnapshotCopyConfigurationResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/DeleteSnapshotCopyConfiguration">REST API Reference for DeleteSnapshotCopyConfiguration Operation</seealso>
        public virtual DeleteSnapshotCopyConfigurationResponse EndDeleteSnapshotCopyConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSnapshotCopyConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteUsageLimit

        /// <summary>
        /// Deletes a usage limit from Amazon Redshift Serverless.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUsageLimit service method.</param>
        /// 
        /// <returns>The response from the DeleteUsageLimit service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/DeleteUsageLimit">REST API Reference for DeleteUsageLimit Operation</seealso>
        public virtual DeleteUsageLimitResponse DeleteUsageLimit(DeleteUsageLimitRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUsageLimitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUsageLimitResponseUnmarshaller.Instance;

            return Invoke<DeleteUsageLimitResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUsageLimit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUsageLimit operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteUsageLimit
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/DeleteUsageLimit">REST API Reference for DeleteUsageLimit Operation</seealso>
        public virtual IAsyncResult BeginDeleteUsageLimit(DeleteUsageLimitRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUsageLimitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUsageLimitResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUsageLimit operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUsageLimit.</param>
        /// 
        /// <returns>Returns a  DeleteUsageLimitResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/DeleteUsageLimit">REST API Reference for DeleteUsageLimit Operation</seealso>
        public virtual DeleteUsageLimitResponse EndDeleteUsageLimit(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteUsageLimitResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteWorkgroup

        /// <summary>
        /// Deletes a workgroup.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkgroup service method.</param>
        /// 
        /// <returns>The response from the DeleteWorkgroup service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/DeleteWorkgroup">REST API Reference for DeleteWorkgroup Operation</seealso>
        public virtual DeleteWorkgroupResponse DeleteWorkgroup(DeleteWorkgroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWorkgroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkgroupResponseUnmarshaller.Instance;

            return Invoke<DeleteWorkgroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWorkgroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkgroup operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWorkgroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/DeleteWorkgroup">REST API Reference for DeleteWorkgroup Operation</seealso>
        public virtual IAsyncResult BeginDeleteWorkgroup(DeleteWorkgroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWorkgroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkgroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWorkgroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWorkgroup.</param>
        /// 
        /// <returns>Returns a  DeleteWorkgroupResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/DeleteWorkgroup">REST API Reference for DeleteWorkgroup Operation</seealso>
        public virtual DeleteWorkgroupResponse EndDeleteWorkgroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteWorkgroupResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCredentials

        /// <summary>
        /// Returns a database user name and temporary password with temporary authorization to
        /// log in to Amazon Redshift Serverless.
        /// 
        ///  
        /// <para>
        /// By default, the temporary credentials expire in 900 seconds. You can optionally specify
        /// a duration between 900 seconds (15 minutes) and 3600 seconds (60 minutes).
        /// </para>
        ///  
        /// <para>
        /// The Identity and Access Management (IAM) user or role that runs GetCredentials must
        /// have an IAM policy attached that allows access to all necessary actions and resources.
        /// </para>
        ///  
        /// <para>
        /// If the <c>DbName</c> parameter is specified, the IAM policy must allow access to the
        /// resource dbname for the specified database name.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCredentials service method.</param>
        /// 
        /// <returns>The response from the GetCredentials service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetCredentials">REST API Reference for GetCredentials Operation</seealso>
        public virtual GetCredentialsResponse GetCredentials(GetCredentialsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCredentialsResponseUnmarshaller.Instance;

            return Invoke<GetCredentialsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCredentials operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCredentials operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCredentials
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetCredentials">REST API Reference for GetCredentials Operation</seealso>
        public virtual IAsyncResult BeginGetCredentials(GetCredentialsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCredentialsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCredentials operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCredentials.</param>
        /// 
        /// <returns>Returns a  GetCredentialsResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetCredentials">REST API Reference for GetCredentials Operation</seealso>
        public virtual GetCredentialsResponse EndGetCredentials(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCredentialsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCustomDomainAssociation

        /// <summary>
        /// Gets information about a specific custom domain association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCustomDomainAssociation service method.</param>
        /// 
        /// <returns>The response from the GetCustomDomainAssociation service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetCustomDomainAssociation">REST API Reference for GetCustomDomainAssociation Operation</seealso>
        public virtual GetCustomDomainAssociationResponse GetCustomDomainAssociation(GetCustomDomainAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCustomDomainAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCustomDomainAssociationResponseUnmarshaller.Instance;

            return Invoke<GetCustomDomainAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCustomDomainAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCustomDomainAssociation operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCustomDomainAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetCustomDomainAssociation">REST API Reference for GetCustomDomainAssociation Operation</seealso>
        public virtual IAsyncResult BeginGetCustomDomainAssociation(GetCustomDomainAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCustomDomainAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCustomDomainAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCustomDomainAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCustomDomainAssociation.</param>
        /// 
        /// <returns>Returns a  GetCustomDomainAssociationResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetCustomDomainAssociation">REST API Reference for GetCustomDomainAssociation Operation</seealso>
        public virtual GetCustomDomainAssociationResponse EndGetCustomDomainAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCustomDomainAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetEndpointAccess

        /// <summary>
        /// Returns information, such as the name, about a VPC endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEndpointAccess service method.</param>
        /// 
        /// <returns>The response from the GetEndpointAccess service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetEndpointAccess">REST API Reference for GetEndpointAccess Operation</seealso>
        public virtual GetEndpointAccessResponse GetEndpointAccess(GetEndpointAccessRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEndpointAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEndpointAccessResponseUnmarshaller.Instance;

            return Invoke<GetEndpointAccessResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetEndpointAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEndpointAccess operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEndpointAccess
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetEndpointAccess">REST API Reference for GetEndpointAccess Operation</seealso>
        public virtual IAsyncResult BeginGetEndpointAccess(GetEndpointAccessRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEndpointAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEndpointAccessResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetEndpointAccess operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEndpointAccess.</param>
        /// 
        /// <returns>Returns a  GetEndpointAccessResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetEndpointAccess">REST API Reference for GetEndpointAccess Operation</seealso>
        public virtual GetEndpointAccessResponse EndGetEndpointAccess(IAsyncResult asyncResult)
        {
            return EndInvoke<GetEndpointAccessResponse>(asyncResult);
        }

        #endregion
        
        #region  GetNamespace

        /// <summary>
        /// Returns information about a namespace in Amazon Redshift Serverless.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNamespace service method.</param>
        /// 
        /// <returns>The response from the GetNamespace service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetNamespace">REST API Reference for GetNamespace Operation</seealso>
        public virtual GetNamespaceResponse GetNamespace(GetNamespaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNamespaceResponseUnmarshaller.Instance;

            return Invoke<GetNamespaceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetNamespace operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetNamespace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetNamespace">REST API Reference for GetNamespace Operation</seealso>
        public virtual IAsyncResult BeginGetNamespace(GetNamespaceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNamespaceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetNamespace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetNamespace.</param>
        /// 
        /// <returns>Returns a  GetNamespaceResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetNamespace">REST API Reference for GetNamespace Operation</seealso>
        public virtual GetNamespaceResponse EndGetNamespace(IAsyncResult asyncResult)
        {
            return EndInvoke<GetNamespaceResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRecoveryPoint

        /// <summary>
        /// Returns information about a recovery point.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRecoveryPoint service method.</param>
        /// 
        /// <returns>The response from the GetRecoveryPoint service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetRecoveryPoint">REST API Reference for GetRecoveryPoint Operation</seealso>
        public virtual GetRecoveryPointResponse GetRecoveryPoint(GetRecoveryPointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRecoveryPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecoveryPointResponseUnmarshaller.Instance;

            return Invoke<GetRecoveryPointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRecoveryPoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRecoveryPoint operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRecoveryPoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetRecoveryPoint">REST API Reference for GetRecoveryPoint Operation</seealso>
        public virtual IAsyncResult BeginGetRecoveryPoint(GetRecoveryPointRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRecoveryPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecoveryPointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRecoveryPoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRecoveryPoint.</param>
        /// 
        /// <returns>Returns a  GetRecoveryPointResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetRecoveryPoint">REST API Reference for GetRecoveryPoint Operation</seealso>
        public virtual GetRecoveryPointResponse EndGetRecoveryPoint(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRecoveryPointResponse>(asyncResult);
        }

        #endregion
        
        #region  GetResourcePolicy

        /// <summary>
        /// Returns a resource policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the GetResourcePolicy service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        public virtual GetResourcePolicyResponse GetResourcePolicy(GetResourcePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<GetResourcePolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        public virtual IAsyncResult BeginGetResourcePolicy(GetResourcePolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResourcePolicy.</param>
        /// 
        /// <returns>Returns a  GetResourcePolicyResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        public virtual GetResourcePolicyResponse EndGetResourcePolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<GetResourcePolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  GetScheduledAction

        /// <summary>
        /// Returns information about a scheduled action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetScheduledAction service method.</param>
        /// 
        /// <returns>The response from the GetScheduledAction service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetScheduledAction">REST API Reference for GetScheduledAction Operation</seealso>
        public virtual GetScheduledActionResponse GetScheduledAction(GetScheduledActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetScheduledActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetScheduledActionResponseUnmarshaller.Instance;

            return Invoke<GetScheduledActionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetScheduledAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetScheduledAction operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetScheduledAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetScheduledAction">REST API Reference for GetScheduledAction Operation</seealso>
        public virtual IAsyncResult BeginGetScheduledAction(GetScheduledActionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetScheduledActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetScheduledActionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetScheduledAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetScheduledAction.</param>
        /// 
        /// <returns>Returns a  GetScheduledActionResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetScheduledAction">REST API Reference for GetScheduledAction Operation</seealso>
        public virtual GetScheduledActionResponse EndGetScheduledAction(IAsyncResult asyncResult)
        {
            return EndInvoke<GetScheduledActionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSnapshot

        /// <summary>
        /// Returns information about a specific snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSnapshot service method.</param>
        /// 
        /// <returns>The response from the GetSnapshot service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetSnapshot">REST API Reference for GetSnapshot Operation</seealso>
        public virtual GetSnapshotResponse GetSnapshot(GetSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSnapshotResponseUnmarshaller.Instance;

            return Invoke<GetSnapshotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSnapshot operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetSnapshot">REST API Reference for GetSnapshot Operation</seealso>
        public virtual IAsyncResult BeginGetSnapshot(GetSnapshotRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSnapshotResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSnapshot.</param>
        /// 
        /// <returns>Returns a  GetSnapshotResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetSnapshot">REST API Reference for GetSnapshot Operation</seealso>
        public virtual GetSnapshotResponse EndGetSnapshot(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSnapshotResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTableRestoreStatus

        /// <summary>
        /// Returns information about a <c>TableRestoreStatus</c> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTableRestoreStatus service method.</param>
        /// 
        /// <returns>The response from the GetTableRestoreStatus service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetTableRestoreStatus">REST API Reference for GetTableRestoreStatus Operation</seealso>
        public virtual GetTableRestoreStatusResponse GetTableRestoreStatus(GetTableRestoreStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTableRestoreStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTableRestoreStatusResponseUnmarshaller.Instance;

            return Invoke<GetTableRestoreStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTableRestoreStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTableRestoreStatus operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTableRestoreStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetTableRestoreStatus">REST API Reference for GetTableRestoreStatus Operation</seealso>
        public virtual IAsyncResult BeginGetTableRestoreStatus(GetTableRestoreStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTableRestoreStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTableRestoreStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTableRestoreStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTableRestoreStatus.</param>
        /// 
        /// <returns>Returns a  GetTableRestoreStatusResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetTableRestoreStatus">REST API Reference for GetTableRestoreStatus Operation</seealso>
        public virtual GetTableRestoreStatusResponse EndGetTableRestoreStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTableRestoreStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTrack

        /// <summary>
        /// Get the Redshift Serverless version for a specified track.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTrack service method.</param>
        /// 
        /// <returns>The response from the GetTrack service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetTrack">REST API Reference for GetTrack Operation</seealso>
        public virtual GetTrackResponse GetTrack(GetTrackRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTrackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTrackResponseUnmarshaller.Instance;

            return Invoke<GetTrackResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTrack operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTrack operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTrack
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetTrack">REST API Reference for GetTrack Operation</seealso>
        public virtual IAsyncResult BeginGetTrack(GetTrackRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTrackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTrackResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTrack operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTrack.</param>
        /// 
        /// <returns>Returns a  GetTrackResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetTrack">REST API Reference for GetTrack Operation</seealso>
        public virtual GetTrackResponse EndGetTrack(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTrackResponse>(asyncResult);
        }

        #endregion
        
        #region  GetUsageLimit

        /// <summary>
        /// Returns information about a usage limit.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUsageLimit service method.</param>
        /// 
        /// <returns>The response from the GetUsageLimit service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetUsageLimit">REST API Reference for GetUsageLimit Operation</seealso>
        public virtual GetUsageLimitResponse GetUsageLimit(GetUsageLimitRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUsageLimitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUsageLimitResponseUnmarshaller.Instance;

            return Invoke<GetUsageLimitResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetUsageLimit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUsageLimit operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUsageLimit
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetUsageLimit">REST API Reference for GetUsageLimit Operation</seealso>
        public virtual IAsyncResult BeginGetUsageLimit(GetUsageLimitRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUsageLimitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUsageLimitResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetUsageLimit operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUsageLimit.</param>
        /// 
        /// <returns>Returns a  GetUsageLimitResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetUsageLimit">REST API Reference for GetUsageLimit Operation</seealso>
        public virtual GetUsageLimitResponse EndGetUsageLimit(IAsyncResult asyncResult)
        {
            return EndInvoke<GetUsageLimitResponse>(asyncResult);
        }

        #endregion
        
        #region  GetWorkgroup

        /// <summary>
        /// Returns information about a specific workgroup.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkgroup service method.</param>
        /// 
        /// <returns>The response from the GetWorkgroup service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetWorkgroup">REST API Reference for GetWorkgroup Operation</seealso>
        public virtual GetWorkgroupResponse GetWorkgroup(GetWorkgroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWorkgroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkgroupResponseUnmarshaller.Instance;

            return Invoke<GetWorkgroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetWorkgroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWorkgroup operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWorkgroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetWorkgroup">REST API Reference for GetWorkgroup Operation</seealso>
        public virtual IAsyncResult BeginGetWorkgroup(GetWorkgroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWorkgroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkgroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetWorkgroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWorkgroup.</param>
        /// 
        /// <returns>Returns a  GetWorkgroupResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetWorkgroup">REST API Reference for GetWorkgroup Operation</seealso>
        public virtual GetWorkgroupResponse EndGetWorkgroup(IAsyncResult asyncResult)
        {
            return EndInvoke<GetWorkgroupResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCustomDomainAssociations

        /// <summary>
        /// Lists custom domain associations for Amazon Redshift Serverless.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCustomDomainAssociations service method.</param>
        /// 
        /// <returns>The response from the ListCustomDomainAssociations service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InvalidPaginationException">
        /// The provided pagination token is invalid.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListCustomDomainAssociations">REST API Reference for ListCustomDomainAssociations Operation</seealso>
        public virtual ListCustomDomainAssociationsResponse ListCustomDomainAssociations(ListCustomDomainAssociationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCustomDomainAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCustomDomainAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListCustomDomainAssociationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCustomDomainAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCustomDomainAssociations operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCustomDomainAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListCustomDomainAssociations">REST API Reference for ListCustomDomainAssociations Operation</seealso>
        public virtual IAsyncResult BeginListCustomDomainAssociations(ListCustomDomainAssociationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCustomDomainAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCustomDomainAssociationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCustomDomainAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCustomDomainAssociations.</param>
        /// 
        /// <returns>Returns a  ListCustomDomainAssociationsResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListCustomDomainAssociations">REST API Reference for ListCustomDomainAssociations Operation</seealso>
        public virtual ListCustomDomainAssociationsResponse EndListCustomDomainAssociations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCustomDomainAssociationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListEndpointAccess

        /// <summary>
        /// Returns an array of <c>EndpointAccess</c> objects and relevant information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEndpointAccess service method.</param>
        /// 
        /// <returns>The response from the ListEndpointAccess service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListEndpointAccess">REST API Reference for ListEndpointAccess Operation</seealso>
        public virtual ListEndpointAccessResponse ListEndpointAccess(ListEndpointAccessRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEndpointAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEndpointAccessResponseUnmarshaller.Instance;

            return Invoke<ListEndpointAccessResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListEndpointAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEndpointAccess operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEndpointAccess
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListEndpointAccess">REST API Reference for ListEndpointAccess Operation</seealso>
        public virtual IAsyncResult BeginListEndpointAccess(ListEndpointAccessRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEndpointAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEndpointAccessResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListEndpointAccess operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEndpointAccess.</param>
        /// 
        /// <returns>Returns a  ListEndpointAccessResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListEndpointAccess">REST API Reference for ListEndpointAccess Operation</seealso>
        public virtual ListEndpointAccessResponse EndListEndpointAccess(IAsyncResult asyncResult)
        {
            return EndInvoke<ListEndpointAccessResponse>(asyncResult);
        }

        #endregion
        
        #region  ListManagedWorkgroups

        /// <summary>
        /// Returns information about a list of specified managed workgroups in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListManagedWorkgroups service method.</param>
        /// 
        /// <returns>The response from the ListManagedWorkgroups service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListManagedWorkgroups">REST API Reference for ListManagedWorkgroups Operation</seealso>
        public virtual ListManagedWorkgroupsResponse ListManagedWorkgroups(ListManagedWorkgroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListManagedWorkgroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListManagedWorkgroupsResponseUnmarshaller.Instance;

            return Invoke<ListManagedWorkgroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListManagedWorkgroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListManagedWorkgroups operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListManagedWorkgroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListManagedWorkgroups">REST API Reference for ListManagedWorkgroups Operation</seealso>
        public virtual IAsyncResult BeginListManagedWorkgroups(ListManagedWorkgroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListManagedWorkgroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListManagedWorkgroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListManagedWorkgroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListManagedWorkgroups.</param>
        /// 
        /// <returns>Returns a  ListManagedWorkgroupsResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListManagedWorkgroups">REST API Reference for ListManagedWorkgroups Operation</seealso>
        public virtual ListManagedWorkgroupsResponse EndListManagedWorkgroups(IAsyncResult asyncResult)
        {
            return EndInvoke<ListManagedWorkgroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListNamespaces

        /// <summary>
        /// Returns information about a list of specified namespaces.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNamespaces service method.</param>
        /// 
        /// <returns>The response from the ListNamespaces service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListNamespaces">REST API Reference for ListNamespaces Operation</seealso>
        public virtual ListNamespacesResponse ListNamespaces(ListNamespacesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNamespacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNamespacesResponseUnmarshaller.Instance;

            return Invoke<ListNamespacesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListNamespaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListNamespaces operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListNamespaces
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListNamespaces">REST API Reference for ListNamespaces Operation</seealso>
        public virtual IAsyncResult BeginListNamespaces(ListNamespacesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNamespacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNamespacesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListNamespaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListNamespaces.</param>
        /// 
        /// <returns>Returns a  ListNamespacesResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListNamespaces">REST API Reference for ListNamespaces Operation</seealso>
        public virtual ListNamespacesResponse EndListNamespaces(IAsyncResult asyncResult)
        {
            return EndInvoke<ListNamespacesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRecoveryPoints

        /// <summary>
        /// Returns an array of recovery points.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecoveryPoints service method.</param>
        /// 
        /// <returns>The response from the ListRecoveryPoints service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListRecoveryPoints">REST API Reference for ListRecoveryPoints Operation</seealso>
        public virtual ListRecoveryPointsResponse ListRecoveryPoints(ListRecoveryPointsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRecoveryPointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecoveryPointsResponseUnmarshaller.Instance;

            return Invoke<ListRecoveryPointsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRecoveryPoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRecoveryPoints operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRecoveryPoints
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListRecoveryPoints">REST API Reference for ListRecoveryPoints Operation</seealso>
        public virtual IAsyncResult BeginListRecoveryPoints(ListRecoveryPointsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRecoveryPointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecoveryPointsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRecoveryPoints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRecoveryPoints.</param>
        /// 
        /// <returns>Returns a  ListRecoveryPointsResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListRecoveryPoints">REST API Reference for ListRecoveryPoints Operation</seealso>
        public virtual ListRecoveryPointsResponse EndListRecoveryPoints(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRecoveryPointsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListScheduledActions

        /// <summary>
        /// Returns a list of scheduled actions. You can use the flags to filter the list of returned
        /// scheduled actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListScheduledActions service method.</param>
        /// 
        /// <returns>The response from the ListScheduledActions service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InvalidPaginationException">
        /// The provided pagination token is invalid.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListScheduledActions">REST API Reference for ListScheduledActions Operation</seealso>
        public virtual ListScheduledActionsResponse ListScheduledActions(ListScheduledActionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListScheduledActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListScheduledActionsResponseUnmarshaller.Instance;

            return Invoke<ListScheduledActionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListScheduledActions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListScheduledActions operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListScheduledActions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListScheduledActions">REST API Reference for ListScheduledActions Operation</seealso>
        public virtual IAsyncResult BeginListScheduledActions(ListScheduledActionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListScheduledActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListScheduledActionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListScheduledActions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListScheduledActions.</param>
        /// 
        /// <returns>Returns a  ListScheduledActionsResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListScheduledActions">REST API Reference for ListScheduledActions Operation</seealso>
        public virtual ListScheduledActionsResponse EndListScheduledActions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListScheduledActionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSnapshotCopyConfigurations

        /// <summary>
        /// Returns a list of snapshot copy configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSnapshotCopyConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListSnapshotCopyConfigurations service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InvalidPaginationException">
        /// The provided pagination token is invalid.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListSnapshotCopyConfigurations">REST API Reference for ListSnapshotCopyConfigurations Operation</seealso>
        public virtual ListSnapshotCopyConfigurationsResponse ListSnapshotCopyConfigurations(ListSnapshotCopyConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSnapshotCopyConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSnapshotCopyConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListSnapshotCopyConfigurationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSnapshotCopyConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSnapshotCopyConfigurations operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSnapshotCopyConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListSnapshotCopyConfigurations">REST API Reference for ListSnapshotCopyConfigurations Operation</seealso>
        public virtual IAsyncResult BeginListSnapshotCopyConfigurations(ListSnapshotCopyConfigurationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSnapshotCopyConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSnapshotCopyConfigurationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSnapshotCopyConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSnapshotCopyConfigurations.</param>
        /// 
        /// <returns>Returns a  ListSnapshotCopyConfigurationsResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListSnapshotCopyConfigurations">REST API Reference for ListSnapshotCopyConfigurations Operation</seealso>
        public virtual ListSnapshotCopyConfigurationsResponse EndListSnapshotCopyConfigurations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSnapshotCopyConfigurationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSnapshots

        /// <summary>
        /// Returns a list of snapshots.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSnapshots service method.</param>
        /// 
        /// <returns>The response from the ListSnapshots service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListSnapshots">REST API Reference for ListSnapshots Operation</seealso>
        public virtual ListSnapshotsResponse ListSnapshots(ListSnapshotsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSnapshotsResponseUnmarshaller.Instance;

            return Invoke<ListSnapshotsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSnapshots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSnapshots operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSnapshots
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListSnapshots">REST API Reference for ListSnapshots Operation</seealso>
        public virtual IAsyncResult BeginListSnapshots(ListSnapshotsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSnapshotsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSnapshots operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSnapshots.</param>
        /// 
        /// <returns>Returns a  ListSnapshotsResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListSnapshots">REST API Reference for ListSnapshots Operation</seealso>
        public virtual ListSnapshotsResponse EndListSnapshots(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSnapshotsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTableRestoreStatus

        /// <summary>
        /// Returns information about an array of <c>TableRestoreStatus</c> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTableRestoreStatus service method.</param>
        /// 
        /// <returns>The response from the ListTableRestoreStatus service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.InvalidPaginationException">
        /// The provided pagination token is invalid.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListTableRestoreStatus">REST API Reference for ListTableRestoreStatus Operation</seealso>
        public virtual ListTableRestoreStatusResponse ListTableRestoreStatus(ListTableRestoreStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTableRestoreStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTableRestoreStatusResponseUnmarshaller.Instance;

            return Invoke<ListTableRestoreStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTableRestoreStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTableRestoreStatus operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTableRestoreStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListTableRestoreStatus">REST API Reference for ListTableRestoreStatus Operation</seealso>
        public virtual IAsyncResult BeginListTableRestoreStatus(ListTableRestoreStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTableRestoreStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTableRestoreStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTableRestoreStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTableRestoreStatus.</param>
        /// 
        /// <returns>Returns a  ListTableRestoreStatusResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListTableRestoreStatus">REST API Reference for ListTableRestoreStatus Operation</seealso>
        public virtual ListTableRestoreStatusResponse EndListTableRestoreStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTableRestoreStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists the tags assigned to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTracks

        /// <summary>
        /// List the Amazon Redshift Serverless versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTracks service method.</param>
        /// 
        /// <returns>The response from the ListTracks service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InvalidPaginationException">
        /// The provided pagination token is invalid.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListTracks">REST API Reference for ListTracks Operation</seealso>
        public virtual ListTracksResponse ListTracks(ListTracksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTracksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTracksResponseUnmarshaller.Instance;

            return Invoke<ListTracksResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTracks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTracks operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTracks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListTracks">REST API Reference for ListTracks Operation</seealso>
        public virtual IAsyncResult BeginListTracks(ListTracksRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTracksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTracksResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTracks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTracks.</param>
        /// 
        /// <returns>Returns a  ListTracksResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListTracks">REST API Reference for ListTracks Operation</seealso>
        public virtual ListTracksResponse EndListTracks(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTracksResponse>(asyncResult);
        }

        #endregion
        
        #region  ListUsageLimits

        /// <summary>
        /// Lists all usage limits within Amazon Redshift Serverless.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUsageLimits service method.</param>
        /// 
        /// <returns>The response from the ListUsageLimits service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InvalidPaginationException">
        /// The provided pagination token is invalid.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListUsageLimits">REST API Reference for ListUsageLimits Operation</seealso>
        public virtual ListUsageLimitsResponse ListUsageLimits(ListUsageLimitsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUsageLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUsageLimitsResponseUnmarshaller.Instance;

            return Invoke<ListUsageLimitsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListUsageLimits operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUsageLimits operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListUsageLimits
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListUsageLimits">REST API Reference for ListUsageLimits Operation</seealso>
        public virtual IAsyncResult BeginListUsageLimits(ListUsageLimitsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUsageLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUsageLimitsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListUsageLimits operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUsageLimits.</param>
        /// 
        /// <returns>Returns a  ListUsageLimitsResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListUsageLimits">REST API Reference for ListUsageLimits Operation</seealso>
        public virtual ListUsageLimitsResponse EndListUsageLimits(IAsyncResult asyncResult)
        {
            return EndInvoke<ListUsageLimitsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListWorkgroups

        /// <summary>
        /// Returns information about a list of specified workgroups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkgroups service method.</param>
        /// 
        /// <returns>The response from the ListWorkgroups service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListWorkgroups">REST API Reference for ListWorkgroups Operation</seealso>
        public virtual ListWorkgroupsResponse ListWorkgroups(ListWorkgroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWorkgroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkgroupsResponseUnmarshaller.Instance;

            return Invoke<ListWorkgroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListWorkgroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWorkgroups operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWorkgroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListWorkgroups">REST API Reference for ListWorkgroups Operation</seealso>
        public virtual IAsyncResult BeginListWorkgroups(ListWorkgroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWorkgroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkgroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListWorkgroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWorkgroups.</param>
        /// 
        /// <returns>Returns a  ListWorkgroupsResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListWorkgroups">REST API Reference for ListWorkgroups Operation</seealso>
        public virtual ListWorkgroupsResponse EndListWorkgroups(IAsyncResult asyncResult)
        {
            return EndInvoke<ListWorkgroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  PutResourcePolicy

        /// <summary>
        /// Creates or updates a resource policy. Currently, you can use policies to share snapshots
        /// across Amazon Web Services accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the PutResourcePolicy service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ServiceQuotaExceededException">
        /// The service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        public virtual PutResourcePolicyResponse PutResourcePolicy(PutResourcePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<PutResourcePolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        public virtual IAsyncResult BeginPutResourcePolicy(PutResourcePolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutResourcePolicy.</param>
        /// 
        /// <returns>Returns a  PutResourcePolicyResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        public virtual PutResourcePolicyResponse EndPutResourcePolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<PutResourcePolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  RestoreFromRecoveryPoint

        /// <summary>
        /// Restore the data from a recovery point.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreFromRecoveryPoint service method.</param>
        /// 
        /// <returns>The response from the RestoreFromRecoveryPoint service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/RestoreFromRecoveryPoint">REST API Reference for RestoreFromRecoveryPoint Operation</seealso>
        public virtual RestoreFromRecoveryPointResponse RestoreFromRecoveryPoint(RestoreFromRecoveryPointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreFromRecoveryPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreFromRecoveryPointResponseUnmarshaller.Instance;

            return Invoke<RestoreFromRecoveryPointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RestoreFromRecoveryPoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreFromRecoveryPoint operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRestoreFromRecoveryPoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/RestoreFromRecoveryPoint">REST API Reference for RestoreFromRecoveryPoint Operation</seealso>
        public virtual IAsyncResult BeginRestoreFromRecoveryPoint(RestoreFromRecoveryPointRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreFromRecoveryPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreFromRecoveryPointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RestoreFromRecoveryPoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRestoreFromRecoveryPoint.</param>
        /// 
        /// <returns>Returns a  RestoreFromRecoveryPointResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/RestoreFromRecoveryPoint">REST API Reference for RestoreFromRecoveryPoint Operation</seealso>
        public virtual RestoreFromRecoveryPointResponse EndRestoreFromRecoveryPoint(IAsyncResult asyncResult)
        {
            return EndInvoke<RestoreFromRecoveryPointResponse>(asyncResult);
        }

        #endregion
        
        #region  RestoreFromSnapshot

        /// <summary>
        /// Restores a namespace from a snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreFromSnapshot service method.</param>
        /// 
        /// <returns>The response from the RestoreFromSnapshot service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ServiceQuotaExceededException">
        /// The service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/RestoreFromSnapshot">REST API Reference for RestoreFromSnapshot Operation</seealso>
        public virtual RestoreFromSnapshotResponse RestoreFromSnapshot(RestoreFromSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreFromSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreFromSnapshotResponseUnmarshaller.Instance;

            return Invoke<RestoreFromSnapshotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RestoreFromSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreFromSnapshot operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRestoreFromSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/RestoreFromSnapshot">REST API Reference for RestoreFromSnapshot Operation</seealso>
        public virtual IAsyncResult BeginRestoreFromSnapshot(RestoreFromSnapshotRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreFromSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreFromSnapshotResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RestoreFromSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRestoreFromSnapshot.</param>
        /// 
        /// <returns>Returns a  RestoreFromSnapshotResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/RestoreFromSnapshot">REST API Reference for RestoreFromSnapshot Operation</seealso>
        public virtual RestoreFromSnapshotResponse EndRestoreFromSnapshot(IAsyncResult asyncResult)
        {
            return EndInvoke<RestoreFromSnapshotResponse>(asyncResult);
        }

        #endregion
        
        #region  RestoreTableFromRecoveryPoint

        /// <summary>
        /// Restores a table from a recovery point to your Amazon Redshift Serverless instance.
        /// You can't use this operation to restore tables with interleaved sort keys.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreTableFromRecoveryPoint service method.</param>
        /// 
        /// <returns>The response from the RestoreTableFromRecoveryPoint service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/RestoreTableFromRecoveryPoint">REST API Reference for RestoreTableFromRecoveryPoint Operation</seealso>
        public virtual RestoreTableFromRecoveryPointResponse RestoreTableFromRecoveryPoint(RestoreTableFromRecoveryPointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreTableFromRecoveryPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreTableFromRecoveryPointResponseUnmarshaller.Instance;

            return Invoke<RestoreTableFromRecoveryPointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RestoreTableFromRecoveryPoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreTableFromRecoveryPoint operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRestoreTableFromRecoveryPoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/RestoreTableFromRecoveryPoint">REST API Reference for RestoreTableFromRecoveryPoint Operation</seealso>
        public virtual IAsyncResult BeginRestoreTableFromRecoveryPoint(RestoreTableFromRecoveryPointRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreTableFromRecoveryPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreTableFromRecoveryPointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RestoreTableFromRecoveryPoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRestoreTableFromRecoveryPoint.</param>
        /// 
        /// <returns>Returns a  RestoreTableFromRecoveryPointResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/RestoreTableFromRecoveryPoint">REST API Reference for RestoreTableFromRecoveryPoint Operation</seealso>
        public virtual RestoreTableFromRecoveryPointResponse EndRestoreTableFromRecoveryPoint(IAsyncResult asyncResult)
        {
            return EndInvoke<RestoreTableFromRecoveryPointResponse>(asyncResult);
        }

        #endregion
        
        #region  RestoreTableFromSnapshot

        /// <summary>
        /// Restores a table from a snapshot to your Amazon Redshift Serverless instance. You
        /// can't use this operation to restore tables with <a href="https://docs.aws.amazon.com/redshift/latest/dg/t_Sorting_data.html#t_Sorting_data-interleaved">interleaved
        /// sort keys</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreTableFromSnapshot service method.</param>
        /// 
        /// <returns>The response from the RestoreTableFromSnapshot service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/RestoreTableFromSnapshot">REST API Reference for RestoreTableFromSnapshot Operation</seealso>
        public virtual RestoreTableFromSnapshotResponse RestoreTableFromSnapshot(RestoreTableFromSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreTableFromSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreTableFromSnapshotResponseUnmarshaller.Instance;

            return Invoke<RestoreTableFromSnapshotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RestoreTableFromSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreTableFromSnapshot operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRestoreTableFromSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/RestoreTableFromSnapshot">REST API Reference for RestoreTableFromSnapshot Operation</seealso>
        public virtual IAsyncResult BeginRestoreTableFromSnapshot(RestoreTableFromSnapshotRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreTableFromSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreTableFromSnapshotResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RestoreTableFromSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRestoreTableFromSnapshot.</param>
        /// 
        /// <returns>Returns a  RestoreTableFromSnapshotResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/RestoreTableFromSnapshot">REST API Reference for RestoreTableFromSnapshot Operation</seealso>
        public virtual RestoreTableFromSnapshotResponse EndRestoreTableFromSnapshot(IAsyncResult asyncResult)
        {
            return EndInvoke<RestoreTableFromSnapshotResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Assigns one or more tags to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.TooManyTagsException">
        /// The request exceeded the number of tags allowed for a resource.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes a tag or set of tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateCustomDomainAssociation

        /// <summary>
        /// Updates an Amazon Redshift Serverless certificate associated with a custom domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCustomDomainAssociation service method.</param>
        /// 
        /// <returns>The response from the UpdateCustomDomainAssociation service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/UpdateCustomDomainAssociation">REST API Reference for UpdateCustomDomainAssociation Operation</seealso>
        public virtual UpdateCustomDomainAssociationResponse UpdateCustomDomainAssociation(UpdateCustomDomainAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCustomDomainAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCustomDomainAssociationResponseUnmarshaller.Instance;

            return Invoke<UpdateCustomDomainAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCustomDomainAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCustomDomainAssociation operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCustomDomainAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/UpdateCustomDomainAssociation">REST API Reference for UpdateCustomDomainAssociation Operation</seealso>
        public virtual IAsyncResult BeginUpdateCustomDomainAssociation(UpdateCustomDomainAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCustomDomainAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCustomDomainAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCustomDomainAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCustomDomainAssociation.</param>
        /// 
        /// <returns>Returns a  UpdateCustomDomainAssociationResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/UpdateCustomDomainAssociation">REST API Reference for UpdateCustomDomainAssociation Operation</seealso>
        public virtual UpdateCustomDomainAssociationResponse EndUpdateCustomDomainAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateCustomDomainAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateEndpointAccess

        /// <summary>
        /// Updates an Amazon Redshift Serverless managed endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEndpointAccess service method.</param>
        /// 
        /// <returns>The response from the UpdateEndpointAccess service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/UpdateEndpointAccess">REST API Reference for UpdateEndpointAccess Operation</seealso>
        public virtual UpdateEndpointAccessResponse UpdateEndpointAccess(UpdateEndpointAccessRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEndpointAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEndpointAccessResponseUnmarshaller.Instance;

            return Invoke<UpdateEndpointAccessResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEndpointAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEndpointAccess operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEndpointAccess
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/UpdateEndpointAccess">REST API Reference for UpdateEndpointAccess Operation</seealso>
        public virtual IAsyncResult BeginUpdateEndpointAccess(UpdateEndpointAccessRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEndpointAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEndpointAccessResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEndpointAccess operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEndpointAccess.</param>
        /// 
        /// <returns>Returns a  UpdateEndpointAccessResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/UpdateEndpointAccess">REST API Reference for UpdateEndpointAccess Operation</seealso>
        public virtual UpdateEndpointAccessResponse EndUpdateEndpointAccess(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateEndpointAccessResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateNamespace

        /// <summary>
        /// Updates a namespace with the specified settings. Unless required, you can't update
        /// multiple parameters in one request. For example, you must specify both <c>adminUsername</c>
        /// and <c>adminUserPassword</c> to update either field, but you can't update both <c>kmsKeyId</c>
        /// and <c>logExports</c> in a single request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNamespace service method.</param>
        /// 
        /// <returns>The response from the UpdateNamespace service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/UpdateNamespace">REST API Reference for UpdateNamespace Operation</seealso>
        public virtual UpdateNamespaceResponse UpdateNamespace(UpdateNamespaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNamespaceResponseUnmarshaller.Instance;

            return Invoke<UpdateNamespaceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateNamespace operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateNamespace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/UpdateNamespace">REST API Reference for UpdateNamespace Operation</seealso>
        public virtual IAsyncResult BeginUpdateNamespace(UpdateNamespaceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNamespaceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateNamespace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateNamespace.</param>
        /// 
        /// <returns>Returns a  UpdateNamespaceResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/UpdateNamespace">REST API Reference for UpdateNamespace Operation</seealso>
        public virtual UpdateNamespaceResponse EndUpdateNamespace(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateNamespaceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateScheduledAction

        /// <summary>
        /// Updates a scheduled action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateScheduledAction service method.</param>
        /// 
        /// <returns>The response from the UpdateScheduledAction service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/UpdateScheduledAction">REST API Reference for UpdateScheduledAction Operation</seealso>
        public virtual UpdateScheduledActionResponse UpdateScheduledAction(UpdateScheduledActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateScheduledActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateScheduledActionResponseUnmarshaller.Instance;

            return Invoke<UpdateScheduledActionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateScheduledAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateScheduledAction operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateScheduledAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/UpdateScheduledAction">REST API Reference for UpdateScheduledAction Operation</seealso>
        public virtual IAsyncResult BeginUpdateScheduledAction(UpdateScheduledActionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateScheduledActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateScheduledActionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateScheduledAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateScheduledAction.</param>
        /// 
        /// <returns>Returns a  UpdateScheduledActionResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/UpdateScheduledAction">REST API Reference for UpdateScheduledAction Operation</seealso>
        public virtual UpdateScheduledActionResponse EndUpdateScheduledAction(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateScheduledActionResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateSnapshot

        /// <summary>
        /// Updates a snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSnapshot service method.</param>
        /// 
        /// <returns>The response from the UpdateSnapshot service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/UpdateSnapshot">REST API Reference for UpdateSnapshot Operation</seealso>
        public virtual UpdateSnapshotResponse UpdateSnapshot(UpdateSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSnapshotResponseUnmarshaller.Instance;

            return Invoke<UpdateSnapshotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSnapshot operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/UpdateSnapshot">REST API Reference for UpdateSnapshot Operation</seealso>
        public virtual IAsyncResult BeginUpdateSnapshot(UpdateSnapshotRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSnapshotResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSnapshot.</param>
        /// 
        /// <returns>Returns a  UpdateSnapshotResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/UpdateSnapshot">REST API Reference for UpdateSnapshot Operation</seealso>
        public virtual UpdateSnapshotResponse EndUpdateSnapshot(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSnapshotResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateSnapshotCopyConfiguration

        /// <summary>
        /// Updates a snapshot copy configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSnapshotCopyConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateSnapshotCopyConfiguration service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/UpdateSnapshotCopyConfiguration">REST API Reference for UpdateSnapshotCopyConfiguration Operation</seealso>
        public virtual UpdateSnapshotCopyConfigurationResponse UpdateSnapshotCopyConfiguration(UpdateSnapshotCopyConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSnapshotCopyConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSnapshotCopyConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateSnapshotCopyConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSnapshotCopyConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSnapshotCopyConfiguration operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSnapshotCopyConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/UpdateSnapshotCopyConfiguration">REST API Reference for UpdateSnapshotCopyConfiguration Operation</seealso>
        public virtual IAsyncResult BeginUpdateSnapshotCopyConfiguration(UpdateSnapshotCopyConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSnapshotCopyConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSnapshotCopyConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSnapshotCopyConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSnapshotCopyConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateSnapshotCopyConfigurationResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/UpdateSnapshotCopyConfiguration">REST API Reference for UpdateSnapshotCopyConfiguration Operation</seealso>
        public virtual UpdateSnapshotCopyConfigurationResponse EndUpdateSnapshotCopyConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSnapshotCopyConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateUsageLimit

        /// <summary>
        /// Update a usage limit in Amazon Redshift Serverless. You can't update the usage type
        /// or period of a usage limit.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUsageLimit service method.</param>
        /// 
        /// <returns>The response from the UpdateUsageLimit service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/UpdateUsageLimit">REST API Reference for UpdateUsageLimit Operation</seealso>
        public virtual UpdateUsageLimitResponse UpdateUsageLimit(UpdateUsageLimitRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUsageLimitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUsageLimitResponseUnmarshaller.Instance;

            return Invoke<UpdateUsageLimitResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUsageLimit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUsageLimit operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateUsageLimit
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/UpdateUsageLimit">REST API Reference for UpdateUsageLimit Operation</seealso>
        public virtual IAsyncResult BeginUpdateUsageLimit(UpdateUsageLimitRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUsageLimitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUsageLimitResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateUsageLimit operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUsageLimit.</param>
        /// 
        /// <returns>Returns a  UpdateUsageLimitResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/UpdateUsageLimit">REST API Reference for UpdateUsageLimit Operation</seealso>
        public virtual UpdateUsageLimitResponse EndUpdateUsageLimit(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateUsageLimitResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateWorkgroup

        /// <summary>
        /// Updates a workgroup with the specified configuration settings. You can't update multiple
        /// parameters in one request. For example, you can update <c>baseCapacity</c> or <c>port</c>
        /// in a single request, but you can't update both in the same request.
        /// 
        ///  
        /// <para>
        /// VPC Block Public Access (BPA) enables you to block resources in VPCs and subnets that
        /// you own in a Region from reaching or being reached from the internet through internet
        /// gateways and egress-only internet gateways. If a workgroup is in an account with VPC
        /// BPA turned on, the following capabilities are blocked: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Creating a public access workgroup
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Modifying a private workgroup to public
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Adding a subnet with VPC BPA turned on to the workgroup when the workgroup is public
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about VPC BPA, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/security-vpc-bpa.html">Block
        /// public access to VPCs and subnets</a> in the <i>Amazon VPC User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkgroup service method.</param>
        /// 
        /// <returns>The response from the UpdateWorkgroup service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InsufficientCapacityException">
        /// There is an insufficient capacity to perform the action.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.Ipv6CidrBlockNotFoundException">
        /// There are no subnets in your VPC with associated IPv6 CIDR blocks. To use dual-stack
        /// mode, associate an IPv6 CIDR block with each subnet in your VPC.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/UpdateWorkgroup">REST API Reference for UpdateWorkgroup Operation</seealso>
        public virtual UpdateWorkgroupResponse UpdateWorkgroup(UpdateWorkgroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWorkgroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkgroupResponseUnmarshaller.Instance;

            return Invoke<UpdateWorkgroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateWorkgroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkgroup operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateWorkgroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/UpdateWorkgroup">REST API Reference for UpdateWorkgroup Operation</seealso>
        public virtual IAsyncResult BeginUpdateWorkgroup(UpdateWorkgroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWorkgroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkgroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWorkgroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWorkgroup.</param>
        /// 
        /// <returns>Returns a  UpdateWorkgroupResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/UpdateWorkgroup">REST API Reference for UpdateWorkgroup Operation</seealso>
        public virtual UpdateWorkgroupResponse EndUpdateWorkgroup(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateWorkgroupResponse>(asyncResult);
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
            var resolver = new AmazonRedshiftServerlessEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}