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
 * Do not modify this file. This file is generated from the apprunner-2020-05-15.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.AppRunner.Model;

namespace Amazon.AppRunner
{
    /// <summary>
    /// Interface for accessing AppRunner
    ///
    /// App Runner 
    /// <para>
    /// App Runner is an application service that provides a fast, simple, and cost-effective
    /// way to go directly from an existing container image or source code to a running service
    /// in the Amazon Web Services Cloud in seconds. You don't need to learn new technologies,
    /// decide which compute service to use, or understand how to provision and configure
    /// Amazon Web Services resources.
    /// </para>
    ///  
    /// <para>
    /// App Runner connects directly to your container registry or source code repository.
    /// It provides an automatic delivery pipeline with fully managed operations, high performance,
    /// scalability, and security.
    /// </para>
    ///  
    /// <para>
    /// For more information about App Runner, see the <a href="https://docs.aws.amazon.com/apprunner/latest/dg/">App
    /// Runner Developer Guide</a>. For release information, see the <a href="https://docs.aws.amazon.com/apprunner/latest/relnotes/">App
    /// Runner Release Notes</a>.
    /// </para>
    ///  
    /// <para>
    ///  To install the Software Development Kits (SDKs), Integrated Development Environment
    /// (IDE) Toolkits, and command line tools that you can use to access the API, see <a
    /// href="http://aws.amazon.com/tools/">Tools for Amazon Web Services</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Endpoints</b> 
    /// </para>
    ///  
    /// <para>
    /// For a list of Region-specific endpoints that App Runner supports, see <a href="https://docs.aws.amazon.com/general/latest/gr/apprunner.html">App
    /// Runner endpoints and quotas</a> in the <i>Amazon Web Services General Reference</i>.
    /// </para>
    /// </summary>
    public partial interface IAmazonAppRunner : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IAppRunnerPaginatorFactory Paginators { get; }
#endif


        
        #region  AssociateCustomDomain


