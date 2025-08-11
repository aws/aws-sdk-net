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
 * Do not modify this file. This file is generated from the evs-2023-07-27.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.Evs.Model;
using Amazon.Evs.Model.Internal.MarshallTransformations;
using Amazon.Evs.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.Evs
{
    /// <summary>
    /// <para>Implementation for accessing Evs</para>
    ///
    /// Amazon Elastic VMware Service (Amazon EVS) is a service that you can use to deploy
    /// a VMware Cloud Foundation (VCF) software environment directly on EC2 bare metal instances
    /// within an Amazon Virtual Private Cloud (VPC).
    /// 
    ///  
    /// <para>
    /// Workloads running on Amazon EVS are fully compatible with workloads running on any
    /// standard VMware vSphere environment. This means that you can migrate any VMware-based
    /// workload to Amazon EVS without workload modification.
    /// </para>
    /// </summary>
    public partial class AmazonEvsClient : AmazonServiceClient, IAmazonEvs
    {
        private static IServiceMetadata serviceMetadata = new AmazonEvsMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IEvsPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IEvsPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new EvsPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonEvsClient with the credentials loaded from the application's
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
        public AmazonEvsClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonEvsConfig()) { }

        /// <summary>
        /// Constructs AmazonEvsClient with the credentials loaded from the application's
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
        public AmazonEvsClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonEvsConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonEvsClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonEvsClient Configuration Object</param>
        public AmazonEvsClient(AmazonEvsConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonEvsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonEvsClient(AWSCredentials credentials)
            : this(credentials, new AmazonEvsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonEvsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonEvsClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonEvsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonEvsClient with AWS Credentials and an
        /// AmazonEvsClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonEvsClient Configuration Object</param>
        public AmazonEvsClient(AWSCredentials credentials, AmazonEvsConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonEvsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonEvsClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonEvsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonEvsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonEvsClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonEvsConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonEvsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonEvsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonEvsClient Configuration Object</param>
        public AmazonEvsClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonEvsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonEvsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonEvsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonEvsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonEvsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonEvsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonEvsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonEvsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonEvsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonEvsClient Configuration Object</param>
        public AmazonEvsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonEvsConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonEvsEndpointResolver());
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


        #region  CreateEnvironment

        /// <summary>
        /// Creates an Amazon EVS environment that runs VCF software, such as SDDC Manager, NSX
        /// Manager, and vCenter Server.
        /// 
        ///  
        /// <para>
        /// During environment creation, Amazon EVS performs validations on DNS settings, provisions
        /// VLAN subnets and hosts, and deploys the supplied version of VCF.
        /// </para>
        ///  
        /// <para>
        /// It can take several hours to create an environment. After the deployment completes,
        /// you can configure VCF in the vSphere user interface according to your needs.
        /// </para>
        ///  <note> 
        /// <para>
        /// You cannot use the <c>dedicatedHostId</c> and <c>placementGroupId</c> parameters together
        /// in the same <c>CreateEnvironment</c> action. This results in a <c>ValidationException</c>
        /// response.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironment service method.</param>
        /// 
        /// <returns>The response from the CreateEnvironment service method, as returned by Evs.</returns>
        /// <exception cref="Amazon.Evs.Model.ValidationException">
        /// The input fails to satisfy the specified constraints. You will see this exception
        /// if invalid inputs are provided for any of the Amazon EVS environment operations, or
        /// if a list operation is performed on an environment resource that is still initializing.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evs-2023-07-27/CreateEnvironment">REST API Reference for CreateEnvironment Operation</seealso>
        public virtual CreateEnvironmentResponse CreateEnvironment(CreateEnvironmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentResponseUnmarshaller.Instance;

            return Invoke<CreateEnvironmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironment operation on AmazonEvsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evs-2023-07-27/CreateEnvironment">REST API Reference for CreateEnvironment Operation</seealso>
        public virtual IAsyncResult BeginCreateEnvironment(CreateEnvironmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEnvironment.</param>
        /// 
        /// <returns>Returns a  CreateEnvironmentResult from Evs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evs-2023-07-27/CreateEnvironment">REST API Reference for CreateEnvironment Operation</seealso>
        public virtual CreateEnvironmentResponse EndCreateEnvironment(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateEnvironmentResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateEnvironmentHost

        /// <summary>
        /// Creates an ESXi host and adds it to an Amazon EVS environment. Amazon EVS supports
        /// 4-16 hosts per environment.
        /// 
        ///  
        /// <para>
        /// This action can only be used after the Amazon EVS environment is deployed.
        /// </para>
        ///  
        /// <para>
        /// You can use the <c>dedicatedHostId</c> parameter to specify an Amazon EC2 Dedicated
        /// Host for ESXi host creation.
        /// </para>
        ///  
        /// <para>
        ///  You can use the <c>placementGroupId</c> parameter to specify a cluster or partition
        /// placement group to launch EC2 instances into.
        /// </para>
        ///  <note> 
        /// <para>
        /// You cannot use the <c>dedicatedHostId</c> and <c>placementGroupId</c> parameters together
        /// in the same <c>CreateEnvironmentHost</c> action. This results in a <c>ValidationException</c>
        /// response.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironmentHost service method.</param>
        /// 
        /// <returns>The response from the CreateEnvironmentHost service method, as returned by Evs.</returns>
        /// <exception cref="Amazon.Evs.Model.ThrottlingException">
        /// The <c>CreateEnvironmentHost</c> operation couldn't be performed because the service
        /// is throttling requests. This exception is thrown when the <c>CreateEnvironmentHost</c>
        /// request exceeds concurrency of 1 transaction per second (TPS).
        /// </exception>
        /// <exception cref="Amazon.Evs.Model.ValidationException">
        /// The input fails to satisfy the specified constraints. You will see this exception
        /// if invalid inputs are provided for any of the Amazon EVS environment operations, or
        /// if a list operation is performed on an environment resource that is still initializing.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evs-2023-07-27/CreateEnvironmentHost">REST API Reference for CreateEnvironmentHost Operation</seealso>
        public virtual CreateEnvironmentHostResponse CreateEnvironmentHost(CreateEnvironmentHostRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentHostRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentHostResponseUnmarshaller.Instance;

            return Invoke<CreateEnvironmentHostResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEnvironmentHost operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironmentHost operation on AmazonEvsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEnvironmentHost
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evs-2023-07-27/CreateEnvironmentHost">REST API Reference for CreateEnvironmentHost Operation</seealso>
        public virtual IAsyncResult BeginCreateEnvironmentHost(CreateEnvironmentHostRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentHostRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentHostResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEnvironmentHost operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEnvironmentHost.</param>
        /// 
        /// <returns>Returns a  CreateEnvironmentHostResult from Evs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evs-2023-07-27/CreateEnvironmentHost">REST API Reference for CreateEnvironmentHost Operation</seealso>
        public virtual CreateEnvironmentHostResponse EndCreateEnvironmentHost(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateEnvironmentHostResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteEnvironment

        /// <summary>
        /// Deletes an Amazon EVS environment.
        /// 
        ///  
        /// <para>
        /// Amazon EVS environments will only be enabled for deletion once the hosts are deleted.
        /// You can delete hosts using the <c>DeleteEnvironmentHost</c> action.
        /// </para>
        ///  
        /// <para>
        /// Environment deletion also deletes the associated Amazon EVS VLAN subnets and Amazon
        /// Web Services Secrets Manager secrets that Amazon EVS created. Amazon Web Services
        /// resources that you create are not deleted. These resources may continue to incur costs.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironment service method.</param>
        /// 
        /// <returns>The response from the DeleteEnvironment service method, as returned by Evs.</returns>
        /// <exception cref="Amazon.Evs.Model.ResourceNotFoundException">
        /// A service resource associated with the request could not be found. The resource might
        /// not be specified correctly, or it may have a <c>state</c> of <c>DELETED</c>.
        /// </exception>
        /// <exception cref="Amazon.Evs.Model.ValidationException">
        /// The input fails to satisfy the specified constraints. You will see this exception
        /// if invalid inputs are provided for any of the Amazon EVS environment operations, or
        /// if a list operation is performed on an environment resource that is still initializing.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evs-2023-07-27/DeleteEnvironment">REST API Reference for DeleteEnvironment Operation</seealso>
        public virtual DeleteEnvironmentResponse DeleteEnvironment(DeleteEnvironmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentResponseUnmarshaller.Instance;

            return Invoke<DeleteEnvironmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironment operation on AmazonEvsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evs-2023-07-27/DeleteEnvironment">REST API Reference for DeleteEnvironment Operation</seealso>
        public virtual IAsyncResult BeginDeleteEnvironment(DeleteEnvironmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEnvironment.</param>
        /// 
        /// <returns>Returns a  DeleteEnvironmentResult from Evs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evs-2023-07-27/DeleteEnvironment">REST API Reference for DeleteEnvironment Operation</seealso>
        public virtual DeleteEnvironmentResponse EndDeleteEnvironment(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteEnvironmentResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteEnvironmentHost

        /// <summary>
        /// Deletes a host from an Amazon EVS environment.
        /// 
        ///  <note> 
        /// <para>
        /// Before deleting a host, you must unassign and decommission the host from within the
        /// SDDC Manager user interface. Not doing so could impact the availability of your virtual
        /// machines or result in data loss.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironmentHost service method.</param>
        /// 
        /// <returns>The response from the DeleteEnvironmentHost service method, as returned by Evs.</returns>
        /// <exception cref="Amazon.Evs.Model.ResourceNotFoundException">
        /// A service resource associated with the request could not be found. The resource might
        /// not be specified correctly, or it may have a <c>state</c> of <c>DELETED</c>.
        /// </exception>
        /// <exception cref="Amazon.Evs.Model.ValidationException">
        /// The input fails to satisfy the specified constraints. You will see this exception
        /// if invalid inputs are provided for any of the Amazon EVS environment operations, or
        /// if a list operation is performed on an environment resource that is still initializing.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evs-2023-07-27/DeleteEnvironmentHost">REST API Reference for DeleteEnvironmentHost Operation</seealso>
        public virtual DeleteEnvironmentHostResponse DeleteEnvironmentHost(DeleteEnvironmentHostRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentHostRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentHostResponseUnmarshaller.Instance;

            return Invoke<DeleteEnvironmentHostResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEnvironmentHost operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironmentHost operation on AmazonEvsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEnvironmentHost
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evs-2023-07-27/DeleteEnvironmentHost">REST API Reference for DeleteEnvironmentHost Operation</seealso>
        public virtual IAsyncResult BeginDeleteEnvironmentHost(DeleteEnvironmentHostRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentHostRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentHostResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEnvironmentHost operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEnvironmentHost.</param>
        /// 
        /// <returns>Returns a  DeleteEnvironmentHostResult from Evs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evs-2023-07-27/DeleteEnvironmentHost">REST API Reference for DeleteEnvironmentHost Operation</seealso>
        public virtual DeleteEnvironmentHostResponse EndDeleteEnvironmentHost(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteEnvironmentHostResponse>(asyncResult);
        }

        #endregion
        
        #region  GetEnvironment

        /// <summary>
        /// Returns a description of the specified environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironment service method.</param>
        /// 
        /// <returns>The response from the GetEnvironment service method, as returned by Evs.</returns>
        /// <exception cref="Amazon.Evs.Model.ResourceNotFoundException">
        /// A service resource associated with the request could not be found. The resource might
        /// not be specified correctly, or it may have a <c>state</c> of <c>DELETED</c>.
        /// </exception>
        /// <exception cref="Amazon.Evs.Model.ValidationException">
        /// The input fails to satisfy the specified constraints. You will see this exception
        /// if invalid inputs are provided for any of the Amazon EVS environment operations, or
        /// if a list operation is performed on an environment resource that is still initializing.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evs-2023-07-27/GetEnvironment">REST API Reference for GetEnvironment Operation</seealso>
        public virtual GetEnvironmentResponse GetEnvironment(GetEnvironmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentResponseUnmarshaller.Instance;

            return Invoke<GetEnvironmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironment operation on AmazonEvsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evs-2023-07-27/GetEnvironment">REST API Reference for GetEnvironment Operation</seealso>
        public virtual IAsyncResult BeginGetEnvironment(GetEnvironmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEnvironment.</param>
        /// 
        /// <returns>Returns a  GetEnvironmentResult from Evs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evs-2023-07-27/GetEnvironment">REST API Reference for GetEnvironment Operation</seealso>
        public virtual GetEnvironmentResponse EndGetEnvironment(IAsyncResult asyncResult)
        {
            return EndInvoke<GetEnvironmentResponse>(asyncResult);
        }

        #endregion
        
        #region  ListEnvironmentHosts

        /// <summary>
        /// List the hosts within an environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironmentHosts service method.</param>
        /// 
        /// <returns>The response from the ListEnvironmentHosts service method, as returned by Evs.</returns>
        /// <exception cref="Amazon.Evs.Model.ResourceNotFoundException">
        /// A service resource associated with the request could not be found. The resource might
        /// not be specified correctly, or it may have a <c>state</c> of <c>DELETED</c>.
        /// </exception>
        /// <exception cref="Amazon.Evs.Model.ValidationException">
        /// The input fails to satisfy the specified constraints. You will see this exception
        /// if invalid inputs are provided for any of the Amazon EVS environment operations, or
        /// if a list operation is performed on an environment resource that is still initializing.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evs-2023-07-27/ListEnvironmentHosts">REST API Reference for ListEnvironmentHosts Operation</seealso>
        public virtual ListEnvironmentHostsResponse ListEnvironmentHosts(ListEnvironmentHostsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEnvironmentHostsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentHostsResponseUnmarshaller.Instance;

            return Invoke<ListEnvironmentHostsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListEnvironmentHosts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironmentHosts operation on AmazonEvsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEnvironmentHosts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evs-2023-07-27/ListEnvironmentHosts">REST API Reference for ListEnvironmentHosts Operation</seealso>
        public virtual IAsyncResult BeginListEnvironmentHosts(ListEnvironmentHostsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEnvironmentHostsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentHostsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListEnvironmentHosts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEnvironmentHosts.</param>
        /// 
        /// <returns>Returns a  ListEnvironmentHostsResult from Evs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evs-2023-07-27/ListEnvironmentHosts">REST API Reference for ListEnvironmentHosts Operation</seealso>
        public virtual ListEnvironmentHostsResponse EndListEnvironmentHosts(IAsyncResult asyncResult)
        {
            return EndInvoke<ListEnvironmentHostsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListEnvironments

        /// <summary>
        /// Lists the Amazon EVS environments in your Amazon Web Services account in the specified
        /// Amazon Web Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironments service method.</param>
        /// 
        /// <returns>The response from the ListEnvironments service method, as returned by Evs.</returns>
        /// <exception cref="Amazon.Evs.Model.ValidationException">
        /// The input fails to satisfy the specified constraints. You will see this exception
        /// if invalid inputs are provided for any of the Amazon EVS environment operations, or
        /// if a list operation is performed on an environment resource that is still initializing.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evs-2023-07-27/ListEnvironments">REST API Reference for ListEnvironments Operation</seealso>
        public virtual ListEnvironmentsResponse ListEnvironments(ListEnvironmentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEnvironmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentsResponseUnmarshaller.Instance;

            return Invoke<ListEnvironmentsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListEnvironments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironments operation on AmazonEvsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEnvironments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evs-2023-07-27/ListEnvironments">REST API Reference for ListEnvironments Operation</seealso>
        public virtual IAsyncResult BeginListEnvironments(ListEnvironmentsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEnvironmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListEnvironments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEnvironments.</param>
        /// 
        /// <returns>Returns a  ListEnvironmentsResult from Evs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evs-2023-07-27/ListEnvironments">REST API Reference for ListEnvironments Operation</seealso>
        public virtual ListEnvironmentsResponse EndListEnvironments(IAsyncResult asyncResult)
        {
            return EndInvoke<ListEnvironmentsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListEnvironmentVlans

        /// <summary>
        /// Lists environment VLANs that are associated with the specified environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironmentVlans service method.</param>
        /// 
        /// <returns>The response from the ListEnvironmentVlans service method, as returned by Evs.</returns>
        /// <exception cref="Amazon.Evs.Model.ResourceNotFoundException">
        /// A service resource associated with the request could not be found. The resource might
        /// not be specified correctly, or it may have a <c>state</c> of <c>DELETED</c>.
        /// </exception>
        /// <exception cref="Amazon.Evs.Model.ValidationException">
        /// The input fails to satisfy the specified constraints. You will see this exception
        /// if invalid inputs are provided for any of the Amazon EVS environment operations, or
        /// if a list operation is performed on an environment resource that is still initializing.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evs-2023-07-27/ListEnvironmentVlans">REST API Reference for ListEnvironmentVlans Operation</seealso>
        public virtual ListEnvironmentVlansResponse ListEnvironmentVlans(ListEnvironmentVlansRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEnvironmentVlansRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentVlansResponseUnmarshaller.Instance;

            return Invoke<ListEnvironmentVlansResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListEnvironmentVlans operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironmentVlans operation on AmazonEvsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEnvironmentVlans
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evs-2023-07-27/ListEnvironmentVlans">REST API Reference for ListEnvironmentVlans Operation</seealso>
        public virtual IAsyncResult BeginListEnvironmentVlans(ListEnvironmentVlansRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEnvironmentVlansRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentVlansResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListEnvironmentVlans operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEnvironmentVlans.</param>
        /// 
        /// <returns>Returns a  ListEnvironmentVlansResult from Evs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evs-2023-07-27/ListEnvironmentVlans">REST API Reference for ListEnvironmentVlans Operation</seealso>
        public virtual ListEnvironmentVlansResponse EndListEnvironmentVlans(IAsyncResult asyncResult)
        {
            return EndInvoke<ListEnvironmentVlansResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists the tags for an Amazon EVS resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Evs.</returns>
        /// <exception cref="Amazon.Evs.Model.ResourceNotFoundException">
        /// A service resource associated with the request could not be found. The resource might
        /// not be specified correctly, or it may have a <c>state</c> of <c>DELETED</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evs-2023-07-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonEvsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evs-2023-07-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from Evs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evs-2023-07-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Associates the specified tags to an Amazon EVS resource with the specified <c>resourceArn</c>.
        /// If existing tags on a resource are not specified in the request parameters, they aren't
        /// changed. When a resource is deleted, the tags associated with that resource are also
        /// deleted. Tags that you create for Amazon EVS resources don't propagate to any other
        /// resources associated with the environment. For example, if you tag an environment
        /// with this operation, that tag doesn't automatically propagate to the VLAN subnets
        /// and hosts associated with the environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Evs.</returns>
        /// <exception cref="Amazon.Evs.Model.ResourceNotFoundException">
        /// A service resource associated with the request could not be found. The resource might
        /// not be specified correctly, or it may have a <c>state</c> of <c>DELETED</c>.
        /// </exception>
        /// <exception cref="Amazon.Evs.Model.ServiceQuotaExceededException">
        /// The number of one or more Amazon EVS resources exceeds the maximum allowed. For a
        /// list of Amazon EVS quotas, see <a href="https://docs.aws.amazon.com/evs/latest/userguide/service-quotas-evs.html">Amazon
        /// EVS endpoints and quotas</a> in the <i>Amazon EVS User Guide</i>. Delete some resources
        /// or request an increase in your service quota. To request an increase, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_service_limits.html">Amazon
        /// Web Services Service Quotas</a> in the <i>Amazon Web Services General Reference Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Evs.Model.TagPolicyException">
        /// <note> 
        /// <para>
        ///  <c>TagPolicyException</c> is deprecated. See <a href="https://docs.aws.amazon.com/evs/latest/APIReference/API_ValidationException.html">
        /// <c>ValidationException</c> </a> instead.
        /// 
        ///  </note> 
        /// <para>
        /// The request doesn't comply with IAM tag policy. Correct your request and then retry
        /// it.
        /// </para>
        /// 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Evs.Model.TooManyTagsException">
        /// <note> 
        /// <para>
        ///  <c>TooManyTagsException</c> is deprecated. See <a href="https://docs.aws.amazon.com/evs/latest/APIReference/API_ServiceQuotaExceededException.html">
        /// <c>ServiceQuotaExceededException</c> </a> instead.
        /// 
        ///  </note> 
        /// <para>
        /// A service resource associated with the request has more than 200 tags.
        /// </para>
        /// 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evs-2023-07-27/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonEvsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evs-2023-07-27/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from Evs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evs-2023-07-27/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Deletes specified tags from an Amazon EVS resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Evs.</returns>
        /// <exception cref="Amazon.Evs.Model.ResourceNotFoundException">
        /// A service resource associated with the request could not be found. The resource might
        /// not be specified correctly, or it may have a <c>state</c> of <c>DELETED</c>.
        /// </exception>
        /// <exception cref="Amazon.Evs.Model.TagPolicyException">
        /// <note> 
        /// <para>
        ///  <c>TagPolicyException</c> is deprecated. See <a href="https://docs.aws.amazon.com/evs/latest/APIReference/API_ValidationException.html">
        /// <c>ValidationException</c> </a> instead.
        /// 
        ///  </note> 
        /// <para>
        /// The request doesn't comply with IAM tag policy. Correct your request and then retry
        /// it.
        /// </para>
        /// 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evs-2023-07-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonEvsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evs-2023-07-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from Evs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evs-2023-07-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
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
            var resolver = new AmazonEvsEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}