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
 * Do not modify this file. This file is generated from the route53-recovery-readiness-2019-12-02.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.Route53RecoveryReadiness.Model;
using Amazon.Route53RecoveryReadiness.Model.Internal.MarshallTransformations;
using Amazon.Route53RecoveryReadiness.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.Route53RecoveryReadiness
{
    /// <summary>
    /// <para>Implementation for accessing Route53RecoveryReadiness</para>
    ///
    /// Recovery readiness
    /// </summary>
    public partial class AmazonRoute53RecoveryReadinessClient : AmazonServiceClient, IAmazonRoute53RecoveryReadiness
    {
        private static IServiceMetadata serviceMetadata = new AmazonRoute53RecoveryReadinessMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IRoute53RecoveryReadinessPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IRoute53RecoveryReadinessPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new Route53RecoveryReadinessPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonRoute53RecoveryReadinessClient with the credentials loaded from the application's
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
        public AmazonRoute53RecoveryReadinessClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRoute53RecoveryReadinessConfig()) { }

        /// <summary>
        /// Constructs AmazonRoute53RecoveryReadinessClient with the credentials loaded from the application's
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
        public AmazonRoute53RecoveryReadinessClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRoute53RecoveryReadinessConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonRoute53RecoveryReadinessClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonRoute53RecoveryReadinessClient Configuration Object</param>
        public AmazonRoute53RecoveryReadinessClient(AmazonRoute53RecoveryReadinessConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonRoute53RecoveryReadinessClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonRoute53RecoveryReadinessClient(AWSCredentials credentials)
            : this(credentials, new AmazonRoute53RecoveryReadinessConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53RecoveryReadinessClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRoute53RecoveryReadinessClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonRoute53RecoveryReadinessConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53RecoveryReadinessClient with AWS Credentials and an
        /// AmazonRoute53RecoveryReadinessClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonRoute53RecoveryReadinessClient Configuration Object</param>
        public AmazonRoute53RecoveryReadinessClient(AWSCredentials credentials, AmazonRoute53RecoveryReadinessConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53RecoveryReadinessClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonRoute53RecoveryReadinessClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRoute53RecoveryReadinessConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53RecoveryReadinessClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRoute53RecoveryReadinessClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRoute53RecoveryReadinessConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53RecoveryReadinessClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRoute53RecoveryReadinessClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonRoute53RecoveryReadinessClient Configuration Object</param>
        public AmazonRoute53RecoveryReadinessClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonRoute53RecoveryReadinessConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53RecoveryReadinessClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonRoute53RecoveryReadinessClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRoute53RecoveryReadinessConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53RecoveryReadinessClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRoute53RecoveryReadinessClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRoute53RecoveryReadinessConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53RecoveryReadinessClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRoute53RecoveryReadinessClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonRoute53RecoveryReadinessClient Configuration Object</param>
        public AmazonRoute53RecoveryReadinessClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonRoute53RecoveryReadinessConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonRoute53RecoveryReadinessEndpointResolver());
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


        #region  CreateCell

        /// <summary>
        /// Creates a cell in an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCell service method.</param>
        /// 
        /// <returns>The response from the CreateCell service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/CreateCell">REST API Reference for CreateCell Operation</seealso>
        public virtual CreateCellResponse CreateCell(CreateCellRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCellRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCellResponseUnmarshaller.Instance;

            return Invoke<CreateCellResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCell operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCell operation on AmazonRoute53RecoveryReadinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCell
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/CreateCell">REST API Reference for CreateCell Operation</seealso>
        public virtual IAsyncResult BeginCreateCell(CreateCellRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCellRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCellResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCell operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCell.</param>
        /// 
        /// <returns>Returns a  CreateCellResult from Route53RecoveryReadiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/CreateCell">REST API Reference for CreateCell Operation</seealso>
        public virtual CreateCellResponse EndCreateCell(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateCellResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateCrossAccountAuthorization

        /// <summary>
        /// Creates a cross-account readiness authorization. This lets you authorize another account
        /// to work with Route 53 Application Recovery Controller, for example, to check the readiness
        /// status of resources in a separate account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCrossAccountAuthorization service method.</param>
        /// 
        /// <returns>The response from the CreateCrossAccountAuthorization service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/CreateCrossAccountAuthorization">REST API Reference for CreateCrossAccountAuthorization Operation</seealso>
        public virtual CreateCrossAccountAuthorizationResponse CreateCrossAccountAuthorization(CreateCrossAccountAuthorizationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCrossAccountAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCrossAccountAuthorizationResponseUnmarshaller.Instance;

            return Invoke<CreateCrossAccountAuthorizationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCrossAccountAuthorization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCrossAccountAuthorization operation on AmazonRoute53RecoveryReadinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCrossAccountAuthorization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/CreateCrossAccountAuthorization">REST API Reference for CreateCrossAccountAuthorization Operation</seealso>
        public virtual IAsyncResult BeginCreateCrossAccountAuthorization(CreateCrossAccountAuthorizationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCrossAccountAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCrossAccountAuthorizationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCrossAccountAuthorization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCrossAccountAuthorization.</param>
        /// 
        /// <returns>Returns a  CreateCrossAccountAuthorizationResult from Route53RecoveryReadiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/CreateCrossAccountAuthorization">REST API Reference for CreateCrossAccountAuthorization Operation</seealso>
        public virtual CreateCrossAccountAuthorizationResponse EndCreateCrossAccountAuthorization(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateCrossAccountAuthorizationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateReadinessCheck

        /// <summary>
        /// Creates a readiness check in an account. A readiness check monitors a resource set
        /// in your application, such as a set of Amazon Aurora instances, that Application Recovery
        /// Controller is auditing recovery readiness for. The audits run once every minute on
        /// every resource that's associated with a readiness check.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReadinessCheck service method.</param>
        /// 
        /// <returns>The response from the CreateReadinessCheck service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/CreateReadinessCheck">REST API Reference for CreateReadinessCheck Operation</seealso>
        public virtual CreateReadinessCheckResponse CreateReadinessCheck(CreateReadinessCheckRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateReadinessCheckRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReadinessCheckResponseUnmarshaller.Instance;

            return Invoke<CreateReadinessCheckResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateReadinessCheck operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReadinessCheck operation on AmazonRoute53RecoveryReadinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateReadinessCheck
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/CreateReadinessCheck">REST API Reference for CreateReadinessCheck Operation</seealso>
        public virtual IAsyncResult BeginCreateReadinessCheck(CreateReadinessCheckRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateReadinessCheckRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReadinessCheckResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateReadinessCheck operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateReadinessCheck.</param>
        /// 
        /// <returns>Returns a  CreateReadinessCheckResult from Route53RecoveryReadiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/CreateReadinessCheck">REST API Reference for CreateReadinessCheck Operation</seealso>
        public virtual CreateReadinessCheckResponse EndCreateReadinessCheck(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateReadinessCheckResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateRecoveryGroup

        /// <summary>
        /// Creates a recovery group in an account. A recovery group corresponds to an application
        /// and includes a list of the cells that make up the application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRecoveryGroup service method.</param>
        /// 
        /// <returns>The response from the CreateRecoveryGroup service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/CreateRecoveryGroup">REST API Reference for CreateRecoveryGroup Operation</seealso>
        public virtual CreateRecoveryGroupResponse CreateRecoveryGroup(CreateRecoveryGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRecoveryGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRecoveryGroupResponseUnmarshaller.Instance;

            return Invoke<CreateRecoveryGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRecoveryGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRecoveryGroup operation on AmazonRoute53RecoveryReadinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRecoveryGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/CreateRecoveryGroup">REST API Reference for CreateRecoveryGroup Operation</seealso>
        public virtual IAsyncResult BeginCreateRecoveryGroup(CreateRecoveryGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRecoveryGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRecoveryGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRecoveryGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRecoveryGroup.</param>
        /// 
        /// <returns>Returns a  CreateRecoveryGroupResult from Route53RecoveryReadiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/CreateRecoveryGroup">REST API Reference for CreateRecoveryGroup Operation</seealso>
        public virtual CreateRecoveryGroupResponse EndCreateRecoveryGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateRecoveryGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateResourceSet

        /// <summary>
        /// Creates a resource set. A resource set is a set of resources of one type that span
        /// multiple cells. You can associate a resource set with a readiness check to monitor
        /// the resources for failover readiness.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResourceSet service method.</param>
        /// 
        /// <returns>The response from the CreateResourceSet service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/CreateResourceSet">REST API Reference for CreateResourceSet Operation</seealso>
        public virtual CreateResourceSetResponse CreateResourceSet(CreateResourceSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateResourceSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateResourceSetResponseUnmarshaller.Instance;

            return Invoke<CreateResourceSetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateResourceSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateResourceSet operation on AmazonRoute53RecoveryReadinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateResourceSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/CreateResourceSet">REST API Reference for CreateResourceSet Operation</seealso>
        public virtual IAsyncResult BeginCreateResourceSet(CreateResourceSetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateResourceSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateResourceSetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateResourceSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateResourceSet.</param>
        /// 
        /// <returns>Returns a  CreateResourceSetResult from Route53RecoveryReadiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/CreateResourceSet">REST API Reference for CreateResourceSet Operation</seealso>
        public virtual CreateResourceSetResponse EndCreateResourceSet(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateResourceSetResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteCell

        /// <summary>
        /// Delete a cell. When successful, the response code is 204, with no response body.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCell service method.</param>
        /// 
        /// <returns>The response from the DeleteCell service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ResourceNotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/DeleteCell">REST API Reference for DeleteCell Operation</seealso>
        public virtual DeleteCellResponse DeleteCell(DeleteCellRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCellRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCellResponseUnmarshaller.Instance;

            return Invoke<DeleteCellResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCell operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCell operation on AmazonRoute53RecoveryReadinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCell
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/DeleteCell">REST API Reference for DeleteCell Operation</seealso>
        public virtual IAsyncResult BeginDeleteCell(DeleteCellRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCellRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCellResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCell operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCell.</param>
        /// 
        /// <returns>Returns a  DeleteCellResult from Route53RecoveryReadiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/DeleteCell">REST API Reference for DeleteCell Operation</seealso>
        public virtual DeleteCellResponse EndDeleteCell(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteCellResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteCrossAccountAuthorization

        /// <summary>
        /// Deletes cross account readiness authorization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCrossAccountAuthorization service method.</param>
        /// 
        /// <returns>The response from the DeleteCrossAccountAuthorization service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/DeleteCrossAccountAuthorization">REST API Reference for DeleteCrossAccountAuthorization Operation</seealso>
        public virtual DeleteCrossAccountAuthorizationResponse DeleteCrossAccountAuthorization(DeleteCrossAccountAuthorizationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCrossAccountAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCrossAccountAuthorizationResponseUnmarshaller.Instance;

            return Invoke<DeleteCrossAccountAuthorizationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCrossAccountAuthorization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCrossAccountAuthorization operation on AmazonRoute53RecoveryReadinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCrossAccountAuthorization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/DeleteCrossAccountAuthorization">REST API Reference for DeleteCrossAccountAuthorization Operation</seealso>
        public virtual IAsyncResult BeginDeleteCrossAccountAuthorization(DeleteCrossAccountAuthorizationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCrossAccountAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCrossAccountAuthorizationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCrossAccountAuthorization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCrossAccountAuthorization.</param>
        /// 
        /// <returns>Returns a  DeleteCrossAccountAuthorizationResult from Route53RecoveryReadiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/DeleteCrossAccountAuthorization">REST API Reference for DeleteCrossAccountAuthorization Operation</seealso>
        public virtual DeleteCrossAccountAuthorizationResponse EndDeleteCrossAccountAuthorization(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteCrossAccountAuthorizationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteReadinessCheck

        /// <summary>
        /// Deletes a readiness check.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReadinessCheck service method.</param>
        /// 
        /// <returns>The response from the DeleteReadinessCheck service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ResourceNotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/DeleteReadinessCheck">REST API Reference for DeleteReadinessCheck Operation</seealso>
        public virtual DeleteReadinessCheckResponse DeleteReadinessCheck(DeleteReadinessCheckRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteReadinessCheckRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReadinessCheckResponseUnmarshaller.Instance;

            return Invoke<DeleteReadinessCheckResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReadinessCheck operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReadinessCheck operation on AmazonRoute53RecoveryReadinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteReadinessCheck
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/DeleteReadinessCheck">REST API Reference for DeleteReadinessCheck Operation</seealso>
        public virtual IAsyncResult BeginDeleteReadinessCheck(DeleteReadinessCheckRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteReadinessCheckRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReadinessCheckResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteReadinessCheck operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteReadinessCheck.</param>
        /// 
        /// <returns>Returns a  DeleteReadinessCheckResult from Route53RecoveryReadiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/DeleteReadinessCheck">REST API Reference for DeleteReadinessCheck Operation</seealso>
        public virtual DeleteReadinessCheckResponse EndDeleteReadinessCheck(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteReadinessCheckResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteRecoveryGroup

        /// <summary>
        /// Deletes a recovery group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRecoveryGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteRecoveryGroup service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ResourceNotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/DeleteRecoveryGroup">REST API Reference for DeleteRecoveryGroup Operation</seealso>
        public virtual DeleteRecoveryGroupResponse DeleteRecoveryGroup(DeleteRecoveryGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRecoveryGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRecoveryGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteRecoveryGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRecoveryGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRecoveryGroup operation on AmazonRoute53RecoveryReadinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRecoveryGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/DeleteRecoveryGroup">REST API Reference for DeleteRecoveryGroup Operation</seealso>
        public virtual IAsyncResult BeginDeleteRecoveryGroup(DeleteRecoveryGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRecoveryGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRecoveryGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRecoveryGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRecoveryGroup.</param>
        /// 
        /// <returns>Returns a  DeleteRecoveryGroupResult from Route53RecoveryReadiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/DeleteRecoveryGroup">REST API Reference for DeleteRecoveryGroup Operation</seealso>
        public virtual DeleteRecoveryGroupResponse EndDeleteRecoveryGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRecoveryGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteResourceSet

        /// <summary>
        /// Deletes a resource set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourceSet service method.</param>
        /// 
        /// <returns>The response from the DeleteResourceSet service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ResourceNotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/DeleteResourceSet">REST API Reference for DeleteResourceSet Operation</seealso>
        public virtual DeleteResourceSetResponse DeleteResourceSet(DeleteResourceSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteResourceSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourceSetResponseUnmarshaller.Instance;

            return Invoke<DeleteResourceSetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteResourceSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourceSet operation on AmazonRoute53RecoveryReadinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteResourceSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/DeleteResourceSet">REST API Reference for DeleteResourceSet Operation</seealso>
        public virtual IAsyncResult BeginDeleteResourceSet(DeleteResourceSetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteResourceSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourceSetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteResourceSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteResourceSet.</param>
        /// 
        /// <returns>Returns a  DeleteResourceSetResult from Route53RecoveryReadiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/DeleteResourceSet">REST API Reference for DeleteResourceSet Operation</seealso>
        public virtual DeleteResourceSetResponse EndDeleteResourceSet(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteResourceSetResponse>(asyncResult);
        }

        #endregion
        
        #region  GetArchitectureRecommendations

        /// <summary>
        /// Gets recommendations about architecture designs for improving resiliency for an application,
        /// based on a recovery group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetArchitectureRecommendations service method.</param>
        /// 
        /// <returns>The response from the GetArchitectureRecommendations service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ResourceNotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/GetArchitectureRecommendations">REST API Reference for GetArchitectureRecommendations Operation</seealso>
        public virtual GetArchitectureRecommendationsResponse GetArchitectureRecommendations(GetArchitectureRecommendationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetArchitectureRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetArchitectureRecommendationsResponseUnmarshaller.Instance;

            return Invoke<GetArchitectureRecommendationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetArchitectureRecommendations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetArchitectureRecommendations operation on AmazonRoute53RecoveryReadinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetArchitectureRecommendations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/GetArchitectureRecommendations">REST API Reference for GetArchitectureRecommendations Operation</seealso>
        public virtual IAsyncResult BeginGetArchitectureRecommendations(GetArchitectureRecommendationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetArchitectureRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetArchitectureRecommendationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetArchitectureRecommendations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetArchitectureRecommendations.</param>
        /// 
        /// <returns>Returns a  GetArchitectureRecommendationsResult from Route53RecoveryReadiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/GetArchitectureRecommendations">REST API Reference for GetArchitectureRecommendations Operation</seealso>
        public virtual GetArchitectureRecommendationsResponse EndGetArchitectureRecommendations(IAsyncResult asyncResult)
        {
            return EndInvoke<GetArchitectureRecommendationsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCell

        /// <summary>
        /// Gets information about a cell including cell name, cell Amazon Resource Name (ARN),
        /// ARNs of nested cells for this cell, and a list of those cell ARNs with their associated
        /// recovery group ARNs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCell service method.</param>
        /// 
        /// <returns>The response from the GetCell service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ResourceNotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/GetCell">REST API Reference for GetCell Operation</seealso>
        public virtual GetCellResponse GetCell(GetCellRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCellRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCellResponseUnmarshaller.Instance;

            return Invoke<GetCellResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCell operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCell operation on AmazonRoute53RecoveryReadinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCell
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/GetCell">REST API Reference for GetCell Operation</seealso>
        public virtual IAsyncResult BeginGetCell(GetCellRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCellRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCellResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCell operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCell.</param>
        /// 
        /// <returns>Returns a  GetCellResult from Route53RecoveryReadiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/GetCell">REST API Reference for GetCell Operation</seealso>
        public virtual GetCellResponse EndGetCell(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCellResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCellReadinessSummary

        /// <summary>
        /// Gets readiness for a cell. Aggregates the readiness of all the resources that are
        /// associated with the cell into a single value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCellReadinessSummary service method.</param>
        /// 
        /// <returns>The response from the GetCellReadinessSummary service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ResourceNotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/GetCellReadinessSummary">REST API Reference for GetCellReadinessSummary Operation</seealso>
        public virtual GetCellReadinessSummaryResponse GetCellReadinessSummary(GetCellReadinessSummaryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCellReadinessSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCellReadinessSummaryResponseUnmarshaller.Instance;

            return Invoke<GetCellReadinessSummaryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCellReadinessSummary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCellReadinessSummary operation on AmazonRoute53RecoveryReadinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCellReadinessSummary
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/GetCellReadinessSummary">REST API Reference for GetCellReadinessSummary Operation</seealso>
        public virtual IAsyncResult BeginGetCellReadinessSummary(GetCellReadinessSummaryRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCellReadinessSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCellReadinessSummaryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCellReadinessSummary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCellReadinessSummary.</param>
        /// 
        /// <returns>Returns a  GetCellReadinessSummaryResult from Route53RecoveryReadiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/GetCellReadinessSummary">REST API Reference for GetCellReadinessSummary Operation</seealso>
        public virtual GetCellReadinessSummaryResponse EndGetCellReadinessSummary(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCellReadinessSummaryResponse>(asyncResult);
        }

        #endregion
        
        #region  GetReadinessCheck

        /// <summary>
        /// Gets details about a readiness check.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReadinessCheck service method.</param>
        /// 
        /// <returns>The response from the GetReadinessCheck service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ResourceNotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/GetReadinessCheck">REST API Reference for GetReadinessCheck Operation</seealso>
        public virtual GetReadinessCheckResponse GetReadinessCheck(GetReadinessCheckRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetReadinessCheckRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReadinessCheckResponseUnmarshaller.Instance;

            return Invoke<GetReadinessCheckResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetReadinessCheck operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetReadinessCheck operation on AmazonRoute53RecoveryReadinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetReadinessCheck
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/GetReadinessCheck">REST API Reference for GetReadinessCheck Operation</seealso>
        public virtual IAsyncResult BeginGetReadinessCheck(GetReadinessCheckRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetReadinessCheckRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReadinessCheckResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetReadinessCheck operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetReadinessCheck.</param>
        /// 
        /// <returns>Returns a  GetReadinessCheckResult from Route53RecoveryReadiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/GetReadinessCheck">REST API Reference for GetReadinessCheck Operation</seealso>
        public virtual GetReadinessCheckResponse EndGetReadinessCheck(IAsyncResult asyncResult)
        {
            return EndInvoke<GetReadinessCheckResponse>(asyncResult);
        }

        #endregion
        
        #region  GetReadinessCheckResourceStatus

        /// <summary>
        /// Gets individual readiness status for a readiness check. To see the overall readiness
        /// status for a recovery group, that considers the readiness status for all the readiness
        /// checks in the recovery group, use GetRecoveryGroupReadinessSummary.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReadinessCheckResourceStatus service method.</param>
        /// 
        /// <returns>The response from the GetReadinessCheckResourceStatus service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ResourceNotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/GetReadinessCheckResourceStatus">REST API Reference for GetReadinessCheckResourceStatus Operation</seealso>
        public virtual GetReadinessCheckResourceStatusResponse GetReadinessCheckResourceStatus(GetReadinessCheckResourceStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetReadinessCheckResourceStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReadinessCheckResourceStatusResponseUnmarshaller.Instance;

            return Invoke<GetReadinessCheckResourceStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetReadinessCheckResourceStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetReadinessCheckResourceStatus operation on AmazonRoute53RecoveryReadinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetReadinessCheckResourceStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/GetReadinessCheckResourceStatus">REST API Reference for GetReadinessCheckResourceStatus Operation</seealso>
        public virtual IAsyncResult BeginGetReadinessCheckResourceStatus(GetReadinessCheckResourceStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetReadinessCheckResourceStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReadinessCheckResourceStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetReadinessCheckResourceStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetReadinessCheckResourceStatus.</param>
        /// 
        /// <returns>Returns a  GetReadinessCheckResourceStatusResult from Route53RecoveryReadiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/GetReadinessCheckResourceStatus">REST API Reference for GetReadinessCheckResourceStatus Operation</seealso>
        public virtual GetReadinessCheckResourceStatusResponse EndGetReadinessCheckResourceStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<GetReadinessCheckResourceStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  GetReadinessCheckStatus

        /// <summary>
        /// Gets the readiness status for an individual readiness check. To see the overall readiness
        /// status for a recovery group, that considers the readiness status for all the readiness
        /// checks in a recovery group, use GetRecoveryGroupReadinessSummary.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReadinessCheckStatus service method.</param>
        /// 
        /// <returns>The response from the GetReadinessCheckStatus service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ResourceNotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/GetReadinessCheckStatus">REST API Reference for GetReadinessCheckStatus Operation</seealso>
        public virtual GetReadinessCheckStatusResponse GetReadinessCheckStatus(GetReadinessCheckStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetReadinessCheckStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReadinessCheckStatusResponseUnmarshaller.Instance;

            return Invoke<GetReadinessCheckStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetReadinessCheckStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetReadinessCheckStatus operation on AmazonRoute53RecoveryReadinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetReadinessCheckStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/GetReadinessCheckStatus">REST API Reference for GetReadinessCheckStatus Operation</seealso>
        public virtual IAsyncResult BeginGetReadinessCheckStatus(GetReadinessCheckStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetReadinessCheckStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReadinessCheckStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetReadinessCheckStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetReadinessCheckStatus.</param>
        /// 
        /// <returns>Returns a  GetReadinessCheckStatusResult from Route53RecoveryReadiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/GetReadinessCheckStatus">REST API Reference for GetReadinessCheckStatus Operation</seealso>
        public virtual GetReadinessCheckStatusResponse EndGetReadinessCheckStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<GetReadinessCheckStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRecoveryGroup

        /// <summary>
        /// Gets details about a recovery group, including a list of the cells that are included
        /// in it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRecoveryGroup service method.</param>
        /// 
        /// <returns>The response from the GetRecoveryGroup service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ResourceNotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/GetRecoveryGroup">REST API Reference for GetRecoveryGroup Operation</seealso>
        public virtual GetRecoveryGroupResponse GetRecoveryGroup(GetRecoveryGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRecoveryGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecoveryGroupResponseUnmarshaller.Instance;

            return Invoke<GetRecoveryGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRecoveryGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRecoveryGroup operation on AmazonRoute53RecoveryReadinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRecoveryGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/GetRecoveryGroup">REST API Reference for GetRecoveryGroup Operation</seealso>
        public virtual IAsyncResult BeginGetRecoveryGroup(GetRecoveryGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRecoveryGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecoveryGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRecoveryGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRecoveryGroup.</param>
        /// 
        /// <returns>Returns a  GetRecoveryGroupResult from Route53RecoveryReadiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/GetRecoveryGroup">REST API Reference for GetRecoveryGroup Operation</seealso>
        public virtual GetRecoveryGroupResponse EndGetRecoveryGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRecoveryGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRecoveryGroupReadinessSummary

        /// <summary>
        /// Displays a summary of information about a recovery group's readiness status. Includes
        /// the readiness checks for resources in the recovery group and the readiness status
        /// of each one.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRecoveryGroupReadinessSummary service method.</param>
        /// 
        /// <returns>The response from the GetRecoveryGroupReadinessSummary service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ResourceNotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/GetRecoveryGroupReadinessSummary">REST API Reference for GetRecoveryGroupReadinessSummary Operation</seealso>
        public virtual GetRecoveryGroupReadinessSummaryResponse GetRecoveryGroupReadinessSummary(GetRecoveryGroupReadinessSummaryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRecoveryGroupReadinessSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecoveryGroupReadinessSummaryResponseUnmarshaller.Instance;

            return Invoke<GetRecoveryGroupReadinessSummaryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRecoveryGroupReadinessSummary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRecoveryGroupReadinessSummary operation on AmazonRoute53RecoveryReadinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRecoveryGroupReadinessSummary
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/GetRecoveryGroupReadinessSummary">REST API Reference for GetRecoveryGroupReadinessSummary Operation</seealso>
        public virtual IAsyncResult BeginGetRecoveryGroupReadinessSummary(GetRecoveryGroupReadinessSummaryRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRecoveryGroupReadinessSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecoveryGroupReadinessSummaryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRecoveryGroupReadinessSummary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRecoveryGroupReadinessSummary.</param>
        /// 
        /// <returns>Returns a  GetRecoveryGroupReadinessSummaryResult from Route53RecoveryReadiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/GetRecoveryGroupReadinessSummary">REST API Reference for GetRecoveryGroupReadinessSummary Operation</seealso>
        public virtual GetRecoveryGroupReadinessSummaryResponse EndGetRecoveryGroupReadinessSummary(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRecoveryGroupReadinessSummaryResponse>(asyncResult);
        }

        #endregion
        
        #region  GetResourceSet

        /// <summary>
        /// Displays the details about a resource set, including a list of the resources in the
        /// set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceSet service method.</param>
        /// 
        /// <returns>The response from the GetResourceSet service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ResourceNotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/GetResourceSet">REST API Reference for GetResourceSet Operation</seealso>
        public virtual GetResourceSetResponse GetResourceSet(GetResourceSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourceSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceSetResponseUnmarshaller.Instance;

            return Invoke<GetResourceSetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetResourceSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourceSet operation on AmazonRoute53RecoveryReadinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResourceSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/GetResourceSet">REST API Reference for GetResourceSet Operation</seealso>
        public virtual IAsyncResult BeginGetResourceSet(GetResourceSetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourceSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceSetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetResourceSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResourceSet.</param>
        /// 
        /// <returns>Returns a  GetResourceSetResult from Route53RecoveryReadiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/GetResourceSet">REST API Reference for GetResourceSet Operation</seealso>
        public virtual GetResourceSetResponse EndGetResourceSet(IAsyncResult asyncResult)
        {
            return EndInvoke<GetResourceSetResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCells

        /// <summary>
        /// Lists the cells for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCells service method.</param>
        /// 
        /// <returns>The response from the ListCells service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/ListCells">REST API Reference for ListCells Operation</seealso>
        public virtual ListCellsResponse ListCells(ListCellsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCellsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCellsResponseUnmarshaller.Instance;

            return Invoke<ListCellsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCells operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCells operation on AmazonRoute53RecoveryReadinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCells
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/ListCells">REST API Reference for ListCells Operation</seealso>
        public virtual IAsyncResult BeginListCells(ListCellsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCellsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCellsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCells operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCells.</param>
        /// 
        /// <returns>Returns a  ListCellsResult from Route53RecoveryReadiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/ListCells">REST API Reference for ListCells Operation</seealso>
        public virtual ListCellsResponse EndListCells(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCellsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCrossAccountAuthorizations

        /// <summary>
        /// Lists the cross-account readiness authorizations that are in place for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCrossAccountAuthorizations service method.</param>
        /// 
        /// <returns>The response from the ListCrossAccountAuthorizations service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/ListCrossAccountAuthorizations">REST API Reference for ListCrossAccountAuthorizations Operation</seealso>
        public virtual ListCrossAccountAuthorizationsResponse ListCrossAccountAuthorizations(ListCrossAccountAuthorizationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCrossAccountAuthorizationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCrossAccountAuthorizationsResponseUnmarshaller.Instance;

            return Invoke<ListCrossAccountAuthorizationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCrossAccountAuthorizations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCrossAccountAuthorizations operation on AmazonRoute53RecoveryReadinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCrossAccountAuthorizations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/ListCrossAccountAuthorizations">REST API Reference for ListCrossAccountAuthorizations Operation</seealso>
        public virtual IAsyncResult BeginListCrossAccountAuthorizations(ListCrossAccountAuthorizationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCrossAccountAuthorizationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCrossAccountAuthorizationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCrossAccountAuthorizations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCrossAccountAuthorizations.</param>
        /// 
        /// <returns>Returns a  ListCrossAccountAuthorizationsResult from Route53RecoveryReadiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/ListCrossAccountAuthorizations">REST API Reference for ListCrossAccountAuthorizations Operation</seealso>
        public virtual ListCrossAccountAuthorizationsResponse EndListCrossAccountAuthorizations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCrossAccountAuthorizationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListReadinessChecks

        /// <summary>
        /// Lists the readiness checks for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReadinessChecks service method.</param>
        /// 
        /// <returns>The response from the ListReadinessChecks service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/ListReadinessChecks">REST API Reference for ListReadinessChecks Operation</seealso>
        public virtual ListReadinessChecksResponse ListReadinessChecks(ListReadinessChecksRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListReadinessChecksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReadinessChecksResponseUnmarshaller.Instance;

            return Invoke<ListReadinessChecksResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListReadinessChecks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListReadinessChecks operation on AmazonRoute53RecoveryReadinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListReadinessChecks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/ListReadinessChecks">REST API Reference for ListReadinessChecks Operation</seealso>
        public virtual IAsyncResult BeginListReadinessChecks(ListReadinessChecksRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListReadinessChecksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReadinessChecksResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListReadinessChecks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListReadinessChecks.</param>
        /// 
        /// <returns>Returns a  ListReadinessChecksResult from Route53RecoveryReadiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/ListReadinessChecks">REST API Reference for ListReadinessChecks Operation</seealso>
        public virtual ListReadinessChecksResponse EndListReadinessChecks(IAsyncResult asyncResult)
        {
            return EndInvoke<ListReadinessChecksResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRecoveryGroups

        /// <summary>
        /// Lists the recovery groups in an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecoveryGroups service method.</param>
        /// 
        /// <returns>The response from the ListRecoveryGroups service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/ListRecoveryGroups">REST API Reference for ListRecoveryGroups Operation</seealso>
        public virtual ListRecoveryGroupsResponse ListRecoveryGroups(ListRecoveryGroupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRecoveryGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecoveryGroupsResponseUnmarshaller.Instance;

            return Invoke<ListRecoveryGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRecoveryGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRecoveryGroups operation on AmazonRoute53RecoveryReadinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRecoveryGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/ListRecoveryGroups">REST API Reference for ListRecoveryGroups Operation</seealso>
        public virtual IAsyncResult BeginListRecoveryGroups(ListRecoveryGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRecoveryGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecoveryGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRecoveryGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRecoveryGroups.</param>
        /// 
        /// <returns>Returns a  ListRecoveryGroupsResult from Route53RecoveryReadiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/ListRecoveryGroups">REST API Reference for ListRecoveryGroups Operation</seealso>
        public virtual ListRecoveryGroupsResponse EndListRecoveryGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRecoveryGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListResourceSets

        /// <summary>
        /// Lists the resource sets in an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceSets service method.</param>
        /// 
        /// <returns>The response from the ListResourceSets service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/ListResourceSets">REST API Reference for ListResourceSets Operation</seealso>
        public virtual ListResourceSetsResponse ListResourceSets(ListResourceSetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListResourceSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceSetsResponseUnmarshaller.Instance;

            return Invoke<ListResourceSetsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListResourceSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResourceSets operation on AmazonRoute53RecoveryReadinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListResourceSets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/ListResourceSets">REST API Reference for ListResourceSets Operation</seealso>
        public virtual IAsyncResult BeginListResourceSets(ListResourceSetsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListResourceSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceSetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListResourceSets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResourceSets.</param>
        /// 
        /// <returns>Returns a  ListResourceSetsResult from Route53RecoveryReadiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/ListResourceSets">REST API Reference for ListResourceSets Operation</seealso>
        public virtual ListResourceSetsResponse EndListResourceSets(IAsyncResult asyncResult)
        {
            return EndInvoke<ListResourceSetsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRules

        /// <summary>
        /// Lists all readiness rules, or lists the readiness rules for a specific resource type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRules service method.</param>
        /// 
        /// <returns>The response from the ListRules service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/ListRules">REST API Reference for ListRules Operation</seealso>
        public virtual ListRulesResponse ListRules(ListRulesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRulesResponseUnmarshaller.Instance;

            return Invoke<ListRulesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRules operation on AmazonRoute53RecoveryReadinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRules
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/ListRules">REST API Reference for ListRules Operation</seealso>
        public virtual IAsyncResult BeginListRules(ListRulesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRulesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRules.</param>
        /// 
        /// <returns>Returns a  ListRulesResult from Route53RecoveryReadiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/ListRules">REST API Reference for ListRules Operation</seealso>
        public virtual ListRulesResponse EndListRules(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRulesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResources

        /// <summary>
        /// Lists the tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResources service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResources service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ResourceNotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/ListTagsForResources">REST API Reference for ListTagsForResources Operation</seealso>
        public virtual ListTagsForResourcesResponse ListTagsForResources(ListTagsForResourcesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourcesResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourcesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResources operation on AmazonRoute53RecoveryReadinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/ListTagsForResources">REST API Reference for ListTagsForResources Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResources(ListTagsForResourcesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourcesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResources.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourcesResult from Route53RecoveryReadiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/ListTagsForResources">REST API Reference for ListTagsForResources Operation</seealso>
        public virtual ListTagsForResourcesResponse EndListTagsForResources(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourcesResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds a tag to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ResourceNotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonRoute53RecoveryReadinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from Route53RecoveryReadiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes a tag from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ResourceNotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonRoute53RecoveryReadinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from Route53RecoveryReadiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateCell

        /// <summary>
        /// Updates a cell to replace the list of nested cells with a new list of nested cells.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCell service method.</param>
        /// 
        /// <returns>The response from the UpdateCell service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ResourceNotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/UpdateCell">REST API Reference for UpdateCell Operation</seealso>
        public virtual UpdateCellResponse UpdateCell(UpdateCellRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCellRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCellResponseUnmarshaller.Instance;

            return Invoke<UpdateCellResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCell operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCell operation on AmazonRoute53RecoveryReadinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCell
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/UpdateCell">REST API Reference for UpdateCell Operation</seealso>
        public virtual IAsyncResult BeginUpdateCell(UpdateCellRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCellRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCellResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCell operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCell.</param>
        /// 
        /// <returns>Returns a  UpdateCellResult from Route53RecoveryReadiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/UpdateCell">REST API Reference for UpdateCell Operation</seealso>
        public virtual UpdateCellResponse EndUpdateCell(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateCellResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateReadinessCheck

        /// <summary>
        /// Updates a readiness check.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateReadinessCheck service method.</param>
        /// 
        /// <returns>The response from the UpdateReadinessCheck service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ResourceNotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/UpdateReadinessCheck">REST API Reference for UpdateReadinessCheck Operation</seealso>
        public virtual UpdateReadinessCheckResponse UpdateReadinessCheck(UpdateReadinessCheckRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateReadinessCheckRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateReadinessCheckResponseUnmarshaller.Instance;

            return Invoke<UpdateReadinessCheckResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateReadinessCheck operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateReadinessCheck operation on AmazonRoute53RecoveryReadinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateReadinessCheck
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/UpdateReadinessCheck">REST API Reference for UpdateReadinessCheck Operation</seealso>
        public virtual IAsyncResult BeginUpdateReadinessCheck(UpdateReadinessCheckRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateReadinessCheckRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateReadinessCheckResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateReadinessCheck operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateReadinessCheck.</param>
        /// 
        /// <returns>Returns a  UpdateReadinessCheckResult from Route53RecoveryReadiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/UpdateReadinessCheck">REST API Reference for UpdateReadinessCheck Operation</seealso>
        public virtual UpdateReadinessCheckResponse EndUpdateReadinessCheck(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateReadinessCheckResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateRecoveryGroup

        /// <summary>
        /// Updates a recovery group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRecoveryGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateRecoveryGroup service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ResourceNotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/UpdateRecoveryGroup">REST API Reference for UpdateRecoveryGroup Operation</seealso>
        public virtual UpdateRecoveryGroupResponse UpdateRecoveryGroup(UpdateRecoveryGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRecoveryGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRecoveryGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateRecoveryGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRecoveryGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRecoveryGroup operation on AmazonRoute53RecoveryReadinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRecoveryGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/UpdateRecoveryGroup">REST API Reference for UpdateRecoveryGroup Operation</seealso>
        public virtual IAsyncResult BeginUpdateRecoveryGroup(UpdateRecoveryGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRecoveryGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRecoveryGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRecoveryGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRecoveryGroup.</param>
        /// 
        /// <returns>Returns a  UpdateRecoveryGroupResult from Route53RecoveryReadiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/UpdateRecoveryGroup">REST API Reference for UpdateRecoveryGroup Operation</seealso>
        public virtual UpdateRecoveryGroupResponse EndUpdateRecoveryGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateRecoveryGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateResourceSet

        /// <summary>
        /// Updates a resource set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResourceSet service method.</param>
        /// 
        /// <returns>The response from the UpdateResourceSet service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ResourceNotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/UpdateResourceSet">REST API Reference for UpdateResourceSet Operation</seealso>
        public virtual UpdateResourceSetResponse UpdateResourceSet(UpdateResourceSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateResourceSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResourceSetResponseUnmarshaller.Instance;

            return Invoke<UpdateResourceSetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateResourceSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateResourceSet operation on AmazonRoute53RecoveryReadinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateResourceSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/UpdateResourceSet">REST API Reference for UpdateResourceSet Operation</seealso>
        public virtual IAsyncResult BeginUpdateResourceSet(UpdateResourceSetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateResourceSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResourceSetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateResourceSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateResourceSet.</param>
        /// 
        /// <returns>Returns a  UpdateResourceSetResult from Route53RecoveryReadiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/UpdateResourceSet">REST API Reference for UpdateResourceSet Operation</seealso>
        public virtual UpdateResourceSetResponse EndUpdateResourceSet(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateResourceSetResponse>(asyncResult);
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
            var resolver = new AmazonRoute53RecoveryReadinessEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}