        /// <summary>
        /// Associate your own domain name with the App Runner subdomain URL of your App Runner
        /// service.
        /// 
        ///  
        /// <para>
        /// After you call <code>AssociateCustomDomain</code> and receive a successful response,
        /// use the information in the <a>CustomDomain</a> record that's returned to add CNAME
        /// records to your Domain Name System (DNS). For each mapped domain name, add a mapping
        /// to the target App Runner subdomain and one or more certificate validation records.
        /// App Runner then performs DNS validation to verify that you own or control the domain
        /// name that you associated. App Runner tracks domain validity in a certificate stored
        /// in <a href="https://docs.aws.amazon.com/acm/latest/userguide">AWS Certificate Manager
        /// (ACM)</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateCustomDomain service method.</param>
        /// 
        /// <returns>The response from the AssociateCustomDomain service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidStateException">
        /// You can't perform this action when the resource is in its current state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/AssociateCustomDomain">REST API Reference for AssociateCustomDomain Operation</seealso>
        AssociateCustomDomainResponse AssociateCustomDomain(AssociateCustomDomainRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateCustomDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateCustomDomain operation on AmazonAppRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateCustomDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/AssociateCustomDomain">REST API Reference for AssociateCustomDomain Operation</seealso>
        IAsyncResult BeginAssociateCustomDomain(AssociateCustomDomainRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateCustomDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateCustomDomain.</param>
        /// 
        /// <returns>Returns a  AssociateCustomDomainResult from AppRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/AssociateCustomDomain">REST API Reference for AssociateCustomDomain Operation</seealso>
        AssociateCustomDomainResponse EndAssociateCustomDomain(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateAutoScalingConfiguration


        /// <summary>
        /// Create an App Runner automatic scaling configuration resource. App Runner requires
        /// this resource when you create or update App Runner services and you require non-default
        /// auto scaling settings. You can share an auto scaling configuration across multiple
        /// services.
        /// 
        ///  
        /// <para>
        /// Create multiple revisions of a configuration by calling this action multiple times
        /// using the same <code>AutoScalingConfigurationName</code>. The call returns incremental
        /// <code>AutoScalingConfigurationRevision</code> values. When you create a service and
        /// configure an auto scaling configuration resource, the service uses the latest active
        /// revision of the auto scaling configuration by default. You can optionally configure
        /// the service to use a specific revision.
        /// </para>
        ///  
        /// <para>
        /// Configure a higher <code>MinSize</code> to increase the spread of your App Runner
        /// service over more Availability Zones in the Amazon Web Services Region. The tradeoff
        /// is a higher minimal cost.
        /// </para>
        ///  
        /// <para>
        /// Configure a lower <code>MaxSize</code> to control your cost. The tradeoff is lower
        /// responsiveness during peak demand.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAutoScalingConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateAutoScalingConfiguration service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ServiceQuotaExceededException">
        /// App Runner can't create this resource. You've reached your account quota for this
        /// resource type.
        /// 
        ///  
        /// <para>
        /// For App Runner per-resource quotas, see <a href="https://docs.aws.amazon.com/general/latest/gr/apprunner.html">App
        /// Runner endpoints and quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/CreateAutoScalingConfiguration">REST API Reference for CreateAutoScalingConfiguration Operation</seealso>
        CreateAutoScalingConfigurationResponse CreateAutoScalingConfiguration(CreateAutoScalingConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAutoScalingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAutoScalingConfiguration operation on AmazonAppRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAutoScalingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/CreateAutoScalingConfiguration">REST API Reference for CreateAutoScalingConfiguration Operation</seealso>
        IAsyncResult BeginCreateAutoScalingConfiguration(CreateAutoScalingConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAutoScalingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAutoScalingConfiguration.</param>
        /// 
        /// <returns>Returns a  CreateAutoScalingConfigurationResult from AppRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/CreateAutoScalingConfiguration">REST API Reference for CreateAutoScalingConfiguration Operation</seealso>
        CreateAutoScalingConfigurationResponse EndCreateAutoScalingConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateConnection


        /// <summary>
        /// Create an App Runner connection resource. App Runner requires a connection resource
        /// when you create App Runner services that access private repositories from certain
        /// third-party providers. You can share a connection across multiple services.
        /// 
        ///  
        /// <para>
        /// A connection resource is needed to access GitHub repositories. GitHub requires a user
        /// interface approval process through the App Runner console before you can use the connection.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConnection service method.</param>
        /// 
        /// <returns>The response from the CreateConnection service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ServiceQuotaExceededException">
        /// App Runner can't create this resource. You've reached your account quota for this
        /// resource type.
        /// 
        ///  
        /// <para>
        /// For App Runner per-resource quotas, see <a href="https://docs.aws.amazon.com/general/latest/gr/apprunner.html">App
        /// Runner endpoints and quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/CreateConnection">REST API Reference for CreateConnection Operation</seealso>
        CreateConnectionResponse CreateConnection(CreateConnectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConnection operation on AmazonAppRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/CreateConnection">REST API Reference for CreateConnection Operation</seealso>
        IAsyncResult BeginCreateConnection(CreateConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConnection.</param>
        /// 
        /// <returns>Returns a  CreateConnectionResult from AppRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/CreateConnection">REST API Reference for CreateConnection Operation</seealso>
        CreateConnectionResponse EndCreateConnection(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateObservabilityConfiguration


        /// <summary>
        /// Create an App Runner observability configuration resource. App Runner requires this
        /// resource when you create or update App Runner services and you want to enable non-default
        /// observability features. You can share an observability configuration across multiple
        /// services.
        /// 
        ///  
        /// <para>
        /// Create multiple revisions of a configuration by calling this action multiple times
        /// using the same <code>ObservabilityConfigurationName</code>. The call returns incremental
        /// <code>ObservabilityConfigurationRevision</code> values. When you create a service
        /// and configure an observability configuration resource, the service uses the latest
        /// active revision of the observability configuration by default. You can optionally
        /// configure the service to use a specific revision.
        /// </para>
        ///  
        /// <para>
        /// The observability configuration resource is designed to configure multiple features
        /// (currently one feature, tracing). This action takes optional parameters that describe
        /// the configuration of these features (currently one parameter, <code>TraceConfiguration</code>).
        /// If you don't specify a feature parameter, App Runner doesn't enable the feature.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateObservabilityConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateObservabilityConfiguration service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ServiceQuotaExceededException">
        /// App Runner can't create this resource. You've reached your account quota for this
        /// resource type.
        /// 
        ///  
        /// <para>
        /// For App Runner per-resource quotas, see <a href="https://docs.aws.amazon.com/general/latest/gr/apprunner.html">App
        /// Runner endpoints and quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/CreateObservabilityConfiguration">REST API Reference for CreateObservabilityConfiguration Operation</seealso>
        CreateObservabilityConfigurationResponse CreateObservabilityConfiguration(CreateObservabilityConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateObservabilityConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateObservabilityConfiguration operation on AmazonAppRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateObservabilityConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/CreateObservabilityConfiguration">REST API Reference for CreateObservabilityConfiguration Operation</seealso>
        IAsyncResult BeginCreateObservabilityConfiguration(CreateObservabilityConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateObservabilityConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateObservabilityConfiguration.</param>
        /// 
        /// <returns>Returns a  CreateObservabilityConfigurationResult from AppRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/CreateObservabilityConfiguration">REST API Reference for CreateObservabilityConfiguration Operation</seealso>
        CreateObservabilityConfigurationResponse EndCreateObservabilityConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateService


        /// <summary>
        /// Create an App Runner service. After the service is created, the action also automatically
        /// starts a deployment.
        /// 
        ///  
        /// <para>
        /// This is an asynchronous operation. On a successful call, you can use the returned
        /// <code>OperationId</code> and the <a href="https://docs.aws.amazon.com/apprunner/latest/api/API_ListOperations.html">ListOperations</a>
        /// call to track the operation's progress.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateService service method.</param>
        /// 
        /// <returns>The response from the CreateService service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ServiceQuotaExceededException">
        /// App Runner can't create this resource. You've reached your account quota for this
        /// resource type.
        /// 
        ///  
        /// <para>
        /// For App Runner per-resource quotas, see <a href="https://docs.aws.amazon.com/general/latest/gr/apprunner.html">App
        /// Runner endpoints and quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/CreateService">REST API Reference for CreateService Operation</seealso>
        CreateServiceResponse CreateService(CreateServiceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateService operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateService operation on AmazonAppRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateService
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/CreateService">REST API Reference for CreateService Operation</seealso>
        IAsyncResult BeginCreateService(CreateServiceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateService operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateService.</param>
        /// 
        /// <returns>Returns a  CreateServiceResult from AppRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/CreateService">REST API Reference for CreateService Operation</seealso>
        CreateServiceResponse EndCreateService(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateVpcConnector


        /// <summary>
        /// Create an App Runner VPC connector resource. App Runner requires this resource when
        /// you want to associate your App Runner service to a custom Amazon Virtual Private Cloud
        /// (Amazon VPC).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcConnector service method.</param>
        /// 
        /// <returns>The response from the CreateVpcConnector service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ServiceQuotaExceededException">
        /// App Runner can't create this resource. You've reached your account quota for this
        /// resource type.
        /// 
        ///  
        /// <para>
        /// For App Runner per-resource quotas, see <a href="https://docs.aws.amazon.com/general/latest/gr/apprunner.html">App
        /// Runner endpoints and quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/CreateVpcConnector">REST API Reference for CreateVpcConnector Operation</seealso>
        CreateVpcConnectorResponse CreateVpcConnector(CreateVpcConnectorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpcConnector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcConnector operation on AmazonAppRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVpcConnector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/CreateVpcConnector">REST API Reference for CreateVpcConnector Operation</seealso>
        IAsyncResult BeginCreateVpcConnector(CreateVpcConnectorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVpcConnector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVpcConnector.</param>
        /// 
        /// <returns>Returns a  CreateVpcConnectorResult from AppRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/CreateVpcConnector">REST API Reference for CreateVpcConnector Operation</seealso>
        CreateVpcConnectorResponse EndCreateVpcConnector(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateVpcIngressConnection


        /// <summary>
        /// Create an App Runner VPC Ingress Connection resource. App Runner requires this resource
        /// when you want to associate your App Runner service with an Amazon VPC endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcIngressConnection service method.</param>
        /// 
        /// <returns>The response from the CreateVpcIngressConnection service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidStateException">
        /// You can't perform this action when the resource is in its current state.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ServiceQuotaExceededException">
        /// App Runner can't create this resource. You've reached your account quota for this
        /// resource type.
        /// 
        ///  
        /// <para>
        /// For App Runner per-resource quotas, see <a href="https://docs.aws.amazon.com/general/latest/gr/apprunner.html">App
        /// Runner endpoints and quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/CreateVpcIngressConnection">REST API Reference for CreateVpcIngressConnection Operation</seealso>
        CreateVpcIngressConnectionResponse CreateVpcIngressConnection(CreateVpcIngressConnectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpcIngressConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcIngressConnection operation on AmazonAppRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVpcIngressConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/CreateVpcIngressConnection">REST API Reference for CreateVpcIngressConnection Operation</seealso>
        IAsyncResult BeginCreateVpcIngressConnection(CreateVpcIngressConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVpcIngressConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVpcIngressConnection.</param>
        /// 
        /// <returns>Returns a  CreateVpcIngressConnectionResult from AppRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/CreateVpcIngressConnection">REST API Reference for CreateVpcIngressConnection Operation</seealso>
        CreateVpcIngressConnectionResponse EndCreateVpcIngressConnection(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAutoScalingConfiguration


        /// <summary>
        /// Delete an App Runner automatic scaling configuration resource. You can delete a specific
        /// revision or the latest active revision. You can't delete a configuration that's used
        /// by one or more App Runner services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAutoScalingConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteAutoScalingConfiguration service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/DeleteAutoScalingConfiguration">REST API Reference for DeleteAutoScalingConfiguration Operation</seealso>
        DeleteAutoScalingConfigurationResponse DeleteAutoScalingConfiguration(DeleteAutoScalingConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAutoScalingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAutoScalingConfiguration operation on AmazonAppRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAutoScalingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/DeleteAutoScalingConfiguration">REST API Reference for DeleteAutoScalingConfiguration Operation</seealso>
        IAsyncResult BeginDeleteAutoScalingConfiguration(DeleteAutoScalingConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAutoScalingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAutoScalingConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteAutoScalingConfigurationResult from AppRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/DeleteAutoScalingConfiguration">REST API Reference for DeleteAutoScalingConfiguration Operation</seealso>
        DeleteAutoScalingConfigurationResponse EndDeleteAutoScalingConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteConnection


        /// <summary>
        /// Delete an App Runner connection. You must first ensure that there are no running App
        /// Runner services that use this connection. If there are any, the <code>DeleteConnection</code>
        /// action fails.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnection service method.</param>
        /// 
        /// <returns>The response from the DeleteConnection service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/DeleteConnection">REST API Reference for DeleteConnection Operation</seealso>
        DeleteConnectionResponse DeleteConnection(DeleteConnectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnection operation on AmazonAppRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/DeleteConnection">REST API Reference for DeleteConnection Operation</seealso>
        IAsyncResult BeginDeleteConnection(DeleteConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConnection.</param>
        /// 
        /// <returns>Returns a  DeleteConnectionResult from AppRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/DeleteConnection">REST API Reference for DeleteConnection Operation</seealso>
        DeleteConnectionResponse EndDeleteConnection(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteObservabilityConfiguration


        /// <summary>
        /// Delete an App Runner observability configuration resource. You can delete a specific
        /// revision or the latest active revision. You can't delete a configuration that's used
        /// by one or more App Runner services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteObservabilityConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteObservabilityConfiguration service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/DeleteObservabilityConfiguration">REST API Reference for DeleteObservabilityConfiguration Operation</seealso>
        DeleteObservabilityConfigurationResponse DeleteObservabilityConfiguration(DeleteObservabilityConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteObservabilityConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteObservabilityConfiguration operation on AmazonAppRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteObservabilityConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/DeleteObservabilityConfiguration">REST API Reference for DeleteObservabilityConfiguration Operation</seealso>
        IAsyncResult BeginDeleteObservabilityConfiguration(DeleteObservabilityConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteObservabilityConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteObservabilityConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteObservabilityConfigurationResult from AppRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/DeleteObservabilityConfiguration">REST API Reference for DeleteObservabilityConfiguration Operation</seealso>
        DeleteObservabilityConfigurationResponse EndDeleteObservabilityConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteService


        /// <summary>
        /// Delete an App Runner service.
        /// 
        ///  
        /// <para>
        /// This is an asynchronous operation. On a successful call, you can use the returned
        /// <code>OperationId</code> and the <a>ListOperations</a> call to track the operation's
        /// progress.
        /// </para>
        ///  <note> 
        /// <para>
        /// Make sure that you don't have any active VPCIngressConnections associated with the
        /// service you want to delete. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteService service method.</param>
        /// 
        /// <returns>The response from the DeleteService service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidStateException">
        /// You can't perform this action when the resource is in its current state.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/DeleteService">REST API Reference for DeleteService Operation</seealso>
        DeleteServiceResponse DeleteService(DeleteServiceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteService operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteService operation on AmazonAppRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteService
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/DeleteService">REST API Reference for DeleteService Operation</seealso>
        IAsyncResult BeginDeleteService(DeleteServiceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteService operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteService.</param>
        /// 
        /// <returns>Returns a  DeleteServiceResult from AppRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/DeleteService">REST API Reference for DeleteService Operation</seealso>
        DeleteServiceResponse EndDeleteService(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteVpcConnector


        /// <summary>
        /// Delete an App Runner VPC connector resource. You can't delete a connector that's used
        /// by one or more App Runner services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcConnector service method.</param>
        /// 
        /// <returns>The response from the DeleteVpcConnector service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/DeleteVpcConnector">REST API Reference for DeleteVpcConnector Operation</seealso>
        DeleteVpcConnectorResponse DeleteVpcConnector(DeleteVpcConnectorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpcConnector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcConnector operation on AmazonAppRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVpcConnector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/DeleteVpcConnector">REST API Reference for DeleteVpcConnector Operation</seealso>
        IAsyncResult BeginDeleteVpcConnector(DeleteVpcConnectorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVpcConnector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVpcConnector.</param>
        /// 
        /// <returns>Returns a  DeleteVpcConnectorResult from AppRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/DeleteVpcConnector">REST API Reference for DeleteVpcConnector Operation</seealso>
        DeleteVpcConnectorResponse EndDeleteVpcConnector(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteVpcIngressConnection


        /// <summary>
        /// Delete an App Runner VPC Ingress Connection resource that's associated with an App
        /// Runner service. The VPC Ingress Connection must be in one of the following states
        /// to be deleted: 
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <code>AVAILABLE</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FAILED_CREATION</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FAILED_UPDATE</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FAILED_DELETION</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcIngressConnection service method.</param>
        /// 
        /// <returns>The response from the DeleteVpcIngressConnection service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidStateException">
        /// You can't perform this action when the resource is in its current state.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/DeleteVpcIngressConnection">REST API Reference for DeleteVpcIngressConnection Operation</seealso>
        DeleteVpcIngressConnectionResponse DeleteVpcIngressConnection(DeleteVpcIngressConnectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpcIngressConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcIngressConnection operation on AmazonAppRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVpcIngressConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/DeleteVpcIngressConnection">REST API Reference for DeleteVpcIngressConnection Operation</seealso>
        IAsyncResult BeginDeleteVpcIngressConnection(DeleteVpcIngressConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVpcIngressConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVpcIngressConnection.</param>
        /// 
        /// <returns>Returns a  DeleteVpcIngressConnectionResult from AppRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/DeleteVpcIngressConnection">REST API Reference for DeleteVpcIngressConnection Operation</seealso>
        DeleteVpcIngressConnectionResponse EndDeleteVpcIngressConnection(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeAutoScalingConfiguration


        /// <summary>
        /// Return a full description of an App Runner automatic scaling configuration resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutoScalingConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeAutoScalingConfiguration service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/DescribeAutoScalingConfiguration">REST API Reference for DescribeAutoScalingConfiguration Operation</seealso>
        DescribeAutoScalingConfigurationResponse DescribeAutoScalingConfiguration(DescribeAutoScalingConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAutoScalingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutoScalingConfiguration operation on AmazonAppRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAutoScalingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/DescribeAutoScalingConfiguration">REST API Reference for DescribeAutoScalingConfiguration Operation</seealso>
        IAsyncResult BeginDescribeAutoScalingConfiguration(DescribeAutoScalingConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAutoScalingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAutoScalingConfiguration.</param>
        /// 
        /// <returns>Returns a  DescribeAutoScalingConfigurationResult from AppRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/DescribeAutoScalingConfiguration">REST API Reference for DescribeAutoScalingConfiguration Operation</seealso>
        DescribeAutoScalingConfigurationResponse EndDescribeAutoScalingConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeCustomDomains


        /// <summary>
        /// Return a description of custom domain names that are associated with an App Runner
        /// service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCustomDomains service method.</param>
        /// 
        /// <returns>The response from the DescribeCustomDomains service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/DescribeCustomDomains">REST API Reference for DescribeCustomDomains Operation</seealso>
        DescribeCustomDomainsResponse DescribeCustomDomains(DescribeCustomDomainsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCustomDomains operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCustomDomains operation on AmazonAppRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCustomDomains
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/DescribeCustomDomains">REST API Reference for DescribeCustomDomains Operation</seealso>
        IAsyncResult BeginDescribeCustomDomains(DescribeCustomDomainsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCustomDomains operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCustomDomains.</param>
        /// 
        /// <returns>Returns a  DescribeCustomDomainsResult from AppRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/DescribeCustomDomains">REST API Reference for DescribeCustomDomains Operation</seealso>
        DescribeCustomDomainsResponse EndDescribeCustomDomains(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeObservabilityConfiguration


        /// <summary>
        /// Return a full description of an App Runner observability configuration resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeObservabilityConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeObservabilityConfiguration service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/DescribeObservabilityConfiguration">REST API Reference for DescribeObservabilityConfiguration Operation</seealso>
        DescribeObservabilityConfigurationResponse DescribeObservabilityConfiguration(DescribeObservabilityConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeObservabilityConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeObservabilityConfiguration operation on AmazonAppRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeObservabilityConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/DescribeObservabilityConfiguration">REST API Reference for DescribeObservabilityConfiguration Operation</seealso>
        IAsyncResult BeginDescribeObservabilityConfiguration(DescribeObservabilityConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeObservabilityConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeObservabilityConfiguration.</param>
        /// 
        /// <returns>Returns a  DescribeObservabilityConfigurationResult from AppRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/DescribeObservabilityConfiguration">REST API Reference for DescribeObservabilityConfiguration Operation</seealso>
        DescribeObservabilityConfigurationResponse EndDescribeObservabilityConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeService


        /// <summary>
        /// Return a full description of an App Runner service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeService service method.</param>
        /// 
        /// <returns>The response from the DescribeService service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/DescribeService">REST API Reference for DescribeService Operation</seealso>
        DescribeServiceResponse DescribeService(DescribeServiceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeService operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeService operation on AmazonAppRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeService
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/DescribeService">REST API Reference for DescribeService Operation</seealso>
        IAsyncResult BeginDescribeService(DescribeServiceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeService operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeService.</param>
        /// 
        /// <returns>Returns a  DescribeServiceResult from AppRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/DescribeService">REST API Reference for DescribeService Operation</seealso>
        DescribeServiceResponse EndDescribeService(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeVpcConnector


        /// <summary>
        /// Return a description of an App Runner VPC connector resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcConnector service method.</param>
        /// 
        /// <returns>The response from the DescribeVpcConnector service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/DescribeVpcConnector">REST API Reference for DescribeVpcConnector Operation</seealso>
        DescribeVpcConnectorResponse DescribeVpcConnector(DescribeVpcConnectorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpcConnector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcConnector operation on AmazonAppRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVpcConnector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/DescribeVpcConnector">REST API Reference for DescribeVpcConnector Operation</seealso>
        IAsyncResult BeginDescribeVpcConnector(DescribeVpcConnectorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVpcConnector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVpcConnector.</param>
        /// 
        /// <returns>Returns a  DescribeVpcConnectorResult from AppRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/DescribeVpcConnector">REST API Reference for DescribeVpcConnector Operation</seealso>
        DescribeVpcConnectorResponse EndDescribeVpcConnector(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeVpcIngressConnection


        /// <summary>
        /// Return a full description of an App Runner VPC Ingress Connection resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcIngressConnection service method.</param>
        /// 
        /// <returns>The response from the DescribeVpcIngressConnection service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/DescribeVpcIngressConnection">REST API Reference for DescribeVpcIngressConnection Operation</seealso>
        DescribeVpcIngressConnectionResponse DescribeVpcIngressConnection(DescribeVpcIngressConnectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpcIngressConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcIngressConnection operation on AmazonAppRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVpcIngressConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/DescribeVpcIngressConnection">REST API Reference for DescribeVpcIngressConnection Operation</seealso>
        IAsyncResult BeginDescribeVpcIngressConnection(DescribeVpcIngressConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVpcIngressConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVpcIngressConnection.</param>
        /// 
        /// <returns>Returns a  DescribeVpcIngressConnectionResult from AppRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/DescribeVpcIngressConnection">REST API Reference for DescribeVpcIngressConnection Operation</seealso>
        DescribeVpcIngressConnectionResponse EndDescribeVpcIngressConnection(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateCustomDomain


        /// <summary>
        /// Disassociate a custom domain name from an App Runner service.
        /// 
        ///  
        /// <para>
        /// Certificates tracking domain validity are associated with a custom domain and are
        /// stored in <a href="https://docs.aws.amazon.com/acm/latest/userguide">AWS Certificate
        /// Manager (ACM)</a>. These certificates aren't deleted as part of this action. App Runner
        /// delays certificate deletion for 30 days after a domain is disassociated from your
        /// service.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateCustomDomain service method.</param>
        /// 
        /// <returns>The response from the DisassociateCustomDomain service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidStateException">
        /// You can't perform this action when the resource is in its current state.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/DisassociateCustomDomain">REST API Reference for DisassociateCustomDomain Operation</seealso>
        DisassociateCustomDomainResponse DisassociateCustomDomain(DisassociateCustomDomainRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateCustomDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateCustomDomain operation on AmazonAppRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateCustomDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/DisassociateCustomDomain">REST API Reference for DisassociateCustomDomain Operation</seealso>
        IAsyncResult BeginDisassociateCustomDomain(DisassociateCustomDomainRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateCustomDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateCustomDomain.</param>
        /// 
        /// <returns>Returns a  DisassociateCustomDomainResult from AppRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/DisassociateCustomDomain">REST API Reference for DisassociateCustomDomain Operation</seealso>
        DisassociateCustomDomainResponse EndDisassociateCustomDomain(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAutoScalingConfigurations


        /// <summary>
        /// Returns a list of active App Runner automatic scaling configurations in your Amazon
        /// Web Services account. You can query the revisions for a specific configuration name
        /// or the revisions for all active configurations in your account. You can optionally
        /// query only the latest revision of each requested name.
        /// 
        ///  
        /// <para>
        /// To retrieve a full description of a particular configuration revision, call and provide
        /// one of the ARNs returned by <code>ListAutoScalingConfigurations</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutoScalingConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListAutoScalingConfigurations service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/ListAutoScalingConfigurations">REST API Reference for ListAutoScalingConfigurations Operation</seealso>
        ListAutoScalingConfigurationsResponse ListAutoScalingConfigurations(ListAutoScalingConfigurationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAutoScalingConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAutoScalingConfigurations operation on AmazonAppRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAutoScalingConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/ListAutoScalingConfigurations">REST API Reference for ListAutoScalingConfigurations Operation</seealso>
        IAsyncResult BeginListAutoScalingConfigurations(ListAutoScalingConfigurationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAutoScalingConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAutoScalingConfigurations.</param>
        /// 
        /// <returns>Returns a  ListAutoScalingConfigurationsResult from AppRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/ListAutoScalingConfigurations">REST API Reference for ListAutoScalingConfigurations Operation</seealso>
        ListAutoScalingConfigurationsResponse EndListAutoScalingConfigurations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListConnections


        /// <summary>
        /// Returns a list of App Runner connections that are associated with your Amazon Web
        /// Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConnections service method.</param>
        /// 
        /// <returns>The response from the ListConnections service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/ListConnections">REST API Reference for ListConnections Operation</seealso>
        ListConnectionsResponse ListConnections(ListConnectionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListConnections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConnections operation on AmazonAppRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListConnections
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/ListConnections">REST API Reference for ListConnections Operation</seealso>
        IAsyncResult BeginListConnections(ListConnectionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListConnections operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListConnections.</param>
        /// 
        /// <returns>Returns a  ListConnectionsResult from AppRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/ListConnections">REST API Reference for ListConnections Operation</seealso>
        ListConnectionsResponse EndListConnections(IAsyncResult asyncResult);

        #endregion
        
        #region  ListObservabilityConfigurations


        /// <summary>
        /// Returns a list of active App Runner observability configurations in your Amazon Web
        /// Services account. You can query the revisions for a specific configuration name or
        /// the revisions for all active configurations in your account. You can optionally query
        /// only the latest revision of each requested name.
        /// 
        ///  
        /// <para>
        /// To retrieve a full description of a particular configuration revision, call and provide
        /// one of the ARNs returned by <code>ListObservabilityConfigurations</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListObservabilityConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListObservabilityConfigurations service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/ListObservabilityConfigurations">REST API Reference for ListObservabilityConfigurations Operation</seealso>
        ListObservabilityConfigurationsResponse ListObservabilityConfigurations(ListObservabilityConfigurationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListObservabilityConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListObservabilityConfigurations operation on AmazonAppRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListObservabilityConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/ListObservabilityConfigurations">REST API Reference for ListObservabilityConfigurations Operation</seealso>
        IAsyncResult BeginListObservabilityConfigurations(ListObservabilityConfigurationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListObservabilityConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListObservabilityConfigurations.</param>
        /// 
        /// <returns>Returns a  ListObservabilityConfigurationsResult from AppRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/ListObservabilityConfigurations">REST API Reference for ListObservabilityConfigurations Operation</seealso>
        ListObservabilityConfigurationsResponse EndListObservabilityConfigurations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListOperations


        /// <summary>
        /// Return a list of operations that occurred on an App Runner service.
        /// 
        ///  
        /// <para>
        /// The resulting list of <a>OperationSummary</a> objects is sorted in reverse chronological
        /// order. The first object on the list represents the last started operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOperations service method.</param>
        /// 
        /// <returns>The response from the ListOperations service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/ListOperations">REST API Reference for ListOperations Operation</seealso>
        ListOperationsResponse ListOperations(ListOperationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListOperations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOperations operation on AmazonAppRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOperations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/ListOperations">REST API Reference for ListOperations Operation</seealso>
        IAsyncResult BeginListOperations(ListOperationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListOperations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOperations.</param>
        /// 
        /// <returns>Returns a  ListOperationsResult from AppRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/ListOperations">REST API Reference for ListOperations Operation</seealso>
        ListOperationsResponse EndListOperations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListServices


        /// <summary>
        /// Returns a list of running App Runner services in your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServices service method.</param>
        /// 
        /// <returns>The response from the ListServices service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/ListServices">REST API Reference for ListServices Operation</seealso>
        ListServicesResponse ListServices(ListServicesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListServices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListServices operation on AmazonAppRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListServices
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/ListServices">REST API Reference for ListServices Operation</seealso>
        IAsyncResult BeginListServices(ListServicesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListServices operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListServices.</param>
        /// 
        /// <returns>Returns a  ListServicesResult from AppRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/ListServices">REST API Reference for ListServices Operation</seealso>
        ListServicesResponse EndListServices(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// List tags that are associated with for an App Runner resource. The response contains
        /// a list of tag key-value pairs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidStateException">
        /// You can't perform this action when the resource is in its current state.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonAppRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from AppRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ListVpcConnectors


        /// <summary>
        /// Returns a list of App Runner VPC connectors in your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVpcConnectors service method.</param>
        /// 
        /// <returns>The response from the ListVpcConnectors service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/ListVpcConnectors">REST API Reference for ListVpcConnectors Operation</seealso>
        ListVpcConnectorsResponse ListVpcConnectors(ListVpcConnectorsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListVpcConnectors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVpcConnectors operation on AmazonAppRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVpcConnectors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/ListVpcConnectors">REST API Reference for ListVpcConnectors Operation</seealso>
        IAsyncResult BeginListVpcConnectors(ListVpcConnectorsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListVpcConnectors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVpcConnectors.</param>
        /// 
        /// <returns>Returns a  ListVpcConnectorsResult from AppRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/ListVpcConnectors">REST API Reference for ListVpcConnectors Operation</seealso>
        ListVpcConnectorsResponse EndListVpcConnectors(IAsyncResult asyncResult);

        #endregion
        
        #region  ListVpcIngressConnections


        /// <summary>
        /// Return a list of App Runner VPC Ingress Connections in your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVpcIngressConnections service method.</param>
        /// 
        /// <returns>The response from the ListVpcIngressConnections service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/ListVpcIngressConnections">REST API Reference for ListVpcIngressConnections Operation</seealso>
        ListVpcIngressConnectionsResponse ListVpcIngressConnections(ListVpcIngressConnectionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListVpcIngressConnections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVpcIngressConnections operation on AmazonAppRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVpcIngressConnections
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/ListVpcIngressConnections">REST API Reference for ListVpcIngressConnections Operation</seealso>
        IAsyncResult BeginListVpcIngressConnections(ListVpcIngressConnectionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListVpcIngressConnections operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVpcIngressConnections.</param>
        /// 
        /// <returns>Returns a  ListVpcIngressConnectionsResult from AppRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/ListVpcIngressConnections">REST API Reference for ListVpcIngressConnections Operation</seealso>
        ListVpcIngressConnectionsResponse EndListVpcIngressConnections(IAsyncResult asyncResult);

        #endregion
        
        #region  PauseService


        /// <summary>
        /// Pause an active App Runner service. App Runner reduces compute capacity for the service
        /// to zero and loses state (for example, ephemeral storage is removed).
        /// 
        ///  
        /// <para>
        /// This is an asynchronous operation. On a successful call, you can use the returned
        /// <code>OperationId</code> and the <a>ListOperations</a> call to track the operation's
        /// progress.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PauseService service method.</param>
        /// 
        /// <returns>The response from the PauseService service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidStateException">
        /// You can't perform this action when the resource is in its current state.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/PauseService">REST API Reference for PauseService Operation</seealso>
        PauseServiceResponse PauseService(PauseServiceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PauseService operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PauseService operation on AmazonAppRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPauseService
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/PauseService">REST API Reference for PauseService Operation</seealso>
        IAsyncResult BeginPauseService(PauseServiceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PauseService operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPauseService.</param>
        /// 
        /// <returns>Returns a  PauseServiceResult from AppRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/PauseService">REST API Reference for PauseService Operation</seealso>
        PauseServiceResponse EndPauseService(IAsyncResult asyncResult);

        #endregion
        
        #region  ResumeService


        /// <summary>
        /// Resume an active App Runner service. App Runner provisions compute capacity for the
        /// service.
        /// 
        ///  
        /// <para>
        /// This is an asynchronous operation. On a successful call, you can use the returned
        /// <code>OperationId</code> and the <a>ListOperations</a> call to track the operation's
        /// progress.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResumeService service method.</param>
        /// 
        /// <returns>The response from the ResumeService service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidStateException">
        /// You can't perform this action when the resource is in its current state.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/ResumeService">REST API Reference for ResumeService Operation</seealso>
        ResumeServiceResponse ResumeService(ResumeServiceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ResumeService operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResumeService operation on AmazonAppRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResumeService
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/ResumeService">REST API Reference for ResumeService Operation</seealso>
        IAsyncResult BeginResumeService(ResumeServiceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ResumeService operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResumeService.</param>
        /// 
        /// <returns>Returns a  ResumeServiceResult from AppRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/ResumeService">REST API Reference for ResumeService Operation</seealso>
        ResumeServiceResponse EndResumeService(IAsyncResult asyncResult);

        #endregion
        
        #region  StartDeployment


        /// <summary>
        /// Initiate a manual deployment of the latest commit in a source code repository or the
        /// latest image in a source image repository to an App Runner service.
        /// 
        ///  
        /// <para>
        /// For a source code repository, App Runner retrieves the commit and builds a Docker
        /// image. For a source image repository, App Runner retrieves the latest Docker image.
        /// In both cases, App Runner then deploys the new image to your service and starts a
        /// new container instance.
        /// </para>
        ///  
        /// <para>
        /// This is an asynchronous operation. On a successful call, you can use the returned
        /// <code>OperationId</code> and the <a>ListOperations</a> call to track the operation's
        /// progress.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDeployment service method.</param>
        /// 
        /// <returns>The response from the StartDeployment service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/StartDeployment">REST API Reference for StartDeployment Operation</seealso>
        StartDeploymentResponse StartDeployment(StartDeploymentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartDeployment operation on AmazonAppRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartDeployment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/StartDeployment">REST API Reference for StartDeployment Operation</seealso>
        IAsyncResult BeginStartDeployment(StartDeploymentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartDeployment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartDeployment.</param>
        /// 
        /// <returns>Returns a  StartDeploymentResult from AppRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/StartDeployment">REST API Reference for StartDeployment Operation</seealso>
        StartDeploymentResponse EndStartDeployment(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Add tags to, or update the tag values of, an App Runner resource. A tag is a key-value
        /// pair.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidStateException">
        /// You can't perform this action when the resource is in its current state.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonAppRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from AppRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Remove tags from an App Runner resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidStateException">
        /// You can't perform this action when the resource is in its current state.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonAppRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from AppRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateService


        /// <summary>
        /// Update an App Runner service. You can update the source configuration and instance
        /// configuration of the service. You can also update the ARN of the auto scaling configuration
        /// resource that's associated with the service. However, you can't change the name or
        /// the encryption configuration of the service. These can be set only when you create
        /// the service.
        /// 
        ///  
        /// <para>
        /// To update the tags applied to your service, use the separate actions <a>TagResource</a>
        /// and <a>UntagResource</a>.
        /// </para>
        ///  
        /// <para>
        /// This is an asynchronous operation. On a successful call, you can use the returned
        /// <code>OperationId</code> and the <a>ListOperations</a> call to track the operation's
        /// progress.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateService service method.</param>
        /// 
        /// <returns>The response from the UpdateService service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidStateException">
        /// You can't perform this action when the resource is in its current state.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/UpdateService">REST API Reference for UpdateService Operation</seealso>
        UpdateServiceResponse UpdateService(UpdateServiceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateService operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateService operation on AmazonAppRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateService
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/UpdateService">REST API Reference for UpdateService Operation</seealso>
        IAsyncResult BeginUpdateService(UpdateServiceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateService operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateService.</param>
        /// 
        /// <returns>Returns a  UpdateServiceResult from AppRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/UpdateService">REST API Reference for UpdateService Operation</seealso>
        UpdateServiceResponse EndUpdateService(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateVpcIngressConnection


        /// <summary>
        /// Update an existing App Runner VPC Ingress Connection resource. The VPC Ingress Connection
        /// must be in one of the following states to be updated:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  AVAILABLE 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  FAILED_CREATION 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  FAILED_UPDATE 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVpcIngressConnection service method.</param>
        /// 
        /// <returns>The response from the UpdateVpcIngressConnection service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidStateException">
        /// You can't perform this action when the resource is in its current state.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/UpdateVpcIngressConnection">REST API Reference for UpdateVpcIngressConnection Operation</seealso>
        UpdateVpcIngressConnectionResponse UpdateVpcIngressConnection(UpdateVpcIngressConnectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVpcIngressConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVpcIngressConnection operation on AmazonAppRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateVpcIngressConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/UpdateVpcIngressConnection">REST API Reference for UpdateVpcIngressConnection Operation</seealso>
        IAsyncResult BeginUpdateVpcIngressConnection(UpdateVpcIngressConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateVpcIngressConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateVpcIngressConnection.</param>
        /// 
        /// <returns>Returns a  UpdateVpcIngressConnectionResult from AppRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/UpdateVpcIngressConnection">REST API Reference for UpdateVpcIngressConnection Operation</seealso>
        UpdateVpcIngressConnectionResponse EndUpdateVpcIngressConnection(IAsyncResult asyncResult);

        #endregion
        
    }
}