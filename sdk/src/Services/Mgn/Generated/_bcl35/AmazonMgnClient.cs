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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.Mgn.Model;
using Amazon.Mgn.Model.Internal.MarshallTransformations;
using Amazon.Mgn.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Mgn
{
    /// <summary>
    /// Implementation for accessing Mgn
    ///
    /// The Application Migration Service service.
    /// </summary>
    public partial class AmazonMgnClient : AmazonServiceClient, IAmazonMgn
    {
        private static IServiceMetadata serviceMetadata = new AmazonMgnMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IMgnPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IMgnPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new MgnPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonMgnClient with the credentials loaded from the application's
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
        public AmazonMgnClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMgnConfig()) { }

        /// <summary>
        /// Constructs AmazonMgnClient with the credentials loaded from the application's
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
        public AmazonMgnClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMgnConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonMgnClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonMgnClient Configuration Object</param>
        public AmazonMgnClient(AmazonMgnConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonMgnClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonMgnClient(AWSCredentials credentials)
            : this(credentials, new AmazonMgnConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMgnClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMgnClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonMgnConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMgnClient with AWS Credentials and an
        /// AmazonMgnClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonMgnClient Configuration Object</param>
        public AmazonMgnClient(AWSCredentials credentials, AmazonMgnConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMgnClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonMgnClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMgnConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMgnClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMgnClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMgnConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonMgnClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMgnClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonMgnClient Configuration Object</param>
        public AmazonMgnClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonMgnConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMgnClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonMgnClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMgnConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMgnClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMgnClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMgnConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMgnClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMgnClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonMgnClient Configuration Object</param>
        public AmazonMgnClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonMgnConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonMgnEndpointResolver());
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


        #region  ArchiveApplication

        /// <summary>
        /// Archive application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ArchiveApplication service method.</param>
        /// 
        /// <returns>The response from the ArchiveApplication service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because its exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ArchiveApplication">REST API Reference for ArchiveApplication Operation</seealso>
        public virtual ArchiveApplicationResponse ArchiveApplication(ArchiveApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ArchiveApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ArchiveApplicationResponseUnmarshaller.Instance;

            return Invoke<ArchiveApplicationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ArchiveApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ArchiveApplication operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndArchiveApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ArchiveApplication">REST API Reference for ArchiveApplication Operation</seealso>
        public virtual IAsyncResult BeginArchiveApplication(ArchiveApplicationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ArchiveApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ArchiveApplicationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ArchiveApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginArchiveApplication.</param>
        /// 
        /// <returns>Returns a  ArchiveApplicationResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ArchiveApplication">REST API Reference for ArchiveApplication Operation</seealso>
        public virtual ArchiveApplicationResponse EndArchiveApplication(IAsyncResult asyncResult)
        {
            return EndInvoke<ArchiveApplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  ArchiveWave

        /// <summary>
        /// Archive wave.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ArchiveWave service method.</param>
        /// 
        /// <returns>The response from the ArchiveWave service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because its exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ArchiveWave">REST API Reference for ArchiveWave Operation</seealso>
        public virtual ArchiveWaveResponse ArchiveWave(ArchiveWaveRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ArchiveWaveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ArchiveWaveResponseUnmarshaller.Instance;

            return Invoke<ArchiveWaveResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ArchiveWave operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ArchiveWave operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndArchiveWave
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ArchiveWave">REST API Reference for ArchiveWave Operation</seealso>
        public virtual IAsyncResult BeginArchiveWave(ArchiveWaveRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ArchiveWaveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ArchiveWaveResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ArchiveWave operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginArchiveWave.</param>
        /// 
        /// <returns>Returns a  ArchiveWaveResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ArchiveWave">REST API Reference for ArchiveWave Operation</seealso>
        public virtual ArchiveWaveResponse EndArchiveWave(IAsyncResult asyncResult)
        {
            return EndInvoke<ArchiveWaveResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateApplications

        /// <summary>
        /// Associate applications to wave.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateApplications service method.</param>
        /// 
        /// <returns>The response from the AssociateApplications service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because its exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/AssociateApplications">REST API Reference for AssociateApplications Operation</seealso>
        public virtual AssociateApplicationsResponse AssociateApplications(AssociateApplicationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateApplicationsResponseUnmarshaller.Instance;

            return Invoke<AssociateApplicationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateApplications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateApplications operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateApplications
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/AssociateApplications">REST API Reference for AssociateApplications Operation</seealso>
        public virtual IAsyncResult BeginAssociateApplications(AssociateApplicationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateApplicationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateApplications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateApplications.</param>
        /// 
        /// <returns>Returns a  AssociateApplicationsResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/AssociateApplications">REST API Reference for AssociateApplications Operation</seealso>
        public virtual AssociateApplicationsResponse EndAssociateApplications(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateApplicationsResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateSourceServers

        /// <summary>
        /// Associate source servers to application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateSourceServers service method.</param>
        /// 
        /// <returns>The response from the AssociateSourceServers service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because its exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/AssociateSourceServers">REST API Reference for AssociateSourceServers Operation</seealso>
        public virtual AssociateSourceServersResponse AssociateSourceServers(AssociateSourceServersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateSourceServersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateSourceServersResponseUnmarshaller.Instance;

            return Invoke<AssociateSourceServersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateSourceServers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateSourceServers operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateSourceServers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/AssociateSourceServers">REST API Reference for AssociateSourceServers Operation</seealso>
        public virtual IAsyncResult BeginAssociateSourceServers(AssociateSourceServersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateSourceServersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateSourceServersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateSourceServers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateSourceServers.</param>
        /// 
        /// <returns>Returns a  AssociateSourceServersResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/AssociateSourceServers">REST API Reference for AssociateSourceServers Operation</seealso>
        public virtual AssociateSourceServersResponse EndAssociateSourceServers(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateSourceServersResponse>(asyncResult);
        }

        #endregion
        
        #region  ChangeServerLifeCycleState

        /// <summary>
        /// Allows the user to set the SourceServer.LifeCycle.state property for specific Source
        /// Server IDs to one of the following: READY_FOR_TEST or READY_FOR_CUTOVER. This command
        /// only works if the Source Server is already launchable (dataReplicationInfo.lagDuration
        /// is not null.)
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ChangeServerLifeCycleState service method.</param>
        /// 
        /// <returns>The response from the ChangeServerLifeCycleState service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ChangeServerLifeCycleState">REST API Reference for ChangeServerLifeCycleState Operation</seealso>
        public virtual ChangeServerLifeCycleStateResponse ChangeServerLifeCycleState(ChangeServerLifeCycleStateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ChangeServerLifeCycleStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ChangeServerLifeCycleStateResponseUnmarshaller.Instance;

            return Invoke<ChangeServerLifeCycleStateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ChangeServerLifeCycleState operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ChangeServerLifeCycleState operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndChangeServerLifeCycleState
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ChangeServerLifeCycleState">REST API Reference for ChangeServerLifeCycleState Operation</seealso>
        public virtual IAsyncResult BeginChangeServerLifeCycleState(ChangeServerLifeCycleStateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ChangeServerLifeCycleStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ChangeServerLifeCycleStateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ChangeServerLifeCycleState operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginChangeServerLifeCycleState.</param>
        /// 
        /// <returns>Returns a  ChangeServerLifeCycleStateResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ChangeServerLifeCycleState">REST API Reference for ChangeServerLifeCycleState Operation</seealso>
        public virtual ChangeServerLifeCycleStateResponse EndChangeServerLifeCycleState(IAsyncResult asyncResult)
        {
            return EndInvoke<ChangeServerLifeCycleStateResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateApplication

        /// <summary>
        /// Create application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication service method.</param>
        /// 
        /// <returns>The response from the CreateApplication service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because its exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        public virtual CreateApplicationResponse CreateApplication(CreateApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationResponseUnmarshaller.Instance;

            return Invoke<CreateApplicationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        public virtual IAsyncResult BeginCreateApplication(CreateApplicationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateApplication.</param>
        /// 
        /// <returns>Returns a  CreateApplicationResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        public virtual CreateApplicationResponse EndCreateApplication(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateApplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateLaunchConfigurationTemplate

        /// <summary>
        /// Creates a new Launch Configuration Template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLaunchConfigurationTemplate service method.</param>
        /// 
        /// <returns>The response from the CreateLaunchConfigurationTemplate service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operating denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/CreateLaunchConfigurationTemplate">REST API Reference for CreateLaunchConfigurationTemplate Operation</seealso>
        public virtual CreateLaunchConfigurationTemplateResponse CreateLaunchConfigurationTemplate(CreateLaunchConfigurationTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLaunchConfigurationTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLaunchConfigurationTemplateResponseUnmarshaller.Instance;

            return Invoke<CreateLaunchConfigurationTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLaunchConfigurationTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLaunchConfigurationTemplate operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLaunchConfigurationTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/CreateLaunchConfigurationTemplate">REST API Reference for CreateLaunchConfigurationTemplate Operation</seealso>
        public virtual IAsyncResult BeginCreateLaunchConfigurationTemplate(CreateLaunchConfigurationTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLaunchConfigurationTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLaunchConfigurationTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLaunchConfigurationTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLaunchConfigurationTemplate.</param>
        /// 
        /// <returns>Returns a  CreateLaunchConfigurationTemplateResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/CreateLaunchConfigurationTemplate">REST API Reference for CreateLaunchConfigurationTemplate Operation</seealso>
        public virtual CreateLaunchConfigurationTemplateResponse EndCreateLaunchConfigurationTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateLaunchConfigurationTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateReplicationConfigurationTemplate

        /// <summary>
        /// Creates a new ReplicationConfigurationTemplate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationConfigurationTemplate service method.</param>
        /// 
        /// <returns>The response from the CreateReplicationConfigurationTemplate service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operating denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/CreateReplicationConfigurationTemplate">REST API Reference for CreateReplicationConfigurationTemplate Operation</seealso>
        public virtual CreateReplicationConfigurationTemplateResponse CreateReplicationConfigurationTemplate(CreateReplicationConfigurationTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateReplicationConfigurationTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReplicationConfigurationTemplateResponseUnmarshaller.Instance;

            return Invoke<CreateReplicationConfigurationTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateReplicationConfigurationTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationConfigurationTemplate operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateReplicationConfigurationTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/CreateReplicationConfigurationTemplate">REST API Reference for CreateReplicationConfigurationTemplate Operation</seealso>
        public virtual IAsyncResult BeginCreateReplicationConfigurationTemplate(CreateReplicationConfigurationTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateReplicationConfigurationTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReplicationConfigurationTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateReplicationConfigurationTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateReplicationConfigurationTemplate.</param>
        /// 
        /// <returns>Returns a  CreateReplicationConfigurationTemplateResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/CreateReplicationConfigurationTemplate">REST API Reference for CreateReplicationConfigurationTemplate Operation</seealso>
        public virtual CreateReplicationConfigurationTemplateResponse EndCreateReplicationConfigurationTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateReplicationConfigurationTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateWave

        /// <summary>
        /// Create wave.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWave service method.</param>
        /// 
        /// <returns>The response from the CreateWave service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because its exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/CreateWave">REST API Reference for CreateWave Operation</seealso>
        public virtual CreateWaveResponse CreateWave(CreateWaveRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWaveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWaveResponseUnmarshaller.Instance;

            return Invoke<CreateWaveResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWave operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWave operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWave
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/CreateWave">REST API Reference for CreateWave Operation</seealso>
        public virtual IAsyncResult BeginCreateWave(CreateWaveRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWaveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWaveResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWave operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWave.</param>
        /// 
        /// <returns>Returns a  CreateWaveResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/CreateWave">REST API Reference for CreateWave Operation</seealso>
        public virtual CreateWaveResponse EndCreateWave(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateWaveResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteApplication

        /// <summary>
        /// Delete application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication service method.</param>
        /// 
        /// <returns>The response from the DeleteApplication service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        public virtual DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationResponseUnmarshaller.Instance;

            return Invoke<DeleteApplicationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        public virtual IAsyncResult BeginDeleteApplication(DeleteApplicationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApplication.</param>
        /// 
        /// <returns>Returns a  DeleteApplicationResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        public virtual DeleteApplicationResponse EndDeleteApplication(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteApplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteJob

        /// <summary>
        /// Deletes a single Job by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteJob service method.</param>
        /// 
        /// <returns>The response from the DeleteJob service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteJob">REST API Reference for DeleteJob Operation</seealso>
        public virtual DeleteJobResponse DeleteJob(DeleteJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteJobResponseUnmarshaller.Instance;

            return Invoke<DeleteJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteJob operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteJob">REST API Reference for DeleteJob Operation</seealso>
        public virtual IAsyncResult BeginDeleteJob(DeleteJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteJob.</param>
        /// 
        /// <returns>Returns a  DeleteJobResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteJob">REST API Reference for DeleteJob Operation</seealso>
        public virtual DeleteJobResponse EndDeleteJob(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteJobResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteLaunchConfigurationTemplate

        /// <summary>
        /// Deletes a single Launch Configuration Template by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLaunchConfigurationTemplate service method.</param>
        /// 
        /// <returns>The response from the DeleteLaunchConfigurationTemplate service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteLaunchConfigurationTemplate">REST API Reference for DeleteLaunchConfigurationTemplate Operation</seealso>
        public virtual DeleteLaunchConfigurationTemplateResponse DeleteLaunchConfigurationTemplate(DeleteLaunchConfigurationTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLaunchConfigurationTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLaunchConfigurationTemplateResponseUnmarshaller.Instance;

            return Invoke<DeleteLaunchConfigurationTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLaunchConfigurationTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLaunchConfigurationTemplate operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLaunchConfigurationTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteLaunchConfigurationTemplate">REST API Reference for DeleteLaunchConfigurationTemplate Operation</seealso>
        public virtual IAsyncResult BeginDeleteLaunchConfigurationTemplate(DeleteLaunchConfigurationTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLaunchConfigurationTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLaunchConfigurationTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLaunchConfigurationTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLaunchConfigurationTemplate.</param>
        /// 
        /// <returns>Returns a  DeleteLaunchConfigurationTemplateResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteLaunchConfigurationTemplate">REST API Reference for DeleteLaunchConfigurationTemplate Operation</seealso>
        public virtual DeleteLaunchConfigurationTemplateResponse EndDeleteLaunchConfigurationTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteLaunchConfigurationTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteReplicationConfigurationTemplate

        /// <summary>
        /// Deletes a single Replication Configuration Template by ID
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationConfigurationTemplate service method.</param>
        /// 
        /// <returns>The response from the DeleteReplicationConfigurationTemplate service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteReplicationConfigurationTemplate">REST API Reference for DeleteReplicationConfigurationTemplate Operation</seealso>
        public virtual DeleteReplicationConfigurationTemplateResponse DeleteReplicationConfigurationTemplate(DeleteReplicationConfigurationTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteReplicationConfigurationTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReplicationConfigurationTemplateResponseUnmarshaller.Instance;

            return Invoke<DeleteReplicationConfigurationTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReplicationConfigurationTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationConfigurationTemplate operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteReplicationConfigurationTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteReplicationConfigurationTemplate">REST API Reference for DeleteReplicationConfigurationTemplate Operation</seealso>
        public virtual IAsyncResult BeginDeleteReplicationConfigurationTemplate(DeleteReplicationConfigurationTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteReplicationConfigurationTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReplicationConfigurationTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteReplicationConfigurationTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteReplicationConfigurationTemplate.</param>
        /// 
        /// <returns>Returns a  DeleteReplicationConfigurationTemplateResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteReplicationConfigurationTemplate">REST API Reference for DeleteReplicationConfigurationTemplate Operation</seealso>
        public virtual DeleteReplicationConfigurationTemplateResponse EndDeleteReplicationConfigurationTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteReplicationConfigurationTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteSourceServer

        /// <summary>
        /// Deletes a single source server by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSourceServer service method.</param>
        /// 
        /// <returns>The response from the DeleteSourceServer service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteSourceServer">REST API Reference for DeleteSourceServer Operation</seealso>
        public virtual DeleteSourceServerResponse DeleteSourceServer(DeleteSourceServerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSourceServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSourceServerResponseUnmarshaller.Instance;

            return Invoke<DeleteSourceServerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSourceServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSourceServer operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSourceServer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteSourceServer">REST API Reference for DeleteSourceServer Operation</seealso>
        public virtual IAsyncResult BeginDeleteSourceServer(DeleteSourceServerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSourceServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSourceServerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSourceServer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSourceServer.</param>
        /// 
        /// <returns>Returns a  DeleteSourceServerResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteSourceServer">REST API Reference for DeleteSourceServer Operation</seealso>
        public virtual DeleteSourceServerResponse EndDeleteSourceServer(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSourceServerResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteVcenterClient

        /// <summary>
        /// Deletes a given vCenter client by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVcenterClient service method.</param>
        /// 
        /// <returns>The response from the DeleteVcenterClient service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteVcenterClient">REST API Reference for DeleteVcenterClient Operation</seealso>
        public virtual DeleteVcenterClientResponse DeleteVcenterClient(DeleteVcenterClientRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVcenterClientRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVcenterClientResponseUnmarshaller.Instance;

            return Invoke<DeleteVcenterClientResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVcenterClient operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVcenterClient operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVcenterClient
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteVcenterClient">REST API Reference for DeleteVcenterClient Operation</seealso>
        public virtual IAsyncResult BeginDeleteVcenterClient(DeleteVcenterClientRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVcenterClientRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVcenterClientResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVcenterClient operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVcenterClient.</param>
        /// 
        /// <returns>Returns a  DeleteVcenterClientResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteVcenterClient">REST API Reference for DeleteVcenterClient Operation</seealso>
        public virtual DeleteVcenterClientResponse EndDeleteVcenterClient(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteVcenterClientResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteWave

        /// <summary>
        /// Delete wave.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWave service method.</param>
        /// 
        /// <returns>The response from the DeleteWave service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteWave">REST API Reference for DeleteWave Operation</seealso>
        public virtual DeleteWaveResponse DeleteWave(DeleteWaveRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWaveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWaveResponseUnmarshaller.Instance;

            return Invoke<DeleteWaveResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWave operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWave operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWave
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteWave">REST API Reference for DeleteWave Operation</seealso>
        public virtual IAsyncResult BeginDeleteWave(DeleteWaveRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWaveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWaveResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWave operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWave.</param>
        /// 
        /// <returns>Returns a  DeleteWaveResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteWave">REST API Reference for DeleteWave Operation</seealso>
        public virtual DeleteWaveResponse EndDeleteWave(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteWaveResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeJobLogItems

        /// <summary>
        /// Retrieves detailed job log items with paging.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobLogItems service method.</param>
        /// 
        /// <returns>The response from the DescribeJobLogItems service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DescribeJobLogItems">REST API Reference for DescribeJobLogItems Operation</seealso>
        public virtual DescribeJobLogItemsResponse DescribeJobLogItems(DescribeJobLogItemsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeJobLogItemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeJobLogItemsResponseUnmarshaller.Instance;

            return Invoke<DescribeJobLogItemsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeJobLogItems operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobLogItems operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeJobLogItems
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DescribeJobLogItems">REST API Reference for DescribeJobLogItems Operation</seealso>
        public virtual IAsyncResult BeginDescribeJobLogItems(DescribeJobLogItemsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeJobLogItemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeJobLogItemsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeJobLogItems operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeJobLogItems.</param>
        /// 
        /// <returns>Returns a  DescribeJobLogItemsResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DescribeJobLogItems">REST API Reference for DescribeJobLogItems Operation</seealso>
        public virtual DescribeJobLogItemsResponse EndDescribeJobLogItems(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeJobLogItemsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeJobs

        /// <summary>
        /// Returns a list of Jobs. Use the JobsID and fromDate and toData filters to limit which
        /// jobs are returned. The response is sorted by creationDataTime - latest date first.
        /// Jobs are normally created by the StartTest, StartCutover, and TerminateTargetInstances
        /// APIs. Jobs are also created by DiagnosticLaunch and TerminateDiagnosticInstances,
        /// which are APIs available only to *Support* and only used in response to relevant support
        /// tickets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobs service method.</param>
        /// 
        /// <returns>The response from the DescribeJobs service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DescribeJobs">REST API Reference for DescribeJobs Operation</seealso>
        public virtual DescribeJobsResponse DescribeJobs(DescribeJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeJobsResponseUnmarshaller.Instance;

            return Invoke<DescribeJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobs operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DescribeJobs">REST API Reference for DescribeJobs Operation</seealso>
        public virtual IAsyncResult BeginDescribeJobs(DescribeJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeJobs.</param>
        /// 
        /// <returns>Returns a  DescribeJobsResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DescribeJobs">REST API Reference for DescribeJobs Operation</seealso>
        public virtual DescribeJobsResponse EndDescribeJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeLaunchConfigurationTemplates

        /// <summary>
        /// Lists all Launch Configuration Templates, filtered by Launch Configuration Template
        /// IDs
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLaunchConfigurationTemplates service method.</param>
        /// 
        /// <returns>The response from the DescribeLaunchConfigurationTemplates service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DescribeLaunchConfigurationTemplates">REST API Reference for DescribeLaunchConfigurationTemplates Operation</seealso>
        public virtual DescribeLaunchConfigurationTemplatesResponse DescribeLaunchConfigurationTemplates(DescribeLaunchConfigurationTemplatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLaunchConfigurationTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLaunchConfigurationTemplatesResponseUnmarshaller.Instance;

            return Invoke<DescribeLaunchConfigurationTemplatesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLaunchConfigurationTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLaunchConfigurationTemplates operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLaunchConfigurationTemplates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DescribeLaunchConfigurationTemplates">REST API Reference for DescribeLaunchConfigurationTemplates Operation</seealso>
        public virtual IAsyncResult BeginDescribeLaunchConfigurationTemplates(DescribeLaunchConfigurationTemplatesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLaunchConfigurationTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLaunchConfigurationTemplatesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLaunchConfigurationTemplates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLaunchConfigurationTemplates.</param>
        /// 
        /// <returns>Returns a  DescribeLaunchConfigurationTemplatesResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DescribeLaunchConfigurationTemplates">REST API Reference for DescribeLaunchConfigurationTemplates Operation</seealso>
        public virtual DescribeLaunchConfigurationTemplatesResponse EndDescribeLaunchConfigurationTemplates(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeLaunchConfigurationTemplatesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeReplicationConfigurationTemplates

        /// <summary>
        /// Lists all ReplicationConfigurationTemplates, filtered by Source Server IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationConfigurationTemplates service method.</param>
        /// 
        /// <returns>The response from the DescribeReplicationConfigurationTemplates service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DescribeReplicationConfigurationTemplates">REST API Reference for DescribeReplicationConfigurationTemplates Operation</seealso>
        public virtual DescribeReplicationConfigurationTemplatesResponse DescribeReplicationConfigurationTemplates(DescribeReplicationConfigurationTemplatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReplicationConfigurationTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReplicationConfigurationTemplatesResponseUnmarshaller.Instance;

            return Invoke<DescribeReplicationConfigurationTemplatesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReplicationConfigurationTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationConfigurationTemplates operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeReplicationConfigurationTemplates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DescribeReplicationConfigurationTemplates">REST API Reference for DescribeReplicationConfigurationTemplates Operation</seealso>
        public virtual IAsyncResult BeginDescribeReplicationConfigurationTemplates(DescribeReplicationConfigurationTemplatesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReplicationConfigurationTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReplicationConfigurationTemplatesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeReplicationConfigurationTemplates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReplicationConfigurationTemplates.</param>
        /// 
        /// <returns>Returns a  DescribeReplicationConfigurationTemplatesResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DescribeReplicationConfigurationTemplates">REST API Reference for DescribeReplicationConfigurationTemplates Operation</seealso>
        public virtual DescribeReplicationConfigurationTemplatesResponse EndDescribeReplicationConfigurationTemplates(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeReplicationConfigurationTemplatesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeSourceServers

        /// <summary>
        /// Retrieves all SourceServers or multiple SourceServers by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSourceServers service method.</param>
        /// 
        /// <returns>The response from the DescribeSourceServers service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DescribeSourceServers">REST API Reference for DescribeSourceServers Operation</seealso>
        public virtual DescribeSourceServersResponse DescribeSourceServers(DescribeSourceServersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSourceServersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSourceServersResponseUnmarshaller.Instance;

            return Invoke<DescribeSourceServersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSourceServers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSourceServers operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSourceServers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DescribeSourceServers">REST API Reference for DescribeSourceServers Operation</seealso>
        public virtual IAsyncResult BeginDescribeSourceServers(DescribeSourceServersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSourceServersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSourceServersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSourceServers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSourceServers.</param>
        /// 
        /// <returns>Returns a  DescribeSourceServersResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DescribeSourceServers">REST API Reference for DescribeSourceServers Operation</seealso>
        public virtual DescribeSourceServersResponse EndDescribeSourceServers(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeSourceServersResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeVcenterClients

        /// <summary>
        /// Returns a list of the installed vCenter clients.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVcenterClients service method.</param>
        /// 
        /// <returns>The response from the DescribeVcenterClients service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DescribeVcenterClients">REST API Reference for DescribeVcenterClients Operation</seealso>
        public virtual DescribeVcenterClientsResponse DescribeVcenterClients(DescribeVcenterClientsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVcenterClientsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVcenterClientsResponseUnmarshaller.Instance;

            return Invoke<DescribeVcenterClientsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVcenterClients operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVcenterClients operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVcenterClients
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DescribeVcenterClients">REST API Reference for DescribeVcenterClients Operation</seealso>
        public virtual IAsyncResult BeginDescribeVcenterClients(DescribeVcenterClientsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVcenterClientsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVcenterClientsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVcenterClients operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVcenterClients.</param>
        /// 
        /// <returns>Returns a  DescribeVcenterClientsResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DescribeVcenterClients">REST API Reference for DescribeVcenterClients Operation</seealso>
        public virtual DescribeVcenterClientsResponse EndDescribeVcenterClients(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeVcenterClientsResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateApplications

        /// <summary>
        /// Disassociate applications from wave.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateApplications service method.</param>
        /// 
        /// <returns>The response from the DisassociateApplications service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DisassociateApplications">REST API Reference for DisassociateApplications Operation</seealso>
        public virtual DisassociateApplicationsResponse DisassociateApplications(DisassociateApplicationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateApplicationsResponseUnmarshaller.Instance;

            return Invoke<DisassociateApplicationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateApplications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateApplications operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateApplications
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DisassociateApplications">REST API Reference for DisassociateApplications Operation</seealso>
        public virtual IAsyncResult BeginDisassociateApplications(DisassociateApplicationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateApplicationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateApplications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateApplications.</param>
        /// 
        /// <returns>Returns a  DisassociateApplicationsResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DisassociateApplications">REST API Reference for DisassociateApplications Operation</seealso>
        public virtual DisassociateApplicationsResponse EndDisassociateApplications(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateApplicationsResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateSourceServers

        /// <summary>
        /// Disassociate source servers from application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateSourceServers service method.</param>
        /// 
        /// <returns>The response from the DisassociateSourceServers service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DisassociateSourceServers">REST API Reference for DisassociateSourceServers Operation</seealso>
        public virtual DisassociateSourceServersResponse DisassociateSourceServers(DisassociateSourceServersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateSourceServersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateSourceServersResponseUnmarshaller.Instance;

            return Invoke<DisassociateSourceServersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateSourceServers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateSourceServers operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateSourceServers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DisassociateSourceServers">REST API Reference for DisassociateSourceServers Operation</seealso>
        public virtual IAsyncResult BeginDisassociateSourceServers(DisassociateSourceServersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateSourceServersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateSourceServersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateSourceServers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateSourceServers.</param>
        /// 
        /// <returns>Returns a  DisassociateSourceServersResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DisassociateSourceServers">REST API Reference for DisassociateSourceServers Operation</seealso>
        public virtual DisassociateSourceServersResponse EndDisassociateSourceServers(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateSourceServersResponse>(asyncResult);
        }

        #endregion
        
        #region  DisconnectFromService

        /// <summary>
        /// Disconnects specific Source Servers from Application Migration Service. Data replication
        /// is stopped immediately. All AWS resources created by Application Migration Service
        /// for enabling the replication of these source servers will be terminated / deleted
        /// within 90 minutes. Launched Test or Cutover instances will NOT be terminated. If the
        /// agent on the source server has not been prevented from communicating with the Application
        /// Migration Service service, then it will receive a command to uninstall itself (within
        /// approximately 10 minutes). The following properties of the SourceServer will be changed
        /// immediately: dataReplicationInfo.dataReplicationState will be set to DISCONNECTED;
        /// The totalStorageBytes property for each of dataReplicationInfo.replicatedDisks will
        /// be set to zero; dataReplicationInfo.lagDuration and dataReplicationInfo.lagDuration
        /// will be nullified.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisconnectFromService service method.</param>
        /// 
        /// <returns>The response from the DisconnectFromService service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DisconnectFromService">REST API Reference for DisconnectFromService Operation</seealso>
        public virtual DisconnectFromServiceResponse DisconnectFromService(DisconnectFromServiceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisconnectFromServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisconnectFromServiceResponseUnmarshaller.Instance;

            return Invoke<DisconnectFromServiceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisconnectFromService operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisconnectFromService operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisconnectFromService
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DisconnectFromService">REST API Reference for DisconnectFromService Operation</seealso>
        public virtual IAsyncResult BeginDisconnectFromService(DisconnectFromServiceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisconnectFromServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisconnectFromServiceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisconnectFromService operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisconnectFromService.</param>
        /// 
        /// <returns>Returns a  DisconnectFromServiceResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DisconnectFromService">REST API Reference for DisconnectFromService Operation</seealso>
        public virtual DisconnectFromServiceResponse EndDisconnectFromService(IAsyncResult asyncResult)
        {
            return EndInvoke<DisconnectFromServiceResponse>(asyncResult);
        }

        #endregion
        
        #region  FinalizeCutover

        /// <summary>
        /// Finalizes the cutover immediately for specific Source Servers. All AWS resources created
        /// by Application Migration Service for enabling the replication of these source servers
        /// will be terminated / deleted within 90 minutes. Launched Test or Cutover instances
        /// will NOT be terminated. The AWS Replication Agent will receive a command to uninstall
        /// itself (within 10 minutes). The following properties of the SourceServer will be changed
        /// immediately: dataReplicationInfo.dataReplicationState will be changed to DISCONNECTED;
        /// The SourceServer.lifeCycle.state will be changed to CUTOVER; The totalStorageBytes
        /// property fo each of dataReplicationInfo.replicatedDisks will be set to zero; dataReplicationInfo.lagDuration
        /// and dataReplicationInfo.lagDuration will be nullified.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FinalizeCutover service method.</param>
        /// 
        /// <returns>The response from the FinalizeCutover service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/FinalizeCutover">REST API Reference for FinalizeCutover Operation</seealso>
        public virtual FinalizeCutoverResponse FinalizeCutover(FinalizeCutoverRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = FinalizeCutoverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FinalizeCutoverResponseUnmarshaller.Instance;

            return Invoke<FinalizeCutoverResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the FinalizeCutover operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the FinalizeCutover operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndFinalizeCutover
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/FinalizeCutover">REST API Reference for FinalizeCutover Operation</seealso>
        public virtual IAsyncResult BeginFinalizeCutover(FinalizeCutoverRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = FinalizeCutoverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FinalizeCutoverResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  FinalizeCutover operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginFinalizeCutover.</param>
        /// 
        /// <returns>Returns a  FinalizeCutoverResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/FinalizeCutover">REST API Reference for FinalizeCutover Operation</seealso>
        public virtual FinalizeCutoverResponse EndFinalizeCutover(IAsyncResult asyncResult)
        {
            return EndInvoke<FinalizeCutoverResponse>(asyncResult);
        }

        #endregion
        
        #region  GetLaunchConfiguration

        /// <summary>
        /// Lists all LaunchConfigurations available, filtered by Source Server IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLaunchConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetLaunchConfiguration service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/GetLaunchConfiguration">REST API Reference for GetLaunchConfiguration Operation</seealso>
        public virtual GetLaunchConfigurationResponse GetLaunchConfiguration(GetLaunchConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLaunchConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLaunchConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetLaunchConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetLaunchConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLaunchConfiguration operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLaunchConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/GetLaunchConfiguration">REST API Reference for GetLaunchConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetLaunchConfiguration(GetLaunchConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLaunchConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLaunchConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetLaunchConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLaunchConfiguration.</param>
        /// 
        /// <returns>Returns a  GetLaunchConfigurationResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/GetLaunchConfiguration">REST API Reference for GetLaunchConfiguration Operation</seealso>
        public virtual GetLaunchConfigurationResponse EndGetLaunchConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetLaunchConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetReplicationConfiguration

        /// <summary>
        /// Lists all ReplicationConfigurations, filtered by Source Server ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReplicationConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetReplicationConfiguration service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/GetReplicationConfiguration">REST API Reference for GetReplicationConfiguration Operation</seealso>
        public virtual GetReplicationConfigurationResponse GetReplicationConfiguration(GetReplicationConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetReplicationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReplicationConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetReplicationConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetReplicationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetReplicationConfiguration operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetReplicationConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/GetReplicationConfiguration">REST API Reference for GetReplicationConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetReplicationConfiguration(GetReplicationConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetReplicationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReplicationConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetReplicationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetReplicationConfiguration.</param>
        /// 
        /// <returns>Returns a  GetReplicationConfigurationResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/GetReplicationConfiguration">REST API Reference for GetReplicationConfiguration Operation</seealso>
        public virtual GetReplicationConfigurationResponse EndGetReplicationConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetReplicationConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  InitializeService

        /// <summary>
        /// Initialize Application Migration Service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InitializeService service method.</param>
        /// 
        /// <returns>The response from the InitializeService service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operating denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/InitializeService">REST API Reference for InitializeService Operation</seealso>
        public virtual InitializeServiceResponse InitializeService(InitializeServiceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InitializeServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InitializeServiceResponseUnmarshaller.Instance;

            return Invoke<InitializeServiceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the InitializeService operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InitializeService operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndInitializeService
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/InitializeService">REST API Reference for InitializeService Operation</seealso>
        public virtual IAsyncResult BeginInitializeService(InitializeServiceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InitializeServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InitializeServiceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  InitializeService operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInitializeService.</param>
        /// 
        /// <returns>Returns a  InitializeServiceResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/InitializeService">REST API Reference for InitializeService Operation</seealso>
        public virtual InitializeServiceResponse EndInitializeService(IAsyncResult asyncResult)
        {
            return EndInvoke<InitializeServiceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListApplications

        /// <summary>
        /// Retrieves all applications or multiple applications by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplications service method.</param>
        /// 
        /// <returns>The response from the ListApplications service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListApplications">REST API Reference for ListApplications Operation</seealso>
        public virtual ListApplicationsResponse ListApplications(ListApplicationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationsResponseUnmarshaller.Instance;

            return Invoke<ListApplicationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListApplications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApplications operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListApplications
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListApplications">REST API Reference for ListApplications Operation</seealso>
        public virtual IAsyncResult BeginListApplications(ListApplicationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListApplications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListApplications.</param>
        /// 
        /// <returns>Returns a  ListApplicationsResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListApplications">REST API Reference for ListApplications Operation</seealso>
        public virtual ListApplicationsResponse EndListApplications(IAsyncResult asyncResult)
        {
            return EndInvoke<ListApplicationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSourceServerActions

        /// <summary>
        /// List source server post migration custom actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSourceServerActions service method.</param>
        /// 
        /// <returns>The response from the ListSourceServerActions service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListSourceServerActions">REST API Reference for ListSourceServerActions Operation</seealso>
        public virtual ListSourceServerActionsResponse ListSourceServerActions(ListSourceServerActionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSourceServerActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSourceServerActionsResponseUnmarshaller.Instance;

            return Invoke<ListSourceServerActionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSourceServerActions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSourceServerActions operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSourceServerActions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListSourceServerActions">REST API Reference for ListSourceServerActions Operation</seealso>
        public virtual IAsyncResult BeginListSourceServerActions(ListSourceServerActionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSourceServerActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSourceServerActionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSourceServerActions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSourceServerActions.</param>
        /// 
        /// <returns>Returns a  ListSourceServerActionsResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListSourceServerActions">REST API Reference for ListSourceServerActions Operation</seealso>
        public virtual ListSourceServerActionsResponse EndListSourceServerActions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSourceServerActionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// List all tags for your Application Migration Service resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operating denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.InternalServerException">
        /// The server encountered an unexpected condition that prevented it from fulfilling the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ThrottlingException">
        /// Reached throttling quota exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTemplateActions

        /// <summary>
        /// List template post migration custom actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTemplateActions service method.</param>
        /// 
        /// <returns>The response from the ListTemplateActions service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListTemplateActions">REST API Reference for ListTemplateActions Operation</seealso>
        public virtual ListTemplateActionsResponse ListTemplateActions(ListTemplateActionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTemplateActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTemplateActionsResponseUnmarshaller.Instance;

            return Invoke<ListTemplateActionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTemplateActions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTemplateActions operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTemplateActions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListTemplateActions">REST API Reference for ListTemplateActions Operation</seealso>
        public virtual IAsyncResult BeginListTemplateActions(ListTemplateActionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTemplateActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTemplateActionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTemplateActions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTemplateActions.</param>
        /// 
        /// <returns>Returns a  ListTemplateActionsResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListTemplateActions">REST API Reference for ListTemplateActions Operation</seealso>
        public virtual ListTemplateActionsResponse EndListTemplateActions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTemplateActionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListWaves

        /// <summary>
        /// Retrieves all waves or multiple waves by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWaves service method.</param>
        /// 
        /// <returns>The response from the ListWaves service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListWaves">REST API Reference for ListWaves Operation</seealso>
        public virtual ListWavesResponse ListWaves(ListWavesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWavesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWavesResponseUnmarshaller.Instance;

            return Invoke<ListWavesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListWaves operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWaves operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWaves
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListWaves">REST API Reference for ListWaves Operation</seealso>
        public virtual IAsyncResult BeginListWaves(ListWavesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWavesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWavesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListWaves operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWaves.</param>
        /// 
        /// <returns>Returns a  ListWavesResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListWaves">REST API Reference for ListWaves Operation</seealso>
        public virtual ListWavesResponse EndListWaves(IAsyncResult asyncResult)
        {
            return EndInvoke<ListWavesResponse>(asyncResult);
        }

        #endregion
        
        #region  MarkAsArchived

        /// <summary>
        /// Archives specific Source Servers by setting the SourceServer.isArchived property to
        /// true for specified SourceServers by ID. This command only works for SourceServers
        /// with a lifecycle. state which equals DISCONNECTED or CUTOVER.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MarkAsArchived service method.</param>
        /// 
        /// <returns>The response from the MarkAsArchived service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/MarkAsArchived">REST API Reference for MarkAsArchived Operation</seealso>
        public virtual MarkAsArchivedResponse MarkAsArchived(MarkAsArchivedRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = MarkAsArchivedRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MarkAsArchivedResponseUnmarshaller.Instance;

            return Invoke<MarkAsArchivedResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the MarkAsArchived operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the MarkAsArchived operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndMarkAsArchived
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/MarkAsArchived">REST API Reference for MarkAsArchived Operation</seealso>
        public virtual IAsyncResult BeginMarkAsArchived(MarkAsArchivedRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = MarkAsArchivedRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MarkAsArchivedResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  MarkAsArchived operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginMarkAsArchived.</param>
        /// 
        /// <returns>Returns a  MarkAsArchivedResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/MarkAsArchived">REST API Reference for MarkAsArchived Operation</seealso>
        public virtual MarkAsArchivedResponse EndMarkAsArchived(IAsyncResult asyncResult)
        {
            return EndInvoke<MarkAsArchivedResponse>(asyncResult);
        }

        #endregion
        
        #region  PutSourceServerAction

        /// <summary>
        /// Put source server post migration custom action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutSourceServerAction service method.</param>
        /// 
        /// <returns>The response from the PutSourceServerAction service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/PutSourceServerAction">REST API Reference for PutSourceServerAction Operation</seealso>
        public virtual PutSourceServerActionResponse PutSourceServerAction(PutSourceServerActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutSourceServerActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSourceServerActionResponseUnmarshaller.Instance;

            return Invoke<PutSourceServerActionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutSourceServerAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutSourceServerAction operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutSourceServerAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/PutSourceServerAction">REST API Reference for PutSourceServerAction Operation</seealso>
        public virtual IAsyncResult BeginPutSourceServerAction(PutSourceServerActionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutSourceServerActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSourceServerActionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutSourceServerAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutSourceServerAction.</param>
        /// 
        /// <returns>Returns a  PutSourceServerActionResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/PutSourceServerAction">REST API Reference for PutSourceServerAction Operation</seealso>
        public virtual PutSourceServerActionResponse EndPutSourceServerAction(IAsyncResult asyncResult)
        {
            return EndInvoke<PutSourceServerActionResponse>(asyncResult);
        }

        #endregion
        
        #region  PutTemplateAction

        /// <summary>
        /// Put template post migration custom action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutTemplateAction service method.</param>
        /// 
        /// <returns>The response from the PutTemplateAction service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/PutTemplateAction">REST API Reference for PutTemplateAction Operation</seealso>
        public virtual PutTemplateActionResponse PutTemplateAction(PutTemplateActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutTemplateActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutTemplateActionResponseUnmarshaller.Instance;

            return Invoke<PutTemplateActionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutTemplateAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutTemplateAction operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutTemplateAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/PutTemplateAction">REST API Reference for PutTemplateAction Operation</seealso>
        public virtual IAsyncResult BeginPutTemplateAction(PutTemplateActionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutTemplateActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutTemplateActionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutTemplateAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutTemplateAction.</param>
        /// 
        /// <returns>Returns a  PutTemplateActionResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/PutTemplateAction">REST API Reference for PutTemplateAction Operation</seealso>
        public virtual PutTemplateActionResponse EndPutTemplateAction(IAsyncResult asyncResult)
        {
            return EndInvoke<PutTemplateActionResponse>(asyncResult);
        }

        #endregion
        
        #region  RemoveSourceServerAction

        /// <summary>
        /// Remove source server post migration custom action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveSourceServerAction service method.</param>
        /// 
        /// <returns>The response from the RemoveSourceServerAction service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/RemoveSourceServerAction">REST API Reference for RemoveSourceServerAction Operation</seealso>
        public virtual RemoveSourceServerActionResponse RemoveSourceServerAction(RemoveSourceServerActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveSourceServerActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveSourceServerActionResponseUnmarshaller.Instance;

            return Invoke<RemoveSourceServerActionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveSourceServerAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveSourceServerAction operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveSourceServerAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/RemoveSourceServerAction">REST API Reference for RemoveSourceServerAction Operation</seealso>
        public virtual IAsyncResult BeginRemoveSourceServerAction(RemoveSourceServerActionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveSourceServerActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveSourceServerActionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveSourceServerAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveSourceServerAction.</param>
        /// 
        /// <returns>Returns a  RemoveSourceServerActionResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/RemoveSourceServerAction">REST API Reference for RemoveSourceServerAction Operation</seealso>
        public virtual RemoveSourceServerActionResponse EndRemoveSourceServerAction(IAsyncResult asyncResult)
        {
            return EndInvoke<RemoveSourceServerActionResponse>(asyncResult);
        }

        #endregion
        
        #region  RemoveTemplateAction

        /// <summary>
        /// Remove template post migration custom action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTemplateAction service method.</param>
        /// 
        /// <returns>The response from the RemoveTemplateAction service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/RemoveTemplateAction">REST API Reference for RemoveTemplateAction Operation</seealso>
        public virtual RemoveTemplateActionResponse RemoveTemplateAction(RemoveTemplateActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveTemplateActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTemplateActionResponseUnmarshaller.Instance;

            return Invoke<RemoveTemplateActionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTemplateAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTemplateAction operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveTemplateAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/RemoveTemplateAction">REST API Reference for RemoveTemplateAction Operation</seealso>
        public virtual IAsyncResult BeginRemoveTemplateAction(RemoveTemplateActionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveTemplateActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTemplateActionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveTemplateAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveTemplateAction.</param>
        /// 
        /// <returns>Returns a  RemoveTemplateActionResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/RemoveTemplateAction">REST API Reference for RemoveTemplateAction Operation</seealso>
        public virtual RemoveTemplateActionResponse EndRemoveTemplateAction(IAsyncResult asyncResult)
        {
            return EndInvoke<RemoveTemplateActionResponse>(asyncResult);
        }

        #endregion
        
        #region  RetryDataReplication

        /// <summary>
        /// Causes the data replication initiation sequence to begin immediately upon next Handshake
        /// for specified SourceServer IDs, regardless of when the previous initiation started.
        /// This command will not work if the SourceServer is not stalled or is in a DISCONNECTED
        /// or STOPPED state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetryDataReplication service method.</param>
        /// 
        /// <returns>The response from the RetryDataReplication service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/RetryDataReplication">REST API Reference for RetryDataReplication Operation</seealso>
        public virtual RetryDataReplicationResponse RetryDataReplication(RetryDataReplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RetryDataReplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RetryDataReplicationResponseUnmarshaller.Instance;

            return Invoke<RetryDataReplicationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RetryDataReplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RetryDataReplication operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRetryDataReplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/RetryDataReplication">REST API Reference for RetryDataReplication Operation</seealso>
        public virtual IAsyncResult BeginRetryDataReplication(RetryDataReplicationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RetryDataReplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RetryDataReplicationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RetryDataReplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRetryDataReplication.</param>
        /// 
        /// <returns>Returns a  RetryDataReplicationResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/RetryDataReplication">REST API Reference for RetryDataReplication Operation</seealso>
        public virtual RetryDataReplicationResponse EndRetryDataReplication(IAsyncResult asyncResult)
        {
            return EndInvoke<RetryDataReplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  StartCutover

        /// <summary>
        /// Launches a Cutover Instance for specific Source Servers. This command starts a LAUNCH
        /// job whose initiatedBy property is StartCutover and changes the SourceServer.lifeCycle.state
        /// property to CUTTING_OVER.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCutover service method.</param>
        /// 
        /// <returns>The response from the StartCutover service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/StartCutover">REST API Reference for StartCutover Operation</seealso>
        public virtual StartCutoverResponse StartCutover(StartCutoverRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartCutoverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCutoverResponseUnmarshaller.Instance;

            return Invoke<StartCutoverResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartCutover operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartCutover operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartCutover
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/StartCutover">REST API Reference for StartCutover Operation</seealso>
        public virtual IAsyncResult BeginStartCutover(StartCutoverRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartCutoverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCutoverResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartCutover operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartCutover.</param>
        /// 
        /// <returns>Returns a  StartCutoverResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/StartCutover">REST API Reference for StartCutover Operation</seealso>
        public virtual StartCutoverResponse EndStartCutover(IAsyncResult asyncResult)
        {
            return EndInvoke<StartCutoverResponse>(asyncResult);
        }

        #endregion
        
        #region  StartReplication

        /// <summary>
        /// Starts replication for SNAPSHOT_SHIPPING agents.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartReplication service method.</param>
        /// 
        /// <returns>The response from the StartReplication service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because its exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/StartReplication">REST API Reference for StartReplication Operation</seealso>
        public virtual StartReplicationResponse StartReplication(StartReplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartReplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartReplicationResponseUnmarshaller.Instance;

            return Invoke<StartReplicationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartReplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartReplication operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartReplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/StartReplication">REST API Reference for StartReplication Operation</seealso>
        public virtual IAsyncResult BeginStartReplication(StartReplicationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartReplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartReplicationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartReplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartReplication.</param>
        /// 
        /// <returns>Returns a  StartReplicationResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/StartReplication">REST API Reference for StartReplication Operation</seealso>
        public virtual StartReplicationResponse EndStartReplication(IAsyncResult asyncResult)
        {
            return EndInvoke<StartReplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  StartTest

        /// <summary>
        /// Launches a Test Instance for specific Source Servers. This command starts a LAUNCH
        /// job whose initiatedBy property is StartTest and changes the SourceServer.lifeCycle.state
        /// property to TESTING.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTest service method.</param>
        /// 
        /// <returns>The response from the StartTest service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/StartTest">REST API Reference for StartTest Operation</seealso>
        public virtual StartTestResponse StartTest(StartTestRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartTestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTestResponseUnmarshaller.Instance;

            return Invoke<StartTestResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartTest operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartTest operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartTest
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/StartTest">REST API Reference for StartTest Operation</seealso>
        public virtual IAsyncResult BeginStartTest(StartTestRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartTestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTestResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartTest operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartTest.</param>
        /// 
        /// <returns>Returns a  StartTestResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/StartTest">REST API Reference for StartTest Operation</seealso>
        public virtual StartTestResponse EndStartTest(IAsyncResult asyncResult)
        {
            return EndInvoke<StartTestResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds or overwrites only the specified tags for the specified Application Migration
        /// Service resource or resources. When you specify an existing tag key, the value is
        /// overwritten with the new value. Each resource can have a maximum of 50 tags. Each
        /// tag consists of a key and optional value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operating denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.InternalServerException">
        /// The server encountered an unexpected condition that prevented it from fulfilling the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ThrottlingException">
        /// Reached throttling quota exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  TerminateTargetInstances

        /// <summary>
        /// Starts a job that terminates specific launched EC2 Test and Cutover instances. This
        /// command will not work for any Source Server with a lifecycle.state of TESTING, CUTTING_OVER,
        /// or CUTOVER.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateTargetInstances service method.</param>
        /// 
        /// <returns>The response from the TerminateTargetInstances service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/TerminateTargetInstances">REST API Reference for TerminateTargetInstances Operation</seealso>
        public virtual TerminateTargetInstancesResponse TerminateTargetInstances(TerminateTargetInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TerminateTargetInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateTargetInstancesResponseUnmarshaller.Instance;

            return Invoke<TerminateTargetInstancesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TerminateTargetInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TerminateTargetInstances operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTerminateTargetInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/TerminateTargetInstances">REST API Reference for TerminateTargetInstances Operation</seealso>
        public virtual IAsyncResult BeginTerminateTargetInstances(TerminateTargetInstancesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TerminateTargetInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateTargetInstancesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TerminateTargetInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTerminateTargetInstances.</param>
        /// 
        /// <returns>Returns a  TerminateTargetInstancesResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/TerminateTargetInstances">REST API Reference for TerminateTargetInstances Operation</seealso>
        public virtual TerminateTargetInstancesResponse EndTerminateTargetInstances(IAsyncResult asyncResult)
        {
            return EndInvoke<TerminateTargetInstancesResponse>(asyncResult);
        }

        #endregion
        
        #region  UnarchiveApplication

        /// <summary>
        /// Unarchive application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnarchiveApplication service method.</param>
        /// 
        /// <returns>The response from the UnarchiveApplication service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because its exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UnarchiveApplication">REST API Reference for UnarchiveApplication Operation</seealso>
        public virtual UnarchiveApplicationResponse UnarchiveApplication(UnarchiveApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UnarchiveApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnarchiveApplicationResponseUnmarshaller.Instance;

            return Invoke<UnarchiveApplicationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UnarchiveApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UnarchiveApplication operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUnarchiveApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UnarchiveApplication">REST API Reference for UnarchiveApplication Operation</seealso>
        public virtual IAsyncResult BeginUnarchiveApplication(UnarchiveApplicationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UnarchiveApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnarchiveApplicationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UnarchiveApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUnarchiveApplication.</param>
        /// 
        /// <returns>Returns a  UnarchiveApplicationResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UnarchiveApplication">REST API Reference for UnarchiveApplication Operation</seealso>
        public virtual UnarchiveApplicationResponse EndUnarchiveApplication(IAsyncResult asyncResult)
        {
            return EndInvoke<UnarchiveApplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  UnarchiveWave

        /// <summary>
        /// Unarchive wave.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnarchiveWave service method.</param>
        /// 
        /// <returns>The response from the UnarchiveWave service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because its exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UnarchiveWave">REST API Reference for UnarchiveWave Operation</seealso>
        public virtual UnarchiveWaveResponse UnarchiveWave(UnarchiveWaveRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UnarchiveWaveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnarchiveWaveResponseUnmarshaller.Instance;

            return Invoke<UnarchiveWaveResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UnarchiveWave operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UnarchiveWave operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUnarchiveWave
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UnarchiveWave">REST API Reference for UnarchiveWave Operation</seealso>
        public virtual IAsyncResult BeginUnarchiveWave(UnarchiveWaveRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UnarchiveWaveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnarchiveWaveResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UnarchiveWave operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUnarchiveWave.</param>
        /// 
        /// <returns>Returns a  UnarchiveWaveResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UnarchiveWave">REST API Reference for UnarchiveWave Operation</seealso>
        public virtual UnarchiveWaveResponse EndUnarchiveWave(IAsyncResult asyncResult)
        {
            return EndInvoke<UnarchiveWaveResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Deletes the specified set of tags from the specified set of Application Migration
        /// Service resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operating denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.InternalServerException">
        /// The server encountered an unexpected condition that prevented it from fulfilling the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ThrottlingException">
        /// Reached throttling quota exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateApplication

        /// <summary>
        /// Update application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication service method.</param>
        /// 
        /// <returns>The response from the UpdateApplication service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        public virtual UpdateApplicationResponse UpdateApplication(UpdateApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationResponseUnmarshaller.Instance;

            return Invoke<UpdateApplicationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        public virtual IAsyncResult BeginUpdateApplication(UpdateApplicationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApplication.</param>
        /// 
        /// <returns>Returns a  UpdateApplicationResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        public virtual UpdateApplicationResponse EndUpdateApplication(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateApplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateLaunchConfiguration

        /// <summary>
        /// Updates multiple LaunchConfigurations by Source Server ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLaunchConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateLaunchConfiguration service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateLaunchConfiguration">REST API Reference for UpdateLaunchConfiguration Operation</seealso>
        public virtual UpdateLaunchConfigurationResponse UpdateLaunchConfiguration(UpdateLaunchConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLaunchConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLaunchConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateLaunchConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLaunchConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLaunchConfiguration operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLaunchConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateLaunchConfiguration">REST API Reference for UpdateLaunchConfiguration Operation</seealso>
        public virtual IAsyncResult BeginUpdateLaunchConfiguration(UpdateLaunchConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLaunchConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLaunchConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLaunchConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLaunchConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateLaunchConfigurationResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateLaunchConfiguration">REST API Reference for UpdateLaunchConfiguration Operation</seealso>
        public virtual UpdateLaunchConfigurationResponse EndUpdateLaunchConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateLaunchConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateLaunchConfigurationTemplate

        /// <summary>
        /// Updates an existing Launch Configuration Template by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLaunchConfigurationTemplate service method.</param>
        /// 
        /// <returns>The response from the UpdateLaunchConfigurationTemplate service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operating denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateLaunchConfigurationTemplate">REST API Reference for UpdateLaunchConfigurationTemplate Operation</seealso>
        public virtual UpdateLaunchConfigurationTemplateResponse UpdateLaunchConfigurationTemplate(UpdateLaunchConfigurationTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLaunchConfigurationTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLaunchConfigurationTemplateResponseUnmarshaller.Instance;

            return Invoke<UpdateLaunchConfigurationTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLaunchConfigurationTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLaunchConfigurationTemplate operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLaunchConfigurationTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateLaunchConfigurationTemplate">REST API Reference for UpdateLaunchConfigurationTemplate Operation</seealso>
        public virtual IAsyncResult BeginUpdateLaunchConfigurationTemplate(UpdateLaunchConfigurationTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLaunchConfigurationTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLaunchConfigurationTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLaunchConfigurationTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLaunchConfigurationTemplate.</param>
        /// 
        /// <returns>Returns a  UpdateLaunchConfigurationTemplateResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateLaunchConfigurationTemplate">REST API Reference for UpdateLaunchConfigurationTemplate Operation</seealso>
        public virtual UpdateLaunchConfigurationTemplateResponse EndUpdateLaunchConfigurationTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateLaunchConfigurationTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateReplicationConfiguration

        /// <summary>
        /// Allows you to update multiple ReplicationConfigurations by Source Server ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateReplicationConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateReplicationConfiguration service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operating denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateReplicationConfiguration">REST API Reference for UpdateReplicationConfiguration Operation</seealso>
        public virtual UpdateReplicationConfigurationResponse UpdateReplicationConfiguration(UpdateReplicationConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateReplicationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateReplicationConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateReplicationConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateReplicationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateReplicationConfiguration operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateReplicationConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateReplicationConfiguration">REST API Reference for UpdateReplicationConfiguration Operation</seealso>
        public virtual IAsyncResult BeginUpdateReplicationConfiguration(UpdateReplicationConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateReplicationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateReplicationConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateReplicationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateReplicationConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateReplicationConfigurationResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateReplicationConfiguration">REST API Reference for UpdateReplicationConfiguration Operation</seealso>
        public virtual UpdateReplicationConfigurationResponse EndUpdateReplicationConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateReplicationConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateReplicationConfigurationTemplate

        /// <summary>
        /// Updates multiple ReplicationConfigurationTemplates by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateReplicationConfigurationTemplate service method.</param>
        /// 
        /// <returns>The response from the UpdateReplicationConfigurationTemplate service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operating denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateReplicationConfigurationTemplate">REST API Reference for UpdateReplicationConfigurationTemplate Operation</seealso>
        public virtual UpdateReplicationConfigurationTemplateResponse UpdateReplicationConfigurationTemplate(UpdateReplicationConfigurationTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateReplicationConfigurationTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateReplicationConfigurationTemplateResponseUnmarshaller.Instance;

            return Invoke<UpdateReplicationConfigurationTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateReplicationConfigurationTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateReplicationConfigurationTemplate operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateReplicationConfigurationTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateReplicationConfigurationTemplate">REST API Reference for UpdateReplicationConfigurationTemplate Operation</seealso>
        public virtual IAsyncResult BeginUpdateReplicationConfigurationTemplate(UpdateReplicationConfigurationTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateReplicationConfigurationTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateReplicationConfigurationTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateReplicationConfigurationTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateReplicationConfigurationTemplate.</param>
        /// 
        /// <returns>Returns a  UpdateReplicationConfigurationTemplateResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateReplicationConfigurationTemplate">REST API Reference for UpdateReplicationConfigurationTemplate Operation</seealso>
        public virtual UpdateReplicationConfigurationTemplateResponse EndUpdateReplicationConfigurationTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateReplicationConfigurationTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateSourceServerReplicationType

        /// <summary>
        /// Allows you to change between the AGENT_BASED replication type and the SNAPSHOT_SHIPPING
        /// replication type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSourceServerReplicationType service method.</param>
        /// 
        /// <returns>The response from the UpdateSourceServerReplicationType service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateSourceServerReplicationType">REST API Reference for UpdateSourceServerReplicationType Operation</seealso>
        public virtual UpdateSourceServerReplicationTypeResponse UpdateSourceServerReplicationType(UpdateSourceServerReplicationTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSourceServerReplicationTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSourceServerReplicationTypeResponseUnmarshaller.Instance;

            return Invoke<UpdateSourceServerReplicationTypeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSourceServerReplicationType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSourceServerReplicationType operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSourceServerReplicationType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateSourceServerReplicationType">REST API Reference for UpdateSourceServerReplicationType Operation</seealso>
        public virtual IAsyncResult BeginUpdateSourceServerReplicationType(UpdateSourceServerReplicationTypeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSourceServerReplicationTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSourceServerReplicationTypeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSourceServerReplicationType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSourceServerReplicationType.</param>
        /// 
        /// <returns>Returns a  UpdateSourceServerReplicationTypeResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateSourceServerReplicationType">REST API Reference for UpdateSourceServerReplicationType Operation</seealso>
        public virtual UpdateSourceServerReplicationTypeResponse EndUpdateSourceServerReplicationType(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSourceServerReplicationTypeResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateWave

        /// <summary>
        /// Update wave.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWave service method.</param>
        /// 
        /// <returns>The response from the UpdateWave service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateWave">REST API Reference for UpdateWave Operation</seealso>
        public virtual UpdateWaveResponse UpdateWave(UpdateWaveRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWaveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWaveResponseUnmarshaller.Instance;

            return Invoke<UpdateWaveResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateWave operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWave operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateWave
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateWave">REST API Reference for UpdateWave Operation</seealso>
        public virtual IAsyncResult BeginUpdateWave(UpdateWaveRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWaveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWaveResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWave operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWave.</param>
        /// 
        /// <returns>Returns a  UpdateWaveResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateWave">REST API Reference for UpdateWave Operation</seealso>
        public virtual UpdateWaveResponse EndUpdateWave(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateWaveResponse>(asyncResult);
        }

        #endregion
        
    }
}