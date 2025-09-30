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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.Odb.Model;
using Amazon.Odb.Model.Internal.MarshallTransformations;
using Amazon.Odb.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.Odb
{
    /// <summary>
    /// <para>Implementation for accessing Odb</para>
    ///
    /// Oracle Database@Amazon Web Services is an offering that enables you to access Oracle
    /// Exadata infrastructure managed by Oracle Cloud Infrastructure (OCI) inside Amazon
    /// Web Services data centers. You can migrate your Oracle Exadata workloads, establish
    /// low-latency connectivity with applications running on Amazon Web Services, and integrate
    /// with Amazon Web Services services. For example, you can run application servers in
    /// a virtual private cloud (VPC) and access an Oracle Exadata system running in Oracle
    /// Database@Amazon Web Services. You can get started with Oracle Database@Amazon Web
    /// Services by using the familiar Amazon Web Services Management Console, APIs, or CLI.
    /// 
    ///  
    /// <para>
    /// This interface reference for Oracle Database@Amazon Web Services contains documentation
    /// for a programming or command line interface that you can use to manage Oracle Database@Amazon
    /// Web Services. Oracle Database@Amazon Web Services is asynchronous, which means that
    /// some interfaces might require techniques such as polling or callback functions to
    /// determine when a command has been applied. The reference structure is as follows.
    /// </para>
    ///  <note> 
    /// <para>
    /// In this preview release documentation, the links in the "See Also" sections do not
    /// work.
    /// </para>
    ///  </note> 
    /// <para>
    ///  <b>Oracle Database@Amazon Web Services API Reference</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// For the alphabetical list of API actions, see .
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For the alphabetical list of data types, see .
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For a list of common parameters, see <a>CommonParameters</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For descriptions of the error codes, see <a>CommonErrors</a>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonOdbClient : AmazonServiceClient, IAmazonOdb
    {
        private static IServiceMetadata serviceMetadata = new AmazonOdbMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IOdbPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IOdbPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new OdbPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonOdbClient with the credentials loaded from the application's
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
        public AmazonOdbClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonOdbConfig()) { }

        /// <summary>
        /// Constructs AmazonOdbClient with the credentials loaded from the application's
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
        public AmazonOdbClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonOdbConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonOdbClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonOdbClient Configuration Object</param>
        public AmazonOdbClient(AmazonOdbConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonOdbClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonOdbClient(AWSCredentials credentials)
            : this(credentials, new AmazonOdbConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonOdbClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonOdbClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonOdbConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonOdbClient with AWS Credentials and an
        /// AmazonOdbClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonOdbClient Configuration Object</param>
        public AmazonOdbClient(AWSCredentials credentials, AmazonOdbConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonOdbClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonOdbClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonOdbConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonOdbClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonOdbClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonOdbConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonOdbClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonOdbClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonOdbClient Configuration Object</param>
        public AmazonOdbClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonOdbConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonOdbClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonOdbClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonOdbConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonOdbClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonOdbClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonOdbConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonOdbClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonOdbClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonOdbClient Configuration Object</param>
        public AmazonOdbClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonOdbConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonOdbEndpointResolver());
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


        #region  AcceptMarketplaceRegistration

        /// <summary>
        /// Registers the Amazon Web Services Marketplace token for your Amazon Web Services account
        /// to activate your Oracle Database@Amazon Web Services subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptMarketplaceRegistration service method.</param>
        /// 
        /// <returns>The response from the AcceptMarketplaceRegistration service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/AcceptMarketplaceRegistration">REST API Reference for AcceptMarketplaceRegistration Operation</seealso>
        public virtual AcceptMarketplaceRegistrationResponse AcceptMarketplaceRegistration(AcceptMarketplaceRegistrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AcceptMarketplaceRegistrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptMarketplaceRegistrationResponseUnmarshaller.Instance;

            return Invoke<AcceptMarketplaceRegistrationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AcceptMarketplaceRegistration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptMarketplaceRegistration operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAcceptMarketplaceRegistration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/AcceptMarketplaceRegistration">REST API Reference for AcceptMarketplaceRegistration Operation</seealso>
        public virtual IAsyncResult BeginAcceptMarketplaceRegistration(AcceptMarketplaceRegistrationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AcceptMarketplaceRegistrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptMarketplaceRegistrationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AcceptMarketplaceRegistration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAcceptMarketplaceRegistration.</param>
        /// 
        /// <returns>Returns a  AcceptMarketplaceRegistrationResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/AcceptMarketplaceRegistration">REST API Reference for AcceptMarketplaceRegistration Operation</seealso>
        public virtual AcceptMarketplaceRegistrationResponse EndAcceptMarketplaceRegistration(IAsyncResult asyncResult)
        {
            return EndInvoke<AcceptMarketplaceRegistrationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateCloudAutonomousVmCluster

        /// <summary>
        /// Creates a new Autonomous VM cluster in the specified Exadata infrastructure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCloudAutonomousVmCluster service method.</param>
        /// 
        /// <returns>The response from the CreateCloudAutonomousVmCluster service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ServiceQuotaExceededException">
        /// You have exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/CreateCloudAutonomousVmCluster">REST API Reference for CreateCloudAutonomousVmCluster Operation</seealso>
        public virtual CreateCloudAutonomousVmClusterResponse CreateCloudAutonomousVmCluster(CreateCloudAutonomousVmClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCloudAutonomousVmClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCloudAutonomousVmClusterResponseUnmarshaller.Instance;

            return Invoke<CreateCloudAutonomousVmClusterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCloudAutonomousVmCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCloudAutonomousVmCluster operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCloudAutonomousVmCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/CreateCloudAutonomousVmCluster">REST API Reference for CreateCloudAutonomousVmCluster Operation</seealso>
        public virtual IAsyncResult BeginCreateCloudAutonomousVmCluster(CreateCloudAutonomousVmClusterRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCloudAutonomousVmClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCloudAutonomousVmClusterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCloudAutonomousVmCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCloudAutonomousVmCluster.</param>
        /// 
        /// <returns>Returns a  CreateCloudAutonomousVmClusterResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/CreateCloudAutonomousVmCluster">REST API Reference for CreateCloudAutonomousVmCluster Operation</seealso>
        public virtual CreateCloudAutonomousVmClusterResponse EndCreateCloudAutonomousVmCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateCloudAutonomousVmClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateCloudExadataInfrastructure

        /// <summary>
        /// Creates an Exadata infrastructure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCloudExadataInfrastructure service method.</param>
        /// 
        /// <returns>The response from the CreateCloudExadataInfrastructure service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ServiceQuotaExceededException">
        /// You have exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/CreateCloudExadataInfrastructure">REST API Reference for CreateCloudExadataInfrastructure Operation</seealso>
        public virtual CreateCloudExadataInfrastructureResponse CreateCloudExadataInfrastructure(CreateCloudExadataInfrastructureRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCloudExadataInfrastructureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCloudExadataInfrastructureResponseUnmarshaller.Instance;

            return Invoke<CreateCloudExadataInfrastructureResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCloudExadataInfrastructure operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCloudExadataInfrastructure operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCloudExadataInfrastructure
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/CreateCloudExadataInfrastructure">REST API Reference for CreateCloudExadataInfrastructure Operation</seealso>
        public virtual IAsyncResult BeginCreateCloudExadataInfrastructure(CreateCloudExadataInfrastructureRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCloudExadataInfrastructureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCloudExadataInfrastructureResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCloudExadataInfrastructure operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCloudExadataInfrastructure.</param>
        /// 
        /// <returns>Returns a  CreateCloudExadataInfrastructureResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/CreateCloudExadataInfrastructure">REST API Reference for CreateCloudExadataInfrastructure Operation</seealso>
        public virtual CreateCloudExadataInfrastructureResponse EndCreateCloudExadataInfrastructure(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateCloudExadataInfrastructureResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateCloudVmCluster

        /// <summary>
        /// Creates a VM cluster on the specified Exadata infrastructure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCloudVmCluster service method.</param>
        /// 
        /// <returns>The response from the CreateCloudVmCluster service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ServiceQuotaExceededException">
        /// You have exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/CreateCloudVmCluster">REST API Reference for CreateCloudVmCluster Operation</seealso>
        public virtual CreateCloudVmClusterResponse CreateCloudVmCluster(CreateCloudVmClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCloudVmClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCloudVmClusterResponseUnmarshaller.Instance;

            return Invoke<CreateCloudVmClusterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCloudVmCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCloudVmCluster operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCloudVmCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/CreateCloudVmCluster">REST API Reference for CreateCloudVmCluster Operation</seealso>
        public virtual IAsyncResult BeginCreateCloudVmCluster(CreateCloudVmClusterRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCloudVmClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCloudVmClusterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCloudVmCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCloudVmCluster.</param>
        /// 
        /// <returns>Returns a  CreateCloudVmClusterResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/CreateCloudVmCluster">REST API Reference for CreateCloudVmCluster Operation</seealso>
        public virtual CreateCloudVmClusterResponse EndCreateCloudVmCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateCloudVmClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateOdbNetwork

        /// <summary>
        /// Creates an ODB network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOdbNetwork service method.</param>
        /// 
        /// <returns>The response from the CreateOdbNetwork service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ServiceQuotaExceededException">
        /// You have exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/CreateOdbNetwork">REST API Reference for CreateOdbNetwork Operation</seealso>
        public virtual CreateOdbNetworkResponse CreateOdbNetwork(CreateOdbNetworkRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateOdbNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOdbNetworkResponseUnmarshaller.Instance;

            return Invoke<CreateOdbNetworkResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateOdbNetwork operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateOdbNetwork operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateOdbNetwork
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/CreateOdbNetwork">REST API Reference for CreateOdbNetwork Operation</seealso>
        public virtual IAsyncResult BeginCreateOdbNetwork(CreateOdbNetworkRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateOdbNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOdbNetworkResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateOdbNetwork operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateOdbNetwork.</param>
        /// 
        /// <returns>Returns a  CreateOdbNetworkResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/CreateOdbNetwork">REST API Reference for CreateOdbNetwork Operation</seealso>
        public virtual CreateOdbNetworkResponse EndCreateOdbNetwork(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateOdbNetworkResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateOdbPeeringConnection

        /// <summary>
        /// Creates a peering connection between an ODB network and either another ODB network
        /// or a customer-owned VPC.
        /// 
        ///  
        /// <para>
        /// A peering connection enables private connectivity between the networks for application-tier
        /// communication.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOdbPeeringConnection service method.</param>
        /// 
        /// <returns>The response from the CreateOdbPeeringConnection service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/CreateOdbPeeringConnection">REST API Reference for CreateOdbPeeringConnection Operation</seealso>
        public virtual CreateOdbPeeringConnectionResponse CreateOdbPeeringConnection(CreateOdbPeeringConnectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateOdbPeeringConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOdbPeeringConnectionResponseUnmarshaller.Instance;

            return Invoke<CreateOdbPeeringConnectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateOdbPeeringConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateOdbPeeringConnection operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateOdbPeeringConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/CreateOdbPeeringConnection">REST API Reference for CreateOdbPeeringConnection Operation</seealso>
        public virtual IAsyncResult BeginCreateOdbPeeringConnection(CreateOdbPeeringConnectionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateOdbPeeringConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOdbPeeringConnectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateOdbPeeringConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateOdbPeeringConnection.</param>
        /// 
        /// <returns>Returns a  CreateOdbPeeringConnectionResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/CreateOdbPeeringConnection">REST API Reference for CreateOdbPeeringConnection Operation</seealso>
        public virtual CreateOdbPeeringConnectionResponse EndCreateOdbPeeringConnection(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateOdbPeeringConnectionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteCloudAutonomousVmCluster

        /// <summary>
        /// Deletes an Autonomous VM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCloudAutonomousVmCluster service method.</param>
        /// 
        /// <returns>The response from the DeleteCloudAutonomousVmCluster service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/DeleteCloudAutonomousVmCluster">REST API Reference for DeleteCloudAutonomousVmCluster Operation</seealso>
        public virtual DeleteCloudAutonomousVmClusterResponse DeleteCloudAutonomousVmCluster(DeleteCloudAutonomousVmClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCloudAutonomousVmClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCloudAutonomousVmClusterResponseUnmarshaller.Instance;

            return Invoke<DeleteCloudAutonomousVmClusterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCloudAutonomousVmCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCloudAutonomousVmCluster operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCloudAutonomousVmCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/DeleteCloudAutonomousVmCluster">REST API Reference for DeleteCloudAutonomousVmCluster Operation</seealso>
        public virtual IAsyncResult BeginDeleteCloudAutonomousVmCluster(DeleteCloudAutonomousVmClusterRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCloudAutonomousVmClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCloudAutonomousVmClusterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCloudAutonomousVmCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCloudAutonomousVmCluster.</param>
        /// 
        /// <returns>Returns a  DeleteCloudAutonomousVmClusterResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/DeleteCloudAutonomousVmCluster">REST API Reference for DeleteCloudAutonomousVmCluster Operation</seealso>
        public virtual DeleteCloudAutonomousVmClusterResponse EndDeleteCloudAutonomousVmCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteCloudAutonomousVmClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteCloudExadataInfrastructure

        /// <summary>
        /// Deletes the specified Exadata infrastructure. Before you use this operation, make
        /// sure to delete all of the VM clusters that are hosted on this Exadata infrastructure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCloudExadataInfrastructure service method.</param>
        /// 
        /// <returns>The response from the DeleteCloudExadataInfrastructure service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/DeleteCloudExadataInfrastructure">REST API Reference for DeleteCloudExadataInfrastructure Operation</seealso>
        public virtual DeleteCloudExadataInfrastructureResponse DeleteCloudExadataInfrastructure(DeleteCloudExadataInfrastructureRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCloudExadataInfrastructureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCloudExadataInfrastructureResponseUnmarshaller.Instance;

            return Invoke<DeleteCloudExadataInfrastructureResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCloudExadataInfrastructure operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCloudExadataInfrastructure operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCloudExadataInfrastructure
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/DeleteCloudExadataInfrastructure">REST API Reference for DeleteCloudExadataInfrastructure Operation</seealso>
        public virtual IAsyncResult BeginDeleteCloudExadataInfrastructure(DeleteCloudExadataInfrastructureRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCloudExadataInfrastructureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCloudExadataInfrastructureResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCloudExadataInfrastructure operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCloudExadataInfrastructure.</param>
        /// 
        /// <returns>Returns a  DeleteCloudExadataInfrastructureResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/DeleteCloudExadataInfrastructure">REST API Reference for DeleteCloudExadataInfrastructure Operation</seealso>
        public virtual DeleteCloudExadataInfrastructureResponse EndDeleteCloudExadataInfrastructure(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteCloudExadataInfrastructureResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteCloudVmCluster

        /// <summary>
        /// Deletes the specified VM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCloudVmCluster service method.</param>
        /// 
        /// <returns>The response from the DeleteCloudVmCluster service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/DeleteCloudVmCluster">REST API Reference for DeleteCloudVmCluster Operation</seealso>
        public virtual DeleteCloudVmClusterResponse DeleteCloudVmCluster(DeleteCloudVmClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCloudVmClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCloudVmClusterResponseUnmarshaller.Instance;

            return Invoke<DeleteCloudVmClusterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCloudVmCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCloudVmCluster operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCloudVmCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/DeleteCloudVmCluster">REST API Reference for DeleteCloudVmCluster Operation</seealso>
        public virtual IAsyncResult BeginDeleteCloudVmCluster(DeleteCloudVmClusterRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCloudVmClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCloudVmClusterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCloudVmCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCloudVmCluster.</param>
        /// 
        /// <returns>Returns a  DeleteCloudVmClusterResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/DeleteCloudVmCluster">REST API Reference for DeleteCloudVmCluster Operation</seealso>
        public virtual DeleteCloudVmClusterResponse EndDeleteCloudVmCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteCloudVmClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteOdbNetwork

        /// <summary>
        /// Deletes the specified ODB network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOdbNetwork service method.</param>
        /// 
        /// <returns>The response from the DeleteOdbNetwork service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/DeleteOdbNetwork">REST API Reference for DeleteOdbNetwork Operation</seealso>
        public virtual DeleteOdbNetworkResponse DeleteOdbNetwork(DeleteOdbNetworkRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteOdbNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOdbNetworkResponseUnmarshaller.Instance;

            return Invoke<DeleteOdbNetworkResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteOdbNetwork operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteOdbNetwork operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteOdbNetwork
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/DeleteOdbNetwork">REST API Reference for DeleteOdbNetwork Operation</seealso>
        public virtual IAsyncResult BeginDeleteOdbNetwork(DeleteOdbNetworkRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteOdbNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOdbNetworkResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteOdbNetwork operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteOdbNetwork.</param>
        /// 
        /// <returns>Returns a  DeleteOdbNetworkResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/DeleteOdbNetwork">REST API Reference for DeleteOdbNetwork Operation</seealso>
        public virtual DeleteOdbNetworkResponse EndDeleteOdbNetwork(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteOdbNetworkResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteOdbPeeringConnection

        /// <summary>
        /// Deletes an ODB peering connection.
        /// 
        ///  
        /// <para>
        /// When you delete an ODB peering connection, the underlying VPC peering connection is
        /// also deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOdbPeeringConnection service method.</param>
        /// 
        /// <returns>The response from the DeleteOdbPeeringConnection service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/DeleteOdbPeeringConnection">REST API Reference for DeleteOdbPeeringConnection Operation</seealso>
        public virtual DeleteOdbPeeringConnectionResponse DeleteOdbPeeringConnection(DeleteOdbPeeringConnectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteOdbPeeringConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOdbPeeringConnectionResponseUnmarshaller.Instance;

            return Invoke<DeleteOdbPeeringConnectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteOdbPeeringConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteOdbPeeringConnection operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteOdbPeeringConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/DeleteOdbPeeringConnection">REST API Reference for DeleteOdbPeeringConnection Operation</seealso>
        public virtual IAsyncResult BeginDeleteOdbPeeringConnection(DeleteOdbPeeringConnectionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteOdbPeeringConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOdbPeeringConnectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteOdbPeeringConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteOdbPeeringConnection.</param>
        /// 
        /// <returns>Returns a  DeleteOdbPeeringConnectionResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/DeleteOdbPeeringConnection">REST API Reference for DeleteOdbPeeringConnection Operation</seealso>
        public virtual DeleteOdbPeeringConnectionResponse EndDeleteOdbPeeringConnection(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteOdbPeeringConnectionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCloudAutonomousVmCluster

        /// <summary>
        /// Gets information about a specific Autonomous VM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCloudAutonomousVmCluster service method.</param>
        /// 
        /// <returns>The response from the GetCloudAutonomousVmCluster service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetCloudAutonomousVmCluster">REST API Reference for GetCloudAutonomousVmCluster Operation</seealso>
        public virtual GetCloudAutonomousVmClusterResponse GetCloudAutonomousVmCluster(GetCloudAutonomousVmClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCloudAutonomousVmClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCloudAutonomousVmClusterResponseUnmarshaller.Instance;

            return Invoke<GetCloudAutonomousVmClusterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCloudAutonomousVmCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCloudAutonomousVmCluster operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCloudAutonomousVmCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetCloudAutonomousVmCluster">REST API Reference for GetCloudAutonomousVmCluster Operation</seealso>
        public virtual IAsyncResult BeginGetCloudAutonomousVmCluster(GetCloudAutonomousVmClusterRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCloudAutonomousVmClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCloudAutonomousVmClusterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCloudAutonomousVmCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCloudAutonomousVmCluster.</param>
        /// 
        /// <returns>Returns a  GetCloudAutonomousVmClusterResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetCloudAutonomousVmCluster">REST API Reference for GetCloudAutonomousVmCluster Operation</seealso>
        public virtual GetCloudAutonomousVmClusterResponse EndGetCloudAutonomousVmCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCloudAutonomousVmClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCloudExadataInfrastructure

        /// <summary>
        /// Returns information about the specified Exadata infrastructure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCloudExadataInfrastructure service method.</param>
        /// 
        /// <returns>The response from the GetCloudExadataInfrastructure service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetCloudExadataInfrastructure">REST API Reference for GetCloudExadataInfrastructure Operation</seealso>
        public virtual GetCloudExadataInfrastructureResponse GetCloudExadataInfrastructure(GetCloudExadataInfrastructureRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCloudExadataInfrastructureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCloudExadataInfrastructureResponseUnmarshaller.Instance;

            return Invoke<GetCloudExadataInfrastructureResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCloudExadataInfrastructure operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCloudExadataInfrastructure operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCloudExadataInfrastructure
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetCloudExadataInfrastructure">REST API Reference for GetCloudExadataInfrastructure Operation</seealso>
        public virtual IAsyncResult BeginGetCloudExadataInfrastructure(GetCloudExadataInfrastructureRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCloudExadataInfrastructureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCloudExadataInfrastructureResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCloudExadataInfrastructure operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCloudExadataInfrastructure.</param>
        /// 
        /// <returns>Returns a  GetCloudExadataInfrastructureResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetCloudExadataInfrastructure">REST API Reference for GetCloudExadataInfrastructure Operation</seealso>
        public virtual GetCloudExadataInfrastructureResponse EndGetCloudExadataInfrastructure(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCloudExadataInfrastructureResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCloudExadataInfrastructureUnallocatedResources

        /// <summary>
        /// Retrieves information about unallocated resources in a specified Cloud Exadata Infrastructure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCloudExadataInfrastructureUnallocatedResources service method.</param>
        /// 
        /// <returns>The response from the GetCloudExadataInfrastructureUnallocatedResources service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetCloudExadataInfrastructureUnallocatedResources">REST API Reference for GetCloudExadataInfrastructureUnallocatedResources Operation</seealso>
        public virtual GetCloudExadataInfrastructureUnallocatedResourcesResponse GetCloudExadataInfrastructureUnallocatedResources(GetCloudExadataInfrastructureUnallocatedResourcesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCloudExadataInfrastructureUnallocatedResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCloudExadataInfrastructureUnallocatedResourcesResponseUnmarshaller.Instance;

            return Invoke<GetCloudExadataInfrastructureUnallocatedResourcesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCloudExadataInfrastructureUnallocatedResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCloudExadataInfrastructureUnallocatedResources operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCloudExadataInfrastructureUnallocatedResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetCloudExadataInfrastructureUnallocatedResources">REST API Reference for GetCloudExadataInfrastructureUnallocatedResources Operation</seealso>
        public virtual IAsyncResult BeginGetCloudExadataInfrastructureUnallocatedResources(GetCloudExadataInfrastructureUnallocatedResourcesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCloudExadataInfrastructureUnallocatedResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCloudExadataInfrastructureUnallocatedResourcesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCloudExadataInfrastructureUnallocatedResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCloudExadataInfrastructureUnallocatedResources.</param>
        /// 
        /// <returns>Returns a  GetCloudExadataInfrastructureUnallocatedResourcesResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetCloudExadataInfrastructureUnallocatedResources">REST API Reference for GetCloudExadataInfrastructureUnallocatedResources Operation</seealso>
        public virtual GetCloudExadataInfrastructureUnallocatedResourcesResponse EndGetCloudExadataInfrastructureUnallocatedResources(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCloudExadataInfrastructureUnallocatedResourcesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCloudVmCluster

        /// <summary>
        /// Returns information about the specified VM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCloudVmCluster service method.</param>
        /// 
        /// <returns>The response from the GetCloudVmCluster service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetCloudVmCluster">REST API Reference for GetCloudVmCluster Operation</seealso>
        public virtual GetCloudVmClusterResponse GetCloudVmCluster(GetCloudVmClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCloudVmClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCloudVmClusterResponseUnmarshaller.Instance;

            return Invoke<GetCloudVmClusterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCloudVmCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCloudVmCluster operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCloudVmCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetCloudVmCluster">REST API Reference for GetCloudVmCluster Operation</seealso>
        public virtual IAsyncResult BeginGetCloudVmCluster(GetCloudVmClusterRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCloudVmClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCloudVmClusterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCloudVmCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCloudVmCluster.</param>
        /// 
        /// <returns>Returns a  GetCloudVmClusterResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetCloudVmCluster">REST API Reference for GetCloudVmCluster Operation</seealso>
        public virtual GetCloudVmClusterResponse EndGetCloudVmCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCloudVmClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDbNode

        /// <summary>
        /// Returns information about the specified DB node.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDbNode service method.</param>
        /// 
        /// <returns>The response from the GetDbNode service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetDbNode">REST API Reference for GetDbNode Operation</seealso>
        public virtual GetDbNodeResponse GetDbNode(GetDbNodeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDbNodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDbNodeResponseUnmarshaller.Instance;

            return Invoke<GetDbNodeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDbNode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDbNode operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDbNode
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetDbNode">REST API Reference for GetDbNode Operation</seealso>
        public virtual IAsyncResult BeginGetDbNode(GetDbNodeRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDbNodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDbNodeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDbNode operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDbNode.</param>
        /// 
        /// <returns>Returns a  GetDbNodeResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetDbNode">REST API Reference for GetDbNode Operation</seealso>
        public virtual GetDbNodeResponse EndGetDbNode(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDbNodeResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDbServer

        /// <summary>
        /// Returns information about the specified database server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDbServer service method.</param>
        /// 
        /// <returns>The response from the GetDbServer service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetDbServer">REST API Reference for GetDbServer Operation</seealso>
        public virtual GetDbServerResponse GetDbServer(GetDbServerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDbServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDbServerResponseUnmarshaller.Instance;

            return Invoke<GetDbServerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDbServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDbServer operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDbServer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetDbServer">REST API Reference for GetDbServer Operation</seealso>
        public virtual IAsyncResult BeginGetDbServer(GetDbServerRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDbServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDbServerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDbServer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDbServer.</param>
        /// 
        /// <returns>Returns a  GetDbServerResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetDbServer">REST API Reference for GetDbServer Operation</seealso>
        public virtual GetDbServerResponse EndGetDbServer(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDbServerResponse>(asyncResult);
        }

        #endregion
        
        #region  GetOciOnboardingStatus

        /// <summary>
        /// Returns the tenancy activation link and onboarding status for your Amazon Web Services
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOciOnboardingStatus service method.</param>
        /// 
        /// <returns>The response from the GetOciOnboardingStatus service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetOciOnboardingStatus">REST API Reference for GetOciOnboardingStatus Operation</seealso>
        public virtual GetOciOnboardingStatusResponse GetOciOnboardingStatus(GetOciOnboardingStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOciOnboardingStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOciOnboardingStatusResponseUnmarshaller.Instance;

            return Invoke<GetOciOnboardingStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetOciOnboardingStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOciOnboardingStatus operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetOciOnboardingStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetOciOnboardingStatus">REST API Reference for GetOciOnboardingStatus Operation</seealso>
        public virtual IAsyncResult BeginGetOciOnboardingStatus(GetOciOnboardingStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOciOnboardingStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOciOnboardingStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetOciOnboardingStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOciOnboardingStatus.</param>
        /// 
        /// <returns>Returns a  GetOciOnboardingStatusResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetOciOnboardingStatus">REST API Reference for GetOciOnboardingStatus Operation</seealso>
        public virtual GetOciOnboardingStatusResponse EndGetOciOnboardingStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<GetOciOnboardingStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  GetOdbNetwork

        /// <summary>
        /// Returns information about the specified ODB network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOdbNetwork service method.</param>
        /// 
        /// <returns>The response from the GetOdbNetwork service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetOdbNetwork">REST API Reference for GetOdbNetwork Operation</seealso>
        public virtual GetOdbNetworkResponse GetOdbNetwork(GetOdbNetworkRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOdbNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOdbNetworkResponseUnmarshaller.Instance;

            return Invoke<GetOdbNetworkResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetOdbNetwork operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOdbNetwork operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetOdbNetwork
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetOdbNetwork">REST API Reference for GetOdbNetwork Operation</seealso>
        public virtual IAsyncResult BeginGetOdbNetwork(GetOdbNetworkRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOdbNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOdbNetworkResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetOdbNetwork operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOdbNetwork.</param>
        /// 
        /// <returns>Returns a  GetOdbNetworkResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetOdbNetwork">REST API Reference for GetOdbNetwork Operation</seealso>
        public virtual GetOdbNetworkResponse EndGetOdbNetwork(IAsyncResult asyncResult)
        {
            return EndInvoke<GetOdbNetworkResponse>(asyncResult);
        }

        #endregion
        
        #region  GetOdbPeeringConnection

        /// <summary>
        /// Retrieves information about an ODB peering connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOdbPeeringConnection service method.</param>
        /// 
        /// <returns>The response from the GetOdbPeeringConnection service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetOdbPeeringConnection">REST API Reference for GetOdbPeeringConnection Operation</seealso>
        public virtual GetOdbPeeringConnectionResponse GetOdbPeeringConnection(GetOdbPeeringConnectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOdbPeeringConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOdbPeeringConnectionResponseUnmarshaller.Instance;

            return Invoke<GetOdbPeeringConnectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetOdbPeeringConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOdbPeeringConnection operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetOdbPeeringConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetOdbPeeringConnection">REST API Reference for GetOdbPeeringConnection Operation</seealso>
        public virtual IAsyncResult BeginGetOdbPeeringConnection(GetOdbPeeringConnectionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOdbPeeringConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOdbPeeringConnectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetOdbPeeringConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOdbPeeringConnection.</param>
        /// 
        /// <returns>Returns a  GetOdbPeeringConnectionResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetOdbPeeringConnection">REST API Reference for GetOdbPeeringConnection Operation</seealso>
        public virtual GetOdbPeeringConnectionResponse EndGetOdbPeeringConnection(IAsyncResult asyncResult)
        {
            return EndInvoke<GetOdbPeeringConnectionResponse>(asyncResult);
        }

        #endregion
        
        #region  InitializeService

        /// <summary>
        /// Initializes the ODB service for the first time in an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InitializeService service method.</param>
        /// 
        /// <returns>The response from the InitializeService service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/InitializeService">REST API Reference for InitializeService Operation</seealso>
        public virtual InitializeServiceResponse InitializeService(InitializeServiceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = InitializeServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InitializeServiceResponseUnmarshaller.Instance;

            return Invoke<InitializeServiceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the InitializeService operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InitializeService operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndInitializeService
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/InitializeService">REST API Reference for InitializeService Operation</seealso>
        public virtual IAsyncResult BeginInitializeService(InitializeServiceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  InitializeServiceResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/InitializeService">REST API Reference for InitializeService Operation</seealso>
        public virtual InitializeServiceResponse EndInitializeService(IAsyncResult asyncResult)
        {
            return EndInvoke<InitializeServiceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAutonomousVirtualMachines

        /// <summary>
        /// Lists all Autonomous VMs in an Autonomous VM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutonomousVirtualMachines service method.</param>
        /// 
        /// <returns>The response from the ListAutonomousVirtualMachines service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListAutonomousVirtualMachines">REST API Reference for ListAutonomousVirtualMachines Operation</seealso>
        public virtual ListAutonomousVirtualMachinesResponse ListAutonomousVirtualMachines(ListAutonomousVirtualMachinesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAutonomousVirtualMachinesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutonomousVirtualMachinesResponseUnmarshaller.Instance;

            return Invoke<ListAutonomousVirtualMachinesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAutonomousVirtualMachines operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAutonomousVirtualMachines operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAutonomousVirtualMachines
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListAutonomousVirtualMachines">REST API Reference for ListAutonomousVirtualMachines Operation</seealso>
        public virtual IAsyncResult BeginListAutonomousVirtualMachines(ListAutonomousVirtualMachinesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAutonomousVirtualMachinesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutonomousVirtualMachinesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAutonomousVirtualMachines operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAutonomousVirtualMachines.</param>
        /// 
        /// <returns>Returns a  ListAutonomousVirtualMachinesResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListAutonomousVirtualMachines">REST API Reference for ListAutonomousVirtualMachines Operation</seealso>
        public virtual ListAutonomousVirtualMachinesResponse EndListAutonomousVirtualMachines(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAutonomousVirtualMachinesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCloudAutonomousVmClusters

        /// <summary>
        /// Lists all Autonomous VM clusters in a specified Cloud Exadata infrastructure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCloudAutonomousVmClusters service method.</param>
        /// 
        /// <returns>The response from the ListCloudAutonomousVmClusters service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListCloudAutonomousVmClusters">REST API Reference for ListCloudAutonomousVmClusters Operation</seealso>
        public virtual ListCloudAutonomousVmClustersResponse ListCloudAutonomousVmClusters(ListCloudAutonomousVmClustersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCloudAutonomousVmClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCloudAutonomousVmClustersResponseUnmarshaller.Instance;

            return Invoke<ListCloudAutonomousVmClustersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCloudAutonomousVmClusters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCloudAutonomousVmClusters operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCloudAutonomousVmClusters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListCloudAutonomousVmClusters">REST API Reference for ListCloudAutonomousVmClusters Operation</seealso>
        public virtual IAsyncResult BeginListCloudAutonomousVmClusters(ListCloudAutonomousVmClustersRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCloudAutonomousVmClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCloudAutonomousVmClustersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCloudAutonomousVmClusters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCloudAutonomousVmClusters.</param>
        /// 
        /// <returns>Returns a  ListCloudAutonomousVmClustersResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListCloudAutonomousVmClusters">REST API Reference for ListCloudAutonomousVmClusters Operation</seealso>
        public virtual ListCloudAutonomousVmClustersResponse EndListCloudAutonomousVmClusters(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCloudAutonomousVmClustersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCloudExadataInfrastructures

        /// <summary>
        /// Returns information about the Exadata infrastructures owned by your Amazon Web Services
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCloudExadataInfrastructures service method.</param>
        /// 
        /// <returns>The response from the ListCloudExadataInfrastructures service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListCloudExadataInfrastructures">REST API Reference for ListCloudExadataInfrastructures Operation</seealso>
        public virtual ListCloudExadataInfrastructuresResponse ListCloudExadataInfrastructures(ListCloudExadataInfrastructuresRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCloudExadataInfrastructuresRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCloudExadataInfrastructuresResponseUnmarshaller.Instance;

            return Invoke<ListCloudExadataInfrastructuresResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCloudExadataInfrastructures operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCloudExadataInfrastructures operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCloudExadataInfrastructures
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListCloudExadataInfrastructures">REST API Reference for ListCloudExadataInfrastructures Operation</seealso>
        public virtual IAsyncResult BeginListCloudExadataInfrastructures(ListCloudExadataInfrastructuresRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCloudExadataInfrastructuresRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCloudExadataInfrastructuresResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCloudExadataInfrastructures operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCloudExadataInfrastructures.</param>
        /// 
        /// <returns>Returns a  ListCloudExadataInfrastructuresResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListCloudExadataInfrastructures">REST API Reference for ListCloudExadataInfrastructures Operation</seealso>
        public virtual ListCloudExadataInfrastructuresResponse EndListCloudExadataInfrastructures(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCloudExadataInfrastructuresResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCloudVmClusters

        /// <summary>
        /// Returns information about the VM clusters owned by your Amazon Web Services account
        /// or only the ones on the specified Exadata infrastructure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCloudVmClusters service method.</param>
        /// 
        /// <returns>The response from the ListCloudVmClusters service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListCloudVmClusters">REST API Reference for ListCloudVmClusters Operation</seealso>
        public virtual ListCloudVmClustersResponse ListCloudVmClusters(ListCloudVmClustersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCloudVmClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCloudVmClustersResponseUnmarshaller.Instance;

            return Invoke<ListCloudVmClustersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCloudVmClusters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCloudVmClusters operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCloudVmClusters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListCloudVmClusters">REST API Reference for ListCloudVmClusters Operation</seealso>
        public virtual IAsyncResult BeginListCloudVmClusters(ListCloudVmClustersRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCloudVmClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCloudVmClustersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCloudVmClusters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCloudVmClusters.</param>
        /// 
        /// <returns>Returns a  ListCloudVmClustersResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListCloudVmClusters">REST API Reference for ListCloudVmClusters Operation</seealso>
        public virtual ListCloudVmClustersResponse EndListCloudVmClusters(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCloudVmClustersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDbNodes

        /// <summary>
        /// Returns information about the DB nodes for the specified VM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDbNodes service method.</param>
        /// 
        /// <returns>The response from the ListDbNodes service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListDbNodes">REST API Reference for ListDbNodes Operation</seealso>
        public virtual ListDbNodesResponse ListDbNodes(ListDbNodesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDbNodesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDbNodesResponseUnmarshaller.Instance;

            return Invoke<ListDbNodesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDbNodes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDbNodes operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDbNodes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListDbNodes">REST API Reference for ListDbNodes Operation</seealso>
        public virtual IAsyncResult BeginListDbNodes(ListDbNodesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDbNodesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDbNodesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDbNodes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDbNodes.</param>
        /// 
        /// <returns>Returns a  ListDbNodesResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListDbNodes">REST API Reference for ListDbNodes Operation</seealso>
        public virtual ListDbNodesResponse EndListDbNodes(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDbNodesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDbServers

        /// <summary>
        /// Returns information about the database servers that belong to the specified Exadata
        /// infrastructure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDbServers service method.</param>
        /// 
        /// <returns>The response from the ListDbServers service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListDbServers">REST API Reference for ListDbServers Operation</seealso>
        public virtual ListDbServersResponse ListDbServers(ListDbServersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDbServersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDbServersResponseUnmarshaller.Instance;

            return Invoke<ListDbServersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDbServers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDbServers operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDbServers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListDbServers">REST API Reference for ListDbServers Operation</seealso>
        public virtual IAsyncResult BeginListDbServers(ListDbServersRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDbServersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDbServersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDbServers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDbServers.</param>
        /// 
        /// <returns>Returns a  ListDbServersResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListDbServers">REST API Reference for ListDbServers Operation</seealso>
        public virtual ListDbServersResponse EndListDbServers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDbServersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDbSystemShapes

        /// <summary>
        /// Returns information about the shapes that are available for an Exadata infrastructure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDbSystemShapes service method.</param>
        /// 
        /// <returns>The response from the ListDbSystemShapes service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListDbSystemShapes">REST API Reference for ListDbSystemShapes Operation</seealso>
        public virtual ListDbSystemShapesResponse ListDbSystemShapes(ListDbSystemShapesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDbSystemShapesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDbSystemShapesResponseUnmarshaller.Instance;

            return Invoke<ListDbSystemShapesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDbSystemShapes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDbSystemShapes operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDbSystemShapes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListDbSystemShapes">REST API Reference for ListDbSystemShapes Operation</seealso>
        public virtual IAsyncResult BeginListDbSystemShapes(ListDbSystemShapesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDbSystemShapesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDbSystemShapesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDbSystemShapes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDbSystemShapes.</param>
        /// 
        /// <returns>Returns a  ListDbSystemShapesResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListDbSystemShapes">REST API Reference for ListDbSystemShapes Operation</seealso>
        public virtual ListDbSystemShapesResponse EndListDbSystemShapes(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDbSystemShapesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListGiVersions

        /// <summary>
        /// Returns information about Oracle Grid Infrastructure (GI) software versions that are
        /// available for a VM cluster for the specified shape.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGiVersions service method.</param>
        /// 
        /// <returns>The response from the ListGiVersions service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListGiVersions">REST API Reference for ListGiVersions Operation</seealso>
        public virtual ListGiVersionsResponse ListGiVersions(ListGiVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGiVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGiVersionsResponseUnmarshaller.Instance;

            return Invoke<ListGiVersionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListGiVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGiVersions operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGiVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListGiVersions">REST API Reference for ListGiVersions Operation</seealso>
        public virtual IAsyncResult BeginListGiVersions(ListGiVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGiVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGiVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListGiVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGiVersions.</param>
        /// 
        /// <returns>Returns a  ListGiVersionsResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListGiVersions">REST API Reference for ListGiVersions Operation</seealso>
        public virtual ListGiVersionsResponse EndListGiVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListGiVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListOdbNetworks

        /// <summary>
        /// Returns information about the ODB networks owned by your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOdbNetworks service method.</param>
        /// 
        /// <returns>The response from the ListOdbNetworks service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListOdbNetworks">REST API Reference for ListOdbNetworks Operation</seealso>
        public virtual ListOdbNetworksResponse ListOdbNetworks(ListOdbNetworksRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOdbNetworksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOdbNetworksResponseUnmarshaller.Instance;

            return Invoke<ListOdbNetworksResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListOdbNetworks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOdbNetworks operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOdbNetworks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListOdbNetworks">REST API Reference for ListOdbNetworks Operation</seealso>
        public virtual IAsyncResult BeginListOdbNetworks(ListOdbNetworksRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOdbNetworksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOdbNetworksResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListOdbNetworks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOdbNetworks.</param>
        /// 
        /// <returns>Returns a  ListOdbNetworksResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListOdbNetworks">REST API Reference for ListOdbNetworks Operation</seealso>
        public virtual ListOdbNetworksResponse EndListOdbNetworks(IAsyncResult asyncResult)
        {
            return EndInvoke<ListOdbNetworksResponse>(asyncResult);
        }

        #endregion
        
        #region  ListOdbPeeringConnections

        /// <summary>
        /// Lists all ODB peering connections or those associated with a specific ODB network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOdbPeeringConnections service method.</param>
        /// 
        /// <returns>The response from the ListOdbPeeringConnections service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListOdbPeeringConnections">REST API Reference for ListOdbPeeringConnections Operation</seealso>
        public virtual ListOdbPeeringConnectionsResponse ListOdbPeeringConnections(ListOdbPeeringConnectionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOdbPeeringConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOdbPeeringConnectionsResponseUnmarshaller.Instance;

            return Invoke<ListOdbPeeringConnectionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListOdbPeeringConnections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOdbPeeringConnections operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOdbPeeringConnections
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListOdbPeeringConnections">REST API Reference for ListOdbPeeringConnections Operation</seealso>
        public virtual IAsyncResult BeginListOdbPeeringConnections(ListOdbPeeringConnectionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOdbPeeringConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOdbPeeringConnectionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListOdbPeeringConnections operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOdbPeeringConnections.</param>
        /// 
        /// <returns>Returns a  ListOdbPeeringConnectionsResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListOdbPeeringConnections">REST API Reference for ListOdbPeeringConnections Operation</seealso>
        public virtual ListOdbPeeringConnectionsResponse EndListOdbPeeringConnections(IAsyncResult asyncResult)
        {
            return EndInvoke<ListOdbPeeringConnectionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSystemVersions

        /// <summary>
        /// Returns information about the system versions that are available for a VM cluster
        /// for the specified <c>giVersion</c> and <c>shape</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSystemVersions service method.</param>
        /// 
        /// <returns>The response from the ListSystemVersions service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListSystemVersions">REST API Reference for ListSystemVersions Operation</seealso>
        public virtual ListSystemVersionsResponse ListSystemVersions(ListSystemVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSystemVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSystemVersionsResponseUnmarshaller.Instance;

            return Invoke<ListSystemVersionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSystemVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSystemVersions operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSystemVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListSystemVersions">REST API Reference for ListSystemVersions Operation</seealso>
        public virtual IAsyncResult BeginListSystemVersions(ListSystemVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSystemVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSystemVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSystemVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSystemVersions.</param>
        /// 
        /// <returns>Returns a  ListSystemVersionsResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListSystemVersions">REST API Reference for ListSystemVersions Operation</seealso>
        public virtual ListSystemVersionsResponse EndListSystemVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSystemVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Returns information about the tags applied to this resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  RebootDbNode

        /// <summary>
        /// Reboots the specified DB node in a VM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebootDbNode service method.</param>
        /// 
        /// <returns>The response from the RebootDbNode service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/RebootDbNode">REST API Reference for RebootDbNode Operation</seealso>
        public virtual RebootDbNodeResponse RebootDbNode(RebootDbNodeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RebootDbNodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootDbNodeResponseUnmarshaller.Instance;

            return Invoke<RebootDbNodeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RebootDbNode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebootDbNode operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRebootDbNode
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/RebootDbNode">REST API Reference for RebootDbNode Operation</seealso>
        public virtual IAsyncResult BeginRebootDbNode(RebootDbNodeRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RebootDbNodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootDbNodeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RebootDbNode operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRebootDbNode.</param>
        /// 
        /// <returns>Returns a  RebootDbNodeResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/RebootDbNode">REST API Reference for RebootDbNode Operation</seealso>
        public virtual RebootDbNodeResponse EndRebootDbNode(IAsyncResult asyncResult)
        {
            return EndInvoke<RebootDbNodeResponse>(asyncResult);
        }

        #endregion
        
        #region  StartDbNode

        /// <summary>
        /// Starts the specified DB node in a VM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDbNode service method.</param>
        /// 
        /// <returns>The response from the StartDbNode service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/StartDbNode">REST API Reference for StartDbNode Operation</seealso>
        public virtual StartDbNodeResponse StartDbNode(StartDbNodeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartDbNodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDbNodeResponseUnmarshaller.Instance;

            return Invoke<StartDbNodeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartDbNode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartDbNode operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartDbNode
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/StartDbNode">REST API Reference for StartDbNode Operation</seealso>
        public virtual IAsyncResult BeginStartDbNode(StartDbNodeRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartDbNodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDbNodeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartDbNode operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartDbNode.</param>
        /// 
        /// <returns>Returns a  StartDbNodeResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/StartDbNode">REST API Reference for StartDbNode Operation</seealso>
        public virtual StartDbNodeResponse EndStartDbNode(IAsyncResult asyncResult)
        {
            return EndInvoke<StartDbNodeResponse>(asyncResult);
        }

        #endregion
        
        #region  StopDbNode

        /// <summary>
        /// Stops the specified DB node in a VM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopDbNode service method.</param>
        /// 
        /// <returns>The response from the StopDbNode service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/StopDbNode">REST API Reference for StopDbNode Operation</seealso>
        public virtual StopDbNodeResponse StopDbNode(StopDbNodeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopDbNodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopDbNodeResponseUnmarshaller.Instance;

            return Invoke<StopDbNodeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopDbNode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopDbNode operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopDbNode
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/StopDbNode">REST API Reference for StopDbNode Operation</seealso>
        public virtual IAsyncResult BeginStopDbNode(StopDbNodeRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopDbNodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopDbNodeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopDbNode operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopDbNode.</param>
        /// 
        /// <returns>Returns a  StopDbNodeResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/StopDbNode">REST API Reference for StopDbNode Operation</seealso>
        public virtual StopDbNodeResponse EndStopDbNode(IAsyncResult asyncResult)
        {
            return EndInvoke<StopDbNodeResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Applies tags to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ServiceQuotaExceededException">
        /// You have exceeded the service quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateCloudExadataInfrastructure

        /// <summary>
        /// Updates the properties of an Exadata infrastructure resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCloudExadataInfrastructure service method.</param>
        /// 
        /// <returns>The response from the UpdateCloudExadataInfrastructure service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/UpdateCloudExadataInfrastructure">REST API Reference for UpdateCloudExadataInfrastructure Operation</seealso>
        public virtual UpdateCloudExadataInfrastructureResponse UpdateCloudExadataInfrastructure(UpdateCloudExadataInfrastructureRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCloudExadataInfrastructureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCloudExadataInfrastructureResponseUnmarshaller.Instance;

            return Invoke<UpdateCloudExadataInfrastructureResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCloudExadataInfrastructure operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCloudExadataInfrastructure operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCloudExadataInfrastructure
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/UpdateCloudExadataInfrastructure">REST API Reference for UpdateCloudExadataInfrastructure Operation</seealso>
        public virtual IAsyncResult BeginUpdateCloudExadataInfrastructure(UpdateCloudExadataInfrastructureRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCloudExadataInfrastructureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCloudExadataInfrastructureResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCloudExadataInfrastructure operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCloudExadataInfrastructure.</param>
        /// 
        /// <returns>Returns a  UpdateCloudExadataInfrastructureResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/UpdateCloudExadataInfrastructure">REST API Reference for UpdateCloudExadataInfrastructure Operation</seealso>
        public virtual UpdateCloudExadataInfrastructureResponse EndUpdateCloudExadataInfrastructure(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateCloudExadataInfrastructureResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateOdbNetwork

        /// <summary>
        /// Updates properties of a specified ODB network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOdbNetwork service method.</param>
        /// 
        /// <returns>The response from the UpdateOdbNetwork service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/UpdateOdbNetwork">REST API Reference for UpdateOdbNetwork Operation</seealso>
        public virtual UpdateOdbNetworkResponse UpdateOdbNetwork(UpdateOdbNetworkRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateOdbNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateOdbNetworkResponseUnmarshaller.Instance;

            return Invoke<UpdateOdbNetworkResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateOdbNetwork operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateOdbNetwork operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateOdbNetwork
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/UpdateOdbNetwork">REST API Reference for UpdateOdbNetwork Operation</seealso>
        public virtual IAsyncResult BeginUpdateOdbNetwork(UpdateOdbNetworkRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateOdbNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateOdbNetworkResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateOdbNetwork operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateOdbNetwork.</param>
        /// 
        /// <returns>Returns a  UpdateOdbNetworkResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/UpdateOdbNetwork">REST API Reference for UpdateOdbNetwork Operation</seealso>
        public virtual UpdateOdbNetworkResponse EndUpdateOdbNetwork(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateOdbNetworkResponse>(asyncResult);
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
            var resolver = new AmazonOdbEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}