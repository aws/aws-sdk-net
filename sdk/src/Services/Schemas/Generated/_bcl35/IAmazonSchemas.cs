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
 * Do not modify this file. This file is generated from the schemas-2019-12-02.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Schemas.Model;

namespace Amazon.Schemas
{
    /// <summary>
    /// Interface for accessing Schemas
    ///
    /// Amazon EventBridge Schema Registry
    /// </summary>
    public partial interface IAmazonSchemas : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ISchemasPaginatorFactory Paginators { get; }
#endif


        
        #region  CreateDiscoverer


        /// <summary>
        /// Creates a discoverer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDiscoverer service method.</param>
        /// 
        /// <returns>The response from the CreateDiscoverer service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/CreateDiscoverer">REST API Reference for CreateDiscoverer Operation</seealso>
        CreateDiscovererResponse CreateDiscoverer(CreateDiscovererRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDiscoverer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDiscoverer operation on AmazonSchemasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDiscoverer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/CreateDiscoverer">REST API Reference for CreateDiscoverer Operation</seealso>
        IAsyncResult BeginCreateDiscoverer(CreateDiscovererRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDiscoverer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDiscoverer.</param>
        /// 
        /// <returns>Returns a  CreateDiscovererResult from Schemas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/CreateDiscoverer">REST API Reference for CreateDiscoverer Operation</seealso>
        CreateDiscovererResponse EndCreateDiscoverer(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateRegistry


        /// <summary>
        /// Creates a registry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRegistry service method.</param>
        /// 
        /// <returns>The response from the CreateRegistry service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/CreateRegistry">REST API Reference for CreateRegistry Operation</seealso>
        CreateRegistryResponse CreateRegistry(CreateRegistryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRegistry operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRegistry operation on AmazonSchemasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRegistry
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/CreateRegistry">REST API Reference for CreateRegistry Operation</seealso>
        IAsyncResult BeginCreateRegistry(CreateRegistryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRegistry operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRegistry.</param>
        /// 
        /// <returns>Returns a  CreateRegistryResult from Schemas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/CreateRegistry">REST API Reference for CreateRegistry Operation</seealso>
        CreateRegistryResponse EndCreateRegistry(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSchema


        /// <summary>
        /// Creates a schema definition.
        /// 
        ///  <note>
        /// <para>
        /// Inactive schemas will be deleted after two years.
        /// </para>
        /// </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSchema service method.</param>
        /// 
        /// <returns>The response from the CreateSchema service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/CreateSchema">REST API Reference for CreateSchema Operation</seealso>
        CreateSchemaResponse CreateSchema(CreateSchemaRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSchema operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSchema operation on AmazonSchemasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSchema
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/CreateSchema">REST API Reference for CreateSchema Operation</seealso>
        IAsyncResult BeginCreateSchema(CreateSchemaRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSchema operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSchema.</param>
        /// 
        /// <returns>Returns a  CreateSchemaResult from Schemas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/CreateSchema">REST API Reference for CreateSchema Operation</seealso>
        CreateSchemaResponse EndCreateSchema(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDiscoverer


        /// <summary>
        /// Deletes a discoverer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDiscoverer service method.</param>
        /// 
        /// <returns>The response from the DeleteDiscoverer service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DeleteDiscoverer">REST API Reference for DeleteDiscoverer Operation</seealso>
        DeleteDiscovererResponse DeleteDiscoverer(DeleteDiscovererRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDiscoverer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDiscoverer operation on AmazonSchemasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDiscoverer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DeleteDiscoverer">REST API Reference for DeleteDiscoverer Operation</seealso>
        IAsyncResult BeginDeleteDiscoverer(DeleteDiscovererRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDiscoverer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDiscoverer.</param>
        /// 
        /// <returns>Returns a  DeleteDiscovererResult from Schemas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DeleteDiscoverer">REST API Reference for DeleteDiscoverer Operation</seealso>
        DeleteDiscovererResponse EndDeleteDiscoverer(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteRegistry


        /// <summary>
        /// Deletes a Registry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRegistry service method.</param>
        /// 
        /// <returns>The response from the DeleteRegistry service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DeleteRegistry">REST API Reference for DeleteRegistry Operation</seealso>
        DeleteRegistryResponse DeleteRegistry(DeleteRegistryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRegistry operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRegistry operation on AmazonSchemasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRegistry
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DeleteRegistry">REST API Reference for DeleteRegistry Operation</seealso>
        IAsyncResult BeginDeleteRegistry(DeleteRegistryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRegistry operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRegistry.</param>
        /// 
        /// <returns>Returns a  DeleteRegistryResult from Schemas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DeleteRegistry">REST API Reference for DeleteRegistry Operation</seealso>
        DeleteRegistryResponse EndDeleteRegistry(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteResourcePolicy


        /// <summary>
        /// Delete the resource-based policy attached to the specified registry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteResourcePolicy service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        DeleteResourcePolicyResponse DeleteResourcePolicy(DeleteResourcePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy operation on AmazonSchemasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        IAsyncResult BeginDeleteResourcePolicy(DeleteResourcePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteResourcePolicy.</param>
        /// 
        /// <returns>Returns a  DeleteResourcePolicyResult from Schemas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        DeleteResourcePolicyResponse EndDeleteResourcePolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSchema


        /// <summary>
        /// Delete a schema definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSchema service method.</param>
        /// 
        /// <returns>The response from the DeleteSchema service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DeleteSchema">REST API Reference for DeleteSchema Operation</seealso>
        DeleteSchemaResponse DeleteSchema(DeleteSchemaRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSchema operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSchema operation on AmazonSchemasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSchema
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DeleteSchema">REST API Reference for DeleteSchema Operation</seealso>
        IAsyncResult BeginDeleteSchema(DeleteSchemaRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSchema operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSchema.</param>
        /// 
        /// <returns>Returns a  DeleteSchemaResult from Schemas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DeleteSchema">REST API Reference for DeleteSchema Operation</seealso>
        DeleteSchemaResponse EndDeleteSchema(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSchemaVersion


        /// <summary>
        /// Delete the schema version definition
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSchemaVersion service method.</param>
        /// 
        /// <returns>The response from the DeleteSchemaVersion service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DeleteSchemaVersion">REST API Reference for DeleteSchemaVersion Operation</seealso>
        DeleteSchemaVersionResponse DeleteSchemaVersion(DeleteSchemaVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSchemaVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSchemaVersion operation on AmazonSchemasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSchemaVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DeleteSchemaVersion">REST API Reference for DeleteSchemaVersion Operation</seealso>
        IAsyncResult BeginDeleteSchemaVersion(DeleteSchemaVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSchemaVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSchemaVersion.</param>
        /// 
        /// <returns>Returns a  DeleteSchemaVersionResult from Schemas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DeleteSchemaVersion">REST API Reference for DeleteSchemaVersion Operation</seealso>
        DeleteSchemaVersionResponse EndDeleteSchemaVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeCodeBinding


        /// <summary>
        /// Describe the code binding URI.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCodeBinding service method.</param>
        /// 
        /// <returns>The response from the DescribeCodeBinding service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DescribeCodeBinding">REST API Reference for DescribeCodeBinding Operation</seealso>
        DescribeCodeBindingResponse DescribeCodeBinding(DescribeCodeBindingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCodeBinding operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCodeBinding operation on AmazonSchemasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCodeBinding
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DescribeCodeBinding">REST API Reference for DescribeCodeBinding Operation</seealso>
        IAsyncResult BeginDescribeCodeBinding(DescribeCodeBindingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCodeBinding operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCodeBinding.</param>
        /// 
        /// <returns>Returns a  DescribeCodeBindingResult from Schemas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DescribeCodeBinding">REST API Reference for DescribeCodeBinding Operation</seealso>
        DescribeCodeBindingResponse EndDescribeCodeBinding(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDiscoverer


        /// <summary>
        /// Describes the discoverer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDiscoverer service method.</param>
        /// 
        /// <returns>The response from the DescribeDiscoverer service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DescribeDiscoverer">REST API Reference for DescribeDiscoverer Operation</seealso>
        DescribeDiscovererResponse DescribeDiscoverer(DescribeDiscovererRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDiscoverer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDiscoverer operation on AmazonSchemasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDiscoverer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DescribeDiscoverer">REST API Reference for DescribeDiscoverer Operation</seealso>
        IAsyncResult BeginDescribeDiscoverer(DescribeDiscovererRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDiscoverer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDiscoverer.</param>
        /// 
        /// <returns>Returns a  DescribeDiscovererResult from Schemas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DescribeDiscoverer">REST API Reference for DescribeDiscoverer Operation</seealso>
        DescribeDiscovererResponse EndDescribeDiscoverer(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeRegistry


        /// <summary>
        /// Describes the registry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRegistry service method.</param>
        /// 
        /// <returns>The response from the DescribeRegistry service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DescribeRegistry">REST API Reference for DescribeRegistry Operation</seealso>
        DescribeRegistryResponse DescribeRegistry(DescribeRegistryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRegistry operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRegistry operation on AmazonSchemasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRegistry
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DescribeRegistry">REST API Reference for DescribeRegistry Operation</seealso>
        IAsyncResult BeginDescribeRegistry(DescribeRegistryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRegistry operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRegistry.</param>
        /// 
        /// <returns>Returns a  DescribeRegistryResult from Schemas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DescribeRegistry">REST API Reference for DescribeRegistry Operation</seealso>
        DescribeRegistryResponse EndDescribeRegistry(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeSchema


        /// <summary>
        /// Retrieve the schema definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSchema service method.</param>
        /// 
        /// <returns>The response from the DescribeSchema service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DescribeSchema">REST API Reference for DescribeSchema Operation</seealso>
        DescribeSchemaResponse DescribeSchema(DescribeSchemaRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSchema operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSchema operation on AmazonSchemasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSchema
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DescribeSchema">REST API Reference for DescribeSchema Operation</seealso>
        IAsyncResult BeginDescribeSchema(DescribeSchemaRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSchema operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSchema.</param>
        /// 
        /// <returns>Returns a  DescribeSchemaResult from Schemas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DescribeSchema">REST API Reference for DescribeSchema Operation</seealso>
        DescribeSchemaResponse EndDescribeSchema(IAsyncResult asyncResult);

        #endregion
        
        #region  ExportSchema


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportSchema service method.</param>
        /// 
        /// <returns>The response from the ExportSchema service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/ExportSchema">REST API Reference for ExportSchema Operation</seealso>
        ExportSchemaResponse ExportSchema(ExportSchemaRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ExportSchema operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExportSchema operation on AmazonSchemasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExportSchema
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/ExportSchema">REST API Reference for ExportSchema Operation</seealso>
        IAsyncResult BeginExportSchema(ExportSchemaRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ExportSchema operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExportSchema.</param>
        /// 
        /// <returns>Returns a  ExportSchemaResult from Schemas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/ExportSchema">REST API Reference for ExportSchema Operation</seealso>
        ExportSchemaResponse EndExportSchema(IAsyncResult asyncResult);

        #endregion
        
        #region  GetCodeBindingSource


        /// <summary>
        /// Get the code binding source URI.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCodeBindingSource service method.</param>
        /// 
        /// <returns>The response from the GetCodeBindingSource service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/GetCodeBindingSource">REST API Reference for GetCodeBindingSource Operation</seealso>
        GetCodeBindingSourceResponse GetCodeBindingSource(GetCodeBindingSourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCodeBindingSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCodeBindingSource operation on AmazonSchemasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCodeBindingSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/GetCodeBindingSource">REST API Reference for GetCodeBindingSource Operation</seealso>
        IAsyncResult BeginGetCodeBindingSource(GetCodeBindingSourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCodeBindingSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCodeBindingSource.</param>
        /// 
        /// <returns>Returns a  GetCodeBindingSourceResult from Schemas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/GetCodeBindingSource">REST API Reference for GetCodeBindingSource Operation</seealso>
        GetCodeBindingSourceResponse EndGetCodeBindingSource(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDiscoveredSchema


        /// <summary>
        /// Get the discovered schema that was generated based on sampled events.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDiscoveredSchema service method.</param>
        /// 
        /// <returns>The response from the GetDiscoveredSchema service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/GetDiscoveredSchema">REST API Reference for GetDiscoveredSchema Operation</seealso>
        GetDiscoveredSchemaResponse GetDiscoveredSchema(GetDiscoveredSchemaRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDiscoveredSchema operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDiscoveredSchema operation on AmazonSchemasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDiscoveredSchema
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/GetDiscoveredSchema">REST API Reference for GetDiscoveredSchema Operation</seealso>
        IAsyncResult BeginGetDiscoveredSchema(GetDiscoveredSchemaRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDiscoveredSchema operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDiscoveredSchema.</param>
        /// 
        /// <returns>Returns a  GetDiscoveredSchemaResult from Schemas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/GetDiscoveredSchema">REST API Reference for GetDiscoveredSchema Operation</seealso>
        GetDiscoveredSchemaResponse EndGetDiscoveredSchema(IAsyncResult asyncResult);

        #endregion
        
        #region  GetResourcePolicy


        /// <summary>
        /// Retrieves the resource-based policy attached to a given registry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the GetResourcePolicy service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        GetResourcePolicyResponse GetResourcePolicy(GetResourcePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy operation on AmazonSchemasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        IAsyncResult BeginGetResourcePolicy(GetResourcePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResourcePolicy.</param>
        /// 
        /// <returns>Returns a  GetResourcePolicyResult from Schemas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        GetResourcePolicyResponse EndGetResourcePolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDiscoverers


        /// <summary>
        /// List the discoverers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDiscoverers service method.</param>
        /// 
        /// <returns>The response from the ListDiscoverers service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/ListDiscoverers">REST API Reference for ListDiscoverers Operation</seealso>
        ListDiscoverersResponse ListDiscoverers(ListDiscoverersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDiscoverers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDiscoverers operation on AmazonSchemasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDiscoverers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/ListDiscoverers">REST API Reference for ListDiscoverers Operation</seealso>
        IAsyncResult BeginListDiscoverers(ListDiscoverersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDiscoverers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDiscoverers.</param>
        /// 
        /// <returns>Returns a  ListDiscoverersResult from Schemas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/ListDiscoverers">REST API Reference for ListDiscoverers Operation</seealso>
        ListDiscoverersResponse EndListDiscoverers(IAsyncResult asyncResult);

        #endregion
        
        #region  ListRegistries


        /// <summary>
        /// List the registries.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRegistries service method.</param>
        /// 
        /// <returns>The response from the ListRegistries service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/ListRegistries">REST API Reference for ListRegistries Operation</seealso>
        ListRegistriesResponse ListRegistries(ListRegistriesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRegistries operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRegistries operation on AmazonSchemasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRegistries
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/ListRegistries">REST API Reference for ListRegistries Operation</seealso>
        IAsyncResult BeginListRegistries(ListRegistriesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRegistries operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRegistries.</param>
        /// 
        /// <returns>Returns a  ListRegistriesResult from Schemas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/ListRegistries">REST API Reference for ListRegistries Operation</seealso>
        ListRegistriesResponse EndListRegistries(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSchemas


        /// <summary>
        /// List the schemas.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSchemas service method.</param>
        /// 
        /// <returns>The response from the ListSchemas service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/ListSchemas">REST API Reference for ListSchemas Operation</seealso>
        ListSchemasResponse ListSchemas(ListSchemasRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSchemas operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSchemas operation on AmazonSchemasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSchemas
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/ListSchemas">REST API Reference for ListSchemas Operation</seealso>
        IAsyncResult BeginListSchemas(ListSchemasRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSchemas operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSchemas.</param>
        /// 
        /// <returns>Returns a  ListSchemasResult from Schemas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/ListSchemas">REST API Reference for ListSchemas Operation</seealso>
        ListSchemasResponse EndListSchemas(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSchemaVersions


        /// <summary>
        /// Provides a list of the schema versions and related information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSchemaVersions service method.</param>
        /// 
        /// <returns>The response from the ListSchemaVersions service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/ListSchemaVersions">REST API Reference for ListSchemaVersions Operation</seealso>
        ListSchemaVersionsResponse ListSchemaVersions(ListSchemaVersionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSchemaVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSchemaVersions operation on AmazonSchemasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSchemaVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/ListSchemaVersions">REST API Reference for ListSchemaVersions Operation</seealso>
        IAsyncResult BeginListSchemaVersions(ListSchemaVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSchemaVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSchemaVersions.</param>
        /// 
        /// <returns>Returns a  ListSchemaVersionsResult from Schemas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/ListSchemaVersions">REST API Reference for ListSchemaVersions Operation</seealso>
        ListSchemaVersionsResponse EndListSchemaVersions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Get tags for resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonSchemasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from Schemas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  PutCodeBinding


        /// <summary>
        /// Put code binding URI
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutCodeBinding service method.</param>
        /// 
        /// <returns>The response from the PutCodeBinding service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.GoneException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/PutCodeBinding">REST API Reference for PutCodeBinding Operation</seealso>
        PutCodeBindingResponse PutCodeBinding(PutCodeBindingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutCodeBinding operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutCodeBinding operation on AmazonSchemasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutCodeBinding
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/PutCodeBinding">REST API Reference for PutCodeBinding Operation</seealso>
        IAsyncResult BeginPutCodeBinding(PutCodeBindingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutCodeBinding operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutCodeBinding.</param>
        /// 
        /// <returns>Returns a  PutCodeBindingResult from Schemas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/PutCodeBinding">REST API Reference for PutCodeBinding Operation</seealso>
        PutCodeBindingResponse EndPutCodeBinding(IAsyncResult asyncResult);

        #endregion
        
        #region  PutResourcePolicy


        /// <summary>
        /// The name of the policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the PutResourcePolicy service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.PreconditionFailedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        PutResourcePolicyResponse PutResourcePolicy(PutResourcePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy operation on AmazonSchemasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        IAsyncResult BeginPutResourcePolicy(PutResourcePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutResourcePolicy.</param>
        /// 
        /// <returns>Returns a  PutResourcePolicyResult from Schemas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        PutResourcePolicyResponse EndPutResourcePolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  SearchSchemas


        /// <summary>
        /// Search the schemas
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchSchemas service method.</param>
        /// 
        /// <returns>The response from the SearchSchemas service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/SearchSchemas">REST API Reference for SearchSchemas Operation</seealso>
        SearchSchemasResponse SearchSchemas(SearchSchemasRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SearchSchemas operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchSchemas operation on AmazonSchemasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchSchemas
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/SearchSchemas">REST API Reference for SearchSchemas Operation</seealso>
        IAsyncResult BeginSearchSchemas(SearchSchemasRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SearchSchemas operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchSchemas.</param>
        /// 
        /// <returns>Returns a  SearchSchemasResult from Schemas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/SearchSchemas">REST API Reference for SearchSchemas Operation</seealso>
        SearchSchemasResponse EndSearchSchemas(IAsyncResult asyncResult);

        #endregion
        
        #region  StartDiscoverer


        /// <summary>
        /// Starts the discoverer
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDiscoverer service method.</param>
        /// 
        /// <returns>The response from the StartDiscoverer service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/StartDiscoverer">REST API Reference for StartDiscoverer Operation</seealso>
        StartDiscovererResponse StartDiscoverer(StartDiscovererRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartDiscoverer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartDiscoverer operation on AmazonSchemasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartDiscoverer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/StartDiscoverer">REST API Reference for StartDiscoverer Operation</seealso>
        IAsyncResult BeginStartDiscoverer(StartDiscovererRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartDiscoverer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartDiscoverer.</param>
        /// 
        /// <returns>Returns a  StartDiscovererResult from Schemas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/StartDiscoverer">REST API Reference for StartDiscoverer Operation</seealso>
        StartDiscovererResponse EndStartDiscoverer(IAsyncResult asyncResult);

        #endregion
        
        #region  StopDiscoverer


        /// <summary>
        /// Stops the discoverer
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopDiscoverer service method.</param>
        /// 
        /// <returns>The response from the StopDiscoverer service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/StopDiscoverer">REST API Reference for StopDiscoverer Operation</seealso>
        StopDiscovererResponse StopDiscoverer(StopDiscovererRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopDiscoverer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopDiscoverer operation on AmazonSchemasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopDiscoverer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/StopDiscoverer">REST API Reference for StopDiscoverer Operation</seealso>
        IAsyncResult BeginStopDiscoverer(StopDiscovererRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopDiscoverer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopDiscoverer.</param>
        /// 
        /// <returns>Returns a  StopDiscovererResult from Schemas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/StopDiscoverer">REST API Reference for StopDiscoverer Operation</seealso>
        StopDiscovererResponse EndStopDiscoverer(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Add tags to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonSchemasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from Schemas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonSchemasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from Schemas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDiscoverer


        /// <summary>
        /// Updates the discoverer
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDiscoverer service method.</param>
        /// 
        /// <returns>The response from the UpdateDiscoverer service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/UpdateDiscoverer">REST API Reference for UpdateDiscoverer Operation</seealso>
        UpdateDiscovererResponse UpdateDiscoverer(UpdateDiscovererRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDiscoverer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDiscoverer operation on AmazonSchemasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDiscoverer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/UpdateDiscoverer">REST API Reference for UpdateDiscoverer Operation</seealso>
        IAsyncResult BeginUpdateDiscoverer(UpdateDiscovererRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDiscoverer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDiscoverer.</param>
        /// 
        /// <returns>Returns a  UpdateDiscovererResult from Schemas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/UpdateDiscoverer">REST API Reference for UpdateDiscoverer Operation</seealso>
        UpdateDiscovererResponse EndUpdateDiscoverer(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateRegistry


        /// <summary>
        /// Updates a registry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRegistry service method.</param>
        /// 
        /// <returns>The response from the UpdateRegistry service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/UpdateRegistry">REST API Reference for UpdateRegistry Operation</seealso>
        UpdateRegistryResponse UpdateRegistry(UpdateRegistryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRegistry operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRegistry operation on AmazonSchemasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRegistry
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/UpdateRegistry">REST API Reference for UpdateRegistry Operation</seealso>
        IAsyncResult BeginUpdateRegistry(UpdateRegistryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRegistry operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRegistry.</param>
        /// 
        /// <returns>Returns a  UpdateRegistryResult from Schemas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/UpdateRegistry">REST API Reference for UpdateRegistry Operation</seealso>
        UpdateRegistryResponse EndUpdateRegistry(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSchema


        /// <summary>
        /// Updates the schema definition
        /// 
        ///  <note>
        /// <para>
        /// Inactive schemas will be deleted after two years.
        /// </para>
        /// </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSchema service method.</param>
        /// 
        /// <returns>The response from the UpdateSchema service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/UpdateSchema">REST API Reference for UpdateSchema Operation</seealso>
        UpdateSchemaResponse UpdateSchema(UpdateSchemaRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSchema operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSchema operation on AmazonSchemasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSchema
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/UpdateSchema">REST API Reference for UpdateSchema Operation</seealso>
        IAsyncResult BeginUpdateSchema(UpdateSchemaRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSchema operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSchema.</param>
        /// 
        /// <returns>Returns a  UpdateSchemaResult from Schemas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/UpdateSchema">REST API Reference for UpdateSchema Operation</seealso>
        UpdateSchemaResponse EndUpdateSchema(IAsyncResult asyncResult);

        #endregion
        
    }
}