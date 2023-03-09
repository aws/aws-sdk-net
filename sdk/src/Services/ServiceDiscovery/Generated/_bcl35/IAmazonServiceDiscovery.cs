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
 * Do not modify this file. This file is generated from the servicediscovery-2017-03-14.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ServiceDiscovery.Model;

namespace Amazon.ServiceDiscovery
{
    /// <summary>
    /// Interface for accessing ServiceDiscovery
    ///
    /// Cloud Map 
    /// <para>
    /// With Cloud Map, you can configure public DNS, private DNS, or HTTP namespaces that
    /// your microservice applications run in. When an instance becomes available, you can
    /// call the Cloud Map API to register the instance with Cloud Map. For public or private
    /// DNS namespaces, Cloud Map automatically creates DNS records and an optional health
    /// check. Clients that submit public or private DNS queries, or HTTP requests, for the
    /// service receive an answer that contains up to eight healthy records. 
    /// </para>
    /// </summary>
    public partial interface IAmazonServiceDiscovery : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IServiceDiscoveryPaginatorFactory Paginators { get; }
#endif


        
        #region  CreateHttpNamespace


        /// <summary>
        /// Creates an HTTP namespace. Service instances registered using an HTTP namespace can
        /// be discovered using a <code>DiscoverInstances</code> request but can't be discovered
        /// using DNS.
        /// 
        ///  
        /// <para>
        /// For the current quota on the number of namespaces that you can create using the same
        /// Amazon Web Services account, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/cloud-map-limits.html">Cloud
        /// Map quotas</a> in the <i>Cloud Map Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHttpNamespace service method.</param>
        /// 
        /// <returns>The response from the CreateHttpNamespace service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.DuplicateRequestException">
        /// The operation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.NamespaceAlreadyExistsException">
        /// The namespace that you're trying to create already exists.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ResourceLimitExceededException">
        /// The resource can't be created because you've reached the quota on the number of resources.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.TooManyTagsException">
        /// The list of tags on the resource is over the quota. The maximum number of tags that
        /// can be applied to a resource is 50.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/CreateHttpNamespace">REST API Reference for CreateHttpNamespace Operation</seealso>
        CreateHttpNamespaceResponse CreateHttpNamespace(CreateHttpNamespaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateHttpNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHttpNamespace operation on AmazonServiceDiscoveryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateHttpNamespace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/CreateHttpNamespace">REST API Reference for CreateHttpNamespace Operation</seealso>
        IAsyncResult BeginCreateHttpNamespace(CreateHttpNamespaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateHttpNamespace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateHttpNamespace.</param>
        /// 
        /// <returns>Returns a  CreateHttpNamespaceResult from ServiceDiscovery.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/CreateHttpNamespace">REST API Reference for CreateHttpNamespace Operation</seealso>
        CreateHttpNamespaceResponse EndCreateHttpNamespace(IAsyncResult asyncResult);

        #endregion
        
        #region  CreatePrivateDnsNamespace


        /// <summary>
        /// Creates a private namespace based on DNS, which is visible only inside a specified
        /// Amazon VPC. The namespace defines your service naming scheme. For example, if you
        /// name your namespace <code>example.com</code> and name your service <code>backend</code>,
        /// the resulting DNS name for the service is <code>backend.example.com</code>. Service
        /// instances that are registered using a private DNS namespace can be discovered using
        /// either a <code>DiscoverInstances</code> request or using DNS. For the current quota
        /// on the number of namespaces that you can create using the same Amazon Web Services
        /// account, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/cloud-map-limits.html">Cloud
        /// Map quotas</a> in the <i>Cloud Map Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePrivateDnsNamespace service method.</param>
        /// 
        /// <returns>The response from the CreatePrivateDnsNamespace service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.DuplicateRequestException">
        /// The operation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.NamespaceAlreadyExistsException">
        /// The namespace that you're trying to create already exists.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ResourceLimitExceededException">
        /// The resource can't be created because you've reached the quota on the number of resources.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.TooManyTagsException">
        /// The list of tags on the resource is over the quota. The maximum number of tags that
        /// can be applied to a resource is 50.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/CreatePrivateDnsNamespace">REST API Reference for CreatePrivateDnsNamespace Operation</seealso>
        CreatePrivateDnsNamespaceResponse CreatePrivateDnsNamespace(CreatePrivateDnsNamespaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePrivateDnsNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePrivateDnsNamespace operation on AmazonServiceDiscoveryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePrivateDnsNamespace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/CreatePrivateDnsNamespace">REST API Reference for CreatePrivateDnsNamespace Operation</seealso>
        IAsyncResult BeginCreatePrivateDnsNamespace(CreatePrivateDnsNamespaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePrivateDnsNamespace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePrivateDnsNamespace.</param>
        /// 
        /// <returns>Returns a  CreatePrivateDnsNamespaceResult from ServiceDiscovery.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/CreatePrivateDnsNamespace">REST API Reference for CreatePrivateDnsNamespace Operation</seealso>
        CreatePrivateDnsNamespaceResponse EndCreatePrivateDnsNamespace(IAsyncResult asyncResult);

        #endregion
        
        #region  CreatePublicDnsNamespace


        /// <summary>
        /// Creates a public namespace based on DNS, which is visible on the internet. The namespace
        /// defines your service naming scheme. For example, if you name your namespace <code>example.com</code>
        /// and name your service <code>backend</code>, the resulting DNS name for the service
        /// is <code>backend.example.com</code>. You can discover instances that were registered
        /// with a public DNS namespace by using either a <code>DiscoverInstances</code> request
        /// or using DNS. For the current quota on the number of namespaces that you can create
        /// using the same Amazon Web Services account, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/cloud-map-limits.html">Cloud
        /// Map quotas</a> in the <i>Cloud Map Developer Guide</i>.
        /// 
        ///  <important> 
        /// <para>
        /// The <code>CreatePublicDnsNamespace</code> API operation is not supported in the Amazon
        /// Web Services GovCloud (US) Regions.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePublicDnsNamespace service method.</param>
        /// 
        /// <returns>The response from the CreatePublicDnsNamespace service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.DuplicateRequestException">
        /// The operation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.NamespaceAlreadyExistsException">
        /// The namespace that you're trying to create already exists.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ResourceLimitExceededException">
        /// The resource can't be created because you've reached the quota on the number of resources.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.TooManyTagsException">
        /// The list of tags on the resource is over the quota. The maximum number of tags that
        /// can be applied to a resource is 50.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/CreatePublicDnsNamespace">REST API Reference for CreatePublicDnsNamespace Operation</seealso>
        CreatePublicDnsNamespaceResponse CreatePublicDnsNamespace(CreatePublicDnsNamespaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePublicDnsNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePublicDnsNamespace operation on AmazonServiceDiscoveryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePublicDnsNamespace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/CreatePublicDnsNamespace">REST API Reference for CreatePublicDnsNamespace Operation</seealso>
        IAsyncResult BeginCreatePublicDnsNamespace(CreatePublicDnsNamespaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePublicDnsNamespace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePublicDnsNamespace.</param>
        /// 
        /// <returns>Returns a  CreatePublicDnsNamespaceResult from ServiceDiscovery.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/CreatePublicDnsNamespace">REST API Reference for CreatePublicDnsNamespace Operation</seealso>
        CreatePublicDnsNamespaceResponse EndCreatePublicDnsNamespace(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateService


        /// <summary>
        /// Creates a service. This action defines the configuration for the following entities:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// For public and private DNS namespaces, one of the following combinations of DNS records
        /// in Amazon Route 53:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>A</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AAAA</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>A</code> and <code>AAAA</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SRV</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CNAME</code> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Optionally, a health check
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// After you create the service, you can submit a <a href="https://docs.aws.amazon.com/cloud-map/latest/api/API_RegisterInstance.html">RegisterInstance</a>
        /// request, and Cloud Map uses the values in the configuration to create the specified
        /// entities.
        /// </para>
        ///  
        /// <para>
        /// For the current quota on the number of instances that you can register using the same
        /// namespace and using the same service, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/cloud-map-limits.html">Cloud
        /// Map quotas</a> in the <i>Cloud Map Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateService service method.</param>
        /// 
        /// <returns>The response from the CreateService service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.NamespaceNotFoundException">
        /// No namespace exists with the specified ID.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ResourceLimitExceededException">
        /// The resource can't be created because you've reached the quota on the number of resources.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ServiceAlreadyExistsException">
        /// The service can't be created because a service with the same name already exists.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.TooManyTagsException">
        /// The list of tags on the resource is over the quota. The maximum number of tags that
        /// can be applied to a resource is 50.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/CreateService">REST API Reference for CreateService Operation</seealso>
        CreateServiceResponse CreateService(CreateServiceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateService operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateService operation on AmazonServiceDiscoveryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateService
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/CreateService">REST API Reference for CreateService Operation</seealso>
        IAsyncResult BeginCreateService(CreateServiceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateService operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateService.</param>
        /// 
        /// <returns>Returns a  CreateServiceResult from ServiceDiscovery.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/CreateService">REST API Reference for CreateService Operation</seealso>
        CreateServiceResponse EndCreateService(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteNamespace


        /// <summary>
        /// Deletes a namespace from the current account. If the namespace still contains one
        /// or more services, the request fails.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNamespace service method.</param>
        /// 
        /// <returns>The response from the DeleteNamespace service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.DuplicateRequestException">
        /// The operation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.NamespaceNotFoundException">
        /// No namespace exists with the specified ID.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ResourceInUseException">
        /// The specified resource can't be deleted because it contains other resources. For example,
        /// you can't delete a service that contains any instances.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/DeleteNamespace">REST API Reference for DeleteNamespace Operation</seealso>
        DeleteNamespaceResponse DeleteNamespace(DeleteNamespaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNamespace operation on AmazonServiceDiscoveryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteNamespace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/DeleteNamespace">REST API Reference for DeleteNamespace Operation</seealso>
        IAsyncResult BeginDeleteNamespace(DeleteNamespaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteNamespace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteNamespace.</param>
        /// 
        /// <returns>Returns a  DeleteNamespaceResult from ServiceDiscovery.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/DeleteNamespace">REST API Reference for DeleteNamespace Operation</seealso>
        DeleteNamespaceResponse EndDeleteNamespace(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteService


        /// <summary>
        /// Deletes a specified service. If the service still contains one or more registered
        /// instances, the request fails.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteService service method.</param>
        /// 
        /// <returns>The response from the DeleteService service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ResourceInUseException">
        /// The specified resource can't be deleted because it contains other resources. For example,
        /// you can't delete a service that contains any instances.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ServiceNotFoundException">
        /// No service exists with the specified ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/DeleteService">REST API Reference for DeleteService Operation</seealso>
        DeleteServiceResponse DeleteService(DeleteServiceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteService operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteService operation on AmazonServiceDiscoveryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteService
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/DeleteService">REST API Reference for DeleteService Operation</seealso>
        IAsyncResult BeginDeleteService(DeleteServiceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteService operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteService.</param>
        /// 
        /// <returns>Returns a  DeleteServiceResult from ServiceDiscovery.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/DeleteService">REST API Reference for DeleteService Operation</seealso>
        DeleteServiceResponse EndDeleteService(IAsyncResult asyncResult);

        #endregion
        
        #region  DeregisterInstance


        /// <summary>
        /// Deletes the Amazon Route 53 DNS records and health check, if any, that Cloud Map created
        /// for the specified instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterInstance service method.</param>
        /// 
        /// <returns>The response from the DeregisterInstance service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.DuplicateRequestException">
        /// The operation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InstanceNotFoundException">
        /// No instance exists with the specified ID, or the instance was recently registered,
        /// and information about the instance hasn't propagated yet.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ResourceInUseException">
        /// The specified resource can't be deleted because it contains other resources. For example,
        /// you can't delete a service that contains any instances.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ServiceNotFoundException">
        /// No service exists with the specified ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/DeregisterInstance">REST API Reference for DeregisterInstance Operation</seealso>
        DeregisterInstanceResponse DeregisterInstance(DeregisterInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterInstance operation on AmazonServiceDiscoveryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/DeregisterInstance">REST API Reference for DeregisterInstance Operation</seealso>
        IAsyncResult BeginDeregisterInstance(DeregisterInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterInstance.</param>
        /// 
        /// <returns>Returns a  DeregisterInstanceResult from ServiceDiscovery.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/DeregisterInstance">REST API Reference for DeregisterInstance Operation</seealso>
        DeregisterInstanceResponse EndDeregisterInstance(IAsyncResult asyncResult);

        #endregion
        
        #region  DiscoverInstances


        /// <summary>
        /// Discovers registered instances for a specified namespace and service. You can use
        /// <code>DiscoverInstances</code> to discover instances for any type of namespace. For
        /// public and private DNS namespaces, you can also use DNS queries to discover instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DiscoverInstances service method.</param>
        /// 
        /// <returns>The response from the DiscoverInstances service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.NamespaceNotFoundException">
        /// No namespace exists with the specified ID.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ServiceNotFoundException">
        /// No service exists with the specified ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/DiscoverInstances">REST API Reference for DiscoverInstances Operation</seealso>
        DiscoverInstancesResponse DiscoverInstances(DiscoverInstancesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DiscoverInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DiscoverInstances operation on AmazonServiceDiscoveryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDiscoverInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/DiscoverInstances">REST API Reference for DiscoverInstances Operation</seealso>
        IAsyncResult BeginDiscoverInstances(DiscoverInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DiscoverInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDiscoverInstances.</param>
        /// 
        /// <returns>Returns a  DiscoverInstancesResult from ServiceDiscovery.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/DiscoverInstances">REST API Reference for DiscoverInstances Operation</seealso>
        DiscoverInstancesResponse EndDiscoverInstances(IAsyncResult asyncResult);

        #endregion
        
        #region  GetInstance


        /// <summary>
        /// Gets information about a specified instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInstance service method.</param>
        /// 
        /// <returns>The response from the GetInstance service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InstanceNotFoundException">
        /// No instance exists with the specified ID, or the instance was recently registered,
        /// and information about the instance hasn't propagated yet.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ServiceNotFoundException">
        /// No service exists with the specified ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/GetInstance">REST API Reference for GetInstance Operation</seealso>
        GetInstanceResponse GetInstance(GetInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInstance operation on AmazonServiceDiscoveryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/GetInstance">REST API Reference for GetInstance Operation</seealso>
        IAsyncResult BeginGetInstance(GetInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInstance.</param>
        /// 
        /// <returns>Returns a  GetInstanceResult from ServiceDiscovery.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/GetInstance">REST API Reference for GetInstance Operation</seealso>
        GetInstanceResponse EndGetInstance(IAsyncResult asyncResult);

        #endregion
        
        #region  GetInstancesHealthStatus


        /// <summary>
        /// Gets the current health status (<code>Healthy</code>, <code>Unhealthy</code>, or <code>Unknown</code>)
        /// of one or more instances that are associated with a specified service.
        /// 
        ///  <note> 
        /// <para>
        /// There's a brief delay between when you register an instance and when the health status
        /// for the instance is available. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInstancesHealthStatus service method.</param>
        /// 
        /// <returns>The response from the GetInstancesHealthStatus service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InstanceNotFoundException">
        /// No instance exists with the specified ID, or the instance was recently registered,
        /// and information about the instance hasn't propagated yet.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ServiceNotFoundException">
        /// No service exists with the specified ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/GetInstancesHealthStatus">REST API Reference for GetInstancesHealthStatus Operation</seealso>
        GetInstancesHealthStatusResponse GetInstancesHealthStatus(GetInstancesHealthStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetInstancesHealthStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInstancesHealthStatus operation on AmazonServiceDiscoveryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInstancesHealthStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/GetInstancesHealthStatus">REST API Reference for GetInstancesHealthStatus Operation</seealso>
        IAsyncResult BeginGetInstancesHealthStatus(GetInstancesHealthStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetInstancesHealthStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInstancesHealthStatus.</param>
        /// 
        /// <returns>Returns a  GetInstancesHealthStatusResult from ServiceDiscovery.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/GetInstancesHealthStatus">REST API Reference for GetInstancesHealthStatus Operation</seealso>
        GetInstancesHealthStatusResponse EndGetInstancesHealthStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  GetNamespace


        /// <summary>
        /// Gets information about a namespace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNamespace service method.</param>
        /// 
        /// <returns>The response from the GetNamespace service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.NamespaceNotFoundException">
        /// No namespace exists with the specified ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/GetNamespace">REST API Reference for GetNamespace Operation</seealso>
        GetNamespaceResponse GetNamespace(GetNamespaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetNamespace operation on AmazonServiceDiscoveryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetNamespace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/GetNamespace">REST API Reference for GetNamespace Operation</seealso>
        IAsyncResult BeginGetNamespace(GetNamespaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetNamespace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetNamespace.</param>
        /// 
        /// <returns>Returns a  GetNamespaceResult from ServiceDiscovery.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/GetNamespace">REST API Reference for GetNamespace Operation</seealso>
        GetNamespaceResponse EndGetNamespace(IAsyncResult asyncResult);

        #endregion
        
        #region  GetOperation


        /// <summary>
        /// Gets information about any operation that returns an operation ID in the response,
        /// such as a <code>CreateService</code> request.
        /// 
        ///  <note> 
        /// <para>
        /// To get a list of operations that match specified criteria, see <a href="https://docs.aws.amazon.com/cloud-map/latest/api/API_ListOperations.html">ListOperations</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOperation service method.</param>
        /// 
        /// <returns>The response from the GetOperation service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.OperationNotFoundException">
        /// No operation exists with the specified ID.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/GetOperation">REST API Reference for GetOperation Operation</seealso>
        GetOperationResponse GetOperation(GetOperationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOperation operation on AmazonServiceDiscoveryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/GetOperation">REST API Reference for GetOperation Operation</seealso>
        IAsyncResult BeginGetOperation(GetOperationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetOperation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOperation.</param>
        /// 
        /// <returns>Returns a  GetOperationResult from ServiceDiscovery.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/GetOperation">REST API Reference for GetOperation Operation</seealso>
        GetOperationResponse EndGetOperation(IAsyncResult asyncResult);

        #endregion
        
        #region  GetService


        /// <summary>
        /// Gets the settings for a specified service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetService service method.</param>
        /// 
        /// <returns>The response from the GetService service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ServiceNotFoundException">
        /// No service exists with the specified ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/GetService">REST API Reference for GetService Operation</seealso>
        GetServiceResponse GetService(GetServiceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetService operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetService operation on AmazonServiceDiscoveryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetService
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/GetService">REST API Reference for GetService Operation</seealso>
        IAsyncResult BeginGetService(GetServiceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetService operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetService.</param>
        /// 
        /// <returns>Returns a  GetServiceResult from ServiceDiscovery.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/GetService">REST API Reference for GetService Operation</seealso>
        GetServiceResponse EndGetService(IAsyncResult asyncResult);

        #endregion
        
        #region  ListInstances


        /// <summary>
        /// Lists summary information about the instances that you registered by using a specified
        /// service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstances service method.</param>
        /// 
        /// <returns>The response from the ListInstances service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ServiceNotFoundException">
        /// No service exists with the specified ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/ListInstances">REST API Reference for ListInstances Operation</seealso>
        ListInstancesResponse ListInstances(ListInstancesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInstances operation on AmazonServiceDiscoveryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/ListInstances">REST API Reference for ListInstances Operation</seealso>
        IAsyncResult BeginListInstances(ListInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInstances.</param>
        /// 
        /// <returns>Returns a  ListInstancesResult from ServiceDiscovery.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/ListInstances">REST API Reference for ListInstances Operation</seealso>
        ListInstancesResponse EndListInstances(IAsyncResult asyncResult);

        #endregion
        
        #region  ListNamespaces


        /// <summary>
        /// Lists summary information about the namespaces that were created by the current Amazon
        /// Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNamespaces service method.</param>
        /// 
        /// <returns>The response from the ListNamespaces service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/ListNamespaces">REST API Reference for ListNamespaces Operation</seealso>
        ListNamespacesResponse ListNamespaces(ListNamespacesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListNamespaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListNamespaces operation on AmazonServiceDiscoveryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListNamespaces
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/ListNamespaces">REST API Reference for ListNamespaces Operation</seealso>
        IAsyncResult BeginListNamespaces(ListNamespacesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListNamespaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListNamespaces.</param>
        /// 
        /// <returns>Returns a  ListNamespacesResult from ServiceDiscovery.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/ListNamespaces">REST API Reference for ListNamespaces Operation</seealso>
        ListNamespacesResponse EndListNamespaces(IAsyncResult asyncResult);

        #endregion
        
        #region  ListOperations


        /// <summary>
        /// Lists operations that match the criteria that you specify.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOperations service method.</param>
        /// 
        /// <returns>The response from the ListOperations service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/ListOperations">REST API Reference for ListOperations Operation</seealso>
        ListOperationsResponse ListOperations(ListOperationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListOperations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOperations operation on AmazonServiceDiscoveryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOperations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/ListOperations">REST API Reference for ListOperations Operation</seealso>
        IAsyncResult BeginListOperations(ListOperationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListOperations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOperations.</param>
        /// 
        /// <returns>Returns a  ListOperationsResult from ServiceDiscovery.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/ListOperations">REST API Reference for ListOperations Operation</seealso>
        ListOperationsResponse EndListOperations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListServices


        /// <summary>
        /// Lists summary information for all the services that are associated with one or more
        /// specified namespaces.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServices service method.</param>
        /// 
        /// <returns>The response from the ListServices service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/ListServices">REST API Reference for ListServices Operation</seealso>
        ListServicesResponse ListServices(ListServicesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListServices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListServices operation on AmazonServiceDiscoveryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListServices
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/ListServices">REST API Reference for ListServices Operation</seealso>
        IAsyncResult BeginListServices(ListServicesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListServices operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListServices.</param>
        /// 
        /// <returns>Returns a  ListServicesResult from ServiceDiscovery.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/ListServices">REST API Reference for ListServices Operation</seealso>
        ListServicesResponse EndListServices(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ResourceNotFoundException">
        /// The operation can't be completed because the resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonServiceDiscoveryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from ServiceDiscovery.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  RegisterInstance


        /// <summary>
        /// Creates or updates one or more records and, optionally, creates a health check based
        /// on the settings in a specified service. When you submit a <code>RegisterInstance</code>
        /// request, the following occurs:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// For each DNS record that you define in the service that's specified by <code>ServiceId</code>,
        /// a record is created or updated in the hosted zone that's associated with the corresponding
        /// namespace.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the service includes <code>HealthCheckConfig</code>, a health check is created
        /// based on the settings in the health check configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The health check, if any, is associated with each of the new or updated records.
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// One <code>RegisterInstance</code> request must complete before you can submit another
        /// request and specify the same service ID and instance ID.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/api/API_CreateService.html">CreateService</a>.
        /// </para>
        ///  
        /// <para>
        /// When Cloud Map receives a DNS query for the specified DNS name, it returns the applicable
        /// value:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>If the health check is healthy</b>: returns all the records
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>If the health check is unhealthy</b>: returns the applicable value for the last
        /// healthy instance
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>If you didn't specify a health check configuration</b>: returns all the records
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For the current quota on the number of instances that you can register using the same
        /// namespace and using the same service, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/cloud-map-limits.html">Cloud
        /// Map quotas</a> in the <i>Cloud Map Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterInstance service method.</param>
        /// 
        /// <returns>The response from the RegisterInstance service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.DuplicateRequestException">
        /// The operation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ResourceInUseException">
        /// The specified resource can't be deleted because it contains other resources. For example,
        /// you can't delete a service that contains any instances.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ResourceLimitExceededException">
        /// The resource can't be created because you've reached the quota on the number of resources.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ServiceNotFoundException">
        /// No service exists with the specified ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/RegisterInstance">REST API Reference for RegisterInstance Operation</seealso>
        RegisterInstanceResponse RegisterInstance(RegisterInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterInstance operation on AmazonServiceDiscoveryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/RegisterInstance">REST API Reference for RegisterInstance Operation</seealso>
        IAsyncResult BeginRegisterInstance(RegisterInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterInstance.</param>
        /// 
        /// <returns>Returns a  RegisterInstanceResult from ServiceDiscovery.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/RegisterInstance">REST API Reference for RegisterInstance Operation</seealso>
        RegisterInstanceResponse EndRegisterInstance(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds one or more tags to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ResourceNotFoundException">
        /// The operation can't be completed because the resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.TooManyTagsException">
        /// The list of tags on the resource is over the quota. The maximum number of tags that
        /// can be applied to a resource is 50.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonServiceDiscoveryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from ServiceDiscovery.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes one or more tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ResourceNotFoundException">
        /// The operation can't be completed because the resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonServiceDiscoveryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from ServiceDiscovery.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateHttpNamespace


        /// <summary>
        /// Updates an HTTP namespace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateHttpNamespace service method.</param>
        /// 
        /// <returns>The response from the UpdateHttpNamespace service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.DuplicateRequestException">
        /// The operation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.NamespaceNotFoundException">
        /// No namespace exists with the specified ID.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ResourceInUseException">
        /// The specified resource can't be deleted because it contains other resources. For example,
        /// you can't delete a service that contains any instances.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/UpdateHttpNamespace">REST API Reference for UpdateHttpNamespace Operation</seealso>
        UpdateHttpNamespaceResponse UpdateHttpNamespace(UpdateHttpNamespaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateHttpNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateHttpNamespace operation on AmazonServiceDiscoveryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateHttpNamespace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/UpdateHttpNamespace">REST API Reference for UpdateHttpNamespace Operation</seealso>
        IAsyncResult BeginUpdateHttpNamespace(UpdateHttpNamespaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateHttpNamespace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateHttpNamespace.</param>
        /// 
        /// <returns>Returns a  UpdateHttpNamespaceResult from ServiceDiscovery.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/UpdateHttpNamespace">REST API Reference for UpdateHttpNamespace Operation</seealso>
        UpdateHttpNamespaceResponse EndUpdateHttpNamespace(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateInstanceCustomHealthStatus


        /// <summary>
        /// Submits a request to change the health status of a custom health check to healthy
        /// or unhealthy.
        /// 
        ///  
        /// <para>
        /// You can use <code>UpdateInstanceCustomHealthStatus</code> to change the status only
        /// for custom health checks, which you define using <code>HealthCheckCustomConfig</code>
        /// when you create a service. You can't use it to change the status for Route 53 health
        /// checks, which you define using <code>HealthCheckConfig</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/api/API_HealthCheckCustomConfig.html">HealthCheckCustomConfig</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateInstanceCustomHealthStatus service method.</param>
        /// 
        /// <returns>The response from the UpdateInstanceCustomHealthStatus service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.CustomHealthNotFoundException">
        /// The health check for the instance that's specified by <code>ServiceId</code> and <code>InstanceId</code>
        /// isn't a custom health check.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InstanceNotFoundException">
        /// No instance exists with the specified ID, or the instance was recently registered,
        /// and information about the instance hasn't propagated yet.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ServiceNotFoundException">
        /// No service exists with the specified ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/UpdateInstanceCustomHealthStatus">REST API Reference for UpdateInstanceCustomHealthStatus Operation</seealso>
        UpdateInstanceCustomHealthStatusResponse UpdateInstanceCustomHealthStatus(UpdateInstanceCustomHealthStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateInstanceCustomHealthStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateInstanceCustomHealthStatus operation on AmazonServiceDiscoveryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateInstanceCustomHealthStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/UpdateInstanceCustomHealthStatus">REST API Reference for UpdateInstanceCustomHealthStatus Operation</seealso>
        IAsyncResult BeginUpdateInstanceCustomHealthStatus(UpdateInstanceCustomHealthStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateInstanceCustomHealthStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateInstanceCustomHealthStatus.</param>
        /// 
        /// <returns>Returns a  UpdateInstanceCustomHealthStatusResult from ServiceDiscovery.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/UpdateInstanceCustomHealthStatus">REST API Reference for UpdateInstanceCustomHealthStatus Operation</seealso>
        UpdateInstanceCustomHealthStatusResponse EndUpdateInstanceCustomHealthStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdatePrivateDnsNamespace


        /// <summary>
        /// Updates a private DNS namespace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePrivateDnsNamespace service method.</param>
        /// 
        /// <returns>The response from the UpdatePrivateDnsNamespace service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.DuplicateRequestException">
        /// The operation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.NamespaceNotFoundException">
        /// No namespace exists with the specified ID.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ResourceInUseException">
        /// The specified resource can't be deleted because it contains other resources. For example,
        /// you can't delete a service that contains any instances.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/UpdatePrivateDnsNamespace">REST API Reference for UpdatePrivateDnsNamespace Operation</seealso>
        UpdatePrivateDnsNamespaceResponse UpdatePrivateDnsNamespace(UpdatePrivateDnsNamespaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePrivateDnsNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePrivateDnsNamespace operation on AmazonServiceDiscoveryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePrivateDnsNamespace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/UpdatePrivateDnsNamespace">REST API Reference for UpdatePrivateDnsNamespace Operation</seealso>
        IAsyncResult BeginUpdatePrivateDnsNamespace(UpdatePrivateDnsNamespaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePrivateDnsNamespace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePrivateDnsNamespace.</param>
        /// 
        /// <returns>Returns a  UpdatePrivateDnsNamespaceResult from ServiceDiscovery.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/UpdatePrivateDnsNamespace">REST API Reference for UpdatePrivateDnsNamespace Operation</seealso>
        UpdatePrivateDnsNamespaceResponse EndUpdatePrivateDnsNamespace(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdatePublicDnsNamespace


        /// <summary>
        /// Updates a public DNS namespace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePublicDnsNamespace service method.</param>
        /// 
        /// <returns>The response from the UpdatePublicDnsNamespace service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.DuplicateRequestException">
        /// The operation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.NamespaceNotFoundException">
        /// No namespace exists with the specified ID.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ResourceInUseException">
        /// The specified resource can't be deleted because it contains other resources. For example,
        /// you can't delete a service that contains any instances.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/UpdatePublicDnsNamespace">REST API Reference for UpdatePublicDnsNamespace Operation</seealso>
        UpdatePublicDnsNamespaceResponse UpdatePublicDnsNamespace(UpdatePublicDnsNamespaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePublicDnsNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePublicDnsNamespace operation on AmazonServiceDiscoveryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePublicDnsNamespace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/UpdatePublicDnsNamespace">REST API Reference for UpdatePublicDnsNamespace Operation</seealso>
        IAsyncResult BeginUpdatePublicDnsNamespace(UpdatePublicDnsNamespaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePublicDnsNamespace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePublicDnsNamespace.</param>
        /// 
        /// <returns>Returns a  UpdatePublicDnsNamespaceResult from ServiceDiscovery.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/UpdatePublicDnsNamespace">REST API Reference for UpdatePublicDnsNamespace Operation</seealso>
        UpdatePublicDnsNamespaceResponse EndUpdatePublicDnsNamespace(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateService


        /// <summary>
        /// Submits a request to perform the following operations:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Update the TTL setting for existing <code>DnsRecords</code> configurations
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Add, update, or delete <code>HealthCheckConfig</code> for a specified service
        /// </para>
        ///  <note> 
        /// <para>
        /// You can't add, update, or delete a <code>HealthCheckCustomConfig</code> configuration.
        /// </para>
        ///  </note> </li> </ul> 
        /// <para>
        /// For public and private DNS namespaces, note the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you omit any existing <code>DnsRecords</code> or <code>HealthCheckConfig</code>
        /// configurations from an <code>UpdateService</code> request, the configurations are
        /// deleted from the service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you omit an existing <code>HealthCheckCustomConfig</code> configuration from an
        /// <code>UpdateService</code> request, the configuration isn't deleted from the service.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When you update settings for a service, Cloud Map also updates the corresponding settings
        /// in all the records and health checks that were created by using the specified service.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateService service method.</param>
        /// 
        /// <returns>The response from the UpdateService service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.DuplicateRequestException">
        /// The operation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ServiceNotFoundException">
        /// No service exists with the specified ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/UpdateService">REST API Reference for UpdateService Operation</seealso>
        UpdateServiceResponse UpdateService(UpdateServiceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateService operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateService operation on AmazonServiceDiscoveryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateService
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/UpdateService">REST API Reference for UpdateService Operation</seealso>
        IAsyncResult BeginUpdateService(UpdateServiceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateService operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateService.</param>
        /// 
        /// <returns>Returns a  UpdateServiceResult from ServiceDiscovery.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/UpdateService">REST API Reference for UpdateService Operation</seealso>
        UpdateServiceResponse EndUpdateService(IAsyncResult asyncResult);

        #endregion
        
    }
